﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.Database;
using MiniStore.Interfaces;

namespace MiniStore.BusinessCore
{
    public class StoreBasket : IShopppingBasket
    {
        public StoreBasket(decimal totalSum)
        {
            TotalSum = totalSum;
        }

        public int Id { get; set; }
        public IEnumerable<Product> Items { get; set; }
        public decimal TotalSum { get; private set; }
        public void AddItemToBasket(IShoppingBasketItem line)
        {
            Id = 2;
        }

        public IOrder CreateOrder(ICustomer customer)
        {
            return null;
        }
    }
}
