using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Player : Entity
    {

        public Player(string name, int level, int maxHealth, int attack, int defence,int armor): base(name,level,maxHealth,attack,defence,armor)
        {

        }
        public static void PlayerMouvement(int x, int y)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.UpArrow && key.Key != ConsoleKey.DownArrow && key.Key != ConsoleKey.LeftArrow && key.Key != ConsoleKey.RightArrow &&
                   key.Key != ConsoleKey.W && key.Key != ConsoleKey.A && key.Key != ConsoleKey.S && key.Key != ConsoleKey.D) 
            {
                key = Console.ReadKey();
            }

            if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
            {  
                if (Display.MainTab[x+1][y] != '╦' && Display.MainTab[x + 1][y] != '╩' && Display.MainTab[x + 1][y] != '╣' && Display.MainTab[x + 1][y] != '║' && Display.MainTab[x + 1][y] != '╬' && Display.MainTab[x + 1][y] != '╠' && Display.MainTab[x + 1][y] != '═' && Display.MainTab[x + 1][y] != '╔' && Display.MainTab[x + 1][y] != '╗' && Display.MainTab[x + 1][y] != '╚' && Display.MainTab[x + 1][y] != '╝')
                {
                    if (x < 14)
                    {
                    Display.MainTab[x + 1][y] = '@';
                    Display.MainTab[x][y] = ' ';
                    }
                }
            }
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
            {
                if (Display.MainTab[x - 1][y] != '╦' && Display.MainTab[x - 1][y] != '╩' && Display.MainTab[x - 1][y] != '╣' && Display.MainTab[x - 1][y] != '║' && Display.MainTab[x - 1][y] != '╬' && Display.MainTab[x - 1][y] != '╠' && Display.MainTab[x - 1][y] != '═' && Display.MainTab[x - 1][y] != '╔' && Display.MainTab[x - 1][y] != '╗' && Display.MainTab[x - 1][y] != '╚' && Display.MainTab[x - 1][y] != '╝')
                {
                    if (x > 1)
                    {
                        Display.MainTab[x - 1][y] = '@';
                        Display.MainTab[x][y] = ' ';
                    }
                }
            }
            if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
            {
                if (Display.MainTab[x][y+1] != '╦' && Display.MainTab[x][y + 1] != '╩' && Display.MainTab[x][y + 1] != '╣' && Display.MainTab[x][y + 1] != '║' && Display.MainTab[x][y + 1] != '╬' && Display.MainTab[x][y + 1] != '╠' && Display.MainTab[x][y + 1] != '═' && Display.MainTab[x][y + 1] != '╔' && Display.MainTab[x][y + 1] != '╗' && Display.MainTab[x][y + 1] != '╚' && Display.MainTab[x][y+1] != '╝')
                {
                    if (y < 50)
                    {
                        Display.MainTab[x][y + 1] = '@';
                        Display.MainTab[x][y] = ' ';
                    }
                }
                
            }
            if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
            {

                if (Display.MainTab[x][y - 1] != '╦' && Display.MainTab[x][y - 1] != '╩' && Display.MainTab[x][y - 1] != '╣' && Display.MainTab[x][y - 1] != '║' && Display.MainTab[x][y - 1] != '╬' && Display.MainTab[x][y - 1] != '╠' && Display.MainTab[x][y - 1] != '═' && Display.MainTab[x][y - 1] != '╔' && Display.MainTab[x][y - 1] != '╗' && Display.MainTab[x][y - 1] != '╚' && Display.MainTab[x][y - 1] != '╝')
                {
                    if (y > 1 && y < 51)
                    {
                        Display.MainTab[x][y - 1] = '@';
                        Display.MainTab[x][y] = ' ';
                    }
                }
            }
        }

        public static int[] PlayerPosition()
        {
            bool PositionFound = false;
            int[] position = new int[2];
           while (!PositionFound)
           {
                for (int i = 0; i < 16; i++)
                {
                    int compteur = 0;
                    foreach (char n in Display.MainTab[i])
                    {
                        if (n != '@')
                            compteur++;
                        else
                        {
                            position[0] = compteur;
                            position[1] = i;
                            PositionFound = true;
                            break;
                        }
                    }
                    if (PositionFound) { break; }
                }
           }
           return position;
        } //Returns a int array with player's current coordinates

       

        public override int CombatAttack(int damage)
        {
            Armor = 0;
            int FinalDamage = damage - this.Enemy.Armor;
            this.Enemy.Health -= FinalDamage;
            return FinalDamage;
        }
        public override int Defend()
        {
            Armor = 0;
            Armor += Defense;
            return Armor;
        }
        public int ChooseAction()
        {
            bool isFormatOK = false;
            int choice = 0;
            while (!isFormatOK)
            {
                Console.WriteLine("1 : Attack, 2 : Defend");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1 || choice == 2)
                    {
                        isFormatOK = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect choice.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect choice.");
                }
            }
            return choice;
        }
        public void ExecuteAction(int action)
        {
            switch (action)
            {
                case 1:
                    Combat.CombatLogProcess();
                    int damage = CombatAttack(Attack);
                    Combat.CombatLog.Add(String.Format("║ You inflict {0,-2} Damage.                                             {1,5}", damage, "║"));
                    break;
                case 2:
                    Combat.CombatLogProcess();
                    int defend = Defend();
                    Combat.CombatLog.Add(String.Format("║ You prepare to prevent the next {0,-2} Damage.                         {1,5}",defend, "║"));
                    break;
            }
        }
    }
}
