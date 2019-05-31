using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        private object player;
        private object store;
        public static List<double> day;
        public static string name;
        public Player Player
        {
            get { return Player;}
            set { Player = value; }
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
        public Weather Weather
        {
            get { return Weather; }
            set { Weather = value; }
        }


        public Game()
        {
            player = new Player();
            store = new Store();
            day = new List<double>();
                day.Add(1);
                day.Add(2);
                day.Add(3);
                day.Add(4);
                day.Add(5);
                day.Add(6);
                day.Add(7);
        }


        public void RunGame()
        {

            InputName();
            DisplayRules();
            Player.MainMenu();
            //gameplay FOR LOOP of days
            //counter ++ for each day
            Weather.SetCondition();
            Weather.DisplayWeatherConditions();
            Store.DisplayStoreMenu();

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