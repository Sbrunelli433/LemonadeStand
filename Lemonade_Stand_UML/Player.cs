using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Player
    {
        public Inventory inventory;
        public Recipe recipe;
        public decimal wallet;
        public string name;
        public string input;

        public bool hasPitcherOfLemonade = true;

  

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();

            wallet = 20.0m;

        }

        public void DisplayWallet()
        {
            Console.WriteLine("You currently have $" + wallet + " in your wallet");
            Console.ReadLine();
            //UI.DisplayCash();
            //displays current cash in wallet
        }


        public void CheckWallet()
        {
            Console.WriteLine(wallet);
        }
        public void ClickToStartDay()
        {

        }




    }
}