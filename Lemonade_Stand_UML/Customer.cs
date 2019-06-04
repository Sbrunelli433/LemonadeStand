using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Customer
    {
        //private string weatherPreference;
        //public string WeatherPreference
        //{
        //    get { return weatherPreference; }
        //    set { weatherPreference = value; }
        //}

        //private decimal maxPrice;
        //public decimal MaxPrice
        //{
        //    get { return maxPrice; }
        //    set { maxPrice = value; }
        //}

        //private decimal minPrice;
        //public decimal MinPrice
        //{
        //    get { return minPrice; }
        //    set { minPrice = value; }
        //}

        //private int sweetnessPreference;
        //public int SweetnessPreference
        //{
        //    get { return sweetnessPreference; }
        //    set { sweetnessPreference = value; }
        //}
        //private int sournessPreference;
        //public int SournessPreference
        //{
        //    get { return sournessPreference; }
        //    set { sournessPreference = value; }
        //}
        //private int icePreference;
        //public int IcePreference
        //{
        //    get { return icePreference; }
        //    set { icePreference = value; }
        //}
        private double temperature;
        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public Customer()
        {
            bool willBuy = true;
            if (willBuy == true)
            {
                //BuyLemonade();
            }
            else
            {
                willBuy = false;
            }
        }
        public bool willBuy;

        public virtual void BuyLemonade(Weather weather, Recipe recipe)
        {
            Random rng = new Random();
            rng.Next(50, 99);

            weather.SetCondition();
            if (weather.temperature  > 60)
            {
                willBuy = true;
            }
            else if (weather.temperature != rng.Next(50, 99))
            {
                willBuy = false;
            }
        }
    }
}