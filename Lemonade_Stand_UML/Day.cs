using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Day
    {
        public int weather;
        public int lengthOfDay;
        public List<string> customers;
        //public Random number generator



        public Weather Weather
        {
            get => default;
            set
            {
            }
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public void ChangePrice()
        {
            throw new System.NotImplementedException();
        }

        public void DayEndReport()
        {
            throw new System.NotImplementedException();
        }
    }
}