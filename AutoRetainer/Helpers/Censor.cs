﻿using Lumina.Misc;

namespace AutoRetainer.Helpers;

internal static class Censor
{
    internal static readonly string[] Animals = ["Dog", "Cow", "Cat", "Horse", "Donkey", "Tiger", "Lion", "Panther", "Leopard", "Cheetah", "Bear", "Elephant", "Turtle", "Tortoise", "Crocodile", "Rabbit", "Porcupine", "Hare", "Hen", "Pigeon", "Albatross", "Crow", "Fish", "Dolphin", "Frog", "Whale", "Alligator", "Eagle", "Ostrich", "Fox", "Goat", "Jackal", "Emu", "Armadillo", "Eel", "Goose", "Wolf", "Beagle", "Gorilla", "Chimpanzee", "Monkey", "Beaver", "Orangutan", "Antelope", "Bat", "Badger", "Giraffe", "Hamster", "Cobra", "Camel", "Hawk", "Deer", "Chameleon", "Hippopotamus", "Jaguar", "Chihuahua", "Ibex", "Lizard", "Koala", "Kangaroo", "Iguana", "Llama", "Chinchillas", "Dodo", "Jellyfish", "Rhinoceros", "Hedgehog", "Zebra", "Possum", "Wombat", "Bison", "Bull", "Buffalo", "Sheep", "Meerkat", "Mouse", "Otter", "Sloth", "Owl", "Vulture", "Flamingo", "Racoon", "Mole", "Duck", "Swan", "Lynx", "Elk", "Boar", "Lemur", "Mule", "Baboon", "Mammoth", "Rat", "Snake", "Peacock"];

    internal static readonly string[] Adjectives = ["Attractive", "Bald", "Beautiful", "Chubby", "Clean", "Dazzling", "Drab", "Elegant", "Fancy", "Fit", "Flabby", "Glamorous", "Gorgeous", "Handsome", "Long", "Magnificent", "Muscular", "Plain", "Plump", "Quaint", "Scruffy", "Shapely", "Short", "Skinny", "Stocky", "Ugly", "Unkempt", "Unsightly"];

