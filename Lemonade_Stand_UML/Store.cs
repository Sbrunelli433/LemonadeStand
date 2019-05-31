using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Store
    {
        public decimal priceOfTwentyFive;
        public decimal priceOfFifty;
        public decimal priceOfOneHundred;
        private decimal cost;
        private int quantity;





        public Game Game
        {
            get => default;
            set
            {
            }
        }

       
        public void SellCups(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Cups would you like to buy? 25? 50? 100?");
            Console.ReadLine();
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Cups += quantity;
                    Console.WriteLine("you purchased 25 Cups, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Cups += quantity;
                    Console.WriteLine("you purchased 50 Cups, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Cups += quantity;
                    Console.WriteLine("you purchased 100 Cups, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    Console.ReadLine();
                    break;
            }
        }
        public void SellIce(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Ice Cubes would you like to buy? 25? 50? 100?");
            Console.ReadLine();
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Ice += quantity;
                    Console.WriteLine("you purchased 25 ice cubes, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Ice += quantity;
                    Console.WriteLine("you purchased 50 Cups, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Ice += quantity;
                    Console.WriteLine("you purchased 100 Cups, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    Console.ReadLine();
                    break;
            }
        }
        public void SellLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Lemons would you like to buy? 25? 50? 100?");
            Console.ReadLine();
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Lemons += quantity;
                    Console.WriteLine("you purchased 25 Lemons, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Lemons += quantity;
                    Console.WriteLine("you purchased 50 Lemons, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Lemons += quantity;
                    Console.WriteLine("you purchased 100 Lemons, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    Console.ReadLine();
                    break;
            }
        }

        public void SellSugar(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Lemons would you like to buy? 25? 50? 100?");
            Console.ReadLine();
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Sugar += quantity;
                    Console.WriteLine("you purchased 25 cups of sugar, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Sugar += quantity;
                    Console.WriteLine("you purchased 50 Cups of sugar, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.Wallet -= cost;
                    inventory.Sugar += quantity;
                    Console.WriteLine("you purchased 100 Cups of sugar, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    Console.ReadLine();
                    break;
            }
        }

    }
}