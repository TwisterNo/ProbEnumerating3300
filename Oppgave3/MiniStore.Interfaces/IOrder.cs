using System.Collections.Generic;

namespace MiniStore.Interfaces
{
    public interface IOrder
    {
        int Id { get; set; }
        ICustomer Customer { get; set; }        
        IEnumerable<IOrderLine> OrderLines { get; }
        decimal TotalSum { get; }
        decimal Discount { get; }
        void AddOrderLine(IOrderLine line);
    }
}