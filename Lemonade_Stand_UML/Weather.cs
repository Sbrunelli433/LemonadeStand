using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Weather
    {
        public List<string> conditions;
        public int random;

        public Weather()
        {
            Random rng = new Random();
            int temperature = rng.Next(50, 99);




            List<string> conditions = new List<string>();
            conditions.Add("sunny");
            conditions.Add("cloudy");
            conditions.Add("rainy");
            conditions.Add("overcast");
            conditions.Add("hazy");
            conditions.Add("foggy");


        }


        public void SetForecast()
        {
            throw new System.NotImplementedException();
        }

        public void Rain()
        {
            throw new System.NotImplementedException();
        }
    }
}