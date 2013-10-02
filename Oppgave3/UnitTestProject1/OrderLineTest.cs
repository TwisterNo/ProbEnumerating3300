using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.BusinessCore;
using MiniStore.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderLineTest
    {
        //OrderLine orderLine = new OrderLine(20);

        [TestMethod]
        public void Test_AreEqual_Id()
        {
            //Arrange
            var orderLine = new OrderLine(20.00m);
            orderLine.Id = 10;

            //Act
            var actual = orderLine.Id;
            var expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            //Arrange
            var orderLine = new OrderLine(20.00m);
            orderLine.Id = 10;

            //Act
            var actual = orderLine.Id;
            var expected = 20;

            Assert.AreNotEqual(expected, actual);
        }

        /*
        [TestMethod]
        public void Test_AreEqual_Product()
        {

        }

        [TestMethod]
        public void Test_AreNotEqual_Product()
        {

        }
         
        */

        [TestMethod]
        public void Test_AreEqual_Quantity()
        {
            //Arrange
            var orderLine = new OrderLine(20.00m);
            orderLine.Quantity = 15;

            //Act
            var actual = 15;
            var expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Quantity()
        {
            //Arrange
            var orderLine = new OrderLine(20.00m);
            orderLine.Quantity = 15;

            //Act
            var actual = 15;
            var expected = 25;

            Assert.AreNotEqual(expected, actual);

        }

        [TestMethod]
        public void Test_AreEqual_Price()
        {
            //Arrange
            var orderLine = new OrderLine(20.00m);

            //Act
            var expected = 20.00m;
            var actual = orderLine.Price;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Price()
        {
            //Arrange
            var orderLine = new OrderLine(20.00m);

            //Act
            var expected = 25.00m;
            var actual = orderLine.Price;

            Assert.AreNotEqual(expected, actual);
           
        }

        
        //[TestMethod]
        //public void Test_AreEqual_Order()
        //{
        //    var orderLine = new OrderLine(10.00m);
        //    var iOrder = orderLine as IOrder;

        //    iOrder.


        //}

        //[TestMethod]
        //public void Test_AreNotEqual_Order()
        //{

        //}
        
    }
}
