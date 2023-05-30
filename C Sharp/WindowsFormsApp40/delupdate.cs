using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp40
{
    public static class delupdate
    {
        //Creating a Static Variable
        private static string connectionString = "Server=.\\sqlexpress;integrated security=true;database=CreateDelete";

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
        //Creating a static method to insert record into users table
        public static string InsertRecord(string username,string password)
        {
            SqlConnection con = GetConnection();

            //Creating a insert command
            string query ="insert into users values(@username,@password)";

            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);

                //Defining sqlparameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                //executing the command using executenoquery method
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
        //Creating a ststic method to update record into users table
        public static string Updatedelupadte(string username,string password)
        {
            SqlConnection con = GetConnection();

            //creating a insert command
            string query = "update users set password=@password where username=@username";

            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);

                //defining sqlparametrs
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);

                //Executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "Record inserted Successfully";
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
        //Creating a static method to delete record from users
        public static string DeleteUsers(string username,string password) 
        {
            SqlConnection con = GetConnection();
            //creating a delete command
            string query = "delete from users where username=@username";

            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);

                //defining sqlparameters
                command.Parameters.AddWithValue("@username", username);

                //executing the command using executenoquery method
                command.ExecuteNonQuery();
                return "Record Deleted Successfully";


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
    }
}
