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
        

        public FindPatient()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            DataSet dsFind = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT * FROM patient WHERE Patient_ID='" + txt_PatIDS.Text + "' OR First_Name='" + txt_PaFstNameS.Text + "' and dob='" + txt_DOBS.Text + "' OR First_Name='" + txt_PaFstNameS.Text + "' and Address_1='" + txt_AddS.Text + "'");

            DataTable dataTable = dsFind.Tables[0];

            dataGridView1.DataSource = dataTable;

        }
    }
}
