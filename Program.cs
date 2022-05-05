namespace The_Legend_of_Console
{
    public class Program
    {
        public static bool InProgress = true;
        public static bool TestInProgress = true;
        public static Player player = null;
        public static Monster monster = new("  Blob", 1, 100, 1, 5, 1, 0, player);
        public static int[] position = new int[2];
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

            Player player = new(name, 1, 50, 2, 5, 0, 0);
            return player;
        }
        static void Main(string[] args)
        {
            /*while (TestInProgress)
            {
                Display.InventoryDisplay();
                Console.ReadKey();
            }*/

             Display.TitleScreen();
             Item.WeaponList = Item.GetItemData("Weapon");
             Item.ArmorList = Item.GetItemData("Armor");
             Item.ConsumList = Item.GetItemData("Consum");
             Inventory.InventoryWeaponList.Add(Item.CreateWeapon(0,Item.WeaponList));
             Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.ArmorList));
             Inventory.InventoryArmorList.Add(Item.CreateArmor(1, Item.ArmorList));
             Inventory.InventoryConsumList.Add(Item.CreateConsum(0, Item.ConsumList));

             Display.InitializeGameboard1();
             Display.InitializeStringTab();
             Display.MainTabLoading(Board.GenerateBoard(0, Board.GetBoardData()));
             Coordinate.MonsterCoordList = Monster.MonsterPosition();
             Coordinate.TreasureCoordList = Coordinate.TreasurePosition();
             Coordinate.LeverCoordList = Coordinate.LeverPosition();

             Display.TitleMenuDisplay();
             while (InProgress)
             {
                 Console.Clear();
                 Display.GameboardOptimisation();
                 Display.Gameboard();
                 position = Player.PlayerPosition();
                 Coordinate.CombatInitiator(Coordinate.MonsterCoordList);
                 //Coordinate.CoordListDisplay(Coordinate.MonsterCoordList);
                 Console.WriteLine($"The player is at position ({position[0]},{position[1]})");
                 Player.PlayerMouvement(position[1],position[0]);
                 Thread.Sleep(20);
             }
        }   
    }
}