using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace StoreLibrary
{
    public static class VendorClass
    {
        //Connection
        static SqlConnection con = DBConnection1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //Method To Insert Record In Vendor Table
        public static string insertVendor_Mast(string Vendor_Name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_Mast values(@Vendor_Name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Vendor_Name", Vendor_Name);
               // con.Open();
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
                query = "select max(Vendor_Id)from Vendor_Mast";
                cmd = new SqlCommand(query, con);
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
        //Method To Update Record In Vendor Table
        //public static string updateVendor_Mast(string Vendor_Name, int Vendor_Id)
        //{
        //    string res = null;

        //    //Checking Whether VendorId Exist Or Not
        //    query = "select count(*)from Vendor_Mast where Vendor_Id=@Vendor_Id";
        //    cmd = new SqlCommand(query, con);
        //    cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
        //    con.Open();
        //    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
        //    con.Close();

        //    if (cnt > 0)
        //    {
        //        try
        //        {
        //            query = "update Vendor_Mast set Vendor_Name=@Vendor_Name where Vendor_Id=@Vendor_Id";
        //            cmd = new SqlCommand(query, con);
        //            cmd.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
        //            cmd.Parameters.AddWithValue("@Vendor_Id", Vendor_Id);
        //            con.Open();
        //            cmd.ExecuteNonQuery();

        //            res = "Record Updated in Vendor Master SuccessFully";

        //        }
        //        catch (Exception ex)
        //        {
        //            res = ex.ToString();
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }

        //    }
        //    else
        //    {
        //        res = "No Record Exist";

        //    }
        //    return res;

        //}

        ////Method To Delete Record Into Vendor Master


    }

}
        
      

