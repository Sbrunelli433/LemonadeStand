using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Weather : Day
    {
        private int temperature;
        private int forecast;

        public Customer Customer
        {
            get => default;
            set
            {
            }
        }

        public void SetForecast()
        {
            throw new System.NotImplementedException();
        }

        public void OvercastWeather()
        {
            throw new System.NotImplementedException();
        }

        public void SunnyWeather()
        {
            throw new System.NotImplementedException();
        }

        public void HazyWeather()
        {
            throw new System.NotImplementedException();
        }

        public void RainyWeather()
        {
            throw new System.NotImplementedException();
        }
    }
}