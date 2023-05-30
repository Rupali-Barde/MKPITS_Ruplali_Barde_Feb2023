using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ado
{
    public static class EmployeeDetail
    {
        //Create a connection
        public static string connectionString = "server=DESKTOP-P8DPODF\\SQLEXPRESS;integrated security=true;database=ado;";

                   //Creating a static Method
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }

        //Creating Static Method insert Into employee Table 
        public static string InsertRecord(string empid, string empname, string gender,
        string Mobile, string email, string DOB, string city)
        {
            SqlConnection con = GetConnection();

            //Creating a Insert Command
            string query = "insert into employee values(@empid,@empname,@gender,@Mobile,@email,@DOB,@city)";
            try
            {
                SqlCommand command = new SqlCommand(query, con);

                //Defining Parameters
                command.Parameters.AddWithValue("@empid", empid);
                command.Parameters.AddWithValue("@empname", empname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@mobile", Mobile);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@dob", DOB);
                command.Parameters.AddWithValue("@city", city);

                //Executing Command Using NonQueryMethod
                command.ExecuteNonQuery();
                return "Record Inserted SuccessFully";
            }
            catch (SqlException ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }
        //Connected Method To Return City Name

        //public static SqlDataReader GetCity()
        //{

        //Sqldatareader is used to store record
        // SqlConnection connection= GetConnection();
        //string query = "select * from city";
        //try 
        //{
        //SqlCommand command = new SqlCommand(query, connection);
        //      SqlDataReader dr = command.ExecuteReader();
        //      return dr;
        //}
        //catch 
        //{
        //  return null;    

        // }
        //}
        //Disconnected
        public static DataSet GetCity()
        { 
            SqlConnection con = GetConnection();
            string query = "select * from city";
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "city");
                return ds;
            }
            catch (Exception ee)
            {
                return null;
            }
        }

        //Creating A Static Method to Update Record into Employee Table
        public static string Updateemployee(string empid,string empname ) 
        {
            SqlConnection con = GetConnection();
            //Creating an object o SqlCommand class
            SqlCommand command = new SqlCommnad()
        }




        
    }
}