    internal static readonly string[] Fishes = ["African glass catfish ", "African lungfish ", "Aholehole ", "Airbreathing catfish ", "Airsac catfish ", "Alaska blackfish", "Albacore", "Alewife ", "Alfonsino", "Algae eater ", "Alligatorfish ", "Alligator gar", "Amberjack ", "American sole ", "Amur pike", "Anchovy ", "Anemonefish ", "Angelfish ", "Lophius piscatorius", "Angler catfish ", "Anglerfish ", "Antarctic cod", "Antarctic icefish ", "Antenna codlet ", "Arapaima ", "Archerfish ", "Arctic char", "Armored gurnard ", "Armored searobin ", "Armorhead ", "Armorhead catfish ", "Armoured catfish ", "Arowana ", "Arrowtooth eel ", "Asian carp", "Asiatic glassfish ", "Atka mackerel", "Atlantic bonito", "Atlantic cod", "Atlantic herring", "Atlantic salmon", "Atlantic sharpnose shark", "Atlantic saury", "Atlantic silverside", "Australasian salmon ", "Australian grayling", "Australian herring", "Australian lungfish", "Australian prowfish ", "Ayu sweetfish", "Baikal oilfish", "Bala shark", "Ballan wrasse", "Bamboo shark", "Banded killifish", "Bandfish", "Banjo fish", "Bangus", "Banjo catfish", "Barbus", "Barbus barbus", "Barbeled dragonfish", "Barbeled houndshark", "Barbel-less catfish", "Barfish", "Barracuda", "Barracudina", "Barramundi", "Barred danio", "Barreleye", "Basking shark", "Bass ", "Basslet ", "Batfish ", "Bat ray", "Beachsalmon", "Beaked salmon", "Beaked sandfish", "Beardfish", "Beluga sturgeon", "Bengal danio", "Betta", "Bichir", "Bicolor goat fish", "Bigeye", "Bigeye squaretail", "Bighead carp", "Bigmouth buffalo", "Bigscale", "Bigscale pomfret", "Istiophoridae", "Bitterling", "Black angelfish ", "Black bass", "Black dragonfish ", "Blackchin", "Blackfin Tuna", "Blackfish ", "Black neon tetra", "Blacktip reef shark", "Black mackerel", "Black scalyfin", "Black sea bass", "Black scabbardfish", "Black swallower", "Black tetra", "Black triggerfish", "Bleak ", "Blenny", "Blind goby", "Blind shark", "Blobfish ", "Blowfish", "Blue catfish", "Blue danio", "Blue-redstripe danio", "Trevalla", "Bluefin tuna", "Bluefish", "Bluegill", "Blue gourami", "Blue shark", "Blue triggerfish ", "Blue whiting", "Bluntnose knifefish", "Bluntnose minnow", "Boafish", "Boarfish ", "Bobtail snipe eel", "Bocaccio rockfish", "Boga ", "Bombay duck", "Bonefish", "Bonito", "Bonnethead shark", "Bonnetmouth ", "Bonytail", "Osteoglossoidei", "Bowfin", "Boxfish", "Bramble shark", "Bream", "Brill ", "Bristlemouth", "Bristlenose catfish", "Broadband dogfish", "Bronze corydoras", "Brook lamprey", "Brook stickleback", "Brook trout", "Brotula ", "Brown trout", "Buffalo fish", "Bullhead ", "Bullhead shark", "Bull shark", "Bull trout", "Burbot", "Bumblebee goby", "Japanese amberjack", "Burma danio", "Burrowing goby ", "Pentapodus nagasakiensis", "Butterfly ray", "Butterflyfish", "California flyingfish", "California halibut", "Canary rockfish", "Candiru ", "Candlefish", "Capelin", "Cardinalfish", "Cardinal tetra", "Carp", "Carpetshark", "Carpsucker", "Catalufa ", "Catfish", "Catla", "Cat shark", "Cavefish", "Celebes rainbowfish", "Central mudminnow", "Chain pickerel", "Channel bass", "Channel catfish", "Salvelinus", "Cherry salmon", "Chimera ", "Chinook salmon", "Cherubfish", "Chub", "Chubsucker", "Chum salmon", "Cichlid", "Cisco ", "Climbing catfish", "Climbing gourami", "Climbing perch ", "Clingfish", "Clownfish", "Clown loach", "Clown triggerfish", "Cobbler #Fish", "Cobia", "Cod", "Codlet", "Codling ", "Coelacanth", "Coffinfish", "Coho salmon", "Coley ", "Collared carpetshark", "Collared dogfish", "Colorado squawfish", "Combfish", "Combtail gourami", "Combtooth blenny", "Common carp", "Common tunny", "Conger eel ", "Convict blenny", "Convict cichlid", "Cookie-cutter shark", "Coolie loach", "Cornetfish", "Cowfish", "Cownose ray", "Cow shark", "Crappie", "Creek chub", "Crestfish", "Crevice kelpfish", "Sciaenidae", "Crocodile icefish", "Crocodile shark", "Crucian carp", "Cuckoo wrasse", "Cusk ", "Cusk-eel", "Cutlassfish", "Cutthroat eel", "Cutthroat trout", "Common dab", "Dace ", "Daggertooth pike conger", "Damselfish ", "Danio ", "Darter ", "Dartfish ", "Dealfish ", "Death Valley pupfish", "Deep sea eel ", "Deep sea smelt ", "Deepwater cardinalfish ", "Deepwater flathead ", "Deepwater stingray", "Delta smelt ", "Demoiselle ", "Denticle herring ", "Desert pupfish", "Devario", "Devil ray ", "Dhufish", "Discus ", "Dogfish ", "Dogfish shark ", "Dogteeth tetra", "Dojo loach", "Dolly Varden trout", "Dolphin fish", "Dorab wolf-herring ", "Dorado ", "Dory ", "Dottyback ", "Dragonet ", "Dragonfish ", "Dragon goby ", "Driftfish ", "Driftwood catfish ", "Drum ", "Percophidae", "Duckbill eel", "Dusky grouper", "Dusky shark", "Dwarf gourami ", "Dwarf loach", "Eagle ray", "Earthworm eel", "Eel", "Eel cod", "Eel-goby", "Eelpout", "Eeltail catfish", "Elasmobranch", "Electric catfish", "Electric eel", "Electric knifefish", "Electric ray", "Elephant fish ", "Elephantnose fish", "Elver ", "Ember parrotfish", "Emerald catfish", "Emperor ", "Emperor angelfish", "Emperor bream", "Escolar", "Eucla cod", "Eulachon", "European chub", "European eel", "European flounder", "European minnow", "European perch", "False brotula", "False cat shark", "False moray", "False trevally", "Fangtooth", "Fathead sculpin", "Featherback", "Fierasfer", "Fire goby", "Filefish", "Finback cat shark", "Fingerfish", "Fire bar danio", "Firefish ", "Flabby whale fish", "Flagblenny", "Flagfin", "Flagfish", "Flagtail", "Flashlight fish ", "Flatfish", "Flathead ", "Flathead catfish", "Flier ", "Flounder", "Flying gurnard", "Flying fish", "Footballfish", "Forehead brooder", "Four-eyed fish", "French angelfish", "Freshwater eel", "Freshwater hatchetfish", "Freshwater shark ", "Frigate mackerel", "Frilled shark", "Frogfish", "Frogmouth catfish", "Fusilier fish", "Galjoen fish", "Ganges shark", "Gar", "Garden eel", "Garibaldi ", "Garpike", "Ghostfish ", "Ghost flathead", "Ghost knifefish", "Ghost pipefish", "Ghost shark", "Ghoul ", "Giant danio", "Giant gourami", "Giant sea bass", "Gibberfish", "Gila trout", "Gizzard shad", "Glass catfish ", "Glassfish ", "Glass knifefish", "Glowlight danio", "Goatfish", "Goblin shark", "Goby", "Golden dojo", "Golden loach", "Golden shiner", "Golden trout", "Goldeye", "Goldfish", "Gombessa", "Goosefish", "Gopher rockfish", "Gourami", "Grass carp", "Graveldiver", "Grayling ", "Gray mullet", "Gray reef shark", "Great white shark", "Green swordtail", "Greeneye", "Greenling", "Grenadiers ", "Dichotomyctere nigroviridis", "Ground shark", "Grouper", "Grunion", "Grunt ", "Grunter", "Grunt sculpin", "Gudgeon ", "Guitarfish", "Gulf menhaden", "Saccopharynx", "Gulper", "Gunnel ", "Guppy", "Gurnard ", "Haddock", "Hagfish", "Hairtail", "Hake", "Halfbeak", "Halfmoon", "Halibut", "Halosaur", "Hamlet ", "Hammerhead shark", "Hammerjaw", "Handfish", "Hardhead catfish", "Harelip sucker", "Hatchetfish ", "Hawkfish", "Herring", "Herring smelt", "Hickory Shad", "Hillstream loach", "Hog sucker", "Hoki ", "Horn shark", "Horsefish", "Houndshark", "Huchen", "Humuhumunukunukuapua'a", "Hussar ", "Channichthyidae", "Ide ", "Ilish", "Inanga ", "Stenodus nelma", "Jack #Fish", "Jack #Fish", "Jack Dempsey ", "Japanese eel", "Javelin ", "Jawfish", "Jellynose fish", "Jewelfish", "Jewel tetra", "Jewfish ", "John Dory", "Kafue pike", "Kahawai", "Kaluga ", "Kanyu", "Kelp perch", "Kelpfish ", "Killifish", "King of the herrings ", "Kingfish ", "King-of-the-salmon", "Kissing gourami", "Knifefish ", "Knifejaw", "Koi", "Kokanee ", "Kokopu", "Kuhli loach", "Labyrinth fish", "Ladyfish", "Lake chub", "Lake trout", "Lake whitefish", "Lampfish", "Lamprey", "Lancetfish", "Lanternfish", "Largemouth bass", "Leaf Fish ", "Leatherjacket ", "Lefteye flounder", "Lemon shark", "Lemon sole", "Lemon tetra", "Lenok", "Leopard danio", "Lightfish ", "Limia", "Lined sole", "Ling ", "Ling cod", "Lionfish ", "Livebearer", "Lizardfish", "Loach ", "Loach catfish", "Loach goby", "Loach minnow", "Longfin", "Longfin dragonfish", "Longfin escolar", "Longfin smelt", "Long-finned char", "Long-finned pike", "Long-finned sand diver", "Longjaw mudsucker", "Longneck eel", "Longnose chimaera", "Longnose dace", "Longnose lancetfish", "Longnose sucker", "Longnose whiptail catfish", "Long-whiskered catfish", "Loosejaw", "Lost River sucker", "Louvar", "Loweye catfish", "Luderick", "Luminous hake", "Lumpsucker", "Lungfish", "Mackerel", "Mackerel shark", "Madtom", "Mahi-mahi", "Mahseer", "Mail-cheeked fish", "Mako shark", "Mandarinfish ", "Manefish", "Man-of-war fish", "Manta ray", "Marblefish", "Marine hatchetfish", "Marlin", "Masu salmon", "Medaka", "Medusafish", "Megamouth shark", "Menhaden", "Merluccid hake", "Mexican golden trout", "Midshipman fish", "Milkfish", "Minnow", "Minnow of the deep ", "Modoc sucker", "Mojarra", "Mola mola", "Monkeyface prickleback", "Monkfish", "Mooneye", "Moonfish ", "Moorish idol", "Mora ", "Moray eel", "Morid cod", "Morwong ", "Moses sole", "Mosquitofish", "Mouthbrooder", "Mozambique tilapia", "Mrigal", "Mud catfish", "Mudfish ", "Mud minnow ", "Mudskipper", "Mudsucker", "Mullet ", "Mummichog", "Murray cod", "Muskellunge", "Mustache triggerfish", "Mustard eel", "Naked-back knifefish", "Nase", "Needlefish", "Neon tetra", "New World rivuline", "New Zealand sand diver", "New Zealand smelt", "Nibble fish", "Noodlefish", "North American darter", "North American freshwater catfish", "North Pacific daggertooth", "Northern anchovy", "Northern clingfish", "Northern lampfish", "Northern pike", "Northern sea robin", "Northern squawfish", "Northern stargazer", "Nototheniidae", "Nurseryfish", "Nurse shark", "Oarfish", "Ocean perch", "Ocean sunfish", "Oceanic whitetip shark", "Oilfish", "Oldwife", "Old World knifefish", "Olive flounder", "Opah", "Opaleye", "Orange roughy", "Orangespine unicorn fish", "Orangestriped triggerfish", "Orbicular batfish", "Orbicular velvetfish", "Oregon chub", "Orfe", "Oriental loach", "Oscar ", "Owens pupfish", "Pacific albacore", "Pacific cod", "Pacific hake", "Pacific herring", "Pacific lamprey", "Pacific rudderfish", "Pacific salmon", "Pacific saury", "Pacific trout", "Pacific viperfish", "Paddlefish", "Pancake batfish", "Iridescent shark", "Paradise fish", "Parasitic catfish", "Parore", "Parrotfish", "Peacock flounder", "Peamouth", "Pearleye", "Pearlfish", "Pearl danio", "Pearl perch", "Pelagic cod", "Pelican eel", "Pelican gulper", "Pencil catfish", "Pencilfish", "Pencilsmelt", "Peppered corydoras", "Perch", "Peters' elephantnose fish", "Pickerel ", "Pigfish ", "Pike conger", "Pike eel", "Pike ", "Pikeblenny", "Pikeperch", "Pilchard", "Pilot fish", "Pineapplefish", "Pineconefish", "Pink salmon ", "Píntano", "Pipefish", "Piranha", "Pirarucu", "Pirate perch", "Plaice", "Platy ", "Platyfish", "Pleco ", "Plownose chimaera", "Poacher ", "Pollyfish", "Pollock", "Pomfret ", "Pompano", "Pompano dolphinfish", "Ponyfish", "Popeye catalufa", "Porbeagle shark", "Porcupinefish", "Porgy ", "Port Jackson shark", "Powen", "Prickleback", "Pricklefish", "Prickly shark", "Prowfish", "Pufferfish", "Pumpkinseed", "Pupfish", "Pygmy sunfish", "Queen danio", "Queen parrotfish", "Queen triggerfish", "Quillback", "Quillfish", "Rabbitfish", "Raccoon butterfly fish", "Ragfish", "Rainbow trout", "Rainbowfish", "Rasbora", "Rock gunnel", "Ratfish", "Rattail", "Batoidea", "Razorback sucker", "Razorfish ", "Red grouper", "Red salmon", "Red Snapper ", "Redfin perch", "Redfish", "Redhorse sucker", "Redlip blenny", "Redmouth whalefish", "Redtooth triggerfish", "Red velvetfish", "Red whalefish", "Reedfish", "Reef triggerfish", "Remora", "Requiem shark", "Ribbon eel", "Ribbon sawtail fish", "Ribbonfish", "Rice eel", "Ricefish", "Ridgehead", "Riffle dace", "Righteye flounder", "Rio Grande perch", "River loach", "River shark", "River stingray", "Rivuline", "Roach #Animals", "Roanoke bass", "Rock bass", "Rock beauty", "Rock cod", "Rocket danio", "Rockfish ", "Rockling ", "Rockweed gunnel", "Rohu", "Ronquil", "Roosterfish", "Ropefish", "Rough scad", "Rough sculpin", "Roughy", "Roundhead ", "Round herring", "Round stingray", "Round whitefish", "Rudd", "Rudderfish", "Ruffe", "Russian sturgeon", "Sábalo ", "Sabretooth #Animals", "Saber-toothed blenny", "Sabertooth fish", "Sablefish", "Stromateidae", "Sacramento blackfish", "Sacramento splittail", "Sailfin silverside", "Sailfish", "Salamanderfish", "Salmon", "Salmon shark", "Sandbar shark", "Sandburrower", "Sand dab", "Sand diver ", "Sand eel", "Sandfish ", "Sand goby", "Sand knifefish", "Sand lance", "Sandperch", "Sandroller", "Sand stargazer", "Sand tiger", "Sand tilefish", "Sandbar shark", "Sarcastic fringehead", "Sardine", "Sargassum fish", "Sauger", "Saury", "Sawfish ", "Saw shark", "Sawtooth eel", "Scabbard fish", "Scaly dragonfish", "Scat ", "Scissortail rasbora ", "Scorpionfish", "Sculpin", "Scup", "Sea bass ", "Sea bream", "Sea catfish", "Sea chub", "Sea devil ", "Common seadragon", "Sea lamprey", "Sea raven", "Snailfish", "Sea toad", "Seahorse", "Seamoth", "Searobin", "Sevan trout", "Sergeant major ", "Shad", "Shark", "Sharksucker", "Sharpnose puffer", "Sheatfish ", "Sheepshead ", "Sheepshead minnow", "Shiner ", "Shortnose chimaera", "Shortnose sucker", "Shovelnose sturgeon", "Shrimpfish", "Siamese fighting fish", "Sillago", "Silver carp", "Silver dollar ", "Silver dory", "Silver hake", "Silverside ", "Silvertip tetra", "Sind danio", "Sixgill ray", "Sixgill shark", "Skate ", "Skilfish", "Skipjack tuna", "Slender mola", "Slender snipe eel", "Sleeper #Biology", "Sleeper shark", "Slickhead", "Slimehead", "Slimy mackerel", "Slimy sculpin", "Slipmouth", "Smalleye squaretail", "Smalltooth sawfish", "Smelt ", "Smelt-whiting", "Smooth dogfish", "Snailfish", "Snake eel", "Snakehead ", "Snake mackerel", "Snapper ", "Snipe eel", "Snipefish", "Snook ", "Snubnose eel", "Snubnose parasitic eel", "Sockeye salmon", "Soldierfish", "Sole ", "South American darter", "South American lungfish", "Southern Dolly Varden", "Southern flounder", "Southern hake", "Southern sandfish", "Southern smelt", "Spadefish", "Spaghetti eel", "Spanish mackerel", "Spearfish ", "Speckled trout ", "Spiderfish", "Spikefish", "Spinefoot", "Spiny basslet", "Spiny dogfish", "Spiny dwarf catfish", "Spiny eel", "Spinyfin", "Splitfin", "Spookfish ", "Spotted climbing perch", "Spotted danio", "Spottail pinfish", "Sprat", "Springfish", "Squarehead catfish", "Squaretail", "Squawfish ", "Squeaker ", "Squirrelfish", "Staghorn sculpin", "Stargazer ", "Starry flounder", "Steelhead", "Stickleback", "Stingfish", "Stingray", "Stonecat", "Stonefish", "Stoneroller minnow", "Stream catfish", "Striped bass", "Striped burrfish", "Sturgeon", "Catostomidae", "Suckermouth armored catfish", "Summer flounder", "Sundaland noodlefish", "Sunfish ", "Surf sardine", "Surfperch", "Surgeonfish", "Swallower", "Swamp-eel", "Swampfish", "Sweeper", "Swordfish", "Swordtail", "Tadpole cod", "Tadpole fish", "Bluefish", "Taimen", "Tang ", "Tapetail", "Tarpon", "Tarwhine", "Telescopefish", "Temperate bass", "Temperate ocean-bass", "Temperate perch", "Tench", "Tenpounder", "Tenuis tetra", "Tetra", "Thorny catfish", "Thornfish", "Threadfin", "Threadfin bream", "Thread-tail", "Three spot gourami", "Threespine stickleback", "Three-toothed puffer", "Thresher shark", "Tidewater goby", "Tiger barb", "Tigerperch", "Tiger shark", "Tiger shovelnose catfish", "Tilapia", "Tilefish", "Titan triggerfish", "Toadfish", "Tommy ruff", "Tompot blenny", "Tonguefish", "Tope ", "Topminnow", "Torpedo ", "Torrent catfish", "Torrent fish", "Trahira", "Treefish", "Trevally", "Triggerfish", "Triplefin blenny", "Triplespine", "Tripletail", "Tripod fish ", "Trout", "Trout cod", "Trout-perch", "Trumpeter ", "Trumpetfish", "Trunkfish", "Tubeblenny", "Tube-eye", "Tube-snout ", "Tubeshoulder", "Tui chub", "Tuna", "Turbot", "Two spotted goby", "Uaru", "Unicorn fish ", "Upside-down catfish", "Vanjaram", "Velvet belly lanternshark", "Velvet catfish", "Velvetfish", "Vendace ", "Vermilion snapper", "Vimba", "Viperfish", "Wahoo", "Walking catfish", "Wallago", "Walleye", "Walleye pollock", "Escolar", "Warmouth", "Warty angler", "Waryfish", "Waspfish", "Weasel shark", "Weatherfish", "Weever", "Weeverfish", "Wels catfish", "Whale catfish", "Whalefish", "Whale shark", "Whiff ", "Whitebait", "White croaker", "Whitefish ", "White marlin", "White shark", "Whitetip reef shark", "Whiting ", "Wobbegong", "Wolf-eel", "Wolffish", "Wolf-herring", "Worm eel", "Wormfish", "Wrasse", "Wrymouth", "Yellow-and-black triplefin", "Yellowback fusilier", "Yellowbanded perch", "Yellow bass", "Yellowedge grouper", "Yellow-edged moray", "Yellow-eye mullet", "Yellowhead jawfish", "Yellowfin croaker", "Yellowfin cutthroat trout", "Yellowfin grouper", "Yellowfin tuna", "Yellowfin pike", "Yellowfin surgeonfish", "Yellowfin tuna", "Yellow jack", "Yellowmargin triggerfish", "Yellow moray", "Yellow perch", "Yellowtail ", "Yellowtail amberjack", "Yellowtail barracuda", "Yellowtail clownfish", "Yellowtail horse mackerel", "Yellowtail kingfish", "Yellowtail snapper", "Yellow tang", "Yellow weaver ", "Yellowtail catfish", "Zander", "Zebra bullhead shark", "Zebra danio", "Zebrafish", "Zebra lionfish", "Zebra loach", "Zebra oto", "Zebra pleco", "Zebra shark", "Zebra tilapia", "Zebra turkeyfish", "Ziege", "Zingel"];

