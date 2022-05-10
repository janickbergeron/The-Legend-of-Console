using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public abstract class  Entity
    {
        private Entity _enemy;
        private string _name;
        private int _level;
        private int _maxHealth;
        private int _health;
        private int _minDamage;
        private int _maxDamage;
        private int _defense;
        private int _armor;
        
        public Entity Enemy { get { return _enemy; } set { _enemy = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Level { get { return _level; } set { _level = value; } }
        public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }
        public int Health { get { return _health; } 
            set 
            { 
                if (_health < 0)
                {
                    _health = 0;
                }else
                _health = value; 
            } 
        }
        public int MinDamage { get { return _minDamage; } set { _minDamage = value; } }
        public int MaxDamage { get { return _maxDamage; } set { _maxDamage = value; } }
        public int Defense { get { return _defense; } set { _defense = value; } }
        public int Armor 
            { get 
                {
                    return _armor; 
                }
            set
            {
                if (_armor < 0)
                {
                    _armor = 0;
                }
                else  _armor = value; 
                } 
            }

        public Entity(string name, int level, int maxHealth, int minDamage,int maxDamage, int defense, int armor)
        {
            _name = name;
            _level = level;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _defense = defense;
            _armor = armor;
        }
        public abstract int CombatAttack(int minDamage, int maxDamage);
        public abstract int Defend();
    }
}
