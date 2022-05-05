using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Input
    {
        public static void TitleMenuInput()
        {
            int input = 0;
            try
            {
            do input = int.Parse(Console.ReadLine());
            while (input != 1 && input != 2 && input != 3);
            } catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
            }
            switch (input)
            {
                case 1:
                    Program.player = Program.PlayerCreation();
                    Display.Gameboard();
                    break;
                case 2:
                    //TODO Load/Save Feature
                    break;
                case 3:

                    break;
            }
        }
        public static void InventoryInput()
        {
            int input = 0;
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input != 1 && input != 2);
            } catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry."); 
            }

        }
        public static void EquipmentInput()
        {

        }
    }
}
