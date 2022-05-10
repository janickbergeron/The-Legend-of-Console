﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Player : Entity
    {
        public Inventory PlayerInventory = new Inventory();
        public static bool isPlayerInTown;
        private int _gold;
        private int _experience;
        public int Gold { get { return _gold; } set { _gold = value; } } 
        public int Experience { get { return _experience; } set { _experience = value;} }
        
        public Player(string name, int level, int maxHealth, int minDamage,int maxDamage, int defense,int armor): base(name,level,maxHealth,minDamage,maxDamage,defense,armor)
        {

        }
        public static void PlayerMouvement(Coordinate playerCoord)
        {
            int y=0;
            int x=0;
            y = playerCoord.X;
            x = playerCoord.Y;

            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.UpArrow && key.Key != ConsoleKey.DownArrow && key.Key != ConsoleKey.LeftArrow && key.Key != ConsoleKey.RightArrow &&
                   key.Key != ConsoleKey.W && key.Key != ConsoleKey.A && key.Key != ConsoleKey.S && key.Key != ConsoleKey.D && key.Key != ConsoleKey.Spacebar && key.Key != ConsoleKey.I && key.Key != ConsoleKey.C) 
            {
                key = Console.ReadKey();
            }

            if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
            {  
                if (Display.MainTab[x+1][y] != '╦' && Display.MainTab[x + 1][y] != '╩' && Display.MainTab[x + 1][y] != '╣' && Display.MainTab[x + 1][y] != '║' && Display.MainTab[x + 1][y] != '╬' && Display.MainTab[x + 1][y] != '╠' && Display.MainTab[x + 1][y] != '═' && Display.MainTab[x + 1][y] != '╔' && Display.MainTab[x + 1][y] != '╗' && Display.MainTab[x + 1][y] != '╚' && Display.MainTab[x + 1][y] != '╝' && Display.MainTab[x + 1][y] != '/' && Display.MainTab[x + 1][y] != '\\' && Display.MainTab[x + 1][y] != '|' && Display.MainTab[x + 1][y] != 'x' && Display.MainTab[x + 1][y] != '_' && Display.MainTab[x + 1][y] != '▓' && Display.MainTab[x + 1][y] != '▒' && Display.MainTab[x + 1][y] != 'L' && Display.MainTab[x + 1][y] != 'D' && Display.MainTab[x + 1][y] != 'P')
                {
                    Display.MainTab[x + 1][y] = '@';
                    Display.MainTab[x][y] = ' ';
                }
            }
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
            {
                if (Display.MainTab[x - 1][y] != '╦' && Display.MainTab[x - 1][y] != '╩' && Display.MainTab[x - 1][y] != '╣' && Display.MainTab[x - 1][y] != '║' && Display.MainTab[x - 1][y] != '╬' && Display.MainTab[x - 1][y] != '╠' && Display.MainTab[x - 1][y] != '═' && Display.MainTab[x - 1][y] != '╔' && Display.MainTab[x - 1][y] != '╗' && Display.MainTab[x - 1][y] != '╚' && Display.MainTab[x - 1][y] != '╝' && Display.MainTab[x - 1][y] != '/' && Display.MainTab[x - 1][y] != '\\' && Display.MainTab[x - 1][y] != '|' && Display.MainTab[x - 1][y] != 'x' && Display.MainTab[x - 1][y] != '_' && Display.MainTab[x - 1][y] != '▓' && Display.MainTab[x - 1][y] != '▒' && Display.MainTab[x - 1][y] != 'L' && Display.MainTab[x - 1][y] != 'D' && Display.MainTab[x - 1][y] != 'P')
                {
                        Display.MainTab[x - 1][y] = '@';
                        Display.MainTab[x][y] = ' ';
                }
            }
            if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
            {
                if (Display.MainTab[x][y+1] != '╦' && Display.MainTab[x][y + 1] != '╩' && Display.MainTab[x][y + 1] != '╣' && Display.MainTab[x][y + 1] != '║' && Display.MainTab[x][y + 1] != '╬' && Display.MainTab[x][y + 1] != '╠' && Display.MainTab[x][y + 1] != '═' && Display.MainTab[x][y + 1] != '╔' && Display.MainTab[x][y + 1] != '╗' && Display.MainTab[x][y + 1] != '╚' && Display.MainTab[x][y+1] != '╝' && Display.MainTab[x][y+1] != '/' && Display.MainTab[x][y+1] != '\\' && Display.MainTab[x][y + 1] != '|' && Display.MainTab[x][y + 1] != 'x' && Display.MainTab[x][y + 1] != '_' && Display.MainTab[x][y + 1] != '▓' && Display.MainTab[x][y + 1] != '▒' && Display.MainTab[x][y + 1] != 'L' && Display.MainTab[x][y+1] != 'D' && Display.MainTab[x][y+1] != 'P')
                {
                        Display.MainTab[x][y + 1] = '@';
                        Display.MainTab[x][y] = ' ';
                }
                
            }
            if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
            {

                if (Display.MainTab[x][y - 1] != '╦' && Display.MainTab[x][y - 1] != '╩' && Display.MainTab[x][y - 1] != '╣' && Display.MainTab[x][y - 1] != '║' && Display.MainTab[x][y - 1] != '╬' && Display.MainTab[x][y - 1] != '╠' && Display.MainTab[x][y - 1] != '═' && Display.MainTab[x][y - 1] != '╔' && Display.MainTab[x][y - 1] != '╗' && Display.MainTab[x][y - 1] != '╚' && Display.MainTab[x][y - 1] != '╝' && Display.MainTab[x][y - 1] != '/' && Display.MainTab[x][y - 1] != '\\' && Display.MainTab[x][y - 1] != '|' && Display.MainTab[x][y - 1] != 'x' && Display.MainTab[x][y - 1] != '_' && Display.MainTab[x][y - 1] != '▓' && Display.MainTab[x][y - 1] != '▒' && Display.MainTab[x][y - 1] != 'L' && Display.MainTab[x][y - 1] != 'D' && Display.MainTab[x][y-1] != 'P')
                {
                        Display.MainTab[x][y - 1] = '@';
                        Display.MainTab[x][y] = ' ';
                }
            }
            if (key.Key == ConsoleKey.I)
            {
                Display.ShowInventory();
            }
            if (key.Key == ConsoleKey.Spacebar)
            {
                PlayerInteractionLogic(Coordinate.FindInteractible(playerCoord), playerCoord);
            }
            if (key.Key == ConsoleKey.C)
            {
                Display.EquipmentDisplay();
            }
        }  //Function for the player's mouvement.
        public static void PlayerInteractionLogic(char interactible, Coordinate playerPosition)
        {
            
            if (interactible == 'L')
            {
                //TODO lever interaction
                Interactible.LeverInteractionContext();
                Interactible.LeverInteractionLogic(playerPosition, Interactible.LeverList);
            }
            if (interactible == 'P')
            {
                Coordinate.ShopPanelInteraction(playerPosition);
            }
            if (interactible == '▓')  //shop's door
            {
                Coordinate.PlayerEnterShop(playerPosition);
            }
            if (interactible == '▒')  //portal door  
            {
                if (isPlayerInTown)
                {
                    Display.RandomBoardLoading();
                    Coordinate.MonsterCoordList = Monster.MonsterPosition();
                    Coordinate.TreasureCoordList = Coordinate.TreasurePosition();
                    Coordinate.LeverCoordList = Coordinate.LeverPosition();
                    Coordinate.DoorCoordList = Coordinate.DoorPosition();
                    Interactible.LeverList = Interactible.CreateNewLeverList(Coordinate.LeverCoordList, Coordinate.DoorCoordList);
                }
                else
                {
                    Display.BoardLoading(0);
                }
                

            }
        }  //Function the the player interaction logic.
        public override int CombatAttack(int minDamage, int maxDamage)
        {
            Random random = new Random();
            int damage = random.Next(minDamage,maxDamage);
            int FinalDamage = damage - this.Enemy.Armor;
            this.Enemy.Health -= FinalDamage;
            return damage;
        }  //Player's combat attack function.
        public override int Defend()
        {
            Armor = 0;
            Armor += Defense;
            return Armor;
        }  //Player's combat defense function.
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
        } //Player's combat action choice.
        public void ExecuteAction(int action)
        {
            switch (action)
            {
                case 1:
                    Combat.CombatLogProcess();
                    int damage = CombatAttack(MinDamage,MaxDamage);
                    Combat.CombatLog.Add(String.Format("║ You inflict {0,-2} Damage.                                             {1,5}", damage, "║"));
                    break;
                case 2:
                    Combat.CombatLogProcess();
                    int defend = Defend();
                    Combat.CombatLog.Add(String.Format("║ You prepare to prevent the next {0,-2} Damage.                         {1,5}",defend, "║"));
                    break;
            }
        }  //Execute player's combat action choice.
    }
}
