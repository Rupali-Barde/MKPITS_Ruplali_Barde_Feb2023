using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ItemList3.Models
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=compshopdbwithoutef";
            con = new SqlConnection(constr);
        }
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
}