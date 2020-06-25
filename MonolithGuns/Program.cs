using System;
using System.Threading;
using System.Collections;
using System.Linq;

/*
 * Title: Monolith Item Crafting Calculator
 * Author: parkerx
 * Date: Released on 6-9-2020
 */

namespace MonolithItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Item Makarov = new Item
            {
                Name = "Makarov",
                WeaponPart = "Pistol",
                Crafting = 5,
                CopperBar = 8,
                IronBar = 5
            };
            Item M1911 = new Item
            {
                Name = "M1911",
                WeaponPart = "Pistol",
                Crafting = 12,
                CopperBar = 9,
                IronBar = 6
            };
            Item P99 = new Item
            {
                Name = "P99",
                WeaponPart = "Pistol",
                Crafting = 15,
                CopperBar = 8,
                IronBar = 8
            };
            Item FiveSeven = new Item
            {
                Name = "FN-FiveSeven",
                WeaponPart = "Pistol",
                Crafting = 18,
                CopperBar = 7,
                IronBar = 9,
                SteelBar = 2
            };
            Item MAC11 = new Item
            {
                Name = "Mac-11",
                WeaponPart = "Pistol",
                Crafting = 20,
                CopperBar = 9,
                IronBar = 10
            };
            Item MR96 = new Item
            {
                Name = "MR96",
                WeaponPart = "Pistol",
                Crafting = 20,
                CopperBar = 8,
                IronBar = 5,
                SteelBar = 5
            };
            Item MP5 = new Item
            {
                Name = "HK MP5",
                WeaponPart = "Pistol",
                Crafting = 21,
                CopperBar = 10,
                IronBar = 12,
                SteelBar = 2
            };
            Item UMP = new Item
            {
                Name = "H&K UMP .45",
                WeaponPart = "Pistol",
                Crafting = 27,
                CopperBar = 14,
                IronBar = 16
            };
            Item AK = new Item
            {
                Name = "AK-74",
                WeaponPart = "Damaged Rifle",
                Crafting = 28,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 1
            };
            Item Glock18 = new Item
            {
                Name = "Glock 18",
                WeaponPart = "Pistol",
                Crafting = 28,
                CopperBar = 8,
                IronBar = 12,
                SteelBar = 6
            };
            Item AR15 = new Item
            {
                Name = "AR-15",
                WeaponPart = "Damaged Rifle",
                Crafting = 30,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 3
            };
            Item Thompson = new Item
            {
                Name = "Thompson",
                WeaponPart = "Pistol",
                Crafting = 31,
                CopperBar = 15,
                IronBar = 17,
                SteelBar = 2
            };
            Item Glock17 = new Item
            {
                Name = "Glock 17",
                WeaponPart = "Pistol",
                Crafting = 32,
                CopperBar = 8,
                IronBar = 8,
                SteelBar = 3,
                SilverBar = 1,
                GoldBar = 2
            };
            Item Vector = new Item
            {
                Name = "Kriss Vector",
                WeaponPart = "Pistol",
                Crafting = 34,
                IronBar = 12,
                SteelBar = 7,
                SilverBar = 5,
                GoldBar = 6
            };
            Item Deagle = new Item
            {
                Name = "Desert Eagle",
                WeaponPart = "Pistol",
                Crafting = 35,
                CopperBar = 8,
                IronBar = 10,
                SteelBar = 3
            };
            Item G36C = new Item
            {
                Name = "G36C",
                WeaponPart = "Damaged Rifle",
                Crafting = 37,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 5
            };
            Item LR = new Item
            {
                Name = "LR-300",
                WeaponPart = "Rifle",
                Crafting = 40,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 5,
                SilverBar = 4
            };
            Item DP = new Item
            {
                Name = "DP-28",
                WeaponPart = "Rifle",
                Crafting = 40,
                CopperBar = 12,
                IronBar = 12,
                SteelBar = 6,
                SilverBar = 5
            };
            Item Shorty = new Item
            {
                Name = "Serbu Shorty",
                WeaponPart = "Shotgun",
                Crafting = 40,
                CopperBar = 7,
                IronBar = 8,
                SteelBar = 10
            };
            Item Galil = new Item
            {
                Name = "IMI Galil",
                WeaponPart = "Rifle",
                Crafting = 41,
                IronBar = 14,
                SteelBar = 9,
                SilverBar = 10
            };
            Item G3A3 = new Item
            {
                Name = "G3A3",
                WeaponPart = "Rifle",
                Crafting = 42,
                CopperBar = 12,
                SteelBar = 12,
                SilverBar = 9
            };
            Item Honey = new Item
            {
                Name = "Honey Badger",
                WeaponPart = "Rifle",
                Crafting = 50,
                CopperBar = 10,
                IronBar = 11,
                SteelBar = 12,
                GoldBar = 11
            };
            Item M249 = new Item
            {
                Name = "M249",
                WeaponPart = "Rifle",
                Crafting = 60,
                CopperBar = 9,
                IronBar = 11,
                SteelBar = 8,
                GoldBar = 13,
                TitaniumBar = 1
            };
            Item MP9 = new Item
            {
                Name = "BT MP9",
                WeaponPart = "Pistol",
                Crafting = 62,
                IronBar = 13,
                SteelBar = 5,
                SilverBar = 8,
                TitaniumBar = 2
            };
            Item Mosin = new Item
            {
                Name = "Mosin Nagant",
                WeaponPart = "Sniper",
                Crafting = 64,
                CopperBar = 8,
                IronBar = 14,
                SteelBar = 16,
                SilverBar = 19
            };
            Item M14 = new Item
            {
                Name = "M14",
                WeaponPart = "Sniper",
                Crafting = 65,
                IronBar = 14,
                SteelBar = 13,
                SilverBar = 17,
                GoldBar = 6,
                TitaniumBar = 5
            };
            Item Super = new Item
            {
                Name = "M3 Super 90",
                WeaponPart = "Shotgun",
                Crafting = 66,
                IronBar = 15,
                SteelBar = 6,
                SilverBar = 7,
                GoldBar = 8
            };
            Item M4 = new Item
            {
                Name = "M4 Carbine",
                WeaponPart = "Rifle",
                Crafting = 68,
                CopperBar = 10,
                IronBar = 11,
                SteelBar = 10,
                SilverBar = 8,
                GoldBar = 11,
                TitaniumBar = 1
            };
            Item ACR = new Item
            {
                Name = "ACR-E",
                WeaponPart = "Rifle",
                Crafting = 73,
                CopperBar = 12,
                IronBar = 13,
                SteelBar = 10,
                GoldBar = 10,
                TitaniumBar = 2
            };
            Item KSG = new Item
            {
                Name = "KSG-12 Shotgun",
                WeaponPart = "Shotgun",
                IronBar = 17,
                SteelBar = 13,
                SilverBar = 7,
                GoldBar = 8,
                TitaniumBar = 5
            };
            Item AUG = new Item
            {
                Name = "AUG A3",
                WeaponPart = "Rifle",
                CopperBar = 12,
                IronBar = 11,
                SteelBar = 14,
                SilverBar = 8,
                GoldBar = 13,
                TitaniumBar = 4
            };
            Item XM8 = new Item
            {
                Name = "XM8",
                WeaponPart = "Rifle",
                CopperBar = 6,
                IronBar = 6,
                SteelBar = 14,
                SilverBar = 20,
                GoldBar = 13,
                TitaniumBar = 7
            };
            // BELOW THIS POINT IS NEW
            Item Copper = new Item
            {
                Name = "Copper Bar",
                CopperBar = 1
            };
            Item Iron = new Item
            {
                Name = "Iron Bar",
                IronBar = 1
            };
            Item Steel = new Item
            {
                Name = "Steel Bar",
                IronBar = 1
            };
            Item Silver = new Item
            {
                Name = "Silver Bar",
                IronBar = 1
            };
            Item Gold = new Item
            {
                Name = "Gold Bar",
                IronBar = 1
            };
            Item Titanium = new Item
            {
                Name = "Titanium Bar",
                IronBar = 1
            };
            Item Lockpick = new Item
            {
                Name = "Lockpick",
                CopperBar = 2,
                IronBar = 1
            };
            Item Siphon = new Item
            {
                Name = "Siphon Pump",
                CopperBar = 2,
                IronBar = 3,
                SteelBar = 1
            };
            Item Zipties = new Item
            {
                Name = "Zipties",
                IronBar = 2,
            };
            Item Mask = new Item
            {
                Name = "Gas Mask",
                CopperBar = 4,
                IronBar = 4,
                SteelBar = 4
            };
            Item Filter = new Item
            {
                Name = "Gas Filter",
                CopperBar = 4,
                IronBar = 4,
                SteelBar = 2
            };
            Item Charge = new Item
            {
                Name = "Door Charge",
                CopperBar = 6,
                IronBar = 8,
                SteelBar = 3,
                GoldBar = 4
            };
            Item Machete = new Item
            {
                Name = "Machete",
                CopperBar = 8,
                IronBar = 5
            };
            Item Gas = new Item
            {
                Name = "CK Gas Grenade",
                CopperBar = 12,
                IronBar = 10,
                SteelBar = 10,
                TitaniumBar = 4
            };
            Console.Clear();
            string itemInput = "Banana";
            int itemQuantity = 0;
            double TotalCoal = 0;
            double TotalCopper = 0;
            double TotalIron = 0;
            double TotalSilver = 0;
            double TotalGold = 0;
            double TotalTitanium = 0;
            while (itemInput != "done")
            {
                PrintLine();
                PrintRow("Rifles", "SMGs", "Pistols", "Shotguns", "Other", "Manual");
                PrintLine();
                PrintLine();
                PrintRow(AK.Name, MAC11.Name, Makarov.Name, Shorty.Name, Lockpick.Name, Copper.Name);
                PrintRow(AR15.Name, MP5.Name, M1911.Name, Super.Name, Siphon.Name, Iron.Name);
                PrintRow(G36C.Name, UMP.Name, P99.Name, KSG.Name, Zipties.Name, Steel.Name);
                PrintRow(LR.Name, Thompson.Name, FiveSeven.Name, "", Mask.Name, Silver.Name);
                PrintRow(DP.Name, Vector.Name, MR96.Name, "", Filter.Name, Gold.Name);
                PrintRow(Galil.Name, MP9.Name, Glock18.Name, "", Charge.Name, Titanium.Name);
                PrintRow(G3A3.Name, "", Glock17.Name, "", Machete.Name, "");
                PrintRow(Honey.Name, "", Deagle.Name, "", Gas.Name, "");
                PrintRow(M249.Name, "", "", "", "", "");
                PrintRow(Mosin.Name, "", "", "", "", "");
                PrintRow(M14.Name, "", "", "", "", "");
                PrintRow(M4.Name, "", "", "", "", "");
                PrintRow(ACR.Name, "", "", "", "", "");
                PrintRow(AUG.Name, "", "", "", "", "");
                PrintRow(XM8.Name, "", "", "", "", "");
                PrintLine();

                Console.WriteLine("\nType the exact name of a item from the table above. (type 'done' if you're done)");
                itemInput = Console.ReadLine();
                while (!(itemInput == "done" ||
                    itemInput == Makarov.Name ||
                    itemInput == M1911.Name ||
                    itemInput == P99.Name ||
                    itemInput == FiveSeven.Name ||
                    itemInput == MAC11.Name ||
                    itemInput == MR96.Name ||
                    itemInput == MP5.Name ||
                    itemInput == UMP.Name ||
                    itemInput == AK.Name ||
                    itemInput == Glock18.Name ||
                    itemInput == AR15.Name ||
                    itemInput == Thompson.Name ||
                    itemInput == Glock17.Name ||
                    itemInput == Vector.Name ||
                    itemInput == Deagle.Name ||
                    itemInput == G36C.Name ||
                    itemInput == LR.Name ||
                    itemInput == DP.Name ||
                    itemInput == Shorty.Name ||
                    itemInput == Galil.Name ||
                    itemInput == G3A3.Name ||
                    itemInput == Honey.Name ||
                    itemInput == M249.Name ||
                    itemInput == MP9.Name ||
                    itemInput == Mosin.Name ||
                    itemInput == M14.Name ||
                    itemInput == Super.Name ||
                    itemInput == M4.Name ||
                    itemInput == ACR.Name ||
                    itemInput == KSG.Name ||
                    itemInput == AUG.Name ||
                    itemInput == XM8.Name ||
                    itemInput == Copper.Name ||
                    itemInput == Iron.Name ||
                    itemInput == Steel.Name ||
                    itemInput == Silver.Name ||
                    itemInput == Gold.Name ||
                    itemInput == Titanium.Name ||
                    itemInput == Lockpick.Name ||
                    itemInput == Siphon.Name ||
                    itemInput == Zipties.Name ||
                    itemInput == Mask.Name ||
                    itemInput == Filter.Name ||
                    itemInput == Charge.Name ||
                    itemInput == Machete.Name ||
                    itemInput == Gas.Name))
                {
                    Console.WriteLine("ERROR -- Input unrecognized");
                    itemInput = Console.ReadLine();
                }
                if (itemInput == "done")
                {
                    break;
                }
                Console.WriteLine("How many " + itemInput +"'s do you want?");
                itemQuantity = Convert.ToInt16(Console.ReadLine());
                while (itemQuantity < 0)
                {
                    Console.WriteLine("ERROR -- Use integer greater than -1");
                    itemQuantity = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine();
                Console.Write("I"); Thread.Sleep(50);
                Console.Write("t"); Thread.Sleep(50);
                Console.Write("e"); Thread.Sleep(50);
                Console.Write("m"); Thread.Sleep(50);
                Console.Write(" "); Thread.Sleep(50);
                Console.Write("a"); Thread.Sleep(50);
                Console.Write("d"); Thread.Sleep(50);
                Console.Write("d"); Thread.Sleep(50);
                Console.Write("e"); Thread.Sleep(50);
                Console.Write("d"); Thread.Sleep(50);
                Console.Write("."); Thread.Sleep(50);
                Console.Write("."); Thread.Sleep(50);
                Console.Write("."); Thread.Sleep(500);

                // This is where the math needs to be done.
                ArrayList ItemArray = new ArrayList()
                {
                    new Item
                    {
                        Name = "Makarov",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 5,
                        CopperBar = 8,
                        IronBar = 5
                    },
                    new Item
                    {
                        Name = "M1911",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 12,
                        CopperBar = 9,
                        IronBar = 6
                    },
                    new Item
                    {
                        Name = "P99",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 15,
                        CopperBar = 8,
                        IronBar = 8
                    },
                    new Item
                    {
                        Name = "FN-FiveSeven",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 18,
                        CopperBar = 7,
                        IronBar = 9,
                        SteelBar = 2
                    },
                    new Item
                    {
                        Name = "Mac-11",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 20,
                        CopperBar = 9,
                        IronBar = 10
                    },
                    new Item
                    {
                        Name = "MR96",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 20,
                        CopperBar = 8,
                        IronBar = 5,
                        SteelBar = 5
                    },
                    new Item
                    {
                        Name = "HK MP5",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 21,
                        CopperBar = 10,
                        IronBar = 12,
                        SteelBar = 2
                    },
                    new Item
                    {
                        Name = "H&K UMP .45",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 27,
                        CopperBar = 14,
                        IronBar = 16
                    },
                    new Item
                    {
                        Name = "AK-74",
                        WeaponPart = "Damaged Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        Crafting = 28,
                        CopperBar = 11,
                        IronBar = 11,
                        SteelBar = 1
                    },
                    new Item
                    {
                        Name = "Glock 18",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 28,
                        CopperBar = 8,
                        IronBar = 12,
                        SteelBar = 6
                    },
                    new Item
                    {
                        Name = "AR-15",
                        WeaponPart = "Damaged Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        Crafting = 30,
                        CopperBar = 11,
                        IronBar = 11,
                        SteelBar = 3
                    },
                    new Item
                    {
                        Name = "Thompson",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 31,
                        CopperBar = 15,
                        IronBar = 17,
                        SteelBar = 2
                    },
                    new Item
                    {
                        Name = "Glock 17",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 32,
                        CopperBar = 8,
                        IronBar = 8,
                        SteelBar = 3,
                        SilverBar = 1,
                        GoldBar = 2
                    },
                    new Item
                    {
                        Name = "Kriss Vector",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 34,
                        IronBar = 12,
                        SteelBar = 7,
                        SilverBar = 5,
                        GoldBar = 6
                    },
                    new Item
                    {
                        Name = "Desert Eagle",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 35,
                        CopperBar = 8,
                        IronBar = 10,
                        SteelBar = 3
                    },
                    new Item
                    {
                        Name = "G36C",
                        WeaponPart = "Damaged Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        Crafting = 37,
                        CopperBar = 11,
                        IronBar = 11,
                        SteelBar = 5
                    },
                    new Item
                    {
                        Name = "LR-300",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 40,
                        CopperBar = 11,
                        IronBar = 11,
                        SteelBar = 5,
                        SilverBar = 4
                    },
                    new Item
                    {
                        Name = "DP-28",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 40,
                        CopperBar = 12,
                        IronBar = 12,
                        SteelBar = 6,
                        SilverBar = 5
                    },
                    new Item
                    {
                        Name = "Serbu Shorty",
                        WeaponPart = "Shotgun",
                        PartIron = 1,
                        PartSteel = 1,
                        PartSilver = 3,
                        Crafting = 40,
                        CopperBar = 7,
                        IronBar = 8,
                        SteelBar = 10
                    },
                    new Item
                    {
                        Name = "IMI Galil",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 41,
                        IronBar = 14,
                        SteelBar = 9,
                        SilverBar = 10
                    },
                    new Item
                    {
                        Name = "G3A3",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 42,
                        CopperBar = 12,
                        SteelBar = 12,
                        SilverBar = 9
                    },
                    new Item
                    {
                        Name = "Honey Badger",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 50,
                        CopperBar = 10,
                        IronBar = 11,
                        SteelBar = 12,
                        GoldBar = 11
                    },
                    new Item
                    {
                        Name = "M249",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 60,
                        CopperBar = 9,
                        IronBar = 11,
                        SteelBar = 8,
                        GoldBar = 13,
                        TitaniumBar = 1
                    },
                    new Item
                    {
                        Name = "BT MP9",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 62,
                        IronBar = 13,
                        SteelBar = 5,
                        SilverBar = 8,
                        TitaniumBar = 2
                    },
                    new Item
                    {
                        Name = "Mosin Nagant",
                        WeaponPart = "Sniper",
                        PartSteel = 4,
                        PartSilver = 3,
                        PartGold = 2,
                        Crafting = 64,
                        CopperBar = 8,
                        IronBar = 14,
                        SteelBar = 16,
                        SilverBar = 19
                    },
                    new Item
                    {
                        Name = "M14",
                        WeaponPart = "Sniper",
                        PartSteel = 4,
                        PartSilver = 3,
                        PartGold = 2,
                        Crafting = 65,
                        IronBar = 14,
                        SteelBar = 13,
                        SilverBar = 17,
                        GoldBar = 6,
                        TitaniumBar = 5
                    },
                    new Item
                    {
                        Name = "M3 Super 90",
                        WeaponPart = "Shotgun",
                        PartIron = 1,
                        PartSteel = 1,
                        PartSilver = 3,
                        Crafting = 66,
                        IronBar = 15,
                        SteelBar = 6,
                        SilverBar = 7,
                        GoldBar = 8
                    },
                    new Item
                    {
                        Name = "M4 Carbine",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 68,
                        CopperBar = 10,
                        IronBar = 11,
                        SteelBar = 10,
                        SilverBar = 8,
                        GoldBar = 11,
                        TitaniumBar = 1
                    },
                    new Item
                    {
                        Name = "ACR-E",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 73,
                        CopperBar = 12,
                        IronBar = 13,
                        SteelBar = 10,
                        GoldBar = 10,
                        TitaniumBar = 2
                    },
                    new Item
                    {
                        Name = "KSG-12 Shotgun",
                        WeaponPart = "Shotgun",
                        PartIron = 1,
                        PartSteel = 1,
                        PartSilver = 3,
                        IronBar = 17,
                        SteelBar = 13,
                        SilverBar = 7,
                        GoldBar = 8,
                        TitaniumBar = 5
                    },
                    new Item
                    {
                        Name = "AUG A3",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        CopperBar = 12,
                        IronBar = 11,
                        SteelBar = 14,
                        SilverBar = 8,
                        GoldBar = 13,
                        TitaniumBar = 4
                    },
                    new Item
                    {
                        Name = "XM8",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        CopperBar = 6,
                        IronBar = 6,
                        SteelBar = 14,
                        SilverBar = 20,
                        GoldBar = 13,
                        TitaniumBar = 7
                    },
                    new Item
                    {
                        Name = "Copper Bar",
                        CopperBar = 1
                    },
                    new Item
                    {
                        Name = "Iron Bar",
                        IronBar = 1
                    },
                    new Item
                    {
                        Name = "Steel Bar",
                        SteelBar = 1
                    },
                    new Item
                    {
                        Name = "Silver Bar",
                        SilverBar = 1
                    },
                    new Item
                    {
                        Name = "Gold Bar",
                        GoldBar = 1
                    },
                    new Item
                    {
                        Name = "Titanium Bar",
                        TitaniumBar = 1
                    },
                    new Item
                    {
                        Name = "Lockpick",
                        CopperBar = 2,
                        IronBar = 1
                    },
                    new Item
                    {
                        Name = "Siphon Pump",
                        CopperBar = 2,
                        IronBar = 3,
                        SteelBar = 1
                    },
                    new Item
                    {
                        Name = "Zipties",
                        IronBar = 2,
                    },
                    new Item
                    {
                        Name = "Gas Mask",
                        CopperBar = 4,
                        IronBar = 4,
                        SteelBar = 4
                    },
                    new Item
                    {
                        Name = "Gas Filter",
                        CopperBar = 4,
                        IronBar = 4,
                        SteelBar = 2
                    },
                    new Item
                    {
                        Name = "Door Charge",
                        CopperBar = 6,
                        IronBar = 8,
                        SteelBar = 3,
                        GoldBar = 4
                    },
                    new Item
                    {
                        Name = "Machete",
                        CopperBar = 8,
                        IronBar = 5
                    },
                    new Item
                    {
                        Name = "CK Gas Grenade",
                        CopperBar = 12,
                        IronBar = 10,
                        SteelBar = 10,
                        TitaniumBar = 4
                    }
                };
                var ItemEnum = ItemArray.OfType<Item>();
                var AddedItem = from item in ItemEnum where item.Name == itemInput orderby item.Name select item;
                foreach(var item in AddedItem)
                {
                    TotalCoal = TotalCoal + (item.CoalChunk*itemQuantity) + item.PartCoalChunk * itemQuantity;
                    TotalCopper = TotalCopper + (item.CopperChunk*itemQuantity) + item.PartCopperChunk * itemQuantity;
                    TotalIron = TotalIron + (item.IronChunk*itemQuantity) + item.PartIronChunk * itemQuantity;
                    TotalSilver = TotalSilver + (item.SilverChunk*itemQuantity) + item.PartSilverChunk * itemQuantity;
                    TotalGold = TotalGold + (item.GoldChunk*itemQuantity) + item.PartGoldChunk * itemQuantity;
                    TotalTitanium = TotalTitanium = (item.TitaniumChunk*itemQuantity);
                }
                Console.Clear();
            }
            //Display all the totals here.
            Console.Clear();
            Console.WriteLine("Coal Chunks: " + TotalCoal);
            Console.WriteLine("Copper Chunks: " + TotalCopper);
            Console.WriteLine("Iron Chunks: " + TotalIron);
            Console.WriteLine("Silver Chunks: " + TotalSilver);
            Console.WriteLine("Gold Chunks: " + TotalGold);
            Console.WriteLine("Titanium Chunks: " + TotalTitanium);
            Console.WriteLine("\n\n\nCreated by parkerx\nPress any key to close...");
            Console.ReadKey();
        }
        static int tableWidth = 91;
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += AlignCenter(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        static string AlignCenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}