using System;
using System.Threading;
using System.Collections;
using System.Linq;

/*
 * Title: Monolith Gun Crafting Calculator
 * Author: parkerx
 * Date: Released on 6-9-2020
 */

namespace MonolithGuns
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun Makarov = new Gun
            {
                Name = "Makarov",
                WeaponPart = "Pistol",
                Crafting = 5,
                CopperBar = 8,
                IronBar = 5
            };
            Gun M1911 = new Gun
            {
                Name = "M1911",
                WeaponPart = "Pistol",
                Crafting = 12,
                CopperBar = 9,
                IronBar = 6
            };
            Gun P99 = new Gun
            {
                Name = "P99",
                WeaponPart = "Pistol",
                Crafting = 15,
                CopperBar = 8,
                IronBar = 8
            };
            Gun FiveSeven = new Gun
            {
                Name = "FN-FiveSeven",
                WeaponPart = "Pistol",
                Crafting = 18,
                CopperBar = 7,
                IronBar = 9,
                SteelBar = 2
            };
            Gun MAC11 = new Gun
            {
                Name = "Mac-11",
                WeaponPart = "Pistol",
                Crafting = 20,
                CopperBar = 9,
                IronBar = 10
            };
            Gun MR96 = new Gun
            {
                Name = "MR96",
                WeaponPart = "Pistol",
                Crafting = 20,
                CopperBar = 8,
                IronBar = 5,
                SteelBar = 5
            };
            Gun MP5 = new Gun
            {
                Name = "HK MP5",
                WeaponPart = "Pistol",
                Crafting = 21,
                CopperBar = 10,
                IronBar = 12,
                SteelBar = 2
            };
            Gun UMP = new Gun
            {
                Name = "H&K UMP .45",
                WeaponPart = "Pistol",
                Crafting = 27,
                CopperBar = 14,
                IronBar = 16
            };
            Gun AK = new Gun
            {
                Name = "AK-74",
                WeaponPart = "Damaged Rifle",
                Crafting = 28,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 1
            };
            Gun Glock18 = new Gun
            {
                Name = "Glock 18",
                WeaponPart = "Pistol",
                Crafting = 28,
                CopperBar = 8,
                IronBar = 12,
                SteelBar = 6
            };
            Gun AR15 = new Gun
            {
                Name = "AR-15",
                WeaponPart = "Damaged Rifle",
                Crafting = 30,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 3
            };
            Gun Thompson = new Gun
            {
                Name = "Thompson",
                WeaponPart = "Pistol",
                Crafting = 31,
                CopperBar = 15,
                IronBar = 17,
                SteelBar = 2
            };
            Gun Glock17 = new Gun
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
            Gun Vector = new Gun
            {
                Name = "Kriss Vector",
                WeaponPart = "Pistol",
                Crafting = 34,
                IronBar = 12,
                SteelBar = 7,
                SilverBar = 5,
                GoldBar = 6
            };
            Gun Deagle = new Gun
            {
                Name = "Desert Eagle",
                WeaponPart = "Pistol",
                Crafting = 35,
                CopperBar = 8,
                IronBar = 10,
                SteelBar = 3
            };
            Gun G36C = new Gun
            {
                Name = "G36C",
                WeaponPart = "Damaged Rifle",
                Crafting = 37,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 5
            };
            Gun LR = new Gun
            {
                Name = "LR-300",
                WeaponPart = "Rifle",
                Crafting = 40,
                CopperBar = 11,
                IronBar = 11,
                SteelBar = 5,
                SilverBar = 4
            };
            Gun DP = new Gun
            {
                Name = "DP-28",
                WeaponPart = "Rifle",
                Crafting = 40,
                CopperBar = 12,
                IronBar = 12,
                SteelBar = 6,
                SilverBar = 5
            };
            Gun Shorty = new Gun
            {
                Name = "Serbu Shorty",
                WeaponPart = "Shotgun",
                Crafting = 40,
                CopperBar = 7,
                IronBar = 8,
                SteelBar = 10
            };
            Gun Galil = new Gun
            {
                Name = "IMI Galil",
                WeaponPart = "Rifle",
                Crafting = 41,
                IronBar = 14,
                SteelBar = 9,
                SilverBar = 10
            };
            Gun G3A3 = new Gun
            {
                Name = "G3A3",
                WeaponPart = "Rifle",
                Crafting = 42,
                CopperBar = 12,
                SteelBar = 12,
                SilverBar = 9
            };
            Gun Honey = new Gun
            {
                Name = "Honey Badger",
                WeaponPart = "Rifle",
                Crafting = 50,
                CopperBar = 10,
                IronBar = 11,
                SteelBar = 12,
                GoldBar = 11
            };
            Gun M249 = new Gun
            {
                Name = "M249",
                WeaponPart = "Rifle",
                Crafting = 60,
                CopperBar = 9,
                IronBar = 11,
                SteelBar = 12,
                GoldBar = 13,
                TitaniumBar = 3
            };
            Gun MP9 = new Gun
            {
                Name = "BT MP9",
                WeaponPart = "Pistol",
                Crafting = 62,
                IronBar = 13,
                SteelBar = 5,
                SilverBar = 8,
                TitaniumBar = 2
            };
            Gun Mosin = new Gun
            {
                Name = "Mosin Nagant",
                WeaponPart = "Sniper",
                Crafting = 64,
                CopperBar = 8,
                IronBar = 14,
                SteelBar = 16,
                SilverBar = 19
            };
            Gun M14 = new Gun
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
            Gun Super = new Gun
            {
                Name = "M3 Super 90",
                WeaponPart = "Shotgun",
                Crafting = 66,
                IronBar = 15,
                SteelBar = 6,
                SilverBar = 7,
                GoldBar = 8
            };
            Gun M4 = new Gun
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
            Gun ACR = new Gun
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
            Gun KSG = new Gun
            {
                Name = "KSG-12 Shotgun",
                WeaponPart = "Shotgun",
                IronBar = 17,
                SteelBar = 13,
                SilverBar = 7,
                GoldBar = 8,
                TitaniumBar = 5
            };
            Gun AUG = new Gun
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
            Gun XM8 = new Gun
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
                PrintRow("Rifles", "SMGs", "Pistols", "Other");
                PrintLine();
                PrintLine();
                PrintRow(AK.Name, MAC11.Name, Makarov.Name, Shorty.Name);
                PrintRow(AR15.Name, MP5.Name, M1911.Name, Mosin.Name);
                PrintRow(G36C.Name, UMP.Name, P99.Name, M14.Name);
                PrintRow(LR.Name, Thompson.Name, FiveSeven.Name, Super.Name);
                PrintRow(DP.Name, Vector.Name, MR96.Name, KSG.Name);
                PrintRow(Galil.Name, MP9.Name, Glock18.Name, "");
                PrintRow(G3A3.Name, "", Glock17.Name, "");
                PrintRow(Honey.Name, "", Deagle.Name, "");
                PrintRow(M249.Name, "", "", "");
                PrintRow(M4.Name, "", "", "");
                PrintRow(ACR.Name, "", "", "");
                PrintRow(AUG.Name, "", "", "");
                PrintRow(XM8.Name, "", "", "");
                PrintLine();

                Console.WriteLine("\nType the exact name of a gun from the table above. (type 'done' if you're done)");
                itemInput = Console.ReadLine();
                while (!(itemInput == "done" || itemInput == Makarov.Name || itemInput == M1911.Name || itemInput == P99.Name || itemInput == FiveSeven.Name || itemInput == MAC11.Name || itemInput == MR96.Name || itemInput == MP5.Name || itemInput == UMP.Name || itemInput == AK.Name || itemInput == Glock18.Name || itemInput == AR15.Name || itemInput == Thompson.Name || itemInput == Glock17.Name || itemInput == Vector.Name || itemInput == Deagle.Name || itemInput == G36C.Name || itemInput == LR.Name || itemInput == DP.Name || itemInput == Shorty.Name || itemInput == Galil.Name || itemInput == G3A3.Name || itemInput == Honey.Name || itemInput == M249.Name || itemInput == MP9.Name || itemInput == Mosin.Name || itemInput == M14.Name || itemInput == Super.Name || itemInput == M4.Name || itemInput == ACR.Name || itemInput == KSG.Name || itemInput == AUG.Name || itemInput == XM8.Name))
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
                ArrayList GunArray = new ArrayList()
                {
                    new Gun
                    {
                        Name = "Makarov",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 5,
                        CopperBar = 8,
                        IronBar = 5
                    },
                    new Gun
                    {
                        Name = "M1911",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 12,
                        CopperBar = 9,
                        IronBar = 6
                    },
                    new Gun
                    {
                        Name = "P99",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 15,
                        CopperBar = 8,
                        IronBar = 8
                    },
                    new Gun
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
                    new Gun
                    {
                        Name = "Mac-11",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 20,
                        CopperBar = 9,
                        IronBar = 10
                    },
                    new Gun
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
                    new Gun
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
                    new Gun
                    {
                        Name = "H&K UMP .45",
                        WeaponPart = "Pistol",
                        PartCopper = 2,
                        PartIron = 2,
                        Crafting = 27,
                        CopperBar = 14,
                        IronBar = 16
                    },
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
                    {
                        Name = "M249",
                        WeaponPart = "Rifle",
                        PartCopper = 5,
                        PartIron = 5,
                        PartSteel = 2,
                        Crafting = 60,
                        CopperBar = 9,
                        IronBar = 11,
                        SteelBar = 12,
                        GoldBar = 13,
                        TitaniumBar = 3
                    },
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    new Gun
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
                    }
                };
                var GunEnum = GunArray.OfType<Gun>();
                var AddedGun = from gun in GunEnum where gun.Name == itemInput orderby gun.Name select gun;
                foreach(var gun in AddedGun)
                {
                    TotalCoal = TotalCoal + (gun.CoalChunk*itemQuantity) + gun.PartCoalChunk * itemQuantity;
                    TotalCopper = TotalCopper + (gun.CopperChunk*itemQuantity) + gun.PartCopperChunk * itemQuantity;
                    TotalIron = TotalIron + (gun.IronChunk*itemQuantity) + gun.PartIronChunk * itemQuantity;
                    TotalSilver = TotalSilver + (gun.SilverChunk*itemQuantity) + gun.PartSilverChunk * itemQuantity;
                    TotalGold = TotalGold + (gun.GoldChunk*itemQuantity) + gun.PartGoldChunk * itemQuantity;
                    TotalTitanium = TotalTitanium = (gun.TitaniumChunk*itemQuantity);
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
        static int tableWidth = 73;
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