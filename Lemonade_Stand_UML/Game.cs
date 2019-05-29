using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        public string player;
        public int lengthOfGame;
        public int customer;
        public List<int> numberOfDays;
        private int store;

        public Player Player1
        {
            
            get => default;
            set
            {
            }


        }

        public Store Store
        {
            get => default;
            set
            {

            }
        }

        public Customer Customer1
        {
            get => default;
            set
            {
            }
        }

        public void SetGameLength()
        {
            this.numberOfDays = new List<int>();
            numberOfDays.Add(1);
            numberOfDays.Add(2);
            numberOfDays.Add(3);
            numberOfDays.Add(4);
            numberOfDays.Add(5);
            numberOfDays.Add(6);
            numberOfDays.Add(7);

            throw new System.NotImplementedException();
        }

        public void CalcTotalIncome()
        {
            throw new System.NotImplementedException();
        }

        public void CalcTotalExpenses()
        {
            throw new System.NotImplementedException();
        }

        public void CalcBottomLine(int CalcTotalIncome, int CalcTotalExpenses)
        {
            int CalcBottomLine = CalcTotalExpenses - CalcTotalIncome;
            throw new System.NotImplementedException();
        }

        public void GoToStore()
        {
            Player.BuyItemsFromStore();

            throw new System.NotImplementedException();
        }

        public void GoToRecipe()
        {
            throw new System.NotImplementedException();
        }

        public void RunGame()
        {

            throw new System.NotImplementedException();
        }
    }
}