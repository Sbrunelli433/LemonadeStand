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
        public static int cupsPerPitcher = 15;

        public void DisplayRecipeMenu()
        {
            bool isOut = true;
            while (isOut)
            {
                Console.WriteLine("welcome to the Recipe Menu! What would you like to do? Set Price for each cup? Add Ice? Add Lemons? Add Sugar? exit to exit.");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "price":
                        SetPricePerCup();
                        DisplayPrice();
                        break;
                    //case "ice":
                    //    int AddIce(Player player, Inventory inventory);
                    //    break;
                    //case "lemons":
                    //    int AddLemons(Player player, Inventory inventory)
                    //    break;
                    //case "sugar":
                    //    int AddSugar(player, inventory);
                    //    break;
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


            public int AddIce(Player player, Inventory inventory)
            {
                Console.WriteLine("how much ice per cup would you like to use?");
                quantity = Int32.Parse(Console.ReadLine());
                switch (quantity)
                {
                    case 1:
                        quantity - inventory.Ice;
                        //MixLemonade();
                        break;

                    default:
                        inventory.Ice = 0;
                        Console.WriteLine("you do not have enough Ice! Purchase more from the store");
                        Console.ReadLine();
                        break;
                }
                return quantity;
            }

            public int AddLemons(Player player, Inventory inventory)
            {
                Console.WriteLine("how many lemons per pitcher would you like to use?");
                quantity = Int32.Parse(Console.ReadLine());
                switch (quantity)
                {
                    default:
                        inventory.Lemons = 0;
                        Console.WriteLine("you do not have enough Lemons! Purchase more from the store");
                        Console.ReadLine();
                        break;
                }
                return quantity;
            }

            public int AddSugar(Player player, Inventory inventory)
            {
                Console.WriteLine("how much sugar per pitcher would you like to use?");
                quantity = Int32.Parse(Console.ReadLine());
                switch (quantity)
                {
                    default:
                        inventory.Sugar = 0;
                        Console.WriteLine("you do not have enough Sugar! Purchase more from the store");
                        Console.ReadLine();
                        break;
                }
                return quantity;
            }

            public void MixLemonade(Player player, Inventory inventory)
            {
                inventory.Ice -= AddIce(player, inventory);
                inventory.Lemons -= AddLemons(player, inventory);
                inventory.Sugar -= AddSugar(player, inventory);

            }
            public void DisplayPrice()
            {
                Console.WriteLine("the price per cup for today is set at " + price);
            }
    }
    }

//every qty of lemons and sugar used goes into 1 pitcher
//ice per cup
