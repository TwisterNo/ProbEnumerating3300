using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.Interfaces;
using MiniStore.BusinessCore;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderTest
    {

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

        [TestMethod]
        public void Test_AreEqual_Customer()
        {
            //Arrange
            var customer = new Customer("Id", "Name", "Email");
            var order = new Order(10, 200);

            //Act
            order.Customer = customer;
            var expected = customer;

            //Assert
            Assert.AreEqual(expected, order.Customer);
        }

        [TestMethod]
        public void Test_AreNotEqual_Customer()
        {
            //Arrange
            var customer1 = new Customer("Id2", "Name", "Email");
            var customer2 = new Customer("Id", "Name", "Email");
            var order = new Order(10, 200);


            //Act

            order.Customer = customer1;
            var expected = customer2;

            //Assert
            Assert.AreNotEqual(expected, order.Customer);
        }


        [TestMethod]
        public void Test_AreEqual_OrderLines()
        {
            //Arrange
            List<IEnumerable<OrderLine>> list = new List<IEnumerable<OrderLine>>();
            
            //Assert
            Assert.IsTrue(list != null);


        }

        
        
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
            //Arrange
            var order = new Order(4.00m, 200.00m);

            //Act
            var actual = order.TotalSum;
            var expected = 300.00m;

            //Assert
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


        [TestMethod]
        public void Test_AreEqual_AddOrderLine()
        {
            //Arrange
            var order = new Order(10, 200);
            IOrderLine orderline = new OrderLine(20m);
            order.AddOrderLine(orderline);


            //Assert
            Assert.IsNotNull(order.OrderLines != null);


        }        


    }
}
