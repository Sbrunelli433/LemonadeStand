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
        public int random;

        public Weather()
        {
            Random rng = new Random();
            int temperature = rng.Next(50, 99);


           

            conditions = new List<string>();
            conditions.Add("sunny");
            conditions.Add("cloudy");
            conditions.Add("rainy");
            conditions.Add("overcast");
            conditions.Add("hazy");
            conditions.Add("foggy");


            rng.Next(0, conditions.Count);
        }


        public void SetCondition()
        {
            Random rng = new Random();
            int conditionIndex = rng.Next(0, conditions.Count);
            condition = conditions[conditionIndex];
            Console.WriteLine("the weather for this condition is " + condition);
            Console.ReadLine();
        }

        public void Rain()
        {
            throw new System.NotImplementedException();
        }
    }
}