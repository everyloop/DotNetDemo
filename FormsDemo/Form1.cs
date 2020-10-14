using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            using (FormAddUser addUserForm = new FormAddUser())
            {
                // TODO: Uppdatera FormAddUser så att den fyller textboxarna
                // FirstName och LastName när jag använder följande kod:

                // addUserForm.UserName = "Fredrik Johansson";

                if (addUserForm.ShowDialog() == DialogResult.OK)
                {
                    listBoxUsers.Items.Add(addUserForm.UserName);
                }
            }
        }
    }
}
