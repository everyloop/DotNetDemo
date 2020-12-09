using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CompanyDB
{
    public partial class OrderDetailsGrid : UserControl, IOrderDetails
    {
        private ICollection<OrderDetail> details;

        public OrderDetailsGrid()
        {
            InitializeComponent();
        }

        public ICollection<Product> Products { get; set; }

        public ICollection<OrderDetail> Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;

                dataGridView1.Rows.Clear();

                foreach (OrderDetail detail in details)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Tag = detail;

                    var comboBoxCell = dataGridView1.Rows[rowIndex].Cells["Product"] as DataGridViewComboBoxCell;
                    comboBoxCell.ValueType = typeof(Product);
                    comboBoxCell.DisplayMember = "ProductName";
                    comboBoxCell.ValueMember = "This";

                    foreach (Product product in Products)
                    {
                        comboBoxCell.Items.Add(product);
                    }

                    dataGridView1.Rows[rowIndex].Cells["Product"].Value = detail.Product;
                    dataGridView1.Rows[rowIndex].Cells["UnitPrice"].Value = detail.UnitPrice;
                    dataGridView1.Rows[rowIndex].Cells["Quantity"].Value = detail.Quantity;
                }

            }
        }

        public event EventHandler<OrderDetailsEventArgs> OrderDetailsUpdated;

        // TODO: Use event called only when User changes the value.
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // TODO: Use column name to identify column "Products"
            if (cell is DataGridViewComboBoxCell comboBox)
            {
                var product = comboBox.Value as Product;

                dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value = product.UnitPrice;
                var details = dataGridView1.Rows[e.RowIndex].Tag as OrderDetail;
                details.Product = product;
                details.UnitPrice = product.UnitPrice;
                
                OrderDetailsUpdated?.Invoke(this, new OrderDetailsEventArgs(details));
            }
            else if (e.ColumnIndex == 1)
            {
                var details = dataGridView1.Rows[e.RowIndex].Tag as OrderDetail;

                int result;

                if (Int32.TryParse(cell.Value.ToString(), out result))
                {
                    details.UnitPrice = (int?)result;
                }

                OrderDetailsUpdated?.Invoke(this, new OrderDetailsEventArgs(details));
            }
            else if (e.ColumnIndex == 2)
            {
                var details = dataGridView1.Rows[e.RowIndex].Tag as OrderDetail;

                int result;

                if (Int32.TryParse(cell.Value.ToString(), out result))
                {
                    details.Quantity = (int?)result;
                }

                OrderDetailsUpdated?.Invoke(this, new OrderDetailsEventArgs(details));
            }

        }
    }
}
