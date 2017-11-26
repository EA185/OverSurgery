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
    public partial class Booking : Form
    {
        public Variables var = new Variables();
        public Booking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu page = new Menu();
            page.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChangeAP_Click(object sender, EventArgs e)
        {
            var.Patient_ID = txt_AppPID.Text;
            var.FirstName = txt_AppPN.Text;
            var.AppDate = dtp_App.Value;
            var.GPName = txt_AppGpNa.Text;

            if (DBConnection.GetDBConnectionInstance().Appointment(var) > 0)
            {
                MessageBox.Show("Successful!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
