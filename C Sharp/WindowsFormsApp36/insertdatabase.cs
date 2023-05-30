using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp36
{
    public static class insertdatabase
    {
        //Creating a Static Variable
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=school";
        //Creating a Static Method
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
        //Creating a Static Method to insert record into users table
        public static string InsertRecord(string name,string course)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into student values(@name,@course)";
            //@rno,@name,@course are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
               
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@course", course);
                //Executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "Record Inserted Successfully";
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
