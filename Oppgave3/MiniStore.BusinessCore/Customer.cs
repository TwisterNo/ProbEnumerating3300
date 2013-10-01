

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStore.Interfaces;

namespace MiniStore.BusinessCore
{
    public class Customer : ICustomer
    {
        public Customer(string id, string name, string email, IEnumerable<IOrder> orders)
        {
            Orders = orders;
            Email = email;
            Name = name;
            Id = id;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public IEnumerable<IOrder> Orders { get; private set; }
    }
}
