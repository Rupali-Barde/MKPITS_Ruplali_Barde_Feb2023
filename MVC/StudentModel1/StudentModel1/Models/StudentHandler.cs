using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace StudentModel1.Models
{
    public class StudentHandler
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = "Server=.\\sqlexpress;integrated security =true;database=MVC";
            con = new SqlConnection(constr);

        }
        //Insert Item
        public bool InsertRecord(StudentModel ilist)
        {
            connection();
            string query = "Insert into StudentModel values('" + ilist.Name + "','" + ilist.City + "','" + ilist.Percentage + "')";
            SqlCommand cmd = new SqlCommand (query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery ();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;   
        }

        //View All Records In Table
       public List<StudentModel> GetRecords()
        {
            connection();
            List<StudentModel> ilist = new List<StudentModel>();
            string query = "Select * from StudentModel";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

             foreach(DataRow dr in dt.Rows)
             {
                ilist.Add(new StudentModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    City = Convert.ToString(dr["City"]),
                    Percentage = Convert.ToDecimal(dr["Percentage"])
                });
                    
             }
            return ilist;
       }

        //Update Student details
        public bool UpdateRecord(StudentModel ilist)
        {
            connection();
            string query = "Update StudentModel set Name='" + ilist.Name + "', City='" + ilist.City + "', Percentage='"+ilist.Percentage+"' where ID="+ilist.ID;
            SqlCommand cmd = new SqlCommand (query, con);
            con.Open ();
            int i = cmd.ExecuteNonQuery();
            con.Close ();

            if(i>=1)
                return true;
            else
                return false;
        }

        //Delete Records From StudentModel
        public bool DeleteRecord(int ID)
        {
            connection();
            string query = "Delete from StudentModel where ID=" + ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open ();
            int i = cmd.ExecuteNonQuery();
            con.Close() ;

            if (i >= 1)
                return true;
            else
                return false;

        }
    }
}