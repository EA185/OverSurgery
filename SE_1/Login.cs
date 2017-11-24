using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SE_1
{
    public partial class Login : Form
    {
        public Variables variables = new Variables();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            variables.Username = txt_username.Text;
            variables.Password = txt_password.Text;

            if (DBConnection.CheckLogin(variables) == true)
            {
                MessageBox.Show("Login Successful!", "Welcome");
                this.Hide();
                Menu page = new Menu();
                page.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
