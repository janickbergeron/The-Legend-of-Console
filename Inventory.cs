using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Inventory
    {
        public static List<Item> InventoryList = new List<Item>();
        public static List<Item> HouseStorageList = new List<Item>();
        public static List<Item> HouseStorageArmor = new List<Item>();
        public static List<Item> HouseStorageWeapon = new List<Item>();
        public static List<Item> HouseStorageConsum = new List<Item>();
        public static List<Item> HouseStorageMaterial = new List<Item>();
        public static List<Item> InventoryWeaponList = new List<Item>();
        public static List<Item> InventoryArmorList = new List<Item>();
        public static List<Item> InventoryConsumList = new List<Item>();
        public static List<Item> InventoryMaterialList = new List<Item>();

        public static List<Item> EquippedWeapon = new List<Item>();
        public static List<Item> EquippedOffHand = new List<Item>();
        public static List<Item> EquippedChest = new List<Item>();
        public static List<Item> EquippedPants = new List<Item>();
        public static List<Item> EquippedBoots = new List<Item>();
        public static List<Item> EquippedGloves = new List<Item>();
        public static List<Item> EquippedRing = new List<Item>();

        public static void InitializeEquipment()
        {
            Item item = new(" ", "Placeholder", 0,0);
            InventoryList.Add(item);
            EquippedWeapon.Add(item);
            EquippedOffHand.Add(item);
            EquippedChest.Add(item);
            EquippedPants.Add(item);
            EquippedBoots.Add(item);
            EquippedGloves.Add(item);
            EquippedRing.Add(item);
            EquippedRing.Add(item);
        } //Function to initialize the equipment slot with placeholders.
        public static void RefreshInventoryList()
        {
            InventoryList.Clear();
            foreach (Item item in InventoryWeaponList)
            {
                InventoryList.Add(item);
            }
            foreach (Item item in InventoryArmorList)
            {
                InventoryList.Add(item);
            }
            foreach (Item item in InventoryConsumList)
            {
                InventoryList.Add(item);
            }
            foreach (Item item in InventoryMaterialList)
            {
                InventoryList.Add(item);
            }

            HouseStorageList.Clear();
            foreach (Item item in HouseStorageWeapon)
            {
                HouseStorageList.Add(item);
            }
            foreach (Item item in HouseStorageArmor)
            {
                HouseStorageList.Add(item);
            }
            foreach (Item item in HouseStorageConsum)
            {
                HouseStorageList.Add(item);
            }
            foreach (Item item in HouseStorageMaterial)
            {
                HouseStorageList.Add(item);
            }
        } // Function to refresh the inventoryList
        public static void InventoryTest()
        {
            Inventory.InventoryWeaponList.Add(Item.CreateItem(0, Item.WeaponList));
            Inventory.InventoryWeaponList.Add(Item.CreateItem(0, Item.OffHandList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.PantsList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.ChestList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.BootsList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.GlovesList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.RingList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(1, Item.RingList));
            Inventory.InventoryConsumList.Add(Item.CreateItem(0, Item.ConsumList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(0, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(0, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(0, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(1, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(1, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(2, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(2, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(3, Item.MaterialList));
            Inventory.InventoryMaterialList.Add(Item.CreateItem(4, Item.MaterialList));
        }  //Function to add items to inventory for testing.
        public static List<Item> InventoryMaterialProcess(List<Item> materialList)
        {
            //HashSet<Item> hashset = new HashSet<Item>();
            //IEnumerable<Item> duplicates = InventoryMaterialList.Where(e => !hashset.Add(e));
            //return duplicates;

            List<Item> duplicate = materialList.GroupBy(p => p.Name)
                           .Select(grp => grp.First())
                           .ToList();
            //List<Item> duplicate = materialList.Distinct().ToList();
            return duplicate;
        }  //Function that return a list of distinct material in the player's inventory.
        public static void AddItemToInventory(Item item)
        {
            if (item.Type == "Chest")
                InventoryArmorList.Add(item);
            if (item.Type == "Pants")
                InventoryArmorList.Add(item);
            if (item.Type == "Boots")
                InventoryArmorList.Add(item);
            if (item.Type == "Gloves")
                InventoryArmorList.Add(item);
            if (item.Type == "Ring")
                InventoryArmorList.Add(item);
            if (item.Type == "Weapon")
                InventoryWeaponList.Add(item);
            if (item.Type == "Off-Hand")
                InventoryWeaponList.Add(item);
            if (item.Type == "Consum")
                InventoryConsumList.Add(item);
            if (item.Type == "Material")
                InventoryMaterialList.Add(item);
        }  //Function to add an item to inventory.
        public static void AddItemToInventory(List<Item> itemList)
        {
            foreach(Item item in itemList)
            {
                if (item.Type == "Chest")
                    InventoryArmorList.Add(item);
                if (item.Type == "Pants")
                    InventoryArmorList.Add(item);
                if (item.Type == "Boots")
                    InventoryArmorList.Add(item);
                if (item.Type == "Gloves")
                    InventoryArmorList.Add(item);
                if (item.Type == "Ring")
                    InventoryArmorList.Add(item);
                if (item.Type == "Weapon")
                    InventoryWeaponList.Add(item);
                if (item.Type == "Off-Hand")
                    InventoryWeaponList.Add(item);
                if (item.Type == "Consum")
                    InventoryConsumList.Add(item);
                if (item.Type == "Material")
                    InventoryMaterialList.Add(item);
            }
        }  //Function to add an item to inventory.
        public static void RemoveMaterialFromInventory(int itemPosition)
        {
                InventoryMaterialList.RemoveAt(itemPosition);
        }  //Function to remove materials from inventory.
        public static int FindCraftingMaterial(List<Item> materialList, Item itemToFind)
        {
            int counter = 0;
            int materialPosition = 0;
            for (int i = 0; i < materialList.Count; i++)
            {
                if (materialList[i].Name == itemToFind.Name)
                {
                    materialPosition = counter;
                }
                counter++;
            }
            return materialPosition;
        }  //Function to find a specific material in the inventory (crafting)
        public static void AddItemToStorage(Item item)
        {
            if (item.Type == "Chest")
                HouseStorageArmor.Add(item);
            if (item.Type == "Pants")
                HouseStorageArmor.Add(item);
            if (item.Type == "Boots")
                HouseStorageArmor.Add(item);
            if (item.Type == "Gloves")
                HouseStorageArmor.Add(item);
            if (item.Type == "Ring")
                HouseStorageArmor.Add(item);
            if (item.Type == "Weapon")
                HouseStorageWeapon.Add(item);
            if (item.Type == "Off-Hand")
                HouseStorageWeapon.Add(item);
            if (item.Type == "Consum")
                HouseStorageConsum.Add(item);
            if (item.Type == "Material")
                HouseStorageMaterial.Add(item);

        }  //Function to add an item to storage.
        public static void RemoveItemFromInventory(int input)
        {
            List<Item> materialList = InventoryMaterialProcess(InventoryMaterialList);
            int weapon = Inventory.InventoryWeaponList.Count();
            int armor = Inventory.InventoryArmorList.Count();
            int consum = Inventory.InventoryConsumList.Count();
            int mats = materialList.Count();
            int weaponArmor = weapon + armor;
            int weaponArmorConsum = weapon + armor + consum;
            int weaponArmorConsumMats = weapon + armor + consum + mats;

            if (input+1 <= weapon)
                Inventory.InventoryWeaponList.RemoveAt(input);
            if (input + 1 > weapon && input < weaponArmor)
                Inventory.InventoryArmorList.RemoveAt(input-weapon);
            if (input + 1 > weaponArmor && input < weaponArmorConsum)
                Inventory.InventoryConsumList.RemoveAt(input - weaponArmor);
            if (input + 1 > weaponArmorConsum && input <= weaponArmorConsumMats)
                Inventory.InventoryMaterialList.RemoveAt(input - weaponArmorConsum);
        }  //Function to remove an item from inventory.
        public static void RemoveItemFromStorage(int input)
        {
            List<Item> materialList = InventoryMaterialProcess(InventoryMaterialList);
            int weapon = Inventory.InventoryWeaponList.Count();
            int armor = Inventory.InventoryArmorList.Count();
            int consum = Inventory.InventoryConsumList.Count();
            int mats = materialList.Count();
            int weaponArmor = weapon + armor;
            int weaponArmorConsum = weapon + armor + consum;
            int weaponArmorConsumMats = weapon + armor + consum + mats;

            if (input < weapon)
                Inventory.HouseStorageWeapon.RemoveAt(input);
            if (input >= weapon && input < weaponArmor)
                Inventory.HouseStorageArmor.RemoveAt(input - weapon);
            if (input > weaponArmorConsum)
                Inventory.HouseStorageConsum.RemoveAt(input - weaponArmor);
            if (input > weaponArmorConsumMats)
                Inventory.HouseStorageMaterial.RemoveAt(input - weaponArmorConsum);
        }  //Function to remove an item from storage.
        public static void InventoryLogicAfterLoad(List<Item> itemList)
        {
            foreach (Item item in itemList)
            {
                AddItemToInventory(item);
            }
        }  //Function to load the saved item into the player's inventory.
        public static void StorageLogicAfterLoad(List<Item> itemList)
        {
            foreach (Item item in itemList)
            {
                AddItemToStorage(item);
            }
        }  //Function to load the saved item into the player's house.
        public static void EquipItemAfterLoad(List<Item> itemList)
        {
            foreach (Item item in itemList)
            {
                EquipItemToSlot(item);
            }
        }  //Function to reequip all saved equipment
        public static void RemoveItemStatsBeforeSave(List<Item> itemList)
        {
            foreach(Item item in itemList)
            {
                RemoveItemStats(item);
            }
        }  //Function that ensure the save feature only save the player's base stats.
        public static List<Item> GetEquippedItems()
        {
            List<Item> equippedItems = new List<Item>();

            equippedItems.Add(EquippedWeapon[0]);
            equippedItems.Add(EquippedOffHand[0]);
            equippedItems.Add(EquippedChest[0]);
            equippedItems.Add(EquippedPants[0]);
            equippedItems.Add(EquippedBoots[0]);
            equippedItems.Add(EquippedGloves[0]);
            equippedItems.Add(EquippedRing[0]);
            equippedItems.Add(EquippedRing[1]);
            return equippedItems;
        }  //function to generate a list of all equipped items for saving.
        public static Item EquipItemToSlot(Item item)
        {
            Item returnToInventory = new(" ", "Placeholder", 0,0);
            Item placeholder = new(" ", "Placeholder", 0,0);

            if (item.Type == "Weapon") { returnToInventory = EquippedWeapon[0]; RemoveItemStats(EquippedWeapon[0]); EquippedWeapon.RemoveAt(0); EquippedWeapon.Add(item); AddItemStats(item); }
            if (item.Type == "Off-Hand") { returnToInventory = EquippedOffHand[0]; RemoveItemStats(EquippedOffHand[0]); EquippedOffHand.RemoveAt(0); EquippedOffHand.Add(item); AddItemStats(item); } 
            if (item.Type == "Chest") { returnToInventory = EquippedChest[0]; RemoveItemStats(EquippedChest[0]); EquippedChest.RemoveAt(0);  EquippedChest.Add(item); AddItemStats(item); } 
            if (item.Type == "Pants") { returnToInventory = EquippedPants[0]; RemoveItemStats(EquippedPants[0]); EquippedPants.RemoveAt(0);  EquippedPants.Add(item); AddItemStats(item); } 
            if (item.Type == "Boots") { returnToInventory = EquippedBoots[0]; RemoveItemStats(EquippedBoots[0]); EquippedBoots.RemoveAt(0);  EquippedBoots.Add(item); AddItemStats(item); } 
            if (item.Type == "Gloves") { returnToInventory = EquippedGloves[0]; RemoveItemStats(EquippedGloves[0]); EquippedGloves.RemoveAt(0);  EquippedGloves.Add(item); AddItemStats(item); } 
            if (item.Type == "Ring") { returnToInventory = EquippedRing[0]; RemoveItemStats(EquippedRing[0]); EquippedRing.RemoveAt(0);  EquippedRing.Add(item); AddItemStats(item); } 
            
            if (returnToInventory.Type != "Placeholder")
            {
                return returnToInventory;
            }
            else
            {
                return placeholder;
            }
        } //Function to equip an item and return previously equipped item to inventory.
        public static void RemoveItemStats(Item item)
        {
            Program.player.MaxHealth -= item.Health;
            Program.player.MinDamage -= item.MinDamage;
            Program.player.MaxDamage -= item.MaxDamage;
            Program.player.Defense -= item.Defense;
        } //Remove stats from item when its unequipped.
        public static void AddItemStats(Item item)
        {
            Program.player.MaxHealth += item.Health;
            Program.player.MinDamage += item.MinDamage;
            Program.player.MaxDamage += item.MaxDamage;
            Program.player.Defense += item.Defense;
        } //Add stats from item when its equipped.
        public static int MaterialCount(Item material)
        {
            int counter = 0;
            foreach (Item item in InventoryMaterialList)
            {
                if (material.Name == item.Name)
                counter++;
            }
            return counter;
        }   //Fucntion to count the number of material in the player's inventory.
        public static int GetInventoryTotal()
        {
            int list = InventoryWeaponList.Count();
                list += InventoryArmorList.Count();
                list += InventoryConsumList.Count();
                list += InventoryMaterialList.Count();
            return list;
        } //Function to get the total items in the inventory
        public static int GetStorageTotal()
        {
            int list1 = HouseStorageWeapon.Count();
            list1 += HouseStorageArmor.Count();
            list1 += HouseStorageConsum.Count();
            list1 += HouseStorageMaterial.Count();
            return list1;
        } //Function to get the total items in the inventory
    }
}
