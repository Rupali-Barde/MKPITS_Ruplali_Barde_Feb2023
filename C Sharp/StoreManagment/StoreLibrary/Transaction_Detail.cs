using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreLibrary
{
    public static class Transaction_Detail
    {
        //Connection
        static SqlConnection con = DBConnection1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        public static string TransactionIssue(int Item_Id,DateTime transaction_date,int Department_Id,int Quantity)
        {
            string res = null;
            try
            {
                query = "insert into Transaction_Process(Item_Id,transaction_date,Department_Id,Quantity) values(@Item_Id,@TransactionDate,@Department_Id,@Quantity)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@TransactionDate", transaction_date);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "Record Saved In Transaction Master Successfully";

                //Code To Get Balance Quantity For Item Master
                int bal_quantity = 0;
                query = "Select Balance_quantity from Item_Master where Item_Id = @Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bal_quantity = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                int qty = bal_quantity + Quantity;
                query = "update Item_Master set Balance_Quantity = @Balance_Quantity where Item_Id=@Item_Id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                con.Open();
                cmd.ExecuteNonQuery();
                return "Item Issued To Department Successfully";

            }
            catch (Exception ex)
            {
                res = ex.ToString();

            }
            finally
            {
                con.Close();
            } return res;
                 




            
        }
            


    }
}
