using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
            

        

    }
}
