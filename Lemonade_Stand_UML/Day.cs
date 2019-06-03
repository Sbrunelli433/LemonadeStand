using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Day
    {
        public List<Customer> customers;
        public Weather weather;

        //public Random number generator

        public Day()
        {
            customers = new List<Customer>()
            {
                new EasyCustomer(),
                new StingyCustomer(),
                new SourCustomer(),
                new SweetCustomer(),
                new ColdCustomer(),
                new DifficultCustomer(),
            };
            weather = new Weather();
        }

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public Weather Weather
        {
            get => default;
            set
            {
            }
        }

        public void GenerateCustomersForSunny()
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);

            for (int i = 0; i < 150; i++)
            {
                switch (customer)
                {
                    case 1:
                        customers.Add(new EasyCustomer());
                        break;
                    case 2:
                        customers.Add(new StingyCustomer());
                        break;
                    case 3:
                        customers.Add(new SourCustomer());
                        break;
                    case 4:
                        customers.Add(new SweetCustomer());
                        break;
                    case 5:
                        customers.Add(new ColdCustomer());
                        break;
                    case 6:
                        customers.Add(new DifficultCustomer());
                        break;
                }
            }
        }
        public void GenerateCustomersForCloudy()
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);

            for (int i = 0; i < 100; i++)
            {
                switch (customer)
                {
                    case 1:
                        customers.Add(new EasyCustomer());
                        break;
                    case 2:
                        customers.Add(new StingyCustomer());
                        break;
                    case 3:
                        customers.Add(new SourCustomer());
                        break;
                    case 4:
                        customers.Add(new SweetCustomer());
                        break;
                    case 5:
                        customers.Add(new ColdCustomer());
                        break;
                    case 6:
                        customers.Add(new DifficultCustomer());
                        break;
                }
            }
        }
        public void GenerateCustomersForRain()
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);      

            for (int i = 0; i < 30; i++)
            { 
                switch (customer)
                {
                    case 1:
                        customers.Add(new EasyCustomer());
                        break;
                    case 2:
                        customers.Add(new StingyCustomer());
                        break;
                    case 3:
                        customers.Add(new SourCustomer());
                        break;
                    case 4:
                        customers.Add(new SweetCustomer());
                        break;
                    case 5:
                        customers.Add(new ColdCustomer());
                        break;
                    case 6:
                        customers.Add(new DifficultCustomer());
                        break;
                }
            }
        }

        public void GenerateCustomersForOvercast()
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);

            for (int i = 0; i < 90; i++)
            {
                switch (customer)
                {
                    case 1:
                        customers.Add(new EasyCustomer());
                        break;
                    case 2:
                        customers.Add(new StingyCustomer());
                        break;
                    case 3:
                        customers.Add(new SourCustomer());
                        break;
                    case 4:
                        customers.Add(new SweetCustomer());
                        break;
                    case 5:
                        customers.Add(new ColdCustomer());
                        break;
                    case 6:
                        customers.Add(new DifficultCustomer());
                        break;
                }
            }
        }

        public void GenerateCustomersForHazy()
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);

            for (int i = 0; i < 125; i++)
            {
                switch (customer)
                {
                    case 1:
                        customers.Add(new EasyCustomer());
                        break;
                    case 2:
                        customers.Add(new StingyCustomer());
                        break;
                    case 3:
                        customers.Add(new SourCustomer());
                        break;
                    case 4:
                        customers.Add(new SweetCustomer());
                        break;
                    case 5:
                        customers.Add(new ColdCustomer());
                        break;
                    case 6:
                        customers.Add(new DifficultCustomer());
                        break;
                }
            }
        }

        public void GenerateCustomersForFoggy()
        {
            Random rng = new Random();
            int customer = rng.Next(1, 6);

            for (int i = 0; i < 25; i++)
            {
                switch (customer)
                {
                    case 1:
                        customers.Add(new EasyCustomer());
                        break;
                    case 2:
                        customers.Add(new StingyCustomer());
                        break;
                    case 3:
                        customers.Add(new SourCustomer());
                        break;
                    case 4:
                        customers.Add(new SweetCustomer());
                        break;
                    case 5:
                        customers.Add(new ColdCustomer());
                        break;
                    case 6:
                        customers.Add(new DifficultCustomer());
                        break;
                }
            }

        }
        public void EndDay()
        {
            //display cups sold
            //display end of day money
            //
            
       
        }
    }
}