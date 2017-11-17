using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration page = new Registration();
            page.ShowDialog();
        }

        private void btn_exitM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindPatient page = new FindPatient();
            page.ShowDialog();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckEmployee page = new CheckEmployee();
            page.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking page = new Booking();
            page.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prescription page = new Prescription();
            page.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result page = new Result();
            page.ShowDialog();
        }
    }
}
