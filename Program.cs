namespace The_Legend_of_Console
{
    public class Program
    {
        public static bool InProgress = true;
        public static bool TestInProgress = true;
        public static Player player = new("pepito", 1, 100, 1, 5, 10, 0);
        public static Monster monster = new("  Blob", 1, 100, 1, 5, 10, 0, player);
        public static int[] position = new int[2];
        public static void InitializeCombat()
        {
            Combat combat1 = new Combat(Program.player, Program.monster);
            monster.Health = monster.MaxHealth;
            combat1.StartCombat();
        }
        static void Main(string[] args)
        {
            /*while (TestInProgress)
            {
                Display.InventoryDisplay();
                Console.ReadKey();
            }*/
             Item.WeaponList = Item.GetWeaponData();
             Item.ArmorList = Item.GetArmorData();
             Item.ConsumList = Item.GetConsumData();
             Inventory.InventoryWeaponList.Add(Item.CreateWeapon(0,Item.WeaponList));
             Inventory.InventoryArmorList.Add(Item.CreateArmor(0, Item.ArmorList));
             Inventory.InventoryConsumList.Add(Item.CreateConsum(0, Item.ConsumList));

             Display.InitializeGameboard1();
             Display.InitializeStringTab();
             Display.MainTabLoading(Board.GenerateBoard(0, Board.GetBoardData()));
             Coordinate.MonsterCoordList = Monster.MonsterPosition();
             Coordinate.TreasureCoordList = Coordinate.TreasurePosition();
             Coordinate.LeverCoordList = Coordinate.LeverPosition();
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