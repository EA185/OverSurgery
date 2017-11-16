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
    public partial class CheckEmployee : Form
    {
        

        public CheckEmployee()
        {
            InitializeComponent();
        }

        private void Btn_CheckAv_Click(object sender, EventArgs e)
        {
            DataSet dsCheckNurAv = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT * FROM nurse WHERE Nurse_Name='" + txt_NurName.Text + "'");

            DataTable dataTable = dsCheckNurAv.Tables[0];

            dgv_GPav.DataSource = dataTable;
             
        }

        private void btn_CheckGPav_Click(object sender, EventArgs e)
        {
            DataSet dsCheckGPav = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT * FROM GP WHERE GP_name='" + txt_GPName.Text + "'");

            DataTable dataTable = dsCheckGPav.Tables[0];

            dgv_GPav.DataSource = dataTable;
        }
    }
}
