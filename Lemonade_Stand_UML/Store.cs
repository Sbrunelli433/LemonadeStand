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
        public decimal priceOfSixty;
        


        //Constructors
        public Store()
        {
            priceOfTwenty = .20m;
            priceOfFourty = .15m;
            priceOfSixty = .12m;

        }


        //public object SellCups(decimal priceOfCups)
        //{
        //    decimal quantity = 25;
        //    decimal cost = (quantity * priceOfCups);
        //    if (Player.Wallet() >= cost)
        //    {
        //        return Player.Inventory.Cups + quantity;
        //    }

        //    //sell 25 paper cups for $0.90
        //    //sell 50 paper cups for $1.70
        //    //sell 100 paper cups for $2.80
        //    throw new System.NotImplementedException();
        //}
        //public void SellIce(decimal priceOfIce)
        //{
        //    if()

        //    //sell 100 ice cubes for priceOfIce;
        //    //sell 250 ice cubes for $1.98
        //    //sell 500 ice cubes for $3.65
        //    throw new System.NotImplementedException();
        //}

        //public void SellLemons(decimal priceOfLemons)
        //{
        //    //sell 10 lemons for $0.60
        //    //sell 30 lemons for $2.17
        //    //sell 75 lemons for $4.08
        //    throw new System.NotImplementedException();
        //}

        //public void SellSugar(decimal priceOfSugar)
        //{
        //    //sell 8 cups of sugar for $0.65
        //    //sell 20 cups of sugar for $1.64
        //    //sell 48 cups of sugar for $3.44
        //    throw new System.NotImplementedException();
        //}


    }
}