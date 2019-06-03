using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        public static List<Day> days;
        public string name;
        public string[] dayNames;

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

        public Game()
        {
            player = new Player();
            dayNames = new string[] {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            store = new Store();
            days = new List<Day>();
            for (int i = 0; i < 7; i++)
            {
                string dayName = dayNames[i];
                days.Add(new Day(dayName));
            }
        }

        public void RunGame()
        {
            InputName();
            DisplayRules();
            for (int i = 0; i < 7; i++)
            {
                MainMenu(i);
                days[i].weather.SetCondition();
            }
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
        public void Sales(Day day)
        {
            foreach (var customer in day.customers)
            {
                customer.BuyLemonade();
                player.recipe.cupsPerPitcher--;
                player.wallet += player.recipe.price;
            }
        }
        public void MainMenu(int i)
        {
            bool isOver = true;
            while (isOver)
            {

                string input = UserInterface.DisplayHomeScreen();


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
                        days[i].weather.SetCondition();
                        break;
                    case "wallet":
                        player.DisplayWallet();
                        break;
                    case "start day":
                        StartDay(i);
                        isOver = false;
                        break;
                }
            }
        }

        public void StartDay(int i)
        {
            Console.WriteLine("today is " + days[i].dayName);
            days[i].GenerateCustomersForSunny();
            Sales(days[i]);
        }
     }
}
