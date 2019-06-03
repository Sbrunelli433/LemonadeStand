using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        public static List<double> days;
        public string name;

        private Player player;
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        private Store store;
        public Store Store
        {
            get { return store; }
            set { store = value; }
        }
        private Day day;
        public Day Day
        {
            get { return day; }
            set { day = value; }
        }

        public Game()
        {
            day = new Day();
            player = new Player();
            store = new Store();
            days = new List<double>();
            days.Add(1);
            days.Add(2);
            days.Add(3);
            days.Add(4);
            days.Add(5);
            days.Add(6);
            days.Add(7);
        }


        public void RunGame()
        {

            InputName();
            DisplayRules();
            MainMenu();
            //gameplay FOR LOOP of days
            //counter ++ for each day
            day.weather.SetCondition();
            day.weather.DisplayWeatherConditions();
            store.DisplayStoreMenu(player, player.inventory);

        }

        public void InputName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Greetings " + name + "! you are about to start your own lemonade stand with $20.00 in your Wallet. To begin, you need to buy ingredients from the Store and create your lemonade recipe.");
            Console.WriteLine("If you do not run out of money, this game will lasy 7 days. Press any key to go to the menu.");
            Console.ReadLine();
        }
        public void MainMenu()
        {
            bool isOver = true;
            while (isOver)
            {
                Console.WriteLine("What would you like to do before your day starts?");
                Console.WriteLine("check inventory, go to Store, check recipe, check weather, check wallet, start day, exit to exit.");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "inventory":
                        player.inventory.DisplayInventory();
                        break;
                    case "store":
                        store.DisplayStoreMenu(player, player.inventory);
                        break;
                    case "recipe":
                        player.recipe.DisplayRecipeMenu();
                        break;
                    case "weather":
                        day.weather.DisplayWeatherConditions();
                        break;
                    case "wallet":
                        player.DisplayWallet();
                        break;
                    case "start day":
                        player.ClickToStartDay();
                        break;
                    case "Exit":
                        isOver = false;
                        break;
                }
            

            }

        }
        public void ReturnToMainMenu()
        {
            MainMenu();
        }


    }

}
