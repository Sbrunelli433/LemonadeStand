using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Player
    {
        public object inventory;
        public object recipe;
        public decimal wallet;
        public static string name;
        



        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = 20.0m;
        }

        public Game Game
        {
            get { return Game; }
            set { Game = value;}
        }

        public void Menu()
        {
            
        }
        public void CheckWallet()
        {
            //UI.DisplayCash();
            //displays current cash in wallet
        }





    }
}