using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Player
    {
        public object inventory;
        public object recipe;
        private decimal wallet;

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = 20.0m;
        }
        public void BuyItems()
        {
            throw new System.NotImplementedException();
        }
    }
}