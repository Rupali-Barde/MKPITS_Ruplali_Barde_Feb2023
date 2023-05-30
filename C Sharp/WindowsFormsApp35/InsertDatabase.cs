using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApp35
{
    public static class  InsertDatabase
    {
        //creating a static variable
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=school";
        //creating a static method
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
        //creating a static method to insert record into users table
        public static string InsertRecord(int rno,str) { }
    }
}
