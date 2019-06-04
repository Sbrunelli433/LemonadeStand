using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade_Stand_UML;


namespace Lemonade_Stand_UML_Test
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void DayNamesTest()
        {
            //arrange
            Game game = new Game();
            Player player = new Player();
            Store store = new Store();
            dayNames dayNames = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

            List<Day> day = new List<Day>();

            //act

            //assert
        }

        [TestMethod]
        public void RunGameTest()
        {
            //arrange




            //act

            //assert

        }

        [TestMethod]
        public void SalesTest()
        {
            //arrange




            //act

            //assert

        }

        [TestMethod]
        public void MainMenuTest()
        {
            //arrange




            //act

            //assert

        }

        [TestMethod]
        public void StartDayTest()
        {
            //arrange




            //act

            //assert

        }
    }
}
