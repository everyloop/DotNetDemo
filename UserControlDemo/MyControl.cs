using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public class AddNodeEventArgs : EventArgs
    {
        public string NodeName { get; set; }

        public AddNodeEventArgs(string name)
        {
            NodeName = name;
        }
    }
    public partial class MyControl : UserControl
    {
        //public delegate void MyEventHandler(object sender, AddNodeEventArgs args);
        
        public event EventHandler<AddNodeEventArgs> ButtonClicked;

        public MyControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, new AddNodeEventArgs(comboBox1.Text));

            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
        }
    }
}
