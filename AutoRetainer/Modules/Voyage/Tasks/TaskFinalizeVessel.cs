﻿using AutoRetainer.Internal;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace AutoRetainer.Modules.Voyage.Tasks;

internal unsafe static class TaskFinalizeVessel
{
    internal static void Enqueue(string name, VoyageType type, bool forceRepair, bool quit)
    {
        VoyageUtils.Log($"Task enqueued: {nameof(TaskFinalizeVessel)} name={name}, type={type}, forceRepair={forceRepair}, quit={quit}");
        TaskSelectVesselByName.Enqueue(name, type);
        P.TaskManager.Enqueue(VoyageScheduler.FinalizeVessel);
        P.TaskManager.Enqueue(() => TryGetAddonByName<AtkUnitBase>("SelectString", out var addon) && IsAddonReady(addon), "WaitForSelectStringAddon");
        if (forceRepair || C.SubsRepairFinalize)
        {
            TaskIntelligentRepair.Enqueue(name, type);
        }
        if(quit) P.TaskManager.Enqueue(VoyageScheduler.SelectQuitVesselMenu);
    }
}
