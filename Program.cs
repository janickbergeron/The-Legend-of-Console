namespace The_Legend_of_Console
{
    public class Program
    {
        public static bool InProgress = true;
        public static bool TestInProgress = true;
        public static Player player = null;
        public static Monster monster = new("  Blob", 1, 10, 1, 5, 1, 0, player);
        public static Coordinate playerCoord = new(0, 0);

        public static void InitializeCombat()
        {
            Combat combat1 = new Combat(Program.player, Program.monster);
            monster.Health = monster.MaxHealth;
            combat1.StartCombat();
        }
        public static Player PlayerCreation()
        {
            Console.Clear();
            Console.WriteLine("Choose the Player's name:");
            string name = Console.ReadLine();

            Player player = new(name, 1, 50, 50, 60, 0, 0);
            return player;
        }
        static void Main(string[] args)
        {
            Item.WeaponList = Item.GetItemData("Weapon");
            Item.OffHandList = Item.GetItemData("OffHand");
            Item.ChestList = Item.GetItemData("Chest");
            Item.PantsList = Item.GetItemData("Pants");
            Item.BootsList = Item.GetItemData("Boots");
            Item.GlovesList = Item.GetItemData("Gloves");
            Item.RingList = Item.GetItemData("Ring");
            Item.ConsumList = Item.GetItemData("Consum");
            
              //Assets Loading
            Inventory.InventoryWeaponList.Add(Item.CreateWeapon(0,Item.WeaponList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.OffHandList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(1, Item.ChestList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.PantsList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.ChestList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.BootsList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.GlovesList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.RingList));
            Inventory.InventoryArmorList.Add(Item.CreateArmor(1, Item.RingList));
            Inventory.InventoryConsumList.Add(Item.CreateConsum(0, Item.ConsumList));

            Display.InitializeGameboard1();
            Display.InitializeStringTab();
            Inventory.InitializeEquipment();
            Display.MainTabLoading(Board.GenerateBoard(0, Board.GetBoardData()));
            Coordinate.MonsterCoordList = Monster.MonsterPosition();
            Coordinate.TreasureCoordList = Coordinate.TreasurePosition();
            Coordinate.LeverCoordList = Coordinate.LeverPosition();


          // // Test loop
            Program.player = Program.PlayerCreation();
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.ChestList));
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.PantsList));
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.BootsList));
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.RingList));
            Merchant.BlacksmithList.Add(Item.CreateItem(0, Item.WeaponList));
            Merchant.BlacksmithList.Add(Item.CreateItem(0, Item.WeaponList));
            Merchant.AlchemistList.Add(Item.CreateItem(0, Item.ConsumList));
            Merchant.AlchemistList.Add(Item.CreateItem(0, Item.ConsumList));
            Merchant.AlchemistList.Add(Item.CreateItem(0, Item.ConsumList));

            player.Gold = 100;

            while (TestInProgress)
            {
                //Display.ArmorerDisplay();
                //Merchant.ArmorerLogic(Input.MerchantInput());

                //Display.BlacksmithDisplay();
                //Merchant.BlacksmithLogic(Input.MerchantInput());

                Display.AlchemistDisplay();
                Merchant.AlchemistLogic(Input.MerchantInput());
            }

               //Gameplay Loop
            Display.TitleScreen();
            Display.TitleMenuDisplay();
            while (InProgress)
            {
                Console.Clear();
                Display.GameboardOptimisation();
                Display.Gameboard();
                Program.playerCoord = Coordinate.PlayerPosition();
                Coordinate.CombatInitiator(Coordinate.MonsterCoordList);
                Coordinate.TreasureInitiator(Coordinate.TreasureCoordList);
                //Coordinate.CoordListDisplay(Coordinate.MonsterCoordList);
                Console.WriteLine($"The player is at position ({playerCoord.X},{playerCoord.Y})");
                Player.PlayerMouvement(playerCoord);
                Thread.Sleep(20);
            }
        }   
    }
}