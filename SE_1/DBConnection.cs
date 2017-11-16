using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace SE_1
{
    class DBConnection
    {
        private static DBConnection _instance;

        private static string connectionString;

        private SqlConnection connectionToDB;

        private SqlDataAdapter dataAdapter;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EA\Source\Repos\OverSurgery\SE_1\Creds.mdf;Integrated Security=True;Connect Timeout=30");

        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        public static DBConnection GetDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        public void OpenConnection()
        {
            connectionToDB = new SqlConnection(connectionString);

            connectionToDB.Open();
        }

        public void CloseConnection()
        {
            connectionToDB.Close();
        }

        public DataSet GetDataSet(string sqlStatement)
        {
            DataSet dataSet = new DataSet();

            OpenConnection();

            dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);

            dataAdapter.Fill(dataSet);

            CloseConnection();

            return dataSet;
        }

        public static bool CheckLogin(Variables Var)
        {
            DataSet dsLogin = GetDBConnectionInstance().GetDataSet("SELECT Count (*) From login WHERE username='" + Var.Username + "' and password='" + Var.Password + "'");
            
            DataTable dtLogin = dsLogin.Tables[0];

            bool x = false;
            if (dtLogin.Rows[0][0].ToString() == "1")
            {
                x = true;
            }
            else
            {
                x = false;
            }

            return x;
        }
        

        public void Insert(Variables Var)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO patient VALUES ('" + Var.FirstName + "','" + Var.LastName + "','" + Var.Address1 + "','" + Var.Address2 + "','" + Var.PhoneNumber + "','" + Var.gender + "','" + Var.dob + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("done");
        }
    }
}
