using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDB
{
    public class OrderEventArgs : EventArgs
    {
        public Order order { get; set; }

        public OrderEventArgs(Order order)
        {
            this.order = order;
        }
    }
}
