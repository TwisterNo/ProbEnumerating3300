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

        [TestMethod]
        public void Test_AreEqual_Items()
        {
            //Arrange
            StoreBasket shopItem = new StoreBasket(20m);

            //Assert
            Assert.IsNull(shopItem.Items);

        }

        [TestMethod]
        public void Test_AreEqual_TotalSum()
        {
            //Arrange
            var basket = new StoreBasket(30.00m);
            
            //Act 
            var actual = basket.TotalSum;
            var expected = 30.00m;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreNotEqual_TotalSum()
        {
            //Arrange
            var basket = new StoreBasket(30.00m);

            //Act 
            var actual = basket.TotalSum;
            var expected = 3.00m;

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AreEqual_AddItemToBasket()
        {
            //Arrange
            var basket = new StoreBasket(20m);
            IShoppingBasketItem shopItem = new ShoppingBasketItem();
            shopItem.LineSum = 20;
            basket.AddItemToBasket(shopItem);

            //Assert
            Assert.AreEqual(basket.Id, 2);

        }


        [TestMethod]
        public void Test_AreEqual_CreateOrder()
        {
            //Arrange
            var basket = new StoreBasket(20m);
            ICustomer customer = new Customer("", "hello", "hello@not");
           
            //Act
            var actual = basket.CreateOrder(customer);
 
            //Assert
            Assert.IsNull(actual);


        }

    }
}
