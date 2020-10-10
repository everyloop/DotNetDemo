using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
            linkLabel1.LinkVisited = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my app!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoAToolStripMenuItem.Checked = true;
            infoBToolStripMenuItem.Checked = false;
        }

        private void infoBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoAToolStripMenuItem.Checked = false;
            infoBToolStripMenuItem.Checked = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)numericUpDown1.Value;
        }
    }
}
