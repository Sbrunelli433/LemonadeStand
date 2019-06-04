using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Weather
    {
        public List<string> conditions;
        public string condition;
        public double temperature;

        public Weather()
        {
            Random rng = new Random();
            //temperature
            rng.Next(50, 99);

            conditions = new List<string>();
            conditions.Add("sunny");
            conditions.Add("cloudy");
            conditions.Add("rainy");
            conditions.Add("overcast");
            conditions.Add("hazy");
            conditions.Add("foggy");
            //selects condition from the above list
            rng.Next(0, conditions.Count);
        }

        public void SetCondition()
        {
            Random rng = new Random();
            int conditionIndex = rng.Next(0, conditions.Count);
            condition = conditions[conditionIndex];
            double setTemperature = rng.Next(50, 99);
            temperature = setTemperature;
            Console.ReadLine();
        }
    }
}