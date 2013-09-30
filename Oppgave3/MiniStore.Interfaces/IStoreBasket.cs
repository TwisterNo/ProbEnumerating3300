using System.Collections.Generic;
using MiniStore.Database;

namespace MiniStore.Interfaces
{
    public interface IShopppingBasket
    {
        int Id { get; set; }

        IEnumerable<Product> Items { get; set; }
        decimal TotalSum { get;  }

        void AddItemToBasket(IShoppingBasketItem line);

        IOrder CreateOrder(ICustomer customer);
    }
}