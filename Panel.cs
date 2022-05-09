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
        }
        public static void BlacksmithPanelContext()
        {
            Display.ContextDisplayList.Insert(0, "║    The Blacksmith's Workshop.                               ║");
            Display.ContextDisplayList.RemoveAt(4);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }
        public static void AlchemistPanelContext()
        {
            Display.ContextDisplayList.Insert(0, "║    The Alchemist's Lab.                                     ║");
            Display.ContextDisplayList.RemoveAt(4);
            Display.Gameboard();
            Console.ReadKey();
            Display.InitializeContextDisplay();
        }
    }
}
