using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace MVCConnection1.Models
{
    public class ItemDBHandler
    {
        SqlConnection con = null;
        public void connection()
        {
            //Make Connection
            string constr = "server=.\\sqlexpress;integrated security=true;database=compshopdbwithoutef";
            con = new SqlConnection (constr);
        }

        //Insert Query
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "insert into itemlist values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand (query, con);
            con.Open ();

            int i=command.ExecuteNonQuery ();
            con.Close ();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Code To View All Records Of Table
        public List<ItemModel> GetItemList()
        {
            connection();
            List<ItemModel> ilist = new List<ItemModel>();
            string query = "Select * from ItemList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                ilist.Add( new ItemModel 

                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return ilist;
        }
    }

        

   
}
