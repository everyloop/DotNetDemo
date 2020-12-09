using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDB
{
    interface ICustomerOrders
    {
        public ICollection<Customer> Customers { get; set; }

        public event EventHandler<OrderEventArgs> OrderSelected;

        public event EventHandler<OrderEventArgs> OrderDeleted;
    }
}
