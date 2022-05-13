using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    public class Recipe
    {
        public static List<Recipe> RecipeList = new List<Recipe>();
        private int _numberMaterial1;
        private int _numberMaterial2;
        private int _numberMaterial3;
        private Item _material1;
        private Item _material2;
        private Item _material3;
        private Item _itemToCraft;

        public int NumberMaterial1 { get { return _numberMaterial1; } set { _numberMaterial1 = value; } }
        public int NumberMaterial2 { get { return _numberMaterial2; } set { _numberMaterial2 = value; } }
        public int NumberMaterial3 { get { return _numberMaterial3; } set { _numberMaterial3 = value; } }
        public Item Material1 { get { return _material1; }set { _material1 = value; } }
        public Item Material2 { get { return _material2; }set { _material2 = value; } }
        public Item Material3 { get { return _material3; } set { _material3 = value; } }
        public Item ItemToCraft { get { return _itemToCraft; } set { _itemToCraft = value; } }

        public Recipe(Item material1, int numberMaterial1, Item material2, int numberMaterial2, Item material3, int numberMaterial3, Item itemToCraft)
        {
            _material1 = material1;
            _material2 = material2;
            _material3 = material3;
            _numberMaterial1 = numberMaterial1;
            _numberMaterial2 = numberMaterial2;
            _numberMaterial3 = numberMaterial3;
            _itemToCraft = itemToCraft;
        }

        public static Recipe CreateRecipe(int p_itemToCraft, int material1, int numberMaterial1, int material2, int numberMaterial2, int material3, int numberMaterial3, List<Item> itemList)
        {
            Item Material1 = Item.CreateItem(material1, Item.MaterialList);
            Item Material2 = Item.CreateItem(material2, Item.MaterialList);
            Item Material3 = Item.CreateItem(material3, Item.MaterialList);
            Item itemToCraft = Item.CreateItem(p_itemToCraft, itemList);
            Recipe recipe = new(Material1, numberMaterial1, Material2, numberMaterial2, Material3, numberMaterial3, itemToCraft);
            return recipe;
        }
    }
}
