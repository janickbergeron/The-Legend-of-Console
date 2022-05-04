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
        public static List<Item> EquippedItems = new List<Item>();
        public static void AddItemToInventory(Item item)
        {
            if (item.Type == "Armor")
                InventoryArmorList.Add(item);
            if (item.Type == "Weapon")
                InventoryWeaponList.Add(item);
        }
    }
}
