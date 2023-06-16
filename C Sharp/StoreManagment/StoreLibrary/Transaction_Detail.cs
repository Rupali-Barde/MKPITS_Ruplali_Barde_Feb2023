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

        public static string TransactionIssue(int Item_Id,DateTime Transactiondate,int Department_Id,int Quantity)
        {
            try
            {
                query = "insert into Transaction_Process(Item_Id,TransactionDate,Department_Id,Quantity) values(@Item_Id,@TransactionDate,@Department_Id,@Quantity)";
                cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@Item_Id",Item_Id);
                cmd.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);
                cmd.Parameters.AddWithValue("@Item_Id", Item_Id);



            }
        }
            


    }
}
