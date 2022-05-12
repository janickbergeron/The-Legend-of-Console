using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static List<Coordinate> MonsterCoordList = new List<Coordinate>();
        public static List<Coordinate> TreasureCoordList = new List<Coordinate>();
        public static List<Coordinate> LeverCoordList = new List<Coordinate>();
        public static List<Coordinate> PanelCoordList = new List<Coordinate>();
        public static List<Coordinate> MerchantCoordList = new List<Coordinate>();
        public static List<Coordinate> DoorCoordList = new List<Coordinate>();
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        } //Coordinate Constructor.
        public static Coordinate PlayerPosition()
        {
            Coordinate PlayerCoord = new(0, 0);
            int[] position = new int[2];
            bool PositionFound = false;
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
                            PlayerCoord = new(position[0], position[1]);
                            PositionFound = true;
                            break;
                        }
                    }
                    if (PositionFound) { break; }
                }
            }
            return PlayerCoord;
        } //Returns a Coordinate object with player's current coordinates
        public static List<Coordinate> TreasurePosition()
        {
            int[] position = new int[2];
            List<Coordinate> CoordList = new List<Coordinate>();

            for (int i = 0; i < 16; i++)
            {
                int compteur = 0;
                foreach (char n in Display.MainTab[i])
                {
                    if (n != 'T')
                        compteur++;
                    else
                    {
                        position[0] = compteur;
                        position[1] = i;
                        compteur++;
                        Coordinate Coord = new(position[0], position[1]);
                        CoordList.Add(Coord);
                    }
                }
            }
            return CoordList;
        } //Function that returns a list of coordinate for all Treasures on the gameboard.
        public static List<Coordinate> DoorPosition()
        {
            int[] position = new int[2];
            List<Coordinate> CoordList = new List<Coordinate>();

            for (int i = 0; i < 16; i++)
            {
                int compteur = 0;
                foreach (char n in Display.MainTab[i])
                {
                    if (n != 'D')
                        compteur++;
                    else
                    {
                        position[0] = compteur;
                        position[1] = i;
                        compteur++;
                        Coordinate Coord = new(position[0], position[1]);
                        CoordList.Add(Coord);
                    }
                }
            }
            return CoordList;
        } //Function that returns a list of coordinate for all Treasures on the gameboard.
        public static List<Coordinate> LeverPosition()
        {
            int[] position = new int[2];
            List<Coordinate> CoordList = new List<Coordinate>();

            for (int i = 0; i < 16; i++)
            {
                int compteur = 0;
                foreach (char n in Display.MainTab[i])
                {
                    if (n != 'L')
                        compteur++;
                    else
                    {
                        position[0] = compteur;
                        position[1] = i;
                        compteur++;
                        Coordinate Coord = new(position[0], position[1]);
                        CoordList.Add(Coord);
                    }
                }
            }
            return CoordList;
        } //Function that returns a list of coordinate for all Levers on the gameboard.
        public static List<Coordinate> MerchantPosition()
        {
            int[] position = new int[2];
            List<Coordinate> CoordList = new List<Coordinate>();

            for (int i = 0; i < 16; i++)
            {
                int compteur = 0;
                foreach (char n in Display.MainTab[i])
                {
                    if (n != '▓')
                        compteur++;
                    else
                    {
                        position[0] = compteur;
                        position[1] = i;
                        compteur++;
                        Coordinate Coord = new(position[0], position[1]);
                        CoordList.Add(Coord);
                    }
                }
            }
            return CoordList;
        } //Function that returns a list of coordinate for all Levers on the gameboard.
        public static List<Coordinate> PanelPosition()
        {
            int[] position = new int[2];
            List<Coordinate> CoordList = new List<Coordinate>();

            for (int i = 0; i < 16; i++)
            {
                int compteur = 0;
                foreach (char n in Display.MainTab[i])
                {
                    if (n != 'P')
                        compteur++;
                    else
                    {
                        position[0] = compteur;
                        position[1] = i;
                        compteur++;
                        Coordinate Coord = new(position[0], position[1]);
                        CoordList.Add(Coord);
                    }
                }
            }
            return CoordList;
        } //Function that returns a list of coordinate for all Levers on the gameboard.
        public static void CoordListDisplay(List<Coordinate> ListCoord)
        {
            foreach (Coordinate coord in ListCoord)
            {
                Console.WriteLine($"There is a monster at position ({coord.X},{coord.Y})");
            }
        }  //Test function to see all the monster's coordinate.
        public static void CombatInitiator(List<Coordinate> ListCoord)
        {
            int compteur = 0;
            foreach (Coordinate coord in ListCoord)
            {
                if (coord.X == Program.playerCoord.X && coord.Y == Program.playerCoord.Y)
                {
                    Program.InitializeCombat();
                    MonsterCoordList.RemoveAt(compteur);
                    break;
                }
                compteur++;
            }
        } //Function that verify if a combat encounter should be started.
        public static void TreasureInitiator(List<Coordinate> ListCoord)
        {
            int compteur = -1;
            foreach (Coordinate coord in ListCoord)
            {
                compteur++;
                if (coord.X == Program.playerCoord.X && coord.Y == Program.playerCoord.Y)
                {
                    Animation.ChestAnimationIdle();
                    Treasure.TreasureGenerator();
                    Display.Gameboard();
                    TreasureCoordList.RemoveAt(compteur);
                    break;
                }


            }
        } //Function that verify if a treasure encounter should be started.
        public static void PlayerEnterShop(Coordinate playerPosition)
        {
            if (playerPosition.X == 10 && playerPosition.Y == 8)
            {
                Display.ArmorerDisplay();
                Merchant.ArmorerLogic(Input.MerchantInput());
            }
            if (playerPosition.X == 44 && playerPosition.Y == 7)
            {
                Display.BlacksmithDisplay();
                Merchant.BlacksmithLogic(Input.MerchantInput());
            }
            if (playerPosition.X == 24 && playerPosition.Y == 14)
            {
                Display.AlchemistDisplay();
                Merchant.AlchemistLogic(Input.MerchantInput());
            }
            if (playerPosition.X == 51 && playerPosition.Y == 14)
            {
                Display.PlayerHouseDisplay();
                Player.PlayerHouseLogic(Input.HouseInput());
            }
        }        //Function to know if the player is trying to enter a shop.
        public static void ShopPanelInteraction(Coordinate playerPosition)
        {
            if (playerPosition.X == 14 && playerPosition.Y == 7)
            {
                Panel.ArmorerPanelContext();
            }
            if (playerPosition.X == 13 && playerPosition.Y == 6)
            {
                Panel.ArmorerPanelContext();
            }
            if (playerPosition.X == 13 && playerPosition.Y == 8)
            {
                Panel.ArmorerPanelContext();
            }

            if (playerPosition.X == 40 && playerPosition.Y == 6)
            {
                Panel.BlacksmithPanelContext();
            }
            if (playerPosition.X == 41 && playerPosition.Y == 5)
            {
                Panel.BlacksmithPanelContext();
            }
            if (playerPosition.X == 41 && playerPosition.Y == 7)
            {
                Panel.BlacksmithPanelContext();
            }

            if (playerPosition.X == 26 && playerPosition.Y == 14)
            {
                Panel.AlchemistPanelContext();
            }
            if (playerPosition.X == 27 && playerPosition.Y == 13)
            {
                Panel.AlchemistPanelContext();
            }
            if (playerPosition.X == 28 && playerPosition.Y == 14)
            {
                Panel.AlchemistPanelContext();
            }

            if (playerPosition.X == 47 && playerPosition.Y == 13)
            {
                Panel.PlayerHouseContext();
            }
            if (playerPosition.X == 48 && playerPosition.Y == 12)
            {
                Panel.PlayerHouseContext();
            }
            if (playerPosition.X == 48 && playerPosition.Y == 14)
            {
                Panel.PlayerHouseContext();
            }
        }    //Function to know which shop panel the user is trying to interact with.
        public static char FindInteractible(Coordinate playerPosition)
        {
            if (Display.MainTab[playerPosition.Y+1][playerPosition.X] == 'P' || Display.MainTab[playerPosition.Y + 1][playerPosition.X] == '▓' || Display.MainTab[playerPosition.Y + 1][playerPosition.X] == '▒' || Display.MainTab[playerPosition.Y + 1][playerPosition.X] == 'L')  //Look for interactible Cell to the right of the player.
            {
                return Display.MainTab[playerPosition.Y + 1][playerPosition.X];
            }

            if (Display.MainTab[playerPosition.Y - 1][playerPosition.X] == 'P' || Display.MainTab[playerPosition.Y - 1][playerPosition.X] == '▓' || Display.MainTab[playerPosition.Y - 1][playerPosition.X] == '▒' || Display.MainTab[playerPosition.Y - 1][playerPosition.X] == 'L') //Look interactible Cell to the left of the player.
            {
                return Display.MainTab[playerPosition.Y - 1][playerPosition.X];
            }

            if (Display.MainTab[playerPosition.Y][playerPosition.X - 1] == 'P' || Display.MainTab[playerPosition.Y][playerPosition.X - 1] == '▓' || Display.MainTab[playerPosition.Y ][playerPosition.X - 1] == '▒' || Display.MainTab[playerPosition.Y][playerPosition.X - 1] == 'L') //Look interactible Cell above the player.
            {
                return Display.MainTab[playerPosition.Y][playerPosition.X - 1];
            }

            if (Display.MainTab[playerPosition.Y][playerPosition.X + 1] == 'P' || Display.MainTab[playerPosition.Y][playerPosition.X + 1] == '▓' || Display.MainTab[playerPosition.Y][playerPosition.X + 1] == '▒' || Display.MainTab[playerPosition.Y][playerPosition.X + 1] == 'L') //Look interactible Cell under the player.
            {
                return Display.MainTab[playerPosition.Y][playerPosition.X + 1];
            }
            return ' ';
        }    //Function that verify if any interactible cell is around the player's position.
    }
}
