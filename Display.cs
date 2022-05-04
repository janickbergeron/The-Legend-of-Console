using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Display
    {
        public static char[][] MainTab = new char[16][];
        public static string[][] StringTab = new string[16][];
        public static List<string> ContextDisplayList = new List<string>();

        public static void InitializeStringTab()
        {
            for (int i = 0; i < 16; i++)
            StringTab[i] = new string[] { "" };
        }
        public static void InitializeGameboard1()
        {
            MainTab[0] = new char[] {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[1] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[2] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[3] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[4] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[5] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[6] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[7] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[8] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[9] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[10] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[11] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[12] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[13] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[14] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            MainTab[15] = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };


            // ╦ ╩ ╣ ║ ╬ ╠ ═ ╔ ╗ ╚ ╝
        }  // Function to initialize the display array  52 Coll 16 row

        public static void MainTabLoading(Board board)
        {
                for (int i = 0; i < 63; i++)
                {
                    MainTab[0][i] = board.Line0[i];
                    MainTab[1][i] = board.Line1[i];
                    MainTab[2][i] = board.Line2[i];
                    MainTab[3][i] = board.Line3[i];
                    MainTab[4][i] = board.Line4[i];
                    MainTab[5][i] = board.Line5[i];
                    MainTab[6][i] = board.Line6[i];
                    MainTab[7][i] = board.Line7[i];
                    MainTab[8][i] = board.Line8[i];
                    MainTab[9][i] = board.Line9[i];
                    MainTab[10][i] = board.Line10[i];
                    MainTab[11][i] = board.Line11[i];
                    MainTab[12][i] = board.Line12[i];
                    MainTab[13][i] = board.Line13[i];
                    MainTab[14][i] = board.Line14[i];
                    MainTab[15][i] = board.Line15[i];
                }
        } //Function to load Board from BoardData File
        public static void GameboardOptimisation()
        {
            for (int i = 0; i < 16; i++)
            {
                string str = new string(MainTab[i]);
                Display.StringTab[i][0] = str;
            }
        }
        public static void Gameline(int x)
        {
            foreach (string n in StringTab[x]) 
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }    //Function to draw one line of the gameboard.
        public static void Gameboard()
        {
            for (int i = 0; i < 16; i++)
            {
                Gameline(i);
            }
            ContextDisplay();
        }     //Function to draw the gameboard.
        public static void ContextDisplay()
        {
            InitializeContextDisplay();
             string menuString = "╔═════════════════════════════════════════════════════════════╗ \n";                
                foreach (string n in ContextDisplayList)
                {
                   menuString += n + "\n";
                }
                   menuString += "╚═════════════════════════════════════════════════════════════╝";
            Console.WriteLine(menuString);
            Console.WriteLine("Space = Interact i = Inventory");
        }
        public static void InitializeContextDisplay()
        {
            for (int i = 0; i < 4; i++)
            {
                ContextDisplayList.Clear();
            }
            for (int i = 0; i < 4; i++)
            {
                ContextDisplayList.Add("║                                                             ║");
            }
        }
        public static void CombatLogDisplay()
        {
            Console.Clear();
                    string menuString = "╔════════════════════════════════════╦═══════════════════════════════════╦══════════════════════════════╗ \n";
            menuString += String.Format("║ Name: {0,-10}       {1,-3}/ {2,-3}HP  ║ Enemy: {3,-10}     {4,-3}/ {5,-3}HP  ║          Equipments          ║\n", Program.player.Name, Program.player.Health, Program.player.MaxHealth, Program.monster.Name, Program.monster.Health, Program.monster.MaxHealth) +
                          String.Format("║ Level: {0,-3}             Armor: {1,-3}  ║ Level: {2,-5}          Armor: {3,-3}  ║ Weapon:                      ║\n", Program.player.Level,Program.player.Armor,Program.monster.Level, Program.monster.Armor) +
                          String.Format("║ Damage: {0,3}-{1,-3}                    ║ Damage: {2,3}-{3,-3}                   ║ Off-Hand:                    ║\n", Program.player.MinDamage,Program.player.MaxDamage, Program.monster.MinDamage, Program.monster.MaxDamage) +
                          String.Format("║ Defense: {0,-5}                     ║ Defense: {1,-5}                    ║ Chest:                       ║ \n", Program.player.Defense, Program.monster.Defense); 
                           menuString+= "║                                    ║                                   ║ Pants:                       ║ \n" +
                                        "║                                    ║                                   ║ Gloves:                      ║\n" +
                                        "║                                    ║                                   ║ Boots:                       ║\n" +
                                        "║                                    ╠═══════════════════════════════════╣ Ring:                        ║\n" +
                                        "║                                    ║ Next Action :                     ║ Ring:                        ║\n" +
                                        "╠════════════════════════════════════╩═══════════════════════════════════╬══════════════════════════════╝\n";
            foreach(string n in Combat.CombatLog)
            {
                menuString += n + "\n";
            }
            menuString += "╚════════════════════════════════════════════════════════════════════════╝";
            Console.WriteLine(menuString);
        }
        public static void InventoryDisplay()
        {
            Console.Clear();
            int index = 0;
            string menuString = "╔══════════════════════════════════════════════╗ \n" +
                                "║                   Inventory                  ║ \n" +
                                "╠══════════════════════════════════════════════╣ \n" +
                                "║ Weapon                                       ║ \n" +
                                "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryWeaponList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Damage:  {2,-2}- {3,-3}   ║ \n", index, item.Name,item.MinDamage,item.MaxDamage);
            }
                  menuString += "╠══════════════════════╩═══════════════════════╣ \n" +
                                "║ Armor                                        ║ \n" +
                                "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryArmorList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Defense: {2,-3}       ║\n", index, item.Name, item.Defense);
            }
                  menuString += "╠══════════════════════╩═══════════════════════╣ \n" +
                                "║ Consumable                                   ║ \n" +
                                "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryConsumList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Health: +{2,-3}       ║\n", index, item.Name, item.Health);
            }
                  menuString += "╚══════════════════════╩═══════════════════════╝";
            Console.WriteLine(menuString);
            Console.ReadKey();
        }

    }
}
