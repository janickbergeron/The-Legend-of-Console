namespace The_Legend_of_Console
{
    public class Program
    {
        public static bool InProgress = true;
        public static bool TestInProgress = true;
        public static Player player = null;
        public static Monster monster = null;
        public static Coordinate playerCoord = new(0, 0);

        public static void InitializeCombat()
        {
            //Monster monster = new("  Blob", 1, 10, 1, 5, 1, 0, player);
            Random random = new Random();
            int rand = random.Next(0, Monster.MonsterList.Count());
            Monster monster = Monster.CreateMonster(rand, Monster.MonsterList);
            Program.monster = monster;
            Combat combat1 = new Combat(player, monster);
            monster.Health = monster.MaxHealth;
            combat1.StartCombat();
        }
        public static Player PlayerCreation()
        {
            Display.ClearConsole();
            Console.WriteLine("Choose the Player's name:");
            string name = Console.ReadLine();

            Player player = new(name, 1, 50, 11, 15, 2, 0, 0, 0);
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
            Item.MaterialList = Item.GetItemData("Material");
            Item.CraftedWeaponList = Item.GetItemData("CraftedWeapon");
            Item.CraftedArmorList = Item.GetItemData("CraftedArmor");
            Monster.MonsterList = Monster.GetMonsterData();
            Display.BoardList = Board.GetBoardData();

            //Initialization
            Player.ExperienceTable = Player.InitializeExperienceTable();
            Display.InitializeGameboard1();
            Display.InitializeContextDisplay();
            Display.InitializeStringTab();
            Display.InitializePreFogTab();
            Display.InitializePostFogTab();
            Inventory.InitializeEquipment();
            //Inventory.InventoryTest();

            //Board loading
            Display.BoardLoading(0, Display.MainTab);

            //Merchant Loading
            Merchant.MerchantLoading();

            //Test loop

            /*while (TestInProgress)
            {

            }*/

            //Gameplay Loop
            Display.TitleScreen();
            Display.TitleMenuDisplay();

            while (InProgress)
            {
                playerCoord = Coordinate.PlayerPosition();
                Display.GameboardOptimisation();
                Display.Gameboard();
                //Coordinate.CombatInitiator(Coordinate.MonsterCoordList);
                Coordinate.TreasureInitiator(Coordinate.TreasureCoordList);
                Player.PlayerMouvement(playerCoord);
                Coordinate.RandomCombatInitiator();
                Thread.Sleep(10);
            }
        }   
    }
}