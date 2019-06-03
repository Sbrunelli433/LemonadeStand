using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Recipe
    {

        public int quantity;
        public string input;
        public decimal price;
        public int cupsPerPitcher = 15;
        public int icePerPitcher;
        public int lemonsPerPitcher;
        public int sugarPerPitcher;

        public void DisplayRecipeMenu()
        {
            bool isOut = true;
            while (isOut)
            {
                Console.WriteLine("welcome to the Recipe Menu! What would you like to do? Set Price for each cup? Add Ice? Add Lemons? Add Sugar? View recipe? exit to exit.");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "price":
                        SetPricePerCup();
                        DisplayPrice();
                        break;
                    case "ice":
                        AddIce();
                        break;
                    case "lemons":
                        AddLemons();
                        break;
                    case "sugar":
                        AddSugar();
                        break;
                    case "recipe":
                        DisplayRecipe();
                        break;
                    case "exit":
                        isOut = false;
                        break;
                }
            }

        }

            public void SetPricePerCup()
            {
                Console.WriteLine("what is your price per cup for this day?");
                string input = Console.ReadLine();
                {
                    decimal price = decimal.Parse(input, CultureInfo.InvariantCulture);
                }
            }

            public void AddIce()
            {
                Console.WriteLine("how much ice per cup would you like to use?");
                icePerPitcher = Int32.Parse(Console.ReadLine());
                Console.WriteLine("you are using " + icePerPitcher + " ice cubes in each of your pitchers");
                Console.ReadLine();
            }

            public void AddLemons()
            {
                Console.WriteLine("how many lemons per pitcher would you like to use?");
                lemonsPerPitcher = Int32.Parse(Console.ReadLine());
                Console.WriteLine("you are using " + lemonsPerPitcher   + " lemons in each of your pitchers");
                Console.ReadLine();
        }
            public void AddSugar()
            {
            Console.WriteLine("how many cups of sugar per pitcher would you like to use?");
            sugarPerPitcher = Int32.Parse(Console.ReadLine());
            Console.WriteLine("you are using " + sugarPerPitcher + " cups of sugar in each of your pitchers");
            Console.ReadLine();
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("you currently have " + icePerPitcher + " ice cubes in each pitcher");
            Console.WriteLine("you currently have " + lemonsPerPitcher  + " lemons in each pitcher");
            Console.WriteLine("you currently have " + sugarPerPitcher  + " cups of sugar in each pitcher");
            Console.ReadLine();
        }

        public void MixLemonade(Inventory inventory)
        {
            inventory.Ice -= icePerPitcher;
            inventory.Lemons -= lemonsPerPitcher;
            inventory.Sugar -= sugarPerPitcher;
            cupsPerPitcher = 15;
        }
        public void InventoryCheck(Inventory inventory)
        {
            if (inventory.Ice <= icePerPitcher && inventory.Lemons < lemonsPerPitcher && inventory.Sugar < sugarPerPitcher && inventory.Cups < cupsPerPitcher)
            {
                Console.WriteLine("you cannot make any more pitchers of lemonade!");
            }

        }
            public void DisplayPrice()
            {
                Console.WriteLine("the price per cup for today is set at " + price);
            }
        }
    }

