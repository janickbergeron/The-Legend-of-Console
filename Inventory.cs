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
        public static List<Item> InventoryWeaponList = new List<Item>();
        public static List<Item> InventoryArmorList = new List<Item>();
        public static List<Item> InventoryConsumList = new List<Item>();
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
        } // Function to refresh the inventoryList
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
        }  //Function to add an item to inventory.
        public static void RemoveItemFromInventory(int input)
        {
            int weapon = Inventory.InventoryWeaponList.Count();
            int armor = Inventory.InventoryArmorList.Count();
            int consum = Inventory.InventoryConsumList.Count();
            int weaponArmor = weapon + armor;
            int weaponArmorConsum = weapon + armor + consum;

            if (input < weapon)
                Inventory.InventoryWeaponList.RemoveAt(input);
            if (input >= weapon && input < weaponArmorConsum)
                Inventory.InventoryArmorList.RemoveAt(input-weapon);
            if (input > weaponArmor)
                Inventory.InventoryConsumList.RemoveAt(input - weaponArmor);
        }   //Function to remove an item from inventory.
        public static Item EquipItemToSlot(Item item)
        {
            Item returnToInventory = new(" ", "Placeholder", 0,0);
            Item placeholder = new(" ", "Placeholder", 0,0);

            if (item.Type == "Weapon") { returnToInventory = EquippedWeapon[0]; EquippedWeapon.RemoveAt(0); EquippedWeapon.Add(item);}
            if (item.Type == "Off-Hand") { returnToInventory = EquippedOffHand[0]; EquippedOffHand.RemoveAt(0); EquippedOffHand.Add(item); } 
            if (item.Type == "Chest") { returnToInventory = EquippedChest[0]; EquippedChest.RemoveAt(0);  EquippedChest.Add(item); } 
            if (item.Type == "Pants") { returnToInventory = EquippedPants[0]; EquippedPants.RemoveAt(0);  EquippedPants.Add(item); } 
            if (item.Type == "Boots") { returnToInventory = EquippedBoots[0]; EquippedBoots.RemoveAt(0);  EquippedBoots.Add(item); } 
            if (item.Type == "Gloves") { returnToInventory = EquippedGloves[0]; EquippedGloves.RemoveAt(0);  EquippedGloves.Add(item); } 
            if (item.Type == "Ring") { returnToInventory = EquippedRing[0]; EquippedRing.RemoveAt(0);  EquippedRing.Add(item); } 
            
            if (returnToInventory.Type != "Placeholder")
            {
                return returnToInventory;
            }
            else
            {
                return placeholder;
            }
        } //Function to equip an item and return previously equipped item to inventory
        public static int GetInventoryTotal()
        {
            int list1 = InventoryWeaponList.Count();
                list1 += InventoryArmorList.Count();
                list1 += InventoryConsumList.Count();
            return list1;
        } //Function to get the total items in the inventory
    }
}
