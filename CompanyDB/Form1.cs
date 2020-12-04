using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace CompanyDB
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        private everyloopNETContext db = new everyloopNETContext();
        private Order activeOrder = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.Database.CanConnect())
            {
                products = db.Products.OrderBy(p => p.ProductName).ToList();

                var customers = db.Customers
                    .Include(customer => customer.Orders)
                        .ThenInclude(order => order.OrderDetails)
                            .ThenInclude(details => details.Product)
                    .ToList();

                /*
                var Order = db.Orders
                    .Include(o => o.OrderDetails)
                        .ThenInclude(d => d.Product)
                    .Include(o => o.Customer)
                    .ToList();
                */

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
                                Tag = order
                            };

                            orderNode.Nodes.Add(detailsNode);
                        }

                        customerNode.Nodes.Add(orderNode);
                    }

                    treeView1.Nodes.Add(customerNode);
                }
            }
            else Debug.WriteLine("Connection failed!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Order order)
            {
                activeOrder = order;
                textBoxOrderDate.Text = order.OrderDate;
                textBoxOrderID.Text = order.Id.ToString();
                textBoxContactName.Text = order.Customer.ContactName;
                textBoxPhone.Text = order.Customer.Phone;

                dataGridView1.Rows.Clear();

                foreach (OrderDetail detail in order.OrderDetails)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Tag = detail;

                    var comboBoxCell = dataGridView1.Rows[rowIndex].Cells["Product"] as DataGridViewComboBoxCell;
                    comboBoxCell.ValueType = typeof(Product);
                    comboBoxCell.DisplayMember = "ProductName";
                    comboBoxCell.ValueMember = "This";

                    foreach (Product product in products)
                    {
                        comboBoxCell.Items.Add(product);
                    }

                    dataGridView1.Rows[rowIndex].Cells["Product"].Value = detail.Product;
                    dataGridView1.Rows[rowIndex].Cells["UnitPrice"].Value = detail.UnitPrice;
                    dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = detail.Quantity;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if (cell is DataGridViewComboBoxCell comboBox)
            {
                var product = comboBox.Value as Product;

                dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = product.UnitPrice;
                var details = dataGridView1.Rows[e.RowIndex].Tag as OrderDetail;
                details.Product = product;
                details.UnitPrice = product.UnitPrice;
            }
            else if (e.ColumnIndex == 2)
            {
                var details = dataGridView1.Rows[e.RowIndex].Tag as OrderDetail;

                int result;

                if (Int32.TryParse(cell.Value.ToString(), out result))
                {
                    details.Quantity = (int?)result;
                }
                
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.SaveChanges();
            db.Dispose();
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
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
                        db.Remove(order);
                        var nodeToDelete = treeView1.SelectedNode;
                        nodeToDelete.Parent.Nodes.Remove(nodeToDelete);
                        db.SaveChanges();
                    }
                }
            }
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            if (activeOrder != null)
            {
                var details = new OrderDetail()
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 10)
                };

                activeOrder.OrderDetails.Add(details);

                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Tag = details;

                var comboBoxCell = dataGridView1.Rows[rowIndex].Cells["Product"] as DataGridViewComboBoxCell;
                comboBoxCell.ValueType = typeof(Product);
                comboBoxCell.DisplayMember = "ProductName";
                comboBoxCell.ValueMember = "This";

                foreach (Product product in products)
                {
                    comboBoxCell.Items.Add(product);
                }

                comboBoxCell.Value = products[0];

            }

        }
    }
}
