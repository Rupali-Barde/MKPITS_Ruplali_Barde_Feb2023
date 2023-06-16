using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace StoreLibrary
{
    public static class Item_Master
    {

        //Connection
        static SqlConnection con = DBConnection1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //Method To Insert Record Into Item_Mast
        public static string insertItem_Master(string Item_Name, string Category, int Rate, int Balance_Quantity)
        {
            string res = null;
            try
            {
                query = "insert into Item_Master values(@Department_Name,@Category,@Rate,@Balance_Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Item_Name", Item_Name);
                cmd.Parameters.AddWithValue("Category", Category);
                cmd.Parameters.AddWithValue("Rate", Rate);
                cmd.Parameters.AddWithValue("Balance_Quantity", Balance_Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                //con.Close();
                res = "Record Saved In Item Master Successfully";
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

        public static string getItem_Id()
        {
            string res = null;
            try
            {
                query = "select max(Item_Id) from Item_Master";

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

        //Method To Update The Record In Item Master
        public static string updateItem_Master(string Item_Name, int Rate)
        {
            string res = null;

            //checking whether ItemId exists or not
            //query = "select count(*) from Item_Master where Item_Id=@Item_Id";
            //cmd = new SqlCommand(query, con);
           // cmd.Parameters.AddWithValue("@Item_Id",Item_Id);
            //con.Open();
            //int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            //con.Close();

            //if (cnt > 0)
            //{

                try

                {
                    query = "update Item_Master set Item_Name=@Item_Name where Rate=@Rate";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Item_Name",Item_Name);
                    cmd.Parameters.AddWithValue("@Rate", Rate);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "Record Updated In Item Master Successfully";
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

        //Method To Delete Record From Item Master
        public static string deleteItem_Master(int Item_Id)
        {
            string res = null;

            //checking whether vendorid exists or not
            query = "select count(*) from Item_Master where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (cnt > 0)
            {

                try
                {
                    query = "delete from Item_Master where Item_Id=@Item_Id";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    res = "Record Deleted In Item Master Successfully";
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

        //method to search record in vendor master

        public static DataSet searchItem_Master(int Item_Id)
        {

            query = "select * from Item_Master where Item_Id=@Item_Id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Item_Id",Item_Id);
            da.Fill(ds, "Item_Master");
            return ds;

        }
    }

}


