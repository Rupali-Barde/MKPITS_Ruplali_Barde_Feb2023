using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Prac2_Fen_Proj
{
    public static class ProductStore
    {
        //Create Connection
        private static string connectionString = "Server=.\\Sqlexpress;integrated security=true;database=Project";

        //Method To Create Connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                //con.Open()
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //con.Close();
                con.Close();
            }
        }

        // Method To Return Product_Category
        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableProductCategory";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }

        //Method To Return Product Name For Given Product Type Name
        public static DataSet GetTableProductTypeName(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.ProductID, p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID   where t.Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_type_name", product_type_name);
            da.Fill(ds, "tableproduct");
            return ds;
        }

        //Method To Return GetDetails For Given Product Type Name
        public static DataSet GetGstDetails(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = " select a.cgst,a.sgst,a.igst from table_ProductGSTDetails a inner join tableproductcategory b on a.product_gst_id = b.product_gst_id where b.Product_Type_Name= @product_type_name";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds1, "table_ProductGSTDetails");

            return ds1;
        }


        //Method To Return Product Price For Given Product_Name
        public static DataSet GetProductPrice(string ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "select ProductPrice from TableProduct where ProductName=@ProductName";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds2, "TableProduct");
            return ds2;

        }

        //Method to save record inside invoice table
        public static string saveTableInvoiceDetails(String Customer_Name, String Customer_Contact, int product_category_id, int product_id,
        int residential_type_id, DateTime invoice_date, decimal quantity, decimal price, decimal cgst, decimal sgst, decimal igst, decimal cgst_value,
        decimal sgst_value, decimal igst_value, decimal total_amount)
        {
            string result = null;

            System.Windows.Forms.MessageBox.Show(invoice_date.ToString());
            string query = "insert into TableInvoiceDetails values(@Customer_Name,@Customer_Contact,@product_category_id,@product_id,@residential_type_id,@invoice_date,@quantity,@price,@cgst,@sgst, @igst,@cgst_value,@sgst_value,@igst_value,@total_amount)";
            SqlConnection con = GetConnection();
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@customer_Name", Customer_Name);
            command.Parameters.AddWithValue("@Customer_Contact", Customer_Contact);
            command.Parameters.AddWithValue("@product_category_id", product_category_id);
            command.Parameters.AddWithValue("@product_id", product_id);
            command.Parameters.AddWithValue("@residential_type_id", residential_type_id);
            command.Parameters.AddWithValue("@invoice_date", invoice_date);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@cgst", cgst);
            command.Parameters.AddWithValue("@sgst", sgst);
            command.Parameters.AddWithValue("@igst", igst);
            command.Parameters.AddWithValue("@cgst_value", cgst_value);
            command.Parameters.AddWithValue("@sgst_value", sgst_value);
            command.Parameters.AddWithValue("@igst_value", igst_value);
            command.Parameters.AddWithValue("@total_amount", total_amount);
            try

            {
                command.ExecuteNonQuery();
                result = "record saved successfullly";
            }
            catch (Exception ee)
            {
                result = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return result;



        }
    }
}





        

