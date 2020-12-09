using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CompanyDB
{
    public partial class CustomerOrdersTree : UserControl, ICustomerOrders
    {
        private ICollection<Customer> customers;

        public CustomerOrdersTree()
        {
            InitializeComponent();
        }

        public ICollection<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;

                foreach (Customer customer in customers)
                {
                    TreeNode customerNode = new TreeNode($"{customer.CompanyName} ({customer.Orders.Count})");

                    foreach (Order order in customer.Orders)
                    {
                        TreeNode orderNode = new TreeNode()
                        {
                            Text = $"{order.OrderDate}",
                            Tag = order
                        };

                        foreach (OrderDetail detail in order.OrderDetails)
                        {
                            TreeNode detailsNode = new TreeNode()
                            {
                                Text = $"{detail.Product.ProductName} x {detail.Quantity}",
                                Tag = detail
                            };

                            orderNode.Nodes.Add(detailsNode);
                        }

                        customerNode.Nodes.Add(orderNode);
                    }

                    treeView1.Nodes.Add(customerNode);
                }
            }
        }

        public event EventHandler<OrderEventArgs> OrderSelected;
        public event EventHandler<OrderEventArgs> OrderDeleted;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Order order = null;

            if (e.Node.Tag is Order selectedOrder)
            {
                order = selectedOrder;
            }
            else if (e.Node.Tag is OrderDetail)
            {
                if (e.Node.Parent.Tag is Order parentOrder)
                {
                    order = parentOrder;
                }
            }

            if (order != null)
            {
                OrderSelected?.Invoke(this, new OrderEventArgs(order));
            }
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteOrder();
            }
        }

        private void DeleteOrder()
        {
            if (treeView1.SelectedNode.Tag is Order order)
            {
                var result = MessageBox.Show(
                    $"Do you want to delete order on {order.OrderDate}\nfor customer {order.Customer.CompanyName}?",
                    "Delete Order",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    var nodeToDelete = treeView1.SelectedNode;
                    nodeToDelete.Parent.Nodes.Remove(nodeToDelete);
                    OrderDeleted?.Invoke(this, new OrderEventArgs(order));
                }
            }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var node = treeView1.GetNodeAt(e.X, e.Y);
                treeView1.SelectedNode = node;

                if (node.Tag is Order)
                {
                    contextMenuStripOrders.Show(treeView1.PointToScreen(new Point(e.X, e.Y)));
                }
            }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }
    }
}
