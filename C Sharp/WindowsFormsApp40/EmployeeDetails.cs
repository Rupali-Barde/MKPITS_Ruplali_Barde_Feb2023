using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp40
{
    public static class EmployeeDetails
    {
        //Creating a static variable
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=CreateDelete;";

        //Creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }
        public static string EmployeeInsert(int empno, string empname, string gender, string email, long mobileno, string city, string date)
        {
            SqlConnection con = GetConnection();
            string query = "insert into employee  values(@empno,@empname,@gender,@email,@mobileno,@city,@date)";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@empno", empno);
                command.Parameters.AddWithValue("@empname", empname);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();
                return "Successfully submitted";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        public static SqlDataReader GetCity()      //Connected
        {
            SqlConnection s = GetConnection();
            string query = "select * from city";
            try
            {
                SqlCommand command = new SqlCommand(query, s);

                //sqldatareader is used to store record returned from city table
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }


        }

    }
}

