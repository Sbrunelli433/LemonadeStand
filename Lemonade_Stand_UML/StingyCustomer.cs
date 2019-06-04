using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class StingyCustomer : Customer
    {
        public StingyCustomer()
        {
            //WeatherPreference = "sunny";
            //MaxPrice = 99m;
            //MinPrice = .01m;
            //SweetnessPreference = (0);
            //SournessPreference = (0);
            //IcePreference = (0);
            double minValue = 50;
            double maxValue = 99;
            Temperature = minValue - maxValue;
        }
        public override void BuyLemonade(Weather weather, Recipe recipe)
        {
            if (true)
            {
                recipe.cupsPerPitcher--;
            }
        }
    }
}


