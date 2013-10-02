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
            
        }
    }
}
