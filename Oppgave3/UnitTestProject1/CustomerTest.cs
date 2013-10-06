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

        [TestMethod]
        public void Test_AreEqual_Id()
        {
            //Arrange
            var customer = new Customer("Id", "", "");

            //Act
            var actual = customer.Id;
            var expected = "Id";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Id()
        {
            //Arrange 
            var customer = new Customer("Id", "", "");

            //Act
            var actual = customer.Id;
            var expected = "Wrong Id";

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreEqual_Name()
        {
            //Arrange 
            var customer = new Customer("", "Name", "");

            //Act
            var actual = customer.Name;
            var expected = "Name";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_Name()
        {
            //Arrange 
            var customer = new Customer("", "Name", "");

            //Act
            var actual = customer.Name;
            var expected = "Wrong Name";

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreEqual_Email()
        {
            //Arrange 
            var customer = new Customer("", "", "Email");

            //Act
            var actual = customer.Email;
            var expected = "Email";

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_AreNotEqual_Email()
        {
            //Arrange 
            var customer = new Customer("", "", "Email");

            //Act
            var actual = customer.Email;
            var expected = "Wrong Email";

            //Assert
            Assert.AreNotEqual(expected, actual);

        }


        [TestMethod]
        public void Test_AreEqual_Orders()
        {
            //Arrange 
            var Customer = new Customer("", "", "");

            //Act
            var actual = Customer.Orders;
            object expected = null;

            //Assert
            Assert.AreEqual(expected, actual);
        }

       
    }
}
