using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CompanyDB
{
    class CustomerOrdersPresenter
    {
        private ICustomerOrders view;
        private OrderDetailsPresenter detailsPresenter;

        public CustomerOrdersPresenter(ICustomerOrders customerOrdersView, OrderDetailsPresenter orderDetailsPresenter)
        {
            view = customerOrdersView;
            detailsPresenter = orderDetailsPresenter;

            view.OrderSelected += View_OrderSelected;
            view.OrderDeleted += View_OrderDeleted;

            using (var db = new everyloopNETContext())
            {

                if (db.Database.CanConnect())
                {
                    var products = db.Products.OrderBy(p => p.ProductName).ToList();

                    detailsPresenter.LoadProducts(products);

                    view.Customers = db.Customers
                        .Include(customer => customer.Orders)
                            .ThenInclude(order => order.OrderDetails)
                                .ThenInclude(details => details.Product)
                        .ToList();
                }
                else Debug.WriteLine("Connection failed!");
            }
        }

        private void View_OrderDeleted(object sender, OrderEventArgs e)
        {
            Debug.WriteLine($"Delete order: {e.order.OrderDate}");
        }

        private void View_OrderSelected(object sender, OrderEventArgs e)
        {
            Debug.WriteLine($"Order selected: {e.order.OrderDate}");
            detailsPresenter.UpdateOrderDetails(e.order);
        }
    }
}
