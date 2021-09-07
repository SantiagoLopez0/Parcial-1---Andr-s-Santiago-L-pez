using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1___Andrés_Santiago_López
{
    public partial class Login : Form
    {
        String employeeUser = "empleadoOP";
        String employeePass = "onlypans456";

        String adminUser = "adminOP";
        String adminPass = "onlypans123";

        Employee employeeForm = new Employee();
        Admin adminForm = new Admin();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iniciarSesionBtn_Click(object sender, EventArgs e)
        {

            TextBox user = userInput;
            TextBox password = passInput;

            if (employeeUser == user.Text)
            {
                if (employeePass == password.Text)
                {
                    this.Hide();
                    employeeForm.Show();
                    MessageBox.Show("Usuario o contraeña equivocados, por favor volver a redactar");
                }
            }
            else if (adminUser == user.Text)
            {
                if (adminPass == password.Text)
                {
                    this.Hide();
                    adminForm.Show();
                    MessageBox.Show("Usuario o contraeña equivocados, por favor volver a redactar");
                }
            }
        }
    }
}
