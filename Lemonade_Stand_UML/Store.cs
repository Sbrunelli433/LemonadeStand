using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Store
    {
        public int PriceOfIce;
        public int PriceOfLemons;
        public int PriceOfSugar;
        public int PriceOfPaperCups;

        //Constructors
        public Store(int PriceOfIce, int PriceOfLemons, int PriceOfSugar, int PriceOfPaperCups)
        { 
            this.PriceOfIce = PriceOfIce;
            this.PriceOfLemons = PriceOfLemons;
            this.PriceOfSugar = PriceOfSugar;
            this.PriceOfPaperCups = PriceOfPaperCups;
        }

        public void SellIce()
        {
            
            //sell 100 ice cubes for $0.95
            //sell 250 ice cubes for $1.98
            //sell 500 ice cubes for $3.65
            throw new System.NotImplementedException();
        }

        public void SellLemons(int PriceOfLemons)
        {
            //sell 10 lemons for $0.60
            //sell 30 lemons for $2.17
            //sell 75 lemons for $4.08
            throw new System.NotImplementedException();
        }

        public void SellSugar(int PriceOfSugar)
        {
            //sell 8 cups of sugar for $0.65
            //sell 20 cups of sugar for $1.64
            //sell 48 cups of sugar for $3.44
            throw new System.NotImplementedException();
        }

        public void SellPaperCups()
        {
            //sell 25 paper cups for $0.90
            //sell 50 paper cups for $1.70
            //sell 100 paper cups for $2.80
            throw new System.NotImplementedException();
        }
    }
}