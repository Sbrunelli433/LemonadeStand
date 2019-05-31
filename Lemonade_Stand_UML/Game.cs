using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        private object player;
        private object store;
        private object day;
        public List<double> Day;
        public static string name;
       
        public Game()
        {
            player = new Player();
            store = new Store();
            day = new List<Day>();
                Day.Add(1);
                Day.Add(2);
                Day.Add(3);
                Day.Add(4);
                Day.Add(5);
                Day.Add(6);
                Day.Add(7);
        }


        public void RunGame()
        {
            InputName();

        }

        public void InputName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

    }
 

}