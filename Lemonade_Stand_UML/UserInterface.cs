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
        public static void DisplayWeatherConditions(Weather weather)
        {
            Console.WriteLine("the weather for this condition is " + weather.condition + " ." + "The temperature is " + weather.temperature + " press any key to return to menu");
        }
    }
}
