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
        public Form1()
        {
            InitializeComponent();

            var treeview = new CustomerOrdersTree() { Dock = DockStyle.Fill };
            splitContainer1.Panel1.Controls.Add(treeview);

            var datagrid = new OrderDetailsGrid() { Dock = DockStyle.Fill };
            splitContainer2.Panel2.Controls.Add(datagrid);

            var detailsPresenter = new OrderDetailsPresenter(datagrid);
            new CustomerOrdersPresenter(treeview, detailsPresenter);
        }

        /*
        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            if (activeOrder != null)
            {
                var details = new OrderDetail()
                {
                    Id = Guid.NewGuid().ToString()
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
        */
    }
}
