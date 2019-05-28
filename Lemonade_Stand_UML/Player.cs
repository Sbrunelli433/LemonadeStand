using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Player : Game
    {
        private int Inventory;
        private int Popularity;
        private int Cash;
        private int CustomerSatisfaction;

        public Lemonade Lemonade
        {
            get => default;
            set
            {
            }
        }

        public void BuyPaperCups()
        {
            throw new System.NotImplementedException();
        }

        public void BuyLemons()
        {
            throw new System.NotImplementedException();
        }

        public void BuyIce()
        {
            throw new System.NotImplementedException();
        }

        public void BuySugar()
        {
            throw new System.NotImplementedException();
        }

        public void SetLemonsQty()
        {
            throw new System.NotImplementedException();
        }

        public void SetSugarQty()
        {
            throw new System.NotImplementedException();
        }

        public void SetIceQty()
        {
            throw new System.NotImplementedException();
        }

        public void SetPrice()
        {
            throw new System.NotImplementedException();
        }

        public void MixLemonade()
        {
            throw new System.NotImplementedException();
        }
    }
}