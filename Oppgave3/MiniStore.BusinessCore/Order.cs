﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.Interfaces;

namespace MiniStore.BusinessCore
{
    public class Order : IOrder
    {

        public Order(decimal discount, decimal totalSum)
        {
           
            TotalSum = totalSum;
            Discount = discount;
        }


        public int Id { get; set; }
        public ICustomer Customer { get; set; }
        public IEnumerable<IOrderLine> OrderLines { get; private set; }
        public decimal TotalSum { get; private set; }
        public decimal Discount { get; private set; }
        public void AddOrderLine(IOrderLine line)
        {
            OrderLines = line as IEnumerable<IOrderLine>;
        }
    }
}
