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

        public static void ArmorerDisplay()
        {
            int index = 0;
            string menuString = "╔══════════════════════════════════════════════╗ \n" +
                                "║               Armorer's Shack                ║ \n" +
                                "╠══════════════════════════════════════════════╣ \n" +
                                "║  Armor                                       ║ \n" +
                                "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Merchant.ArmorerList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Defense:  {2,-2}- {3,-3}   ║ \n", index, item.Name, item.Defense);
            }
                  menuString += "╚══════════════════════╩═══════════════════════╝";
            Console.WriteLine(menuString);
        }

        public static void InventoryDisplay()
        {
            Console.Clear();
            int index = 0;
            string menuString = "╔══════════════════════════════════════════════╗ \n" +
                                "║                   Inventory                  ║ \n" +
                                "╠══════════════════════════════════════════════╣ \n" +
                                "║ Weapon                                       ║ \n" +
                                "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryWeaponList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Damage:  {2,-2}- {3,-3}   ║ \n", index, item.Name, item.MinDamage, item.MaxDamage);
            }
            menuString += "╠══════════════════════╩═══════════════════════╣ \n" +
                          "║ Armor                                        ║ \n" +
                          "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryArmorList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Defense: {2,-3}       ║\n", index, item.Name, item.Defense);
            }
            menuString += "╠══════════════════════╩═══════════════════════╣ \n" +
                          "║ Consumable                                   ║ \n" +
                          "╠══════════════════════╦═══════════════════════╣ \n";
            foreach (Item item in Inventory.InventoryConsumList)
            {
                index++;
                menuString += String.Format("║ {0,2} - {1,-15} ║    Health: +{2,-3}       ║\n", index, item.Name, item.Health);
            }
            menuString += "╚══════════════════════╩═══════════════════════╝";
            Console.WriteLine(menuString);

        }
    }
}
