using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.Interfaces;

namespace MiniStore.BusinessCore
{
    class Order : IOrder
    {
        public Order(decimal discount, decimal totalSum, IEnumerable<IOrderLine> orderLines)
        {
            OrderLines = orderLines;
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
 
           
        }
    }
}
