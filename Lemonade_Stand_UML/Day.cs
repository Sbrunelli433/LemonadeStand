using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Day
    {
        public int weather;
        public int lengthOfDay;
        public List<Customer> customers;
        private object easyCustomer;
        private object stingyCustomer;
        private object sourCustomer;
        private object sweetCustomer;
        private object coldCustomer;
        private object difficultCustomer;


        //public Random number generator

        public Day()
        {
            easyCustomer = new EasyCustomer();
            stingyCustomer = new StingyCustomer();
            sourCustomer = new SourCustomer();
            sweetCustomer = new SweetCustomer();
            coldCustomer = new ColdCustomer();
            difficultCustomer = new DifficultCustomer();

            customers = new List<Customer>()
            {
                new EasyCustomer(),
                new StingyCustomer(),
                new SourCustomer(),
                new SweetCustomer(),
                new ColdCustomer(),
                new DifficultCustomer(),
            };
        }


        public Weather Weather
        {
            get => default;
            set
            {
            }
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public void GenerateCustomersForRain()
            
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);

            customers = new List<Customer>();


                new EasyCustomer();
                new StingyCustomer();
                new SourCustomer();
                new SweetCustomer();
                new ColdCustomer();
                new DifficultCustomer();
      

            for (int i = 0; i < 50; i++)
            { 
                switch (i)
                {
                    case 1:
                        rng = 1;
                        new EasyCustomer();
                        break;
                    case 2:
                        rng = 2;
                        new StingyCustomer();
                        break;
                    case 3:
                        rng = 3;
                        new SourCustomer();
                        break;
                    case 4:
                        rng = 4;
                        new SweetCustomer();
                        break;
                    case 5:
                        rng = 4;
                        new ColdCustomer();
                        break;
                    case 6:
                        rng = 5;
                        new DifficultCustomer();
                        break;
                }


            }

            throw new System.NotImplementedException();
        }
    }
}