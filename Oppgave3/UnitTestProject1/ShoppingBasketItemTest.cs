using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.BusinessCore;
using MiniStore.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class ShoppingBasketItemTest
    {
        [TestMethod]
        public void Test_AreEqual_Id()
        {
            //Arrange
            var item = new ShoppingBasketItem();
            item.Id = 1;

            //Act
            var actual = item.Id;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            //Arrange
            var item = new ShoppingBasketItem();
            item.Id = 1;

            //Act
            var actual = item.Id;
            var expected = 2;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        //[TestMethod]
        //public void Test_AreEqual_Product()
        //{
            
        //}

        //[TestMethod]
        //public void Test_AreNotEqual_Product()
        //{

        //}

        [TestMethod]
        public void Test_AreEqual_Quantity()
        {
            //Arrange
            var item = new ShoppingBasketItem();
            item.Quantity = 3;

            //Act
            var actual = item.Quantity;
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Quantity()
        {
            //Arrange
            var item = new ShoppingBasketItem();
            item.Quantity = 3;

            //Act
            var actual = item.Quantity;
            var expected = 4;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreEqual_LineSum()
        {
            //Arrange
            var item = new ShoppingBasketItem();
            item.LineSum = 30.00m;

            //Act
            var actual = item.LineSum;
            var expected = 30.00m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_LineSum()
        {
            //Arrange
            var item = new ShoppingBasketItem();
            item.LineSum = 30.00m;

            //Act
            var actual = item.LineSum;
            var expected = 30.50m;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        //[TestMethod]
        //public void Test_AreEqual_InBasket()
        //{
        //    //Arrange
        //    IShoppingBasketItem item = new ShoppingBasketItem();

        //    //Act
           

        //    //Assert
           
        //}

        //[TestMethod]
        //public void Test_AreNotEqual_InBasket()
        //{
        //    //Arrange
            

        //    //Act


        //    //Assert

        //}
    }
}
