using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ADOEX3
{
    public partial class WebFormADO3Ex : System.Web.UI.Page
    {
         SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Project");
         DataSet ds = new DataSet();
         SqlDataAdapter da;
         string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            str = "Select * from TableProduct";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "TableProduct");
            GridView1.DataSource = ds.Tables["TableProduct"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into TableProduct values(@ProductID,@ProductTypeID,@ProductName,@ProductPrice)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@ProductTypeID", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@ProductName", TextBox3.Text);
            command.Parameters.AddWithValue("@ProductPrice", Convert.ToInt32(TextBox4.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Inserted";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "update tableproduct set producttypeid=@producttypeid,productname=@productname,ProductPrice=@ProductPrice where ProductID=@ProductID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@ProductTypeID", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@ProductName", TextBox3.Text);
            command.Parameters.AddWithValue("@ProductPrice", Convert.ToInt32(TextBox4.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Updated";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from TableProduct where ProductID = @ProductID";
            SqlCommand command = new SqlCommand(str,con);
            command.Parameters.AddWithValue("@ProductID", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery(); 
            con.Close();
            Label1.Text = "Record Deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from tableproduct where productid=@productid";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "tableproduct");

            TextBox2.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[2].ToString();

            TextBox4.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;

            GridView1.DataBind();
        }
    }
}