using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.BusinessCore;
using MiniStore.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderLineTest
    {
        OrderLine orderLine = new OrderLine(20);

        [TestMethod]
        public void Test_AreEqual_Id()
        {
            int expectedId = 10;

            orderLine.Id = 10;

            Assert.AreEqual(expectedId, orderLine.Id);
        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            int expectedId = 20;

            orderLine.Id = 10;

            Assert.AreNotEqual(expectedId, orderLine.Id);
        }

        [TestMethod]
        public void Test_AreEqual_Quantity()
        {
            int expectedQuantity = 15;

            orderLine.Quantity = 15;

            Assert.AreEqual(expectedQuantity, orderLine.Quantity);
        }

        [TestMethod]
        public void Test_AreNotEqual_Quantity()
        {
            int expectedQuantity = 25;

            orderLine.Quantity = 15;

            Assert.AreNotEqual(expectedQuantity, orderLine.Quantity);
        }

        [TestMethod]
        public void Test_AreEqual_Price()
        {
            int expectedPrice = 20;

            int actualPrice = (int) orderLine.Price;

            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void Test_AreNotEqual_Price()
        {
            int expectedPrice = 25;

            int actualPrice = (int)orderLine.Price;

            Assert.AreNotEqual(expectedPrice, actualPrice);
        }

        /*
        [TestMethod]
        public void Test_AreEqual_Order()
        {

        }

        [TestMethod]
        public void Test_AreNotEqual_Order()
        {

        }
        */
    }
}
