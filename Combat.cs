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
        private  Monster _monster;
        public static string monsterAction;
        public static List<string> CombatLog = new List<string>();
        public enum MonsterAction
        {
            Attack,
            Defend
        }

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
        public static int ExperienceGain(Monster monster)
        {
            int exp = monster.MaxHealth / 2;
            exp += monster.MinDamage;
            exp += monster.Defense;
            return exp+25;
        } //Function for the experience gain after combat.
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
            int exp = 0;
            bool itemDropped = false;
            List<Item> itemList = new List<Item>();

            InitializeCombatLog();
            while (_player.Health > 0 && _monster.Health > 0)
            {
                int mobAction = _monster.ChooseAction();
                
                var a = (MonsterAction)mobAction-1;
                monsterAction = a.ToString();
                Display.CombatLogDisplay();
                int playerAction = _player.ChooseAction();
                    if (playerAction == 2 && mobAction == 1)  //Player defend against attack.
                    {
                        PlayerTurn(playerAction);
                        Display.CombatLogDisplay();
                        Thread.Sleep(500);
                        if (_monster.Health <= 0)
                            continue;
                        MonsterTurn(mobAction);
                    }
                    if (playerAction == 1 && mobAction == 2) //Monster defend against attack.
                    {
                            MonsterTurn(mobAction);
                            Display.CombatLogDisplay();
                            Thread.Sleep(500);
                            if (_player.Health <= 0)
                                continue;
                            PlayerTurn(playerAction);
                    }
                    if (playerAction == 1 && mobAction == 1) //Player and monster both attack.
                    {
                        PlayerTurn(playerAction);
                        Display.CombatLogDisplay();
                        Thread.Sleep(500);
                        if (_monster.Health <= 0)
                            continue;
                        MonsterTurn(mobAction);
                    }
                    if (playerAction == 2 && mobAction == 2) //Player and monster both defend.
                    {
                        PlayerTurn(playerAction);
                        Display.CombatLogDisplay();
                        Thread.Sleep(500);
                        if (_monster.Health <= 0)
                            continue;
                        MonsterTurn(mobAction);
                    }
                Display.CombatLogDisplay();
            }

            if (_player.Health <= 0)
            {
                CombatLogProcess();
                Combat.CombatLog.Add("║ Defeat, Game Over.                                                     ║");
                Display.CombatLogDisplay();
                Console.ReadKey();
                Display.TitleMenuDisplay();
            }
            else
            {

                exp = ExperienceGain(_monster);
                _player.Experience += exp;
                CombatLogProcess();
                Combat.CombatLog.Add( "║ Victory !                                                              ║");
                Display.CombatLogDisplay();
                Thread.Sleep(300);
                CombatLogProcess();
                Combat.CombatLog.Add(String.Format("║ You have gained {0,3} experience points.                             {1,5}", exp, "║"));
                Display.CombatLogDisplay();

                //Post Combat Item Process
                itemDropped = Item.MonsterDropChance();
                    if (itemDropped)
                    {
                        itemList = Item.MonsterDroppedItem();
                        foreach(Item item in itemList)
                        {
                            CombatLogProcess();
                            Combat.CombatLog.Add(String.Format("║ The monster dropped : {1,-20}                            ║",_monster.Name, item.Name));
                            Inventory.AddItemToInventory(itemList);
                        }
                        Display.CombatLogDisplay();
                    }
                //Post Combat Gold Process
                CombatLogProcess();
                int gold = Item.MonsterDroppedGold(_monster);
                Combat.CombatLog.Add(String.Format("║ The monster dropped {1,3} gold.                                          ║", _monster.Name, gold));
                _player.Gold += gold;
                Display.CombatLogDisplay();
                Console.ReadKey();
                _player.PlayerLevelUp();
                Display.Gameboard();
            }
        }        //Function to start a new combat.
        private void PlayerTurn(int action)
        {
            _player.ExecuteAction(action);
        }       //Function for the player's turn
        private void MonsterTurn(int action)
        {
            _monster.ExecuteAction(action);
        }  //Function for the monster's turn
    }
}
