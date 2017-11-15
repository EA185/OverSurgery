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
    public partial class FindPatient : Form
    {
        Variables variables = new Variables();

        public FindPatient()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            DataSet dsLogin = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT * FROM patient WHERE First_Name='" + txt_PaFstNameS.Text + "'");

            DataTable dataTable = dsLogin.Tables[0];

            dataGridView1.DataSource = dataTable;

        }
    }
}
