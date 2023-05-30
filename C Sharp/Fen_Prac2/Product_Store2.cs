using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fen_Prac2
{
    public static class Product_Store2
    {
        //Create Connection
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=project";

        //Method to create Connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                return con;
            }
            catch (Exception ee)
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        //Method To Return The Category_Type_Value Form DataBase
        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }

        //Method to Return product Name For Given Product type Name
        public static DataSet GetTableProductName(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID =t.Product_Category_ID where t.Product_Type_Name =@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        
        //Method To Return Product Price For Given ProductName
        public static DataSet GetProductPrice(string ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "select ProductPrice from TableProduct where ProductName =@ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
           da.SelectCommand.Parameters.AddWithValue("@ProductName",ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static DataSet GetTableGSTDetails(string Gst_Detail_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from Table_ProductGSTDetails a inner join TableProductCategory t1 on a.Product_Gst_Id = t1.Product_Gst_ID where Gst_Detail_Name = @Gst_Detail_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Gst_Detail_Name", Gst_Detail_Name);
            da.Fill(ds, "Table_ProductGSTDetails");
            return ds;
        
        }
    }
}

    



    

