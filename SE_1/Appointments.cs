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
    public partial class Appointments : Form
    {
        public Variables var = new Variables();

        public Appointments()
        {
            InitializeComponent();
        }

        private void btn_Book_Click(object sender, EventArgs e)
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

            DataSet appDGV = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT FirstName'" + txt_AppPN.Text + "' and date='" + dtp_App.Value + "'");

            DataTable dataTable = appDGV.Tables[0];

            dgv_Appointment.DataSource = dataTable;
        }

        private void btn_CancelB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu page = new Menu();
            page.ShowDialog();
        }

        private void btn_ChangeAP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Booking page = new Booking();
            page.ShowDialog();
        }
    }
}
