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
        public static List<Item> MaterialList = new List<Item>();
        public static List<Item> CraftedWeaponList = new List<Item>();
        public static List<Item> CraftedArmorList = new List<Item>();
        public static List<Item> AllEquipmentList = new List<Item>();

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
        public int MinDamage { get { return _minDamage; } set { _minDamage = value; } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public int Defense { get { return _defense; } set { _defense = value; } }
        public int Health { get { return _health; } set { _health = value; } }
        public bool Full { get { return _full; } set { _full = value; } }
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
            _goldValue = goldValue;
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
        public static Item CreateItem(int x, List<Item> itemList)
        {
            Item item = new(itemList[x].Name, itemList[x].Type, itemList[x].Health, itemList[x].MinDamage, itemList[x].MaxDamage, itemList[x].Defense, itemList[x].Full, itemList[x].GoldValue);
            return item;
        }  //Function to create an item.
        public static Item CreateItem(Recipe recipe)
        {
            Item item = new(recipe.ItemToCraft.Name, recipe.ItemToCraft.Type, recipe.ItemToCraft.Health, recipe.ItemToCraft.MinDamage, recipe.ItemToCraft.MaxDamage, recipe.ItemToCraft.Defense, recipe.ItemToCraft.Full, recipe.ItemToCraft.GoldValue);
            return item;
        }  //Function to create an item from a Recipe object.
        public static void RefreshEquipmentList()
        {
            AllEquipmentList.Clear();
            AddItemToEquipmentList(WeaponList);
            AddItemToEquipmentList(OffHandList);
            AddItemToEquipmentList(ChestList);
            AddItemToEquipmentList(PantsList);
            AddItemToEquipmentList(BootsList);
            AddItemToEquipmentList(GlovesList);
            AddItemToEquipmentList(RingList);
            AddItemToEquipmentList(ConsumList);
        }  //Function to refresh the list of all equipment
        public static void AddItemToEquipmentList(List<Item> itemList)
        {
            foreach (Item item in itemList)
            {
                AllEquipmentList.Add(item);
            }
        } //Function to add item to the list of all equipment.
        public static bool MonsterDropChance()
        {
            Random random = new Random();
            int rng = random.Next(0, 2);
            if (rng == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  //Function to decide if a monster drop an item from monster encounter.
        public static List<Item> MonsterDroppedItem()
        {
            List<Item> monsterDrop = new List<Item>();
            Item item = null;
            Random random = new Random();
            int ItemType = random.Next(0, 10);
                if (ItemType <= 1) //Equipment drop <= 1 = 20%
                {
                    RefreshEquipmentList();
                    int Item = random.Next(0, AllEquipmentList.Count());
                    item = CreateItem(Item, AllEquipmentList);
                }
                if (ItemType >= 2) //Material drop >= 2 = 80%
                {
                    int Item = random.Next(0, MaterialList.Count());
                    item = CreateItem(Item, MaterialList);
                }
            monsterDrop.Add(item);
            return monsterDrop;
        } //Function to decide which item drops from monster encounter.
        public static List<Item> BossMonsterDroppedItem()
        {
            List<Item> monsterDrop = new List<Item>();
            Item item = null;
            Random random = new Random();
            int ItemType = random.Next(0, 10);
            if (ItemType >= 2) //Equipment drop >= 2 = 80%d
            {
                RefreshEquipmentList();
                int Item = random.Next(0, AllEquipmentList.Count());
                item = CreateItem(Item, AllEquipmentList);
            }
            if (ItemType <= 1) //Material drop <= 1 = 20%
            {
                int Item = random.Next(0, MaterialList.Count());
                item = CreateItem(Item, MaterialList);
            }
            monsterDrop.Add(item);
            return monsterDrop;
        } //Function to decide which item drops from monster encounter.
        public static int MonsterDroppedGold(Monster monster)
        {
            Random random = new Random();
            int goldDropped = random.Next(1, monster.MaxHealth/2);
            return goldDropped;
        } //Function to decide how many gold drops from monster encounter.
    }
}
