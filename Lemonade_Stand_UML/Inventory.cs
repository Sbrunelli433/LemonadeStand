using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Inventory
    {
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        private int cups;
        public int Cups
        {
            get { return cups; }
            set { cups = value; }
        }

        private int ice;
        public int Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private int lemons;
        public int Lemons
        {
            get { return lemons; }
            set { lemons = value; }
        }

        private int sugar;
        public int Sugar
        {
            get { return sugar;  }
            set { sugar = value; }
        }
        public Game Game { get; set; }
        public void DisplayInventory()
        {
            Console.WriteLine("you currently have " + cups + " cups in stock");
            Console.WriteLine("you currently have " + ice + " ice cubes in stock");
            Console.WriteLine("you currently have " + lemons + " lemons in stock");
            Console.WriteLine("you currently have " + sugar + " cups of sugar in stock");
            Console.ReadLine();
        }
        
    }
}