    internal static readonly string[] Worlds = ["Albion", "Asgard", "Avalon", "Averoigne", "Azeroth", "Barsoom", "Darkover", "Deltora", "Dinotopia", "Discworld", "Dreamlands", "Earthsea", "Encantadia", "Equestria", "Eternia", "Etheria", "Filgaia", "Gielinor", "Glorantha", "Gor", "Greyhawk", "Halkeginia", "Hyrule", "Ivalice", "Lankhmar", "Melnibone", "Narnia", "Neverland", "Nirn", "Pellucidar", "Pern", "Prydain", "Spira", "Thedas", "Tyria", "Westeros", "Wonderland", "Xanth"];

    static string Seed => C.CensorSeed;

    internal static string Character(string name, string world)
    {
        if (C.NoNames)
        {
            var n1 = Crc32.Get(Seed + name) % Adjectives.Length;
            var n2 = Crc32.Get(Seed + name) % Animals.Length;
            var w = Crc32.Get(Seed + world) % Worlds.Length;
            return $"{Adjectives[n1]} {Animals[n2]}@{Worlds[w]}";
        }
        else
        {
            return $"{name}@{world}";
        }
    }

    internal static string Character(string name)
    {
        if (C.NoNames)
        {
            if(name.Contains('@'))
            {
                var x = name.Split("@");
                return Character(x[0], x[1]);
            }
            var n1 = Crc32.Get(Seed + name) % Adjectives.Length;
            var n2 = Crc32.Get(Seed + name) % Animals.Length;
            return $"{Adjectives[n1]} {Animals[n2]}";
        }
        else
        {
            return name;
        }
    }

    internal static string World(string world)
    {
        if (C.NoNames)
        {
            var w = Crc32.Get(Seed + world) % Worlds.Length;
            return $"{Worlds[w]}";
        }
        else
        {
            return $"{world}";
        }
    }

    internal static string Retainer(string name)
    {
        if (C.NoNames)
        {
            var w = Crc32.Get(Seed + name) % Fishes.Length;
            return $"{Fishes[w]}";
        }
        else
        {
            return $"{name}";
        }
    }


}
