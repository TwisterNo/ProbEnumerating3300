using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.BusinessCore;
using MiniStore.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class StoreBasketTest
    {
        [TestMethod]
        public void Test_AreEqual_Id()
        {
            //Arrange
            var basket = new StoreBasket(30.00m);
            basket.Id = 20;

            //Act
            var actual = basket.Id;
            var expected = 20;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            //Arrange
            var basket = new StoreBasket(30.00m);
            basket.Id = 20;

            //Act
            var actual = basket.Id;
            var expected = 30;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        //[TestMethod]
        //public void Test_AreEqual_Items()
        //{
            
        //}

        //[TestMethod]
        //public void Test_AreNotEqual_Items()
        //{

        //}

        [TestMethod]
        public void Test_AreEqual_TotalSum()
        {
            //Arrange
            var basket = new StoreBasket(30.00m);
            
            //Act 
            var actual = basket.TotalSum;
            var expected = 30.00m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_TotalSum()
        {
            //Arrange
            var basket = new StoreBasket(30.00m);

            //Act 
            var actual = basket.TotalSum;
            var expected = 3.00m;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        //[TestMethod]
        //public void Test_AreEqual_AddItemToBasket()
        //{
            
        //}

        //[TestMethod]
        //public void Test_AreNotEqual_AddItemToBasket()
        //{

        //}

        //[TestMethod]
        //public void Test_AreEqual_CreateOrder()
        //{

        //}

        //[TestMethod]
        //public void Test_AreNotEqual_CreateOrder()
        //{

        //}
    }
}
