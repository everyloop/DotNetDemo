using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddControlsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {
                Button myButton = new Button() {
                    Text = $"B{i}",
                    Location = new Point(100, 50 * i)
                };

                Controls.Add(myButton);
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("After load");
        }
    }
}
