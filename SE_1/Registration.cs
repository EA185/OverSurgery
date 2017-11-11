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
    public partial class Registration : Form 
    {
        public Variables variables = new Variables();
        
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            variables.FirstName = txt_fstName.Text;
            variables.LastName = txt_lstName.Text;
            variables.Address1 = txt_add1.Text;
            variables.Address2 = txt_add2.Text;
            variables.PhoneNumber = txt_PhNum.Text;

            DBConnection db = new DBConnection();

            db.Insert(variables);
        }
    }
}
