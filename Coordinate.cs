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
        public static List<Coordinate> CoordList = new List<Coordinate>();
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        
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
                if (coord.X == Program.position[0] && coord.Y == Program.position[1])
                {
                    Program.InitializeCombat();
                    CoordList.RemoveAt(compteur);
                    break;
                }
                    

            }
        }
    }
}
