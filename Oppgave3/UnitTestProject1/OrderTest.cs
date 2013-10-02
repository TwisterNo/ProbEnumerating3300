using System;
using System.CodeDom;
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


        [TestMethod]
        public void Test_AreEqual_Id()
        {
            //Arrange
            var order = new Order(10, 200);
            order.Id = 0;
            
            //Act
            var actual = order.Id;
            var expected = 0;
            
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            //Arrange
            var order = new Order(10, 200);
            order.Id = 1;

            //Act
            var actual = order.Id;
            var expected = 0;

            //Assert
            Assert.AreNotEqual(expected, actual);

        }

        //[TestMethod]
        //public void Test_AreEqual_Customer()
        //{
        //    var customer = new Customer("Id", "Name", "Email", EnumOrder);

        //    order.Customer = customer;

        //    Assert.AreEqual(customer, order.Customer);
        //}

        //[TestMethod]
        //public void Test_AreNotEqual_Customer()
        //{
        //    var expected = new Customer("Id2", "Name", "Email", EnumOrder);
        //    var customer = new Customer("Id", "Name", "Email", EnumOrder);
            
        //    order.Customer = customer;

        //    Assert.AreNotEqual(expected, order.Customer);
        //}

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
            //Arrange
            var order = new Order(4.00m, 200.00m);

            //Act
            var actual = order.TotalSum;
            var expected = 200.00m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_TotalSum()
        {
            var order = new Order(4.00m, 200.00m);

            //Act
            var actual = order.TotalSum;
            var expected = 300.00m;

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreEqual_Discount()
        {
            //Arrange
            var order = new Order(4.00m, 200.00m);

            //Act
            var actual = order.Discount;
            var expected = 4.00m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Discount()
        {
            //Arrange
            var order = new Order(4.00m, 200.00m);

            //Act
            var actual = order.Discount;
            var expected = 5.00m;

            //Assert
            Assert.AreNotEqual(expected, actual);
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
