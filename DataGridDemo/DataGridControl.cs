using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDemo
{
    public partial class DataGridControl : UserControl
    {
        public DataGridControl()
        {
            InitializeComponent();
            AddRows();

            dataGridView1.Columns["Length"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Length"].Resizable = DataGridViewTriState.True;
        }

        private void AddRows()
        {
            AddRow("Fredrik Johansson");
            AddRow("Mikael Karlsson");
        }

        private void AddRow(string name)
        {
            Random rnd = new Random();

            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells["FullName"].Value = name;
            dataGridView1.Rows[rowIndex].Cells["Length"].Value = (rnd.NextDouble() + 1.20).ToString("0.00");
            dataGridView1.Rows[rowIndex].Cells["Weight"].Value = rnd.Next(40, 120);
        }
    }
}
