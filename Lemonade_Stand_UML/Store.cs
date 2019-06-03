using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Store
    {
        public Player player;
        public decimal priceOfTwentyFive;
        public decimal priceOfFifty;
        public decimal priceOfOneHundred;
        private decimal cost;
        private int quantity;
        public string input;

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public  void DisplayStoreMenu(Player player, Inventory inventory)
        {
            Console.WriteLine("welcome to the store! What would you like to do? Buy Cups? Buy Ice? Buy Lemons? Buy Sugar? Exit to exit.");
            string input = Console.ReadLine();

            //while loop here
            //bool true
            //bool false breaks out of DisplayStoreMenu() and back to Player.Menu();
            //reference MOST WANTED MENU LOOP
            switch (input)
            {
                case "cups":
                    SellCups(player, inventory);
                    break;
                case "ice":
                    SellIce(player, inventory);
                    break;
                case "lemons":
                    SellLemons(player, inventory);
                    break;
                case "sugar":
                    SellSugar(player, inventory);
                    break;
                case "exit":
                    ExitStore();
                    break;
            }
        }


        public void SellCups(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Cups would you like to buy? 25? 50? 100?");
            quantity = Int32.Parse(Console.ReadLine());
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Cups += quantity;
                    Console.WriteLine("you purchased 25 Cups, for " + .75m + "and have been added to your inventory. Press any key to continue.");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Cups += quantity;
                    Console.WriteLine("you purchased 50 Cups, for " + 1.25m + "and have been added to your inventory. Press any key to continue.");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Cups += quantity;
                    Console.WriteLine("you purchased 100 Cups, for " + 2.25m + "and have been added to your inventory. Press any key to continue.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type '25', '50' or '100'");
                    quantity = Int32.Parse(Console.ReadLine());
                    break;
            }
        }



        public void SellIce(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Ice Cubes would you like to buy? 25? 50? 100?");
            quantity = Int32.Parse(Console.ReadLine());
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Ice += quantity;
                    Console.WriteLine("you purchased 25 ice cubes, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Ice += quantity;
                    Console.WriteLine("you purchased 50 Cups, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Ice += quantity;
                    Console.WriteLine("you purchased 100 Cups, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    quantity = Int32.Parse(Console.ReadLine());
                    break;
            }
        }
        public void SellLemons(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Lemons would you like to buy? 25? 50? 100?");
            quantity = Int32.Parse(Console.ReadLine());
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Lemons += quantity;
                    Console.WriteLine("you purchased 25 Lemons, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Lemons += quantity;
                    Console.WriteLine("you purchased 50 Lemons, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Lemons += quantity;
                    Console.WriteLine("you purchased 100 Lemons, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    quantity = Int32.Parse(Console.ReadLine());
                    break;
            }
        }

        public void SellSugar(Player player, Inventory inventory)
        {
            Console.WriteLine("how many Lemons would you like to buy? 25? 50? 100?");
            quantity = Int32.Parse(Console.ReadLine());
            switch (quantity)
            {
                case 1:
                    quantity = 25;
                    cost = priceOfTwentyFive;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Sugar += quantity;
                    Console.WriteLine("you purchased 25 cups of sugar, for " + .75m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;

                case 2:
                    quantity = 50;
                    cost = priceOfFifty;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Sugar += quantity;
                    Console.WriteLine("you purchased 50 Cups of sugar, for " + 1.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                case 3:
                    quantity = 100;
                    cost = priceOfOneHundred;
                    player.CheckWallet();
                    player.wallet -= cost;
                    inventory.Sugar += quantity;
                    Console.WriteLine("you purchased 100 Cups of sugar, for " + 2.25m + "and have been added to your inventory");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("invalid input, please type 25, 50 or 100");
                    quantity = Int32.Parse(Console.ReadLine());
                    break;
            }
        }
        public void ExitStore()
        {
            player.MainMenu();
        }

    }
}