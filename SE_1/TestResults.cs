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
    public partial class TestResults : Form
    {
        public TestResults()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsTest = DBConnection.GetDBConnectionInstance().GetDataSet("SELECT * FROM TestResults WHERE Test_ID='" + txt_Results.Text + "'");
            DataTable dataTable = dsTest.Tables[0];
             dgv_test.DataSource = dataTable;
        }
    }
}
