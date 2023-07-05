using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//ing System.Web.UI.WebControls;
//ing System.Web.Mvc;

namespace ItemList2.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=compshopdbwithoutef";
            con = new SqlConnection(constr);
        }

        //Insert Item
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "Insert into ItemList values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        //Get All Item List
        public List<ItemModel> GetItemList()
        {
            connection();
            List<ItemModel> iList = new List<ItemModel>();
            string query = "Select * From ItemList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });


            }
            return iList;
        }
        //Update Records In Table

        public bool UpdateItem(ItemModel ilist)
        {
            connection();
            string query = "Update ItemList set Name='" + ilist.Name + "',Category='" + ilist.Category + "',Price='" + ilist.Price + "' where ID=" + ilist.ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;


        }

        //Delete Item Details
        public bool DeleteItem(int ID)
        {
            connection();
            string query = "Delete from ItemList where ID =" + ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        

    }
}