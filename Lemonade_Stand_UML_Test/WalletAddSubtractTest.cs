using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade_Stand_UML;


namespace Lemonade_Stand_UML_Test
{
    [TestClass]
    public class WalletAddSubtractTest
    {
        [TestMethod]
        public void SellCups_Subtract25CupsCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfTwentyFive = .75m;
            player.wallet = 20.0m;
            int quantity = 25;
            decimal expectedResult = player.wallet - store.priceOfTwentyFive;
            decimal actualResult;

            //act
            store.SellCups(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellCups_Subtract50CupsCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfFifty = 1.25m;
            player.wallet = 20.0m;
            int quantity = 50;
            decimal expectedResult = player.wallet - store.priceOfFifty;
            decimal actualResult;

            //act
            store.SellCups(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellCups_Subtract100CupsCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfOneHundred = 2.25m;
            player.wallet = 20.0m;
            int quantity = 100;
            decimal expectedResult = player.wallet - store.priceOfOneHundred;
            decimal actualResult;

            //act
            store.SellCups(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellIce_Subtract25IceCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfTwentyFive = .75m;
            player.wallet = 20.0m;
            int quantity = 25;
            decimal expectedResult = player.wallet - store.priceOfTwentyFive;
            decimal actualResult;

            //act
            store.SellIce(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellIce_Subtract50IceCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfFifty = 1.25m;
            player.wallet = 20.0m;
            int quantity = 50;
            decimal expectedResult = player.wallet - store.priceOfFifty;
            decimal actualResult;

            //act
            store.SellIce(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellIce_Subtract100IceCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfOneHundred = 2.25m;
            player.wallet = 20.0m;
            int quantity = 100;
            decimal expectedResult = player.wallet - store.priceOfOneHundred;
            decimal actualResult;

            //act
            store.SellIce(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellLemons_Subtract25LemonsCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfTwentyFive = .75m;
            player.wallet = 20.0m;
            int quantity = 25;
            decimal expectedResult = player.wallet - store.priceOfTwentyFive;
            decimal actualResult;

            //act
            store.SellLemons(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellLemons_Subtract50LemonsCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfFifty = 1.25m;
            player.wallet = 20.0m;
            int quantity = 50;
            decimal expectedResult = player.wallet - store.priceOfFifty;
            decimal actualResult;

            //act
            store.SellLemons(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellLemons_Subtract100LemonsCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfOneHundred = 2.25m;
            player.wallet = 20.0m;
            int quantity = 100;
            decimal expectedResult = player.wallet - store.priceOfOneHundred;
            decimal actualResult;

            //act
            store.SellLemons(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellSugar_Subtract25SugarCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfTwentyFive = .75m;
            player.wallet = 20.0m;
            int quantity = 25;
            decimal expectedResult = player.wallet - store.priceOfTwentyFive;
            decimal actualResult;

            //act
            store.SellSugar(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellSugar_Subtract50SugarCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfFifty = 1.25m;
            player.wallet = 20.0m;
            int quantity = 50;
            decimal expectedResult = player.wallet - store.priceOfFifty;
            decimal actualResult;

            //act
            store.SellSugar(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SellSugar_Subtract100SugarCostFromWallet()
        {
            //arrange
            Store store = new Store();
            Player player = new Player();
            Inventory inventory = new Inventory();
            store.priceOfOneHundred = 2.25m;
            player.wallet = 20.0m;
            int quantity = 100;
            decimal expectedResult = player.wallet - store.priceOfOneHundred;
            decimal actualResult;

            //act
            store.SellSugar(player, inventory, quantity);
            actualResult = player.wallet;
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}

