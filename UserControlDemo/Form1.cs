using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyControl myControl = new MyControl();
            splitContainer1.Panel2.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;

            myControl.ButtonClicked += MyControl_ButtonClicked;

            /*
            TreeNode root = new TreeNode("Root node");
            TreeNode root2 = new TreeNode("Root node 2");
            treeView1.Nodes.Add(root);
            treeView1.Nodes.Add(root2);

            root.Nodes.Add("fredrik");
            */
        }

        private void MyControl_ButtonClicked(object sender, AddNodeEventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                treeView1.Nodes.Add(e.NodeName);
            }
            else
            {
                treeView1.SelectedNode.Nodes.Add(e.NodeName);
                treeView1.SelectedNode.Expand();
            }

            treeView1.Focus();
        }
    }
}
