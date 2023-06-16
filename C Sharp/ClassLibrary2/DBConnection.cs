using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ClassLibrary2
{
    public static class DBConnection
    {
        static SqlConnection con = DBConnection.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //Method To InsertRecord In VendorTable
        public static string insertVendor_Mast(string Vendor_Name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_Mast values(@Vendor_Name)";
                con.Open();
                cmd.ExecuteNonQuery();
                res = "Record Saved In Vendor Master Successfully";
            }
            catch (Exception ex) 
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }

        //Method To Return Vendor_Id
        public static string getVendor_Id()
        {
            string res = null;
            try
            {
                query = "select max(Vendor_Id) from Vendor_Mast";
                cmd = new SqlCommand(query,con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());
                res = vid.ToString();

            }
            catch (Exception ex) 
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return res;
        }
    }
}
