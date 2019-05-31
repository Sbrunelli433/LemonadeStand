using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class EasyCustomer : Customer
    {
        public EasyCustomer()
        {
            WeatherPreference = "sunny";
            MaxPrice = 99m;
            MinPrice = .01m;
            SweetnessPreference = (0);
            SournessPreference = (0);
            IcePreference = (0);
        }
        public override void BuyLemonade()
        {
            
        }
    }
}