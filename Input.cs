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
                    break;
                case 2:
                    Program.player = GameSave.LoadPlayerData();
                    Inventory.InventoryLogicAfterLoad(GameSave.LoadSavedData("Inventory"));
                    Inventory.StorageLogicAfterLoad(GameSave.LoadSavedData("House"));
                    Inventory.EquipItemAfterLoad(GameSave.LoadSavedData("Equipment"));
                    break;
                case 3:

                    break;
            }
        } //User input in Title Menu
        public static void PauseMenuInput()
        {
            int input = 0;
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input != 1 && input != 2 && input != 3 && input != 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
            }
            switch (input)
            {
                case 1:
                    Inventory.RemoveItemStatsBeforeSave(Inventory.GetEquippedItems());
                    GameSave.SavePlayerData();
                    GameSave.SaveEquipmentData();
                    GameSave.SaveInventoryData();
                    GameSave.SaveHouseData();
                    Display.SaveGameContext();
                    break;
                case 2:
                    //option 2        
                    break;
                case 3:
                    
                    break;
                case 4:
                    Program.InProgress = false;
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
        public static int StorageDepositInput()
        {
            Inventory.RefreshInventoryList();
            Console.WriteLine("Choose an item to deposit:");
            bool isFormatOK = false;
            int input = 0;
            int total = Inventory.GetStorageTotal();
            while (!isFormatOK)
            {
                try
                {
                    do input = int.Parse(Console.ReadLine());
                    while (input < 0 && input > total);
                    isFormatOK = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect Entry.");
                }
                Inventory.RemoveItemFromInventory(input - 1);
            }
            return input - 1;
        } //User input to select which item to equip.
        public static int StorageWithdrawInput()
        {
            Inventory.RefreshInventoryList();
            Console.WriteLine("Choose an item to withdraw:");
            bool isFormatOK = false;
            int input = 0;
            int total = Inventory.GetStorageTotal();
            while (!isFormatOK)
            {
                try
                {
                    do input = int.Parse(Console.ReadLine());
                    while (input < 0 && input > total);
                    isFormatOK = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect Entry.");
                }
                Inventory.RemoveItemFromStorage(input - 1);
            }
                return input - 1;
            
        } //User input to select which item to equip.
        public static bool YesNoInput()
        {
            bool isFormatOK = false;
            string input = null;
            while (!isFormatOK)
            {
                try
                {
                    do input = Console.ReadLine();
                    while (input != "Y" && input != "M" && input != "y" && input != "m");
                    isFormatOK = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect Entry.");
                    Console.ReadKey();
                }
            }
            switch (input)
            {
                case "Y":
                case "y":
                    return true;
                    break;
                case "N":
                case "n":
                    return false;
                    break;
            }
            return false;
        } //Standard Yes/No Function
        public static int MerchantBuyInput(List<Item> merchantList)
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
            return input - 1;
        } //User input to select which item to buy.
        public static int MerchantSellInput(List<Item> playerList)
        {

            Console.WriteLine("Choose an item to sell:");
            int input = 0;
            int total = playerList.Count();
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input < 0 && input > total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
            }
            return input - 1;
        } //User input to select which item to sell.
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
        public static void StorageInput()
        {
            int input = 0;
            int item = 0;
            Inventory.RefreshInventoryList();
            Console.WriteLine("1: Deposit an item. 2: Withdraw an item. 3: Return.");
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
                    if (Inventory.InventoryList.Count > 0)
                    {
                        item = StorageDepositInput();
                        Inventory.AddItemToStorage(Inventory.InventoryList[item]);
                    }
                    else
                    {
                        Console.WriteLine("You don't have anything to deposit.");
                        Console.ReadKey();
                    }
                    Display.StorageDisplay();
                    Input.StorageInput();

                    break;
                case 2:
                    Display.StorageDisplay();
                    if (Inventory.HouseStorageList.Count > 0)
                    {
                        item = StorageWithdrawInput();
                        Inventory.AddItemToInventory(Inventory.HouseStorageList[item]);
                        Inventory.RemoveItemFromStorage(item);
                    }
                    else
                    {
                        Console.WriteLine("There isn't anything to withdraw.");
                        Console.ReadKey();
                    }
                    Display.StorageDisplay();
                    Input.StorageInput();
                    break;
                case 3:

                    break;
            }
        }   //User input in inventory menu
        public static int MerchantInput()
        {
            int input = 0;
            bool isFormatOK = false;

            Console.WriteLine("1: Buy an item. 2: Sell an item. 3: Craft an item. 4: Return.");
            while (!isFormatOK)
            {
                try
                {
                    do input = int.Parse(Console.ReadLine());
                    while (input != 1 && input != 2 && input != 3 && input != 4);
                    isFormatOK = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect Entry.");
                    Console.ReadKey();
                }
            }
            return input;
        }   //Merchant input in Merchant menu
        public static int HouseInput()
        {
            int input = 0;
            Inventory.RefreshInventoryList();

            List<Item> BlacksmithList = Merchant.BlacksmithList;
            List<Item> AlchemistList = Merchant.AlchemistList;

            Console.WriteLine("1: Rest for a moment. 2: Access storage. 3: Return.");
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input != 1 && input != 2 && input != 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
                Console.ReadKey();
            }
            return input;
        }   //Merchant input in Merchant menu
        public static int CraftingInput(List<Recipe> recipeList)
        {
            bool isFormatOK = false;
            int input = 0;
            int total = recipeList.Count();
            Console.WriteLine("Choose an item to craft:");
            try
            {
                do input = int.Parse(Console.ReadLine());
                while (input < 0 && input > total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect Entry.");
            }
            return input - 1;
        } //User input to select which item to equip.
    }
}
