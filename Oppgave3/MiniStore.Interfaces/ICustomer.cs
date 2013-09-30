using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MiniStore.Interfaces
{
    public interface ICustomer
    {
        string Id { get; }
        string Name { get; }
        string Email { get; }
        IEnumerable<IOrder> Orders { get; }
    }
}