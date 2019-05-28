using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public abstract class Player
    {
        

        public int Cash;
        public int Lemonade;
        public int InventoryItems;

        public PitcherOfLemonade PitcherOfLemonade
        {
            get => default;
            set
            {
            }
        }

        public Inventory Inventory
        {
            get => default;
            set
            {
                Inventory.PaperCups = 0;
                Inventory.Lemons = 0;
                Inventory.Sugar = 0;
                Inventory.Ice = 0;
            }
        }

        public void BuyInventory()
        {

            throw new System.NotImplementedException();
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
            Console.WriteLine("how many lemons per pitcher would you like to use?");
            Inventory.Lemons - Console.ReadLine();

            throw new System.NotImplementedException();
        }

        public void SetSugarQty()
        {
            Console.WriteLine("How many cups of sugar per pitcher would you like to use");
            throw new System.NotImplementedException();
        }

        public void SetIceQty()
        {
            Console.WriteLine("How many ice cubes per cup would you like to use?");
            throw new System.NotImplementedException();
        }

        public void SetPrice()
        {
            Console.WriteLine("what is the price per cup of lemonade?");
            throw new System.NotImplementedException();
        }

        public void MixLemonade()
        {

            throw new System.NotImplementedException();
        }

        public void SellLemonade()
        {
            throw new System.NotImplementedException();
        }


    }
}