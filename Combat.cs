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
        }    //Function to initialize combat.
        public static void CombatLogProcess()
        {
            CombatLog.RemoveAt(0);
        }    //Function to remove the last line from the Combat Log
        public void StartCombat()
        {
            CombatRound = 0;
            InitializeCombatLog();
            while (_player.Health > 0 && _monster.Health > 0)
            {
                Display.CombatLogDisplay();
                PlayerTurn();
                Display.CombatLogDisplay();
                Thread.Sleep(500);
                if (_monster.Health <= 0)
                    continue;
                MonsterTurn();
            }

            if (_player.Health <= 0)
                Console.WriteLine("Defeat, Game Over.");
            else
                Console.WriteLine("Victory !");
                Console.ReadKey();
                Console.Clear();
                Display.Gameboard();
        }        //Function to start a new combat.
        private void PlayerTurn()
        {
            _player.ExecuteAction(_player.ChooseAction());
        }       //Function for the player's turn
        private void MonsterTurn()
        {
            _monster.ExecuteAction(_monster.ChooseAction());
        }  //Function for the monster's turn
    }
}
