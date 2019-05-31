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

        public Game Game
        {
            get { return Game; }
            set { Game = value;}
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


        public void MainMenu()
        {
            Console.WriteLine("What would you like to do before your day starts?");
            Console.WriteLine("check inventory, go to Store, check recipe, check weather, check wallet, start day.");
            string input = Console.ReadLine();
            while (true)
            {
                input = "inventory";
                {
                Inventory.InventoryCheck();
                }
                input = "store";
                {
                Store.DisplayStoreMenu();
                }
                input = "Recipe";
                {
                Recipe.DisplayRecipeMenu();
                }
                input = "weather";
                {
                Weather.DisplayWeatherConditions();
                }
                input = "wallet";
                {
                CheckWallet();
                }
                input = "start day";
                {
                ClickToStartDay();
                }
            }
        }

        public void CheckWallet()
        {
            //UI.DisplayCash();
            //displays current cash in wallet
        }
        public void ClickToStartDay()
        {

        }




    }
}