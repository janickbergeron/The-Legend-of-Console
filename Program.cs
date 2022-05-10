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
            Monster monster = new("  Blob", 1, 10, 1, 5, 1, 0, player);
            Combat combat1 = new Combat(player, monster);
            monster.Health = monster.MaxHealth;
            combat1.StartCombat();
        }
        public static Player PlayerCreation()
        {
            Console.Clear();
            Console.WriteLine("Choose the Player's name:");
            string name = Console.ReadLine();

            Player player = new(name, 1, 50, 11, 15, 2, 0);
            return player;
        }
        static void Main(string[] args)
        {
            
            //Assets Loading
            Item.WeaponList = Item.GetItemData("Weapon");
            Item.OffHandList = Item.GetItemData("OffHand");
            Item.ChestList = Item.GetItemData("Chest");
            Item.PantsList = Item.GetItemData("Pants");
            Item.BootsList = Item.GetItemData("Boots");
            Item.GlovesList = Item.GetItemData("Gloves");
            Item.RingList = Item.GetItemData("Ring");
            Item.ConsumList = Item.GetItemData("Consum");
            Display.BoardList = Board.GetBoardData();
            
            Inventory.InventoryWeaponList.Add(Item.CreateItem(0,Item.WeaponList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.OffHandList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(1, Item.ChestList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.PantsList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.ChestList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.BootsList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.GlovesList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(0, Item.RingList));
            Inventory.InventoryArmorList.Add(Item.CreateItem(1, Item.RingList));
            Inventory.InventoryConsumList.Add(Item.CreateItem(0, Item.ConsumList));

            Display.InitializeGameboard1();
            Display.InitializeContextDisplay();
            Display.InitializeStringTab();
            Inventory.InitializeEquipment();
            Display.BoardLoading(0);  //Board chooser
            Coordinate.MonsterCoordList = Monster.MonsterPosition();
            Coordinate.TreasureCoordList = Coordinate.TreasurePosition();
            Coordinate.LeverCoordList = Coordinate.LeverPosition();
            Coordinate.PanelCoordList = Coordinate.PanelPosition();
            Coordinate.MerchantCoordList = Coordinate.MerchantPosition();
            Coordinate.DoorCoordList = Coordinate.DoorPosition();
            Interactible.LeverList = Interactible.CreateNewLeverList(Coordinate.LeverCoordList, Coordinate.DoorCoordList);


            // // Test loop
            //Program.player = Program.PlayerCreation();
            //player.Gold = 100;
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.ChestList));
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.PantsList));
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.BootsList));
            Merchant.ArmorerList.Add(Item.CreateItem(0, Item.RingList));
            Merchant.BlacksmithList.Add(Item.CreateItem(0, Item.WeaponList));
            Merchant.BlacksmithList.Add(Item.CreateItem(0, Item.WeaponList));
            Merchant.AlchemistList.Add(Item.CreateItem(0, Item.ConsumList));
            Merchant.AlchemistList.Add(Item.CreateItem(0, Item.ConsumList));
            Merchant.AlchemistList.Add(Item.CreateItem(0, Item.ConsumList));


            /*while (TestInProgress)
            {
                //Display.ArmorerDisplay();
                //Merchant.ArmorerLogic(Input.MerchantInput());

                //Display.BlacksmithDisplay();
                //Merchant.BlacksmithLogic(Input.MerchantInput());

                Display.AlchemistDisplay();
                Merchant.AlchemistLogic(Input.MerchantInput());
            }*/

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
                Thread.Sleep(10);
            }
        }   
    }
}