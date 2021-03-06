using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Interactible
    {
        public static List<Interactible> LeverList = new List<Interactible>();
        private Coordinate _coord;
        private Coordinate _targetCoord;
        private string _message;
        public Coordinate Coord { get { return _coord; } set { _coord = value; } }
        public Coordinate TargetCoord { get { return _targetCoord; } set { _targetCoord = value; } }
        public string Message { get { return _message; } set { _message = value; } }

        public Interactible(Coordinate coord, Coordinate targetCoord)
        {
            _coord = coord;
            _targetCoord = targetCoord;
        }  //Lever constructor
        public Interactible(Coordinate coord, string message)
        {
            _coord = coord;
            _message = message;
        }  //Panel constructor
        public Interactible(Coordinate coord)
        {
            _coord = coord;
        }  //Door constructor
        public static List<Interactible> CreateNewLeverList(List<Coordinate> coordList, List<Coordinate> targetCoordList)
        {
            int x = 0;
            List<Interactible> leverList = new List<Interactible>();
            foreach (Coordinate coord in coordList)
            {
                Interactible lever = new(coord, targetCoordList[x]);
                leverList.Add(lever);
               if (targetCoordList.Count > 1) 
                x++;
            }
            return leverList;
        }  // Function to create a list of Lever associated with it's targeted door.
        public static void LeverInteractionLogic(Coordinate playerCoord, List<Interactible> leverList)
        {
            int y = playerCoord.X;
            int x = playerCoord.Y;

            foreach (Interactible lever in leverList)
            {
                int leverY= lever.Coord.X;
                int leverX = lever.Coord.Y;
                int targetCoordY = lever.TargetCoord.X;
                int targetCoordX = lever.TargetCoord.Y;
                if (Display.MainTab[x + 1][y] == Display.MainTab[leverX][leverY])
                {
                    Display.MainTab[targetCoordX][targetCoordY] = ' ';
                }
                if (Display.MainTab[x - 1][y] == Display.MainTab[leverX][leverY])
                {
                    Display.MainTab[targetCoordX][targetCoordY] = ' ';
                }
                if (Display.MainTab[x][y + 1] == Display.MainTab[leverX][leverY])
                {
                    Display.MainTab[targetCoordX][targetCoordY] = ' ';
                }
                if (Display.MainTab[x][y - 1] == Display.MainTab[leverX][leverY])
                {
                    Display.MainTab[targetCoordX][targetCoordY] = ' ';
                }

            }

        }  //Function for the lever interaction logic.
        public static void LeverInteractionContext()
        {
            string context = "║    You heard a door opening in the distance...              ║";
            Display.ContextDisplayProcess(context);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the armorer's panel in the Context menu.
        public static void ArmorerPanelContext()
        {
            string context = "║    The Armorer's Shack.                                     ║";
            Display.ContextDisplayProcess(context);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the armorer's panel in the Context menu.
        public static void BlacksmithPanelContext()
        {
            string context = "║    The Blacksmith's Workshop.                               ║";
            Display.ContextDisplayProcess(context);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the blacksmith's panel in the Context menu.
        public static void AlchemistPanelContext()
        {
            string context = "║    The Alchemist's Lab.                                     ║";
            Display.ContextDisplayProcess(context);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the alchemist's panel in the Context menu.
        public static void PlayerHouseContext()
        {
            string context = "║    This is your house.                                      ║";
            Display.ContextDisplayProcess(context);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the armorer's panel in the Context menu.
    }
}
