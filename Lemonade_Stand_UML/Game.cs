using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        private Player player;
        private Store store;
        private Day day;
        public static List<double> days;
        public string name;

        public Player Player
        {
            get { return player;}
            set { player = value; }
        }
        public Lemonade Lemonade
        {
            get { return Lemonade; }
            set { Lemonade = value; }
        }
        public Inventory Inventory
        {
            get { return Inventory; }
            set { Inventory = value; }
        }
        public Store Store
        {
            get { return Store; }
            set { Store = value; }
        }
        public Recipe Recipe
        {
            get { return Recipe; }
            set { Recipe = value; }
        }
        //public Weather Weather
        //{
        //    get { return Weather; }
        //    set { Weather = value; }
        //}


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
            Player.MainMenu();
            //gameplay FOR LOOP of days
            //counter ++ for each day
            day.weather.SetCondition();
            day.weather.DisplayWeatherConditions();
            //player.startDay();
            Store.DisplayStoreMenu(player, player.inventory);

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


    }
 

}