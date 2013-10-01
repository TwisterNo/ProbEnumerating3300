using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniStore.BusinessCore;
using MiniStore.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerTest
    {
        private static IEnumerable<IOrder> Order;  
        Customer customer = new Customer("Id", "Name", "Email", Order);

        [TestMethod]
        public void Test_AreEqual_Id()
        {
            String Id = "Id";
            Assert.AreEqual(Id, customer.Id);
        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            String Id = "Fail Id";
            Assert.AreNotEqual(Id, customer.Id);
        }

        [TestMethod]
        public void Test_AreEqual_Name()
        {
            String Name = "Name";
            Assert.AreEqual(Name, customer.Name);
        }

        [TestMethod]
        public void Test_AreNotEqual_Name()
        {
            String Name = "Fail name";
            Assert.AreNotEqual(Name, customer.Name);
        }

        [TestMethod]
        public void Test_AreEqual_Email()
        {
            String Email = "Email";
            Assert.AreEqual(Email, customer.Email);
        }

        [TestMethod]
        public void Test_AreNotEqual_Email()
        {
            String Email = "Fail email";
            Assert.AreNotEqual(Email, customer.Email);
        }

        [TestMethod]
        public void Test_AreEqual_Orders()
        {
            IEnumerable<IOrder> Order = null;
            Assert.AreEqual(Order, customer.Orders);
        }

        [TestMethod]
        public void Test_AreNotEqual_Orders()
        {
            IEnumerable<IOrder> Order = null;
            Assert.AreNotEqual(Order, customer.Orders);
        }

        
    }
}
