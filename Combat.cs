using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Combat
    {
        private Player _player;
        private Monster _monster;
        public static List<string> CombatLog = new List<string>();
        public static int CombatRound;

        public Player Player
        {
            get { return _player; }
        }
        public Monster Monster
        {
            get { return _monster; }
        }
        public Combat(Player player, Monster monster)
        {
            _player = player;
            _monster = monster;
            player.Enemy = monster;
            monster.Enemy = player;
        }
        public static void InitializeCombatLog()
        {
            for (int i = 0; i < 10; i++)
            {
                CombatLog.Clear();
            }
            for (int i = 0; i < 10; i++)
            {
                CombatLog.Add("║                                                                        ║");
            }
        }  
        public static void CombatLogProcess()
        {
            CombatLog.RemoveAt(0);
        }
        public void StartCombat()
        {
            CombatRound = 0;
            InitializeCombatLog();
            while (_player.Health > 0 && _monster.Health > 0)
            {
                Display.CombatLogDisplay();
                TourPlayer();
                Display.CombatLogDisplay();
                Thread.Sleep(500);
                if (_monster.Health <= 0)
                    continue;
                TourMonster();
            }

            if (_player.Health <= 0)
                Console.WriteLine("Defeat, Game Over.");
            else
                Console.WriteLine("Victory !");
                Console.ReadKey();
                Console.Clear();
                Display.Gameboard();
        }
        private void TourPlayer()
        {
            _player.ExecuteAction(_player.ChooseAction());
        }
        private void TourMonster()
        {
            _monster.ExecuteAction(_monster.ChooseAction());
        }
    }
}
