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
        }  // Function to initialize the display array  62 Coll 16 row
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
        }  // Function to initialize the display array  62 Coll 16 row
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
        } //Function for display optimisation
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
        public static void TitleScreen()
        {
            Console.WriteLine(@" .____                                    .___         _____  _________                            .__");
            Console.WriteLine(@" |    |    ____   ____   ____   ____    __| _/   _____/ ____\ \_   ___ \  ____   ____   __________ |  |  ____ ");
            Console.WriteLine(@" |    |  _/ __ \ / ___\_/ __ \ /    \  / __ |   /  _ \   __\  /    \  \/ /  _ \ /    \ /  ___/  _ \|  | _/ __ \");
            Console.WriteLine(@" |    |__\  ___// /_/  >  ___/|   |  \/ /_/ |  (  <_> )  |    \     \___(  <_> )   |  \\___ (  <_> )  |_\  ___/");
            Console.WriteLine(@" |_______ \___  >___  / \___  >___|  /\____ |   \____/|__|     \______  /\____/|___|  /____  >____/|____/\___  >");
            Console.WriteLine(@"         \/   \/_____/      \/     \/      \/                         \/            \/     \/                \/ ");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        } //Function to display the Title Screen.
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
        } //Function to draw the Context Display.
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
                          String.Format("║ Level: {0,-3}             Armor: {1,-3}  ║ Level: {2,-5}          Armor: {3,-3}  ║ Weapon: {4,-17}    ║\n", Program.player.Level, Program.player.Armor, Program.monster.Level, Program.monster.Armor, Inventory.EquippedWeapon[0].Name) +
                          String.Format("║ Damage: {0,3}-{1,-3}                    ║ Damage: {2,3}-{3,-3}                   ║ Off-Hand: {4,-17}  ║\n", Program.player.MinDamage, Program.player.MaxDamage, Program.monster.MinDamage, Program.monster.MaxDamage, Inventory.EquippedOffHand[0].Name) +
                          String.Format("║ Defense: {0,-5}                     ║ Defense: {1,-5}                    ║ Chest: {2,-17}     ║ \n", Program.player.Defense, Program.monster.Defense, Inventory.EquippedChest[0].Name); 
             menuString+= String.Format("║                                    ║                                   ║ Pants: {0,-17}     ║ \n", Inventory.EquippedPants[0].Name) +
                          String.Format("║                                    ║                                   ║ Gloves: {0,-17}    ║\n", Inventory.EquippedGloves[0].Name) +
                          String.Format("║                                    ║                                   ║ Boots: {0, -17}     ║\n",Inventory.EquippedBoots[0].Name) +
                          String.Format("║                                    ╠═══════════════════════════════════╣ Ring: {0,-17}      ║\n", Inventory.EquippedRing[0].Name) +
                          String.Format("║                                    ║ Next Action :                     ║ Ring: {0,-17}      ║\n", Inventory.EquippedRing[1].Name) +
                                        "╠════════════════════════════════════╩═══════════════════════════════════╬══════════════════════════════╝\n";
            foreach(string n in Combat.CombatLog)
            {
                menuString += n + "\n";
            }
            menuString += "╚════════════════════════════════════════════════════════════════════════╝";
            Console.WriteLine(menuString);
        }
        public static void ShowInventory()
        {
            InventoryDisplay();
            Input.InventoryInput();
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
            
        }
        public static void TitleMenuDisplay()
        {
            Console.Clear();
            string menuString = "╔═════════════════════╗\n" +
                                "║      Main Menu      ║\n" +
                                "╠═════════════════════╣\n" +
                                "║                     ║\n" +
                                "║   1 - New Game      ║\n" +
                                "║   2 - Load Game     ║\n" +
                                "║   3 - Quit          ║\n" +
                                "║                     ║\n" +
                                "╚═════════════════════╝";
            Console.WriteLine(menuString);
            Input.TitleMenuInput();
        }
    }
}
