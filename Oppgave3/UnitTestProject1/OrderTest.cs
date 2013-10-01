using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.Interfaces;
using MiniStore.BusinessCore;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderTest
    {


        
        private static IEnumerable<Order> EnumOrder;
        private Order order = new Order(10, 200);


        [TestMethod]
        public void Test_AreEqual_Id()
        {
            int id = 0;

            order.Id = 0;

            Assert.AreEqual(id, order.Id);

        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            int id = 1;

            order.Id = 0;

            Assert.AreNotEqual(id, order.Id);

        }

        [TestMethod]
        public void Test_AreEqual_Customer()
        {
            var customer = new Customer("Id", "Name", "Email", EnumOrder);

            order.Customer = customer;

            Assert.AreEqual(customer, order.Customer);
        }

        [TestMethod]
        public void Test_AreNotEqual_Customer()
        {
            var expected = new Customer("Id2", "Name", "Email", EnumOrder);
            var customer = new Customer("Id", "Name", "Email", EnumOrder);
            
            order.Customer = customer;

            Assert.AreNotEqual(expected, order.Customer);
        }

        /*
        [TestMethod]
        public void Test_AreEqual_OrderLines()
        {
            OrderLine ordLine = new OrderLine(20);
            List<OrderLine> orderList = new List<OrderLine>();
            IEnumerable<IOrderLine> expectedOrderLine;

            expectedOrderLine.Add(20);
            orderList.Add(ordLine);
           

            Assert.AreEqual(null, order.OrderLines.GetEnumerator());

        }

        [TestMethod]
        public void Test_AreNotEqual_OrderLines()
        {

        }
        
        */
        [TestMethod]
        public void Test_AreEqual_TotalSum()
        {
            int expectedTotalSum = 200;

            Assert.AreEqual(expectedTotalSum, order.TotalSum);
        }

        [TestMethod]
        public void Test_AreNotEqual_TotalSum()
        {
            int expectedTotalSum = 300;

            Assert.AreNotEqual(expectedTotalSum, order.TotalSum);
        }

        [TestMethod]
        public void Test_AreEqual_Discount()
        {
            int expectedDiscount = 10;

            Assert.AreEqual(expectedDiscount, order.Discount);
        }

        [TestMethod]
        public void Test_AreNotEqual_Discount()
        {
            int expectedDiscount = 30;

            Assert.AreNotEqual(expectedDiscount, order.Discount);
        }

        /*
         *  Test for AddOrderLine
        [TestMethod]
        public void Test_AreEqual_AddOrderLine()
        {
            
        }

        [TestMethod]
        public void Test_AreNotEqual_AddOrderLine()
        {

        }
        */


    }
}
