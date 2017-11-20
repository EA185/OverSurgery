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
        public Variables variables = new Variables();
        public Prescription()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                variables.PatientID = txtPatient.Text;
                variables.Diagnosis = txtDiagnosis.Text;
                variables.MedicineName= txtMedName.Text;
                variables.MedicineQuantity = txtMedQuantity.Text;
                variables.MedicalDescription = txtMedDes.Text;

                DBConnection.GetDBConnectionInstance().InsertPrescription(variables);

            }

        }
    }
}
