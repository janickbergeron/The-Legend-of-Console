using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace The_Legend_of_Console
{
    public class Item
    {
        public static List<Item> WeaponList = new List<Item>();
        public static List<Item> OffHandList = new List<Item>();
        public static List<Item> ChestList = new List<Item>();
        public static List<Item> PantsList = new List<Item>();
        public static List<Item> BootsList = new List<Item>();
        public static List<Item> GlovesList = new List<Item>();
        public static List<Item> RingList = new List<Item>();
        public static List<Item> ConsumList = new List<Item>();

        private string _name;
        private string _type;
        private int _minDamage;
        private int _maxDamage;
        private int _defense;
        private int _health;
        private bool _full;
        private int _goldValue;
        public string Name { get { return _name; } set { _name = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public int MinDamage { get { return _minDamage; } set { _minDamage = value;} }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value;} }
        public int Defense { get { return _defense; } set { _defense = value;} }
        public int Health { get { return _health; } set { _health = value;} }
        public bool Full { get { return _full; } set { _full = value;} }    
        public int GoldValue { get { return _goldValue; } set { _goldValue = value; } }

        [JsonConstructor]
        public Item(string name, string type, int health, int minDamage, int maxDamage, int defense, bool full, int goldValue)
        {
            _name = name;
            _type = type;
            _health = health;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _defense = defense;
            _goldValue = goldValue;
            _full = full;
            

         }  //Json Constructor.
        public Item(string name, string type, int minDamage, int maxDamage, int goldValue)  
        {
            _name = name;
            _type = type;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _goldValue= goldValue;
        }   // Weapon Constructor.
        public Item(string name, string type, int defense, int goldValue)
        {
            _name = name;
            _type = type;
            _defense = defense;
            _goldValue = goldValue;
        }   // Armor Constructor.
        public Item(string name, string type, int health, bool full, int goldValue)
        {
            _name = name;
            _type = type;
            _health = health;
            _full = full;
            _goldValue = goldValue;
        }   // Consumable Constructor.
        public static List<Item> GetItemData(string item)
        {
            var CurrentDirectory = Environment.CurrentDirectory;
            string path = $@"\Data\{item}Data.json";
            string fullPath = CurrentDirectory + path;
            StreamReader r = new StreamReader(fullPath);
            string jsonString = r.ReadToEnd();
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(jsonString);
            return itemList;
        } // Function to fetch the Item Data File.
        public static Item CreateWeapon(int x, List<Item> itemList)
        {
            Item item = new(itemList[x].Name, itemList[x].Type, itemList[x].MinDamage, itemList[x].MaxDamage, itemList[x].GoldValue);
            return item;
        }  //Function to create a Weapon.
        public static Item CreateArmor(int x, List<Item> itemList)
        {
            Item item = new(itemList[x].Name, itemList[x].Type, itemList[x].Health, itemList[x].Defense, itemList[x].GoldValue);
            return item;
        }  //Function to create an Armor.
        public static Item CreateItem(int x, List<Item> itemList)
        {
            Item item = new(itemList[x].Name, itemList[x].Type, itemList[x].Health, itemList[x].MinDamage, itemList[x].MaxDamage, itemList[x].Defense, itemList[x].Full, itemList[x].GoldValue);
            return item;
        }  //Function to create an item.
        public static Item CreateConsum(int x, List<Item> itemList)
        {
            Item item = new(itemList[x].Name, itemList[x].Type, itemList[x].Health, itemList[x].Full, itemList[x].GoldValue);
            return item;
        }  //Function to create a consumable.
    }
}
