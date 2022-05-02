using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Display
    {
        public static string[][] MainTab = new string[16][];
        public static void InitializeGameboard1()
        {
             MainTab[0] = new string[] { "╔═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══", "═══╗" };
             MainTab[1] = new string[] { "║ M ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
             MainTab[2] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
             MainTab[3] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
             MainTab[4] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", " M ", "   ", "   ", "   ", "   ", "   ", " M ", "   ", "   ║" };
             MainTab[5] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", " @ ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
             MainTab[6] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
             MainTab[7] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "    " };
             MainTab[8] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
             MainTab[9] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
            MainTab[10] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
            MainTab[11] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
            MainTab[12] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
            MainTab[13] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
            MainTab[14] = new string[] { "║   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ║" };
            MainTab[15] = new string[] { "╚═══", "═══", "═══", "═══", "═══", "═══", "═══", "═ ═", "═══", "═══", "═══", "═══", "═══", "═══", "═══╝" };


        }  // Function to initialize the display array
        public static void Gameline(int x)
        {
            foreach (string n in MainTab[x]) 
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }    //Function to draw one line of the gameboard.
        public static void Gameboard()
        {
            for (int i = 0; i < 16; i++)
            Gameline(i);

        }     //Function to draw the gameboard.
        public static void CombatLogDisplay()
        {
            Console.Clear();
                    string menuString = "╔════════════════════════════════════╦═══════════════════════════════════╦══════════════════════════════╗ \n";
            menuString += String.Format("║ Name: {0,-10}       {1,-3}/ {2,-3}HP  ║ Enemy: {3,-10}     {4,-3}/ {5,-3}HP  ║          Equipments          ║\n", Program.player.Name, Program.player.Health, Program.player.MaxHealth, Program.monster.Name, Program.monster.Health, Program.monster.MaxHealth) +
                          String.Format("║ Level: {0,-3}             Armor: {1,-3}  ║ Level: {2,-5}          Armor: {3,-3}  ║ Weapon:                      ║\n", Program.player.Level,Program.player.Armor,Program.monster.Level, Program.monster.Armor) +
                          String.Format("║ Damage: {0,-5}                      ║ Damage: {1,-5}                     ║ Off-Hand:                    ║\n", Program.player.Attack, Program.monster.Attack) +
                          String.Format("║ Defense: {0,-5}                     ║ Defense: {1,-5}                    ║ Chest:                       ║ \n", Program.player.Defense, Program.monster.Attack); 
                           menuString+= "║                                    ║                                   ║ Pants:                       ║ \n" +
                                        "║                                    ║                                   ║ Gloves:                      ║\n" +
                                        "║                                    ║                                   ║ Boots:                       ║\n" +
                                        "║                                    ║                                   ║ Ring:                        ║\n" +
                                        "║                                    ║                                   ║ Ring:                        ║\n" +
                                        "╠════════════════════════════════════╩═══════════════════════════════════╬══════════════════════════════╝\n";
            foreach(string n in Combat.CombatLog)
            {
                menuString += n + "\n";
            }
            menuString += "╚════════════════════════════════════════════════════════════════════════╝";
            Console.WriteLine(menuString);
        }

    }
}
