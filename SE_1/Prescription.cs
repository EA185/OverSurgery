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
    public partial class Prescription : Form
    {
        public static string insert = "INSERT INTO prescription (Patient_ID, Diagnosis, Medicine_Name, Medicine_Quantity, Medicine_Description) VALUES (@Patient_ID, @Diagnosis, @Medicine_Name, @Medicine_Quantity, @Medical_Description)";
        Variables variables = new Variables();
        public Prescription()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
                variables.Patient_ID = txtPatient.Text;
                variables.Diagnosis = txtDiagnosis.Text;
                variables.Medicine_Name = txtMedName.Text;
                variables.Medicine_Quantity = txtMedQuantity.Text;
                variables.Medical_Description = txtMedDes.Text;
            

                if (DBConnection.GetDBConnectionInstance().InsertPrescription(variables) > 0)
                {
                    MessageBox.Show("The Data Has Been Recorded Successfully!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }

        private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                Menu page = new Menu();
                page.ShowDialog();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
