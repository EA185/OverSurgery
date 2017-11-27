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


        public int Insert(Variables Var)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;

            String dobStr = Var.dob.ToString("yyyyMMdd");
            cmd.CommandText = "INSERT INTO patient VALUES ('" + Var.FirstName + "','" + Var.LastName + "','" + Var.Address1 + "','" + Var.Address2 + "','" + Var.PhoneNumber + "','" + Var.gender + "','" + dobStr + "')";
            
            cmd.Connection = connectionToDB;

            int noRows = cmd.ExecuteNonQuery();

            CloseConnection();

            return noRows;
            
        }
        public int InsertPrescription(Variables Var)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO prescription VALUES ('" + Var.Patient_ID + "','" + Var.Diagnosis + "','" + Var.Medicine_Name + "','" + Var.Medicine_Quantity + "','" + Var.Medical_Description + "')";

            cmd.Connection = connectionToDB;

            int noRows = cmd.ExecuteNonQuery();

            CloseConnection();

            return noRows;

        }

        public int Appointment(Variables var)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            
            String AppDateStr = var.AppDate.ToString("yyyyMMdd");
            cmd.CommandText = "INSERT INTO Appointment VALUES ('" + var.Patient_ID + "','" + var.FirstName + "','" + AppDateStr + "','" + var.GPName + "')";
            
            cmd.Connection = connectionToDB;
            int noRows = cmd.ExecuteNonQuery();
            CloseConnection();
            return noRows;
        }


        public void CloseConnection()
        {
            connectionToDB.Close();
        }
    }
}
