using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.Interfaces;

namespace MiniStore.BusinessCore
{
   public class OrderLine : IOrderLine
    {
       public OrderLine(decimal price)
       {
           Price = price;
       }

       public int Id { get; set; }
       public Database.Product Product { get; set; }
        

        public int Quantity { get; set; }

        public decimal Price { get; private set; }

        public IOrder Order { get; set; }
    }
}
