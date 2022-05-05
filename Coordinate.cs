﻿using System;
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
        } //Returns a int array with player's current coordinates
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
        public static void CoordListDisplay(List<Coordinate> ListCoord)
        {
            foreach (Coordinate coord in ListCoord)
            {
                Console.WriteLine($"There is a monster at position ({coord.X},{coord.Y})");
            }
        }
        public static void CombatInitiator(List<Coordinate> ListCoord)
        {
            int compteur = -1;
            foreach (Coordinate coord in ListCoord)
            {
                compteur++;
                if (coord.X == Program.playerCoord.X && coord.Y == Program.playerCoord.Y)
                {
                    Program.InitializeCombat();
                    MonsterCoordList.RemoveAt(compteur);
                    break;
                }
                    

            }
        }
        public static void TreasureInitiator(List<Coordinate> ListCoord)
        {
            int compteur = -1;
            foreach (Coordinate coord in ListCoord)
            {
                compteur++;
                if (coord.X == Program.playerCoord.X && coord.Y == Program.playerCoord.Y)
                {
                    Animation.ChestAnimationIdle();
                    TreasureCoordList.RemoveAt(compteur);
                    break;
                }


            }
        }
    }
}
