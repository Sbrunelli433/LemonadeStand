using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Inventory : Player
    {
        private int PaperCups;
        private int Ice;
        private int Lemons;
        private int Sugar;

        public Store Store
        {
            get => default;
            set
            {
            }
        }
    }
}