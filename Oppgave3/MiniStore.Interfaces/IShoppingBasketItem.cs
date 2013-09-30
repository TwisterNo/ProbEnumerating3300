using MiniStore.Database;

namespace MiniStore.Interfaces
{
    public interface IShoppingBasketItem
    {
        int Id { get; set; }

        Product Product { get; set; }
        int Quantity { get; set; }
        decimal LineSum { get; set; } 

        IShopppingBasket InBasket { get; set; }
    }
}