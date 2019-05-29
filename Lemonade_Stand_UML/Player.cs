using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public abstract class Player
    {
        

        public decimal wallet;
        public int lemonade;
        public string inventoryItems;

         

        public Player()
        {
            wallet = 20.0m;
            lemonade = 0;


            List<string> InventoryItems = new List<string>();
            InventoryItems.Add("cups");
            InventoryItems.Add("lemons");
            InventoryItems.Add("sugar");
            InventoryItems.Add("ice");

        }

        public Inventory Inventory
        {
            get => default;
            set
            {
                Inventory.cups = 0;
                Inventory.lemons = 0;
                Inventory.sugar = 0;
                Inventory.ice = 0;
            }
        }

        public void BuyInventory()
        {

            throw new System.NotImplementedException();
        }

        public void BuyCups()
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


        public void SellLemonade()
        {
            throw new System.NotImplementedException();
        }


    }
}