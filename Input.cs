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
        } //User input in Title Menu
        public static int EquipmentInput()
        {
            Inventory.RefreshInventoryList();
            Console.WriteLine("Choose an item to equip:");
            int input = 0;
            int total = Inventory.GetInventoryTotal();
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input < 0 && input > total);
            } catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry."); 
            }
            Inventory.RemoveItemFromInventory(input - 1);
            return input-1;
        } //User input to select which item to equip.
        public static int MerchantInput(List<Item> merchantList)
        {
            
            Console.WriteLine("Choose an item to buy:");
            int input = 0;
            int total = merchantList.Count();
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input < 0 && input > total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
            }
            Inventory.RemoveItemFromInventory(input - 1);
            return input - 1;
        } //User input to select which item to buy.
        public static void InventoryInput()
        {
            int input = 0;
            Console.WriteLine("1: Equip an item. 2: Use consumable. 3: Return.");
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input != 1 && input != 2 && input != 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
            }
            switch (input)
            {
                case 1:
                    Display.InventoryDisplay();
                    Inventory.AddItemToInventory(Inventory.EquipItemToSlot(Inventory.InventoryList[EquipmentInput()]));
                    Display.ShowInventory();
                    break;
                case 2:
                    //TODO Consumable feature
                    break;
                case 3:

                    break;
            }
        }   //User input in inventory menu
    }
}
