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

        //Find A Patient Variables
        // public string PatientID { get; set; }
        
        public string PatientFirstNameSearch { get; set; }
        public string PatientAddress { get; set; }
        


    }
}
