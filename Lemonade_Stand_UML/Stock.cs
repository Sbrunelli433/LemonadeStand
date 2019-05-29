using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Stock
    {
        public string Name;
        public decimal Cost;
        public double Quantity;

        public Store Store
        {
            get => default;
            set
            {
            }
        }
    }
}