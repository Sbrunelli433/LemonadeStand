﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Store
    {
        public decimal priceOfIce;
        public decimal priceOfLemons;
        public decimal priceOfSugar;
        public decimal priceOfCups;
        public List<string> stock;

        //Constructors
        public Store()
        {
            List<string> stock = new List<string>();
            stock.Add("Ice");
            stock.Add("Lemons");
            stock.Add("Sugar");
            stock.Add("Cups");


            priceOfIce = .01m;
            priceOfLemons = .75m;
            priceOfSugar = .50m;
            priceOfCups = .30m;


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

        public void SellCups()
        {
            //sell 25 paper cups for $0.90
            //sell 50 paper cups for $1.70
            //sell 100 paper cups for $2.80
            throw new System.NotImplementedException();
        }
    }
}