using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public abstract class Customer
    {
        private int weatherPreference;
        private int maxPrice;
        private int minPrice;
        private int sweetnessPreference;
        private int sournessPreference;
        private int icePreference;

        public void BuyLemonade()
        {
            throw new System.NotImplementedException();
        }
    }
}