using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade_Stand_UML;

namespace Lemonade_Stand_UML_Test
{
    [TestClass]
    public class InventoryAddTest
    {
        [TestMethod]
        public void SellCups_Add25CupsToInventory()
        {
            //ARRANGE
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Cups = 0;

            int expectedResult = 25;
            int actualResult;

            //player.wallet = 20m;
            //decimal priceOfTwentyFive = .75m;
            //decimal priceOfFifty = 1.25m;
            //decimal priceOfOneHundred = 2.25m;
            //decimal cost = priceOfTwentyFive;
            //decimal player.wallet();
            //int player.inventory.Cups += quantity;

            //ACT
            store.SellCups(player, inventory, 25);
            actualResult = player.inventory.Cups;

            //ASSERT
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SellCups_Add50CupsToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Cups = 0;
            int expectedResult = 50;
            int actualResult;

            //act
            store.SellCups(player, inventory, 50);
            actualResult = player.inventory.Cups;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellCups_Add100CupsToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Cups = 0;
            int expectedResult = 100;
            int actualResult;

            //act
            store.SellCups(player, inventory, 100);
            actualResult = player.inventory.Cups;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void SellIce_Add25IceToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Ice = 0;
            int expectedResult = 25;
            int actualResult;

            //act
            store.SellIce(player, inventory, 25);
            actualResult = player.inventory.Ice;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void SellIce_Add50IceToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Ice = 0;
            int expectedResult = 50;
            int actualResult;

            //act
            store.SellIce(player, inventory, 50);
            actualResult = player.inventory.Ice;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellIce_Add100IceToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Ice = 0;
            int expectedResult = 100;
            int actualResult;

            //act
            store.SellIce(player, inventory, 100);
            actualResult = player.inventory.Ice;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellLemons_Add25LemonsToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Lemons = 0;
            int expectedResult = 25;
            int actualResult;

            //act
            store.SellLemons(player, inventory, 25);
            actualResult = player.inventory.Lemons;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellLemons_Add50LemonsToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Lemons = 0;
            int expectedResult = 50;
            int actualResult;

            //act
            store.SellLemons(player, inventory, 50);
            actualResult = player.inventory.Lemons;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellLemons_Add100LemonsToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Lemons = 0;
            int expectedResult = 100;
            int actualResult;

            //act
            store.SellLemons(player, inventory, 100);
            actualResult = player.inventory.Lemons;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellSugar_Add25SugarToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Sugar = 0;
            int expectedResult = 25;
            int actualResult;

            //act
            store.SellSugar(player, inventory, 25);
            actualResult = player.inventory.Sugar;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellSugar_Add50SugarToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Sugar = 0;
            int expectedResult = 50;
            int actualResult;

            //act
            store.SellSugar(player, inventory, 50);
            actualResult = player.inventory.Sugar;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void SellSugar_Add100SugarToInventory()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.inventory.Sugar = 0;
            int expectedResult = 100;
            int actualResult;

            //act
            store.SellSugar(player, inventory, 100);
            actualResult = player.inventory.Sugar;
            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
