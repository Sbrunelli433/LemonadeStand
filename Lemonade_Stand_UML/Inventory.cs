using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Inventory
    {

        public int cups;
        public int ice;
        public int lemons;
        public int sugar;

        public Recipe Recipe
        {
            get => default;
            set
            {
            }
        }

        public void StorePlayerInventory()
        {
            throw new System.NotImplementedException();
        }
    }
}