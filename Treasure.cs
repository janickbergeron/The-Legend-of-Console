using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Treasure
    {
        private int _gold;
        private Item _item;

        public int Gold { get { return _gold; } set { _gold = value; } }
        public Item Item { get { return _item;} set { _item = value; } }

        public Treasure(int gold)
        {
            _gold = gold;
        }
        public Treasure(int gold, Item item)
        {
            _gold = gold;
            _item = item;
        }

        public static void TreasureGenerator()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(0, 21);
            Treasure treasure = new(randomnumber);
            Console.WriteLine($"Congratulation! You have found a treasure containing {treasure.Gold} gold.");
            Console.ReadKey();
            Program.player.Gold += treasure.Gold;
        }  //Function to generate a new treasure.
    }
}
