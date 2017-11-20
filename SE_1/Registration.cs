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
    public partial class Registration : Form 
    {
        public static string insert = "INSERT INTO patient (First_Name, Last_Name, Address_1, Address_2, Phone_Number, Gender, dob) VALUES (@First_Name, @Last_Name, @Address_1, @Address_2, @Phone_Number, @Gender, @dob)";
        public Variables variables = new Variables();
        public string gender;
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            
            variables.dob = dtp.Value;
            variables.FirstName = txt_fstName.Text;
            variables.LastName = txt_lstName.Text;
            variables.Address1 = txt_add1.Text;
            variables.Address2 = txt_add2.Text;
            variables.PhoneNumber = txt_PhNum.Text;
            
            if (Box_Male.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            variables.gender = gender;

            if (DBConnection.GetDBConnectionInstance().Insert(variables) > 0)
            {
                MessageBox.Show("The Data Has Been Recorded Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu page = new Menu();
            page.ShowDialog();
        }
    }
}
