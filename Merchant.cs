using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Merchant
    {
        public static List<Item> ArmorerList = new List<Item>();
        public static List<Item> BlacksmithList = new List<Item>();
        public static List<Item> AlchemistList = new List<Item>();

        public static void BuyItemFromMerchant(int input, List<Item> MerchantList)
        {
            bool isFormatOK = false;
            while (!isFormatOK)
            {
                try
                {
                    if (Program.player.Gold >= MerchantList[input].GoldValue)
                    {
                        Inventory.AddItemToInventory(MerchantList[input]);
                        Program.player.Gold = Program.player.Gold - MerchantList[input].GoldValue;
                        Console.WriteLine($"You have bought a {MerchantList[input].Name} for {MerchantList[input].GoldValue} gold.");
                        isFormatOK = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Not enough gold.");
                        isFormatOK = true;
                        Console.ReadKey();
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Incorrect Entry.");
                }
            }
        } //Function to buy items from merchant.
        public static void SellItemToMerchant(int input, List<Item> PlayerList)
        {
            bool UserConfirmed;
            int itemValue = PlayerList[input].GoldValue / 4;
            Display.InventorySellDisplay();
            Console.WriteLine($"The {PlayerList[input].Name} you want to sell is worth {itemValue} gold.");
            Console.WriteLine("Confirm sale? (Y/N)");
            UserConfirmed = Input.YesNoInput();
            switch (UserConfirmed)
            {
                case true:
                    Program.player.Gold += itemValue;
                    Inventory.RemoveItemFromInventory(input);
                    break;
                case false:
                    break;
            }
        } //Fucntion to sell items to merchant.
        public static void ArmorerLogic(int input)
        {
            List<Item> PlayerList = Inventory.InventoryList;
            List<Item> ArmorerList = Merchant.ArmorerList;
            switch (input)
            {
                case 1:
                    Display.ArmorerDisplay();
                    Merchant.BuyItemFromMerchant(Input.MerchantBuyInput(ArmorerList), ArmorerList);
                    break;
                case 2:
                    Display.InventorySellDisplay();
                    Merchant.SellItemToMerchant(Input.MerchantSellInput(PlayerList), PlayerList);
                    break;
                case 3:

                    break;
            }
        } //Function for the Armorer's buying/selling logic.
        public static void BlacksmithLogic(int input)
        {
            List<Item> PlayerList = Inventory.InventoryList;
            List<Item> BlacksmithList = Merchant.BlacksmithList;
            switch (input)
            {
                case 1:
                    Display.BlacksmithDisplay();
                    Merchant.BuyItemFromMerchant(Input.MerchantBuyInput(BlacksmithList), BlacksmithList);
                    break;
                case 2:
                    Display.InventorySellDisplay();
                    Merchant.SellItemToMerchant(Input.MerchantSellInput(PlayerList), PlayerList);
                    break;
                case 3:

                    break;
            }
        }  //Function for the Blacksmith's buying/selling logic.
        public static void AlchemistLogic(int input)
        {
            List<Item> PlayerList = Inventory.InventoryList;
            List<Item> AlchemistList = Merchant.AlchemistList;
            switch (input)
            {
                case 1:
                    Display.AlchemistDisplay();
                    Merchant.BuyItemFromMerchant(Input.MerchantBuyInput(AlchemistList), AlchemistList);
                    break;
                case 2:
                    Display.InventorySellDisplay();
                    Merchant.SellItemToMerchant(Input.MerchantSellInput(PlayerList), PlayerList);
                    break;
                case 3:

                    break;
            }
        } //Function for the Alchemist's buying/selling logic.


    }
}
