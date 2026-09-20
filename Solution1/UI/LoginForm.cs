using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository;
using Model;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            UserRepository userRepository = new UserRepository();

            User user = userRepository.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            if (user.Role == "Admin")
            {
                AdminLandingPage adminForm = new AdminLandingPage();
                adminForm.Show();
            }
            else if (user.Role == "Registrar")
            {
                RegistrarLandingPage registrarForm = new RegistrarLandingPage();
                registrarForm.Show();
            }

            else if (user.Role == "Cashier")
            {
                CashierLandingPage cashierForm = new CashierLandingPage();
                cashierForm.Show();
            }
            else 
                { 
                MessageBox.Show("User role not recognized.");
                }
        }
    }
}
