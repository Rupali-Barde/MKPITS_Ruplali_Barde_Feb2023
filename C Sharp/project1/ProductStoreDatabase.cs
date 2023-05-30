using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project1
{
    public static class ProductStoreDatabase
    {
        private static string ConnectionString = "Server=.\\Sqlexpress;integrated security=true;database=Project";
        //Method to create connection
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex) 
            {
            return null;
            }
        }
        //Method to return product category
        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select Product_Type_Name from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProductCategory");
            return ds;

        }
       // method to return product name for given product type name
        public static DataSet GetProduct_Type_Name(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select ProductName from TableProduct p inner join TableProductCategory t on t.Product_Category_ID=p.ProductTypeID where t.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        //method to return gstdetails for given product type name
        public static DataSet GetGstDetails(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.CGST,a.SGST,a.IGST from Table_ProductGSTDetails a inner join TableProductCategory b on a.Product_Gst_Id=b.Product_Gst_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "Table_ProductGSTDetails");
            return ds;
        }

        //Method to return product price for given product_name
        public static DataSet GetProductPrice (string ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "select ProductPrice from TableProduct where ProductName = @ProductName";  
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds2,"TableProduct");
            return ds2;
        }

   

    }
}
