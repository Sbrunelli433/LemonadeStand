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
                Console.WriteLine("this is the end of the day... you made X amount of money. Check the weather and your inventory to see what you need for the next day");
                Console.ReadLine();
            }
            Console.WriteLine("this is the end of the 7 days. Congrats! You did it! #GetScwifty");
            Console.ReadLine();
            
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
                customer.BuyLemonade(day.weather, player.recipe);
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
                //UserInterface.DisplayWeatherConditions(Weather weather);



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
                        UserInterface.DisplayWeatherConditions(days[i].weather);
                        //Console.WriteLine("The weather is " + days[i].weather.condition + " and it is " + days[i].weather.temperature + " degrees out");
                        Console.ReadLine();
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
            DayEnd(i);
        }
        public void DayEnd(int i)
        {
            Console.WriteLine("it is the end of " + days[i].dayName + " you made a total of " );
        }
     }
}
