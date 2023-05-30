using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fen_proj_Prac1
{
    public static class DatabaseConnection
    {
        private static string connectionString = "Server=.\\Sqlexpress;integrated security=true;database =project1";

        //Method To Create Connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                //Con.Open()
                con.Open();
                return con;
            }
            catch(Exception ee)
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        //Method To return ProductCategory
        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "Select product_Type_Name from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }
    }
}
