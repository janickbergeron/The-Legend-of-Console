namespace The_Legend_of_Console
{
    public class Program
    {
        public static bool InProgress = true;
        public static Player player = new("pepito", 1, 100, 50, 10, 0);
        public static Monster monster = new("  Blob", 1, 100, 10, 10, 0, player);
        public static int[] position = new int[2];
        public static void InitializeCombat()
        {
            Combat combat1 = new Combat(Program.player, Program.monster);
            monster.Health = monster.MaxHealth;
            combat1.StartCombat();
            
        }
            static void Main(string[] args)
            { 
            
                Display.InitializeGameboard1();
                Display.InitializeStringTab();
                Display.MainTabLoading(Board.GenerateBoard(0, Board.GetBoardData()));
            Coordinate.CoordList = Monster.MonsterPosition();
                while (InProgress)
                {
                    Console.Clear();
                    Display.GameboardOptimisation();
                    Display.Gameboard();
                    position = Player.PlayerPosition();
                    Coordinate.CombatInitiator(Coordinate.CoordList);
                    Coordinate.CoordListDisplay(Coordinate.CoordList);
                    Console.WriteLine($"The player is at position ({position[0]},{position[1]})");
                    Player.PlayerMouvement(position[1],position[0]);
                    Thread.Sleep(20);

                   // InitializeCombat();

                }
            }   
    }
}