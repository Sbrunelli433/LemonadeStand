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

        public Game()
        {
            player = new Player();
            store = new Store();
            day = new List<Day>();
           



          

        }
        public void RunGame()
        {

        }

    }
 

}