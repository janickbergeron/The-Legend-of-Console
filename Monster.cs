using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Monster : Entity
    {
        public Monster(string name, int level, int maxHealth, int minDamage,int maxDamage, int defence, int armor, Entity enemy) : base(name, level, maxHealth, minDamage,maxDamage, defence, armor)
        {
            Enemy = enemy;
        } //Monster Constructor
        public static List<Coordinate> MonsterPosition()
        {
            int[] position = new int[2];
            List<Coordinate> CoordList = new List<Coordinate>();

            for (int i = 0; i < 16; i++)
            {
                int compteur = 0;
                foreach (char n in Display.MainTab[i])
                {
                    if (n != 'M')
                        compteur++;
                    else
                    {
                        position[0] = compteur;
                        position[1] = i;
                        compteur++;
                        Coordinate Coord = new(position[0], position[1]);
                        CoordList.Add(Coord);
                    }
                }
            }
            return CoordList;
        } //Function that returns a list of coordinate for all monster on the gameboard.
        public override int CombatAttack(int minDamage, int maxDamage)
        {
            Random rand = new Random();
            int damage = rand.Next(minDamage,maxDamage);
            int FinalDamage = damage - this.Enemy.Armor;
            if (FinalDamage < 0)
            {
                FinalDamage = 0;
            }
            this.Enemy.Health -= FinalDamage;
            return damage;
        }    //monster's combat attack function.
        public override int Defend()
        {
            Armor = 0;
            Armor += Defense;
            return Armor;
        } //monster's combat defend function.
        public int ChooseAction()
        {
                Random random = new Random();
                int choice = random.Next(1, 3);
                if (choice == 1)
                    return 1;
                else
                    return 2;
        } //monster's combat Choose action function.
        public void ExecuteAction(int action)
        {
            switch (action)
            {
                case 1:
                    Combat.CombatLogProcess();
                    int damage = CombatAttack(MinDamage,MaxDamage);
                    Combat.CombatLog.Add(String.Format("║ The {0,-8} inflict {1,-2} Damage.                                    {2,5}", Program.monster.Name, damage, "║"));
                    break;
                case 2:
                    Combat.CombatLogProcess();
                    int defend = Defend();
                    Combat.CombatLog.Add(String.Format("║ The {0,-8} prepare to prevent the next {1,-2} Damage.                {2,5}", Program.monster.Name, defend, "║"));
                    break;
            }
        } //Execute monster's combat choice of action.
    }
}
