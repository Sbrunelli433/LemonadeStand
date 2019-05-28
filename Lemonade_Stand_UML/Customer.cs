using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public abstract class Customer
    {
        private int WeatherPreference;
        private int MaxPrice;
        private int MinPrice;
        private int SweetnessPreference;
        private int SournessPreference;
        private int IcePreference;

        public void BuyLemonade()
        {
            throw new System.NotImplementedException();
        }
    }
}