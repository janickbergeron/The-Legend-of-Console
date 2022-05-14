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
            Inventory.RefreshInventoryList();
            if ( Inventory.InventoryList.Count > 0)
            {
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
                    Display.ArmorerCraftingDisplay();
                    Recipe recipe = Recipe.ArmorRecipeList[Input.CraftingInput(Recipe.ArmorRecipeList)];
                    Display.ArmorerCraftingInfoDisplay(recipe);
                    Inventory.AddItemToInventory(ArmorerCraftingLogic(recipe));
                    break;
                case 4:

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
                    Display.BlacksmithCraftingDisplay();
                    Recipe recipe = Recipe.WeaponRecipeList[Input.CraftingInput(Recipe.WeaponRecipeList)];
                    Display.BlacksmithCraftingInfoDisplay(recipe);
                    Inventory.AddItemToInventory(BlacksmithCraftingLogic(recipe));
                    break;
                case 4:

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
        public static Item BlacksmithCraftingLogic(Recipe recipe)
        {
            bool PlayerMeetsReq1 = false;
            bool PlayerMeetsReq2 = false;
            bool PlayerMeetsReq3 = false;
            bool PlayerMeetsReq4 = false;
            bool PlayerMeetsReq5 = false;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            Item Material1 = recipe.Material1;
            Item Material2 = recipe.Material2;
            Item Material3 = recipe.Material3;
            Item placeholder = new(" ", " ", 0, 0);

            foreach (Item item in Inventory.InventoryMaterialList)
            {
                if (item.Name == Material1.Name)
                {
                    counter1++;
                    if (counter1 == recipe.NumberMaterial1)
                        PlayerMeetsReq1 = true;
                }
                if (item.Name == Material2.Name)
                {
                    counter2++;
                    if (counter2 == recipe.NumberMaterial2)
                        PlayerMeetsReq2 = true;
                }
                if (item.Name == Material3.Name)
                {
                    counter3++;
                    if (counter3 == recipe.NumberMaterial3)
                        PlayerMeetsReq3 = true;
                }
            }
            if (Program.player.Gold >= recipe.ItemToCraft.GoldValue)
            {
                PlayerMeetsReq4 = true;
            }

            Console.WriteLine($"It'll cost you {recipe.ItemToCraft.GoldValue} gold for me to craft you a {recipe.ItemToCraft.Name}.");
            Console.WriteLine("Are you sure you wish to proceed? (Y/N)");
            PlayerMeetsReq5 = Input.YesNoInput();
            if (!PlayerMeetsReq5)
            {
                Display.BlacksmithCraftingDisplay();
            }

            if (PlayerMeetsReq1 && PlayerMeetsReq2 && PlayerMeetsReq3 && PlayerMeetsReq4 && PlayerMeetsReq5)
            {
                for (int i = 0; i < counter1; i++)
                {
                    Inventory.RemoveMaterialFromInventory(Inventory.FindCraftingMaterial(Inventory.InventoryMaterialList,Material1));
                }
                for (int i = 0; i < counter2; i++)
                {
                    Inventory.RemoveMaterialFromInventory(Inventory.FindCraftingMaterial(Inventory.InventoryMaterialList, Material2));
                }
                for (int i = 0; i < counter3; i++)
                {
                    Inventory.RemoveMaterialFromInventory(Inventory.FindCraftingMaterial(Inventory.InventoryMaterialList, Material3));
                }
                Program.player.Gold -= recipe.ItemToCraft.GoldValue;
                Item craftedItem = Item.CreateItem(recipe);
                Display.BlacksmithCraftingInfoDisplay(recipe);
                Console.WriteLine($"The blacksmith takes the materials and starts to work on your request.");
                Console.WriteLine($"You come back a few hours later to pickup your {recipe.ItemToCraft.Name}.");
                Console.ReadKey();
                return craftedItem;
            }
            else
            {
                if (PlayerMeetsReq4)
                {
                    Console.WriteLine("Not enough materials.");
                    Console.ReadKey();
                }
                
                return placeholder;
            }
        } //Function for the blacksmith's crafting Logic.
        public static Item ArmorerCraftingLogic(Recipe recipe)
        {
            bool PlayerMeetsReq1 = false;
            bool PlayerMeetsReq2 = false;
            bool PlayerMeetsReq3 = false;
            bool PlayerMeetsReq4 = false;
            bool PlayerMeetsReq5 = false;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            Item Material1 = recipe.Material1;
            Item Material2 = recipe.Material2;
            Item Material3 = recipe.Material3;
            Item placeholder = new(" ", " ", 0, 0);

            foreach (Item item in Inventory.InventoryMaterialList)
            {
                if (item.Name == Material1.Name)
                {
                    counter1++;
                    if (counter1 == recipe.NumberMaterial1)
                        PlayerMeetsReq1 = true;
                }
                if (item.Name == Material2.Name)
                {
                    counter2++;
                    if (counter2 == recipe.NumberMaterial2)
                        PlayerMeetsReq2 = true;
                }
                if (item.Name == Material3.Name)
                {
                    counter3++;
                    if (counter3 == recipe.NumberMaterial3)
                        PlayerMeetsReq3 = true;
                }
            }
            if (Program.player.Gold >= recipe.ItemToCraft.GoldValue)
            {
                PlayerMeetsReq4 = true;
            }

            Console.WriteLine($"It'll cost you {recipe.ItemToCraft.GoldValue} gold for me to craft you a {recipe.ItemToCraft.Name}.");
            Console.WriteLine("Are you sure you wish to proceed? (Y/N)");
            PlayerMeetsReq5 = Input.YesNoInput();
            if (!PlayerMeetsReq5)
            {
                Display.ArmorerCraftingDisplay();
            }

            if (PlayerMeetsReq1 && PlayerMeetsReq2 && PlayerMeetsReq3 && PlayerMeetsReq4 && PlayerMeetsReq5)
            {
                for (int i = 0; i < counter1; i++)
                {
                    Inventory.RemoveMaterialFromInventory(Inventory.FindCraftingMaterial(Inventory.InventoryMaterialList, Material1));
                }
                for (int i = 0; i < counter2; i++)
                {
                    Inventory.RemoveMaterialFromInventory(Inventory.FindCraftingMaterial(Inventory.InventoryMaterialList, Material2));
                }
                for (int i = 0; i < counter3; i++)
                {
                    Inventory.RemoveMaterialFromInventory(Inventory.FindCraftingMaterial(Inventory.InventoryMaterialList, Material3));
                }
                Program.player.Gold -= recipe.ItemToCraft.GoldValue;
                Item craftedItem = Item.CreateItem(recipe);
                Display.ArmorerCraftingInfoDisplay(recipe);
                Console.WriteLine($"The armorer takes the materials and starts to work on your request.");
                Console.WriteLine($"You come back a few hours later to pickup your {recipe.ItemToCraft.Name}.");
                Console.ReadKey();
                return craftedItem;
            }
            else
            {
                if (PlayerMeetsReq4)
                {
                    Console.WriteLine("Not enough materials.");
                    Console.ReadKey();
                }

                return placeholder;
            }
        } //Function for the armorer's crafting Logic.


    }
}
