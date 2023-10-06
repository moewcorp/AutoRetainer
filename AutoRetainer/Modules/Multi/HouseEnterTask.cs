﻿using AutoRetainer.Modules.Voyage.Tasks;
using ClickLib.Clicks;
using ECommons.Automation;
using ECommons.Events;
using ECommons.ExcelServices.TerritoryEnumeration;
using ECommons.GameHelpers;
using ECommons.Throttlers;
using FFXIVClientStructs.FFXIV.Client.Game.Control;

namespace AutoRetainer.Modules.Multi;

internal unsafe static class HouseEnterTask
{
    internal static void EnqueueTask()
    {
        P.TaskManager.Enqueue(YesAlready.WaitForYesAlreadyDisabledTask);
        P.TaskManager.Enqueue(WaitUntilNotBusy, 180 * 1000);
        P.TaskManager.Enqueue(() =>
        {
            if(Utils.GetReachableRetainerBell(false) == null)
            {
                var entrance = Utils.GetNearestEntrance(out var d);
                var validDistance = entrance.IsApartmentEntrance() ? 4.85f : 4f;
                if (entrance != null && d > validDistance)
                {
                    P.TaskManager.EnqueueImmediate(() => SetTarget(40f));
                    P.TaskManager.EnqueueImmediate(Lockon);
                    P.TaskManager.EnqueueImmediate(Approach);
                    P.TaskManager.EnqueueImmediate(AutorunOff);
                    P.TaskManager.EnqueueImmediate(() => { Chat.Instance.SendMessage("/automove off"); });
                }
                P.TaskManager.EnqueueImmediate(() => SetTarget(5f));
                P.TaskManager.EnqueueImmediate(Interact);
                P.TaskManager.EnqueueImmediate(SelectYesno);
                P.TaskManager.EnqueueImmediate(WaitUntilLeavingZone);
                P.TaskManager.DelayNextImmediate(60, true);
            }
            return true;
        }, "Master HET");
        TaskEnterWorkshop.Enqueue();
    }

    internal static bool? WaitUntilNotBusy()
    {
        if (!ProperOnLogin.PlayerPresent || !ResidentalAreas.List.Contains(Svc.ClientState.TerritoryType)) return null;
        if (MultiMode.IsInteractionAllowed())
        {
            return true;
        }
        return false;
    }

    internal static bool? Lockon()
    {
        var entrance = Utils.GetNearestEntrance(out _);
        if (entrance != null && Svc.Targets.Target?.Address == entrance.Address && EzThrottler.Throttle("HET.Lockon"))
        {
            Chat.Instance.SendMessage("/lockon");
            return true;
        }
        return false;
    }

    internal static bool? Approach()
    {
        DebugLog($"Enabling automove");
        Utils.RegenerateRandom();
        Chat.Instance.SendMessage("/automove on");
        return true;
    }

    internal static bool? AutorunOff()
    {
        var entrance = Utils.GetNearestEntrance(out var d);
        if (entrance != null && d < 3f + Utils.Random && EzThrottler.Throttle("HET.DisableAutomove"))
        {
            DebugLog($"Disabling automove");
            Chat.Instance.SendMessage("/automove off");
            return true;
        }
        return false;
    }


    internal static bool? SetTarget(float distance)
    {
        var entrance = Utils.GetNearestEntrance(out var d);
        if (entrance != null && d < distance && EzThrottler.Throttle("HET.SetTarget", 200))
        {
            DebugLog($"Setting entrance target ({distance})");
            Svc.Targets.Target = (entrance);
            return true;
        }
        return false;
    }

    internal static bool? Interact()
    {
        var entrance = Utils.GetNearestEntrance(out var d);
        if (entrance != null && Svc.Targets.Target?.Address == entrance.Address && EzThrottler.Throttle("HET.Interact", 1000))
        {
            DebugLog($"Interacting with entrance");
            TargetSystem.Instance()->InteractWithObject((FFXIVClientStructs.FFXIV.Client.Game.Object.GameObject*)entrance.Address, false);
            return true;
        }
        return false;
    }


    internal static bool? SelectYesno()
    {
        if (!ResidentalAreas.List.Contains(Svc.ClientState.TerritoryType))
        {
            return null;
        }
        var addon = Utils.GetSpecificYesno(Lang.ConfirmHouseEntrance);
        if (addon != null)
        {
            if (IsAddonReady(addon) && EzThrottler.Throttle("HET.SelectYesno"))
            {
                DebugLog("Select yes");
                ClickSelectYesNo.Using((nint)addon).Yes();
                return true;
            }
        }
        else
        {
            if (Utils.TrySelectSpecificEntry(Lang.GoToYourApartment, () => EzThrottler.Throttle("HET.SelectYesno")))
            {
                DebugLog("Confirmed going to apartment");
                return true;
            }
        }
        return false;
    }

    internal static bool? WaitUntilLeavingZone()
    {
        return !ResidentalAreas.List.Contains(Svc.ClientState.TerritoryType);
    }

    internal static bool? LockonBell()
    {
        var bell = Utils.GetNearestRetainerBell(out var d);
        if (bell != null && d < 20f)
        {
            if (Svc.Targets.Target?.Address == bell.Address)
            {
                if (EzThrottler.Throttle("HET.LockonBell"))
                {
                    Chat.Instance.SendMessage("/lockon");
                    return true;
                }
            }
            else
            {
                if (EzThrottler.Throttle("HET.SetTargetBell", 200))
                {
                    DebugLog($"Setting bell target ({bell})");
                    Svc.Targets.Target = bell;
                }
            }
        }
        return false;
    }


    internal static bool? AutorunOffBell()
    {
        var bell = Utils.GetReachableRetainerBell(false);
        if(bell != null) PluginLog.Information($"Dist {Vector3.Distance(Player.Object.Position, bell.Position)}");
        if (bell != null && Vector3.Distance(Player.Object.Position, bell.Position) < 4f + Utils.Random * 0.25f)
        {
            DebugLog($"Disabling automove");
            Chat.Instance.SendMessage("/automove off");
            return true;
        }
        return false;
    }
}
