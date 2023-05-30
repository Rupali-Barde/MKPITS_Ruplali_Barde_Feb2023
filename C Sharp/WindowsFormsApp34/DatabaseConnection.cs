using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp34
{
    public static class DatabaseConnection
    {
        //Creating a static variable
        private static string connectionString = "server=.\\sqlexpress;integrated security= true;database=mkpits";
        //Creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException ee)
            {
                return null;
            }
        }
        //Creating a static method to insert record into user table
        public static string InsertRecord(string username,string password)
        {
            SqlConnection con = GetConnection();
            //Creating a insert command
            string query = "insert into users values(@username,@password)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query,con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //executing the command using executnoquery method
                command.ExecuteNonQuery();
                return "Record Inserted Successfully";


            }
            catch(Exception ee) 
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
