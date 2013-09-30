using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.Database;
using MiniStore.Interfaces;

namespace MiniStore.BusinessCore
{
    class ShoppingBasketItem : IShoppingBasketItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal LineSum { get; set; }
        public IShopppingBasket InBasket { get; set; }
    }
}
