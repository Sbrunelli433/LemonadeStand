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
        private int pitcherOfLemonade;

        public int PitcherOfLemonade
        {
            get { return pitcherOfLemonade; }
            set { pitcherOfLemonade = value; }
        }
        public string input;
  

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();

            wallet = 20.0m;

        }

        //public Game Game { get; set; }
        //public Lemonade Lemonade { get; set; }

        //public Inventory Inventory { get; set; }

        //public Store Store{ get; set; }


        //public Recipe Recipe { get; set; }

        //public Weather Weather { get; set; }



        

        public void DisplayWallet()
        {
            Console.WriteLine("You currently have $" + wallet + " in your wallet");
            Console.ReadLine();
            //UI.DisplayCash();
            //displays current cash in wallet
        }


        public void CheckWallet()
        {

        }
        public void ClickToStartDay()
        {

        }




    }
}