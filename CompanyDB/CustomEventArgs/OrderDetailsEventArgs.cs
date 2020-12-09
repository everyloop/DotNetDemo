using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDB
{
    public class OrderDetailsEventArgs : EventArgs
    {
        public OrderDetail details { get; set; }

        public OrderDetailsEventArgs(OrderDetail details)
        {
            this.details = details;
        }
    }
}
