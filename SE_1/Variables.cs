using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SE_1
{
    public class Variables
    {
        //Login Creds Variables
        public string Username { get; set; }
        public string Password { get; set; }

        //Register A Patient Variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PhoneNumber { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }

        //Find A Patient Variables
        // public string PatientID { get; set; }

        public string PatientFirstNameSearch { get; set; }
        public string PatientAddress { get; set; }

        //Appointment
        public string AppDate { get; set; }
        public string GPName { get; set; }


        //Prescription Variables
        public string Patient_ID { get; set; }
    public string Diagnosis { get; set; }
    public string Medicine_Name { get; set; }
    public string Medicine_Quantity { get; set; }
    public string Medical_Description { get; set; }
    }
}
