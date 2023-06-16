using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace StoreLibrary
{
    public static class Department_Mast
    {
        //Connection
        static SqlConnection con = DBConnection1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //Method To Insert Record Into Department_Mast
        public static string insertDepartment_Mast(string Department_Name)
        {
            string res = null;
            try
            {
                query = "insert into Department_Mast values(@Department_Name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Department_Name", Department_Name);
                con.Open();
                cmd.ExecuteNonQuery();
                //con.Close();
                res = "Record Saved In Depertment Master Successfully";
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
        //Method To Return Department Id
        public static string getDepartment_Id()
        {
            string res = null;
            try
            {
                query = "select max(Department_Id)from Department_Mast";
                cmd = new SqlCommand(query, con);
                con.Open();
                int did = Convert.ToInt32(cmd.ExecuteScalar());
                res = did.ToString();
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
        //Method To Update Record In Department Table
        public static string updateDepartment_Mast(string Department_Name, int Department_Id)
        {
            string res = null;

            //Checking Whether VendorId Exist Or Not
            query = "select count(*)from Department_Mast where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {
                try
                {
                    query = "update Department_Mast set Department_Name=@Department_Name where Department_Id=@Department_Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Department_Name", Department_Name);
                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "Record Updated in Department Master SuccessFully";

                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                res = "No Record Exist";

            }
            return res;

        }

        //Method To Delete Record Into Department Master
        public static string deleteDepartment_Mast(int Department_Id)
        {
            string res = null;

            //checking whether Department_Id exists or not
            query = "select count(*) from Department_Mast where Department_Id=@Department_Id";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Department_Mast where Department_Id=@Department_Id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Department_Id", Department_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "Record deleted in Department Master Successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {
                res = "No Record Exist ";
            }
            return res;
        }
        //Method To Search Record In Department Table
        public static DataSet searchDepartment_Mast(int Department_Id)
        {

            query = "select * from Department_Mast where Department_Id=@Department_Id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_Id",Department_Id);
            da.Fill(ds, "Depertment_Mast");
            return ds;

        }



    }
}

