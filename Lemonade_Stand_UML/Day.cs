using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Day
    {
        public int Weather;
        public int LengthOfDay;

        public Weather Weather1
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