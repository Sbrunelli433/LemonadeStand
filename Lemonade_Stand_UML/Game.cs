using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemonade_Stand_UML
{
    public class Game
    {
        public string Player;
        public int LengthOfGame;
        public int Customer;
        public List<int> numberOfDays;

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
            List<int>numberOfDays;

            throw new System.NotImplementedException();
        }

        public void SetStartingMoney()
        {
            //set starting money to $20.00

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

        public void RunGame()
        {
            throw new System.NotImplementedException();
        }
    }
}