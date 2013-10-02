using System.Security.Cryptography.X509Certificates;
using MiniStore.Database;

namespace MiniStore.Interfaces
{
    public interface IOrderLine:IOrder
    {
        int Id { get; set; }

        Product Product { get; set; }
        int Quantity { get; set; }
        decimal Price { get;  }

        IOrder Order { get; set; }
    }

}
