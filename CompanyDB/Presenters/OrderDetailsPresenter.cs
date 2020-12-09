using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CompanyDB
{
    class OrderDetailsPresenter
    {
        private IOrderDetails view;

        public OrderDetailsPresenter(IOrderDetails orderDetailsView)
        {
            view = orderDetailsView;

            view.OrderDetailsUpdated += View_OrderDetailsUpdated;
        }

        private void View_OrderDetailsUpdated(object sender, OrderDetailsEventArgs e)
        {
            Debug.WriteLine($"Updated details: {e.details.Id}");

            using (var db = new everyloopNETContext())
            {
                if (db.Database.CanConnect())
                {
                    var details = db.OrderDetails.FirstOrDefault(d => d.Id == e.details.Id);

                    if (details != null)
                    {
                        details.ProductId = e.details.Product.Id;
                        details.UnitPrice = e.details.Product.UnitPrice;
                        details.Quantity = e.details.Quantity;
                    }

                    var trackedObjects = db.ChangeTracker.Entries();

                    db.SaveChanges();
                }
            }
        }

        public void LoadProducts(ICollection<Product> products)
        {
            view.Products = products;
        }

        public void UpdateOrderDetails(Order order)
        {
            view.Details = order.OrderDetails;
        }
    }
}
