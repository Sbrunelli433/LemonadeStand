using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Store
    {
        public decimal priceOfTwenty;
        public decimal priceOfFourty;
        public decimal priceOfHundred;
        


        //Constructors
        public Store()
        {
            priceOfTwenty = .75m;
            priceOfFourty = 1.25m;
            priceOfHundred = 2.25m;
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public void SellCups()
        {

        }
        public void SellIce()
        {

        }
        public void SellLemons()
        {

        }
        
        public void SellSugar()
        {

        }

    }
}