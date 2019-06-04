using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_UML
{
    public static class UserInterface
    {
        public static string DisplayHomeScreen()
        {
            Console.WriteLine("What would you like to do before your day starts?");
            Console.WriteLine("check inventory, go to Store, check recipe, check weather, check wallet, start day, exit to exit.");
            return Console.ReadLine().ToLower();
        }

        public static void DisplayDailyReport()
        {
            Console.WriteLine("End of day report: ");
            Console.WriteLine("Cups sold: " );
            Console.WriteLine("Pitchers of lemonade made: ");
            Console.WriteLine("Total Sales: ");

        }
        public static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine("you currently have " + recipe.icePerPitcher + " ice cubes in each pitcher");
            Console.WriteLine("you currently have " + recipe.lemonsPerPitcher + " lemons in each pitcher");
            Console.WriteLine("you currently have " + recipe.sugarPerPitcher + " cups of sugar in each pitcher");
            Console.ReadLine();
        }
        public static void DisplayWeatherConditions(Weather weather)
        {
            Console.WriteLine("the weather for this condition is " + weather.condition + " ." + "The temperature is " + weather.temperature + " press any key to return to menu");
        }
        public static void SetPriceForCup()
        {
            Console.WriteLine("what is your price per cup for this day?");

        }
        public static void AddIceToPitcher()
        {
            Console.WriteLine("how much ice per pitcher would you like to use?");
            Console.ReadLine();
        }
    }
}
