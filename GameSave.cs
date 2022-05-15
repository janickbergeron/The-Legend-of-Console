using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace The_Legend_of_Console
{
    internal class GameSave
    {
        public static void SavePlayerData()
        {
            List <Player> playerData = new List<Player>();
            playerData.Add(new Player
            (
                Program.player.Name,
                Program.player.Level,
                Program.player.MaxHealth,
                Program.player.MinDamage,
                Program.player.MaxDamage,
                Program.player.Defense,
                Program.player.Armor,
                Program.player.Gold,
                Program.player.Experience
            ));

            string json = JsonConvert.SerializeObject(playerData.ToArray(), Formatting.Indented, JsonFileUtils._options);

            //write string to file
            var CurrentDirectory = Environment.CurrentDirectory;
            string path1 = $@"\data\Save\PlayerSaveData.json";
            string fullPath = CurrentDirectory + path1;

            //string path = @"C:\Users\Janick Bergeron\source\repos\The-Legend-of-Console\data\Save\PlayerSaveData.json";
            System.IO.File.WriteAllText(fullPath, json);
        }   //Function to save the player's character data.
        public static void SaveEquipmentData()
        {
            List<Item> equippedItemList = new List<Item>();
            equippedItemList.Add(Inventory.EquippedWeapon[0]);
            equippedItemList.Add(Inventory.EquippedOffHand[0]);
            equippedItemList.Add(Inventory.EquippedChest[0]);
            equippedItemList.Add(Inventory.EquippedPants[0]);
            equippedItemList.Add(Inventory.EquippedBoots[0]);
            equippedItemList.Add(Inventory.EquippedGloves[0]);
            equippedItemList.Add(Inventory.EquippedRing[0]);
            equippedItemList.Add(Inventory.EquippedRing[1]);

            string json = JsonConvert.SerializeObject(equippedItemList.ToArray(), Formatting.Indented, JsonFileUtils._options);
            var CurrentDirectory = Environment.CurrentDirectory;
            string path1 = $@"\data\Save\EquipmentSaveData.json";
            string fullPath = CurrentDirectory + path1;
            //string path = @"C:\Users\Janick Bergeron\source\repos\The-Legend-of-Console\data\Save\EquipmentSaveData.json";
            System.IO.File.WriteAllText(fullPath, json);
        } //Function to save the player's equipment data.
        public static void SaveInventoryData()
        {
            Inventory.RefreshInventoryList();
            List<Item> playerInventory = new List<Item>();
            playerInventory = Inventory.InventoryList;
            string json = JsonConvert.SerializeObject(playerInventory.ToArray(), Formatting.Indented, JsonFileUtils._options);
            var CurrentDirectory = Environment.CurrentDirectory;
            string path1 = $@"\data\Save\InventorySaveData.json";
            string fullPath = CurrentDirectory + path1;
            //string path = @"C:\Users\Janick Bergeron\source\repos\The-Legend-of-Console\data\Save\InventorySaveData.json";
            System.IO.File.WriteAllText(fullPath, json);
        } //Function to save the player's inventory data.
        public static void SaveHouseData()
        {
            Inventory.RefreshInventoryList();
            List<Item> houseInventory = new List<Item>();
            houseInventory = Inventory.HouseStorageList;
            string json = JsonConvert.SerializeObject(houseInventory.ToArray(), Formatting.Indented, JsonFileUtils._options);
            var CurrentDirectory = Environment.CurrentDirectory;
            string path1 = $@"\data\Save\HouseSaveData.json";
            string fullPath = CurrentDirectory + path1;
            //string path = @"C:\Users\Janick Bergeron\source\repos\The-Legend-of-Console\data\Save\HouseSaveData.json";
            System.IO.File.WriteAllText(fullPath, json);
        }  //Function to save the player's house storage data.
        public static Player LoadPlayerData()
        {
            var CurrentDirectory = Environment.CurrentDirectory;
            string path1 = $@"\data\Save\PlayerSaveData.json";
            string fullPath = CurrentDirectory + path1;
            StreamReader r = new StreamReader(fullPath);
            string jsonString = r.ReadToEnd();
            List<Player> playerData = JsonConvert.DeserializeObject<List<Player>>(jsonString);
            return playerData[0];
        }  //Function to load the player's character data.
        public static List<Item> LoadSavedData(string dataType)
        {
            var CurrentDirectory = Environment.CurrentDirectory;
            string path1 = $@"\data\Save\{dataType}SaveData.json";
            string fullPath = CurrentDirectory + path1;
            StreamReader r = new StreamReader(fullPath);
            string jsonString = r.ReadToEnd();
            List<Item> Data = JsonConvert.DeserializeObject<List<Item>>(jsonString);
            return Data;
        }   //Function to load the specified data type.
    }
}
