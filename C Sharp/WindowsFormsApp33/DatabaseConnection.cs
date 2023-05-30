using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp33
{
    public static class DatabaseConnection
    {
// Creating Static variable
private static string connectionString ="server=.\\sqlexpress;integrated security=true;database=mkpits";
        //Creating a static method
        public static SqlConnection GetConnection()
        {
SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch(SqlException ex)
            {
                return null;
            }
        }
            
    }
}
