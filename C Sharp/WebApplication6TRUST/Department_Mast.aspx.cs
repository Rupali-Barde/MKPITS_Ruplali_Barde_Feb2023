using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication6TRUST
{
    public partial class Department_Mast : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Trust");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            str = "Select * from Department_Mast";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Department_Mast");
            GridView1.DataSource = ds.Tables["Department_Mast"].DefaultView;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Department_Mast values(@Department_Name)";
            SqlCommand command = new SqlCommand(str, con);
           // command.Parameters.AddWithValue("@Department_Id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Department_Name", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Inserted";
            loaddata();
            TextBox1.Text = "";
            TextBox1.Focus();




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Department_Mast set Department_Name=@Department_Name where Department_Id=@Department_Id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_Id", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Department_Name", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Updated";
            loaddata();
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Department_Mast where Department_Id=@Department_Id";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@Department_Id", Convert.ToInt32(TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted ";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Department_Mast where Department_Id=@Department_Id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_Id", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "Department_Mast");

            TextBox2.Text = ds.Tables["Department_Mast"].Rows[0].ItemArray[1].ToString();
            GridView1.DataSource = ds.Tables["Department_Mast"].DefaultView;

            GridView1.DataBind();
        }
    }
}