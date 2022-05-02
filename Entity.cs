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
        private int _attack;
        private int _defense;
        private int _armor;
        
        public Entity Enemy { get { return _enemy; } set { _enemy = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Level { get { return _level; } set { _level = value; } }
        public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }
        public int Health { get { return _health; } set { _health = value; } }
        public int Attack { get { return _attack; } set { _attack = value; } }
        public int Defense { get { return _defense; } set { _defense = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
       

        public Entity(string name, int level, int maxHealth, int attack, int defense, int armor)
        {
            _name = name;
            _level = level;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attack = attack;
            _defense = defense;
            _armor = armor;
        }
        public abstract int CombatAttack(int damage);

        public abstract int Defend();

    }
}
