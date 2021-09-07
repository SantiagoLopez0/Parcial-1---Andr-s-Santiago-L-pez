using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial_1___Andrés_Santiago_López
{
    public partial class Admin : Form
    {
        Login loginForm = new Login();
        public Admin()
        {
            InitializeComponent();
        }

        private void volverLoginAdminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
