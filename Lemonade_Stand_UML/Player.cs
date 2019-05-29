using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Player
    {
        private int lemonade;
        public int Lemonade
        {
            get { return lemonade; }
            set { lemonade = value; }
        }

        private decimal cups = 0;
        public decimal Cups
        {
            get { return cups; }
            set { cups = value; }
        }

        private decimal ice = 0;
        public decimal Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        private decimal lemons = 0;
        public decimal Lemons
        {
            get { return lemons; }
            set { lemons = value; }
        }

        private decimal sugar = 0;
        public decimal Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }

        private decimal wallet = 20.0m;
        public decimal Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }

        public Player()
        {
            Lemonade = 0;
            Cups = 0;
            Ice = 0;
            Lemons = 0;
            Sugar = 0;
        }


        //public Player()
        //{ 


        //    lemonade = 0;


        //    //List<string> InventoryItems = new List<string>();
        //    //InventoryItems.Add("cups");
        //    //InventoryItems.Add("lemons");
        //    //InventoryItems.Add("sugar");
        //    //InventoryItems.Add("ice");

        //}
        public Recipe Recipe
        {
            get => default;
            set
            {
            }
        }

        public void BuyItemsFromStore()
        {

        }

        public void BuyCups()
        {
            Console.WriteLine("Would you like to buy 50 Cups?");
            Console.ReadLine();
            if (Wallet >= Store.priceOfCups)
            {
                Console.WriteLine("you purchased 50 cups, they have been added to your inventory");
                Console.ReadLine();
                Cups++;
            }
            else
            {
                Console.WriteLine("You do not have sufficient funds to purchase this. Sell more lemonade to earn more money!");
                Console.ReadLine();
                Game.GoToStore();
            }
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


        public void SellLemonade()
        {
            throw new System.NotImplementedException();
        }

        public void CheckWallet()
        {
            Console.WriteLine("Your wallet currently has" + wallet);
            Console.ReadLine();
            if (wallet <= 0)
                {
                //exit game method...needs to go somewhere....

            }
            throw new System.NotImplementedException();
        }
    }
}