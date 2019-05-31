using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Player
    {
        public object Inventory;
        public object recipe;
        public decimal Wallet;
        public static string name;
        



        public Player()
        {
            Inventory = new Inventory();
            recipe = new Recipe();
            Wallet = 20.0m;
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public void CheckWallet()
        {
            //UI.DisplayCash();
            //displays current cash in wallet
        }



    }
}