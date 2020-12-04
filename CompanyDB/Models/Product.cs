using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace CompanyDB
{
    [DebuggerDisplay("{ProductName}")]
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public int? Discontinued { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public object This { get { return this; } }
    }
}
