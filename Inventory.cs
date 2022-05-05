using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Inventory
    {
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
        }

        public static Item EquipItemToSlot(Item item)
        {
            Item returnToInv = null; ;
            if (item.Type == "Weapon") { if (EquippedWeapon.Count > 0) { returnToInv = EquippedWeapon[0]; EquippedWeapon.RemoveAt(0); } else { EquippedWeapon.Add(item); } }
            if (item.Type == "Off-Hand") { if (EquippedOffHand.Count > 0) { returnToInv = EquippedOffHand[0]; EquippedOffHand.RemoveAt(0); } else { EquippedOffHand.Add(item); } }
            if (item.Type == "Chest") { if (EquippedChest.Count > 0) { returnToInv = EquippedChest[0]; EquippedChest.RemoveAt(0); } else { EquippedChest.Add(item); } }
            if (item.Type == "Pants") { if (EquippedPants.Count > 0) { returnToInv = EquippedPants[0]; EquippedPants.RemoveAt(0); } else { EquippedPants.Add(item); } }
            if (item.Type == "Boots") { if (EquippedBoots.Count > 0) { returnToInv = EquippedBoots[0]; EquippedBoots.RemoveAt(0); } else { EquippedBoots.Add(item); } }
            if (item.Type == "Gloves") { if (EquippedGloves.Count > 0) { returnToInv = EquippedGloves[0]; EquippedGloves.RemoveAt(0); } else { EquippedGloves.Add(item); } }
            if (item.Type == "Ring") { if (EquippedRing.Count > 1) { returnToInv = EquippedRing[0]; EquippedRing.RemoveAt(0); } else { EquippedRing.Add(item); } }
            return returnToInv;
        }
    }
}
