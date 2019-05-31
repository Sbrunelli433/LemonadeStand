using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Customer
    {
        private string weatherPreference;
        public string WeatherPreference
        {
            get { return weatherPreference; }
            set { weatherPreference = value; }
        }

        private decimal maxPrice;
        public decimal MaxPrice
        {
            get { return maxPrice; }
            set { maxPrice = value; }
        }

        private decimal minPrice;
        public decimal MinPrice
        {
            get { return minPrice; }
            set { minPrice = value; }
        }

        private int sweetnessPreference;
        public int SweetnessPreference
        {
            get { return sweetnessPreference; }
            set { sweetnessPreference = value; }
        }
        private int sournessPreference;
        public int SournessPreference
        {
            get { return sournessPreference; }
            set { sweetnessPreference = value; }
        }
        private int icePreference;
        public int IcePreference
        {
            get { return icePreference; }
            set { icePreference = value; }
        }
        public Customer()
        {

        }
        public Customer(string weatherPreference, decimal MaxPrice, decimal MinPrice, int SweetnessPreference, int SournessPreference, int IcePreference)
        {


        }


        public Day Day
        {
            get => default;
            set
            {
            }
        }

        public virtual void BuyLemonade()
        {

        }
    }
}