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
            DataSet dsCheckNurAv = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT Nurse_Id,Nurse_Name,Availability_Status FROM nurse WHERE Nurse_Name='" + txt_NurName.Text + "' and date= '"+ dtp_ChkAV.Value + "'");

            DataTable dataTable = dsCheckNurAv.Tables[0];

            dgv_GPav.DataSource = dataTable;
             
        }

        private void btn_CheckGPav_Click(object sender, EventArgs e)
        {
            DataSet dsCheckGPav = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT GP_id,GP_name,Availability_Status FROM GP WHERE GP_name='" + txt_GPName.Text + "' and date='" + dtp_ChkAV.Value + "'");

            DataTable dataTable = dsCheckGPav.Tables[0];

            dgv_GPav.DataSource = dataTable;
        }

        private void btn_Checkduty_Click(object sender, EventArgs e)
        {
            DataSet dsCheckALLGP = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT GP_id,GP_name,Duty FROM GP WHERE date='" + dtp_ChkALL.Value + "'");

            DataTable dataTableGP = dsCheckALLGP.Tables[0];

            DataSet dsCheckALLnur = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT Nurse_Id,Nurse_Name,Duty_Status FROM nurse WHERE date ='" + dtp_ChkALL.Value + "'");

            DataTable dataTableNur = dsCheckALLnur.Tables[0];

            dgv_GPonDuty.DataSource = dataTableGP;

            dgv_NURonDuty.DataSource = dataTableNur;
        }

        private void dgv_NURonDuty_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
