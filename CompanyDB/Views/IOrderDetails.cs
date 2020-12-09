using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDB
{
    interface IOrderDetails
    {
        public ICollection<Product> Products { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
        
        public event EventHandler<OrderDetailsEventArgs> OrderDetailsUpdated;
    }
}
