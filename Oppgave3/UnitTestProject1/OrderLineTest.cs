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
    }
}
