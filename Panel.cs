using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Panel
    {
        
        public static void ArmorerPanelContext()
        {
            Display.ContextDisplayList.Insert(0, "║    The Armorer's Shack.                                     ║");
            Display.ContextDisplayList.RemoveAt(4);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the armorer's panel in the Context menu.
        public static void BlacksmithPanelContext()
        {
            Display.ContextDisplayList.Insert(0, "║    The Blacksmith's Workshop.                               ║");
            Display.ContextDisplayList.RemoveAt(4);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the blacksmith's panel in the Context menu.
        public static void AlchemistPanelContext()
        {
            Display.ContextDisplayList.Insert(0, "║    The Alchemist's Lab.                                     ║");
            Display.ContextDisplayList.RemoveAt(4);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the alchemist's panel in the Context menu.
        public static void PlayerHouseContext()
        {
            Display.ContextDisplayList.Insert(0, "║    This is your house.                                      ║");
            Display.ContextDisplayList.RemoveAt(4);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }  //Function to display the armorer's panel in the Context menu.
    }
}
