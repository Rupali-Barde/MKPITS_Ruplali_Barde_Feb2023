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
    public partial class Item_Master : System.Web.UI.Page
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
            str = "Select * from Item_Master";
            da = new SqlDataAdapter(str,con);
            da.Fill(ds, "Item_Master");
            GridView1.DataSource = ds.Tables["Item_Master"].DefaultView;
            GridView1.DataBind();

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Item_Master where Item_Name =@Item_Name";
            SqlCommand cmd = new SqlCommand(str,con);
            da.SelectCommand.Parameters.AddWithValue("@Item_Name",TextBox4.Text);
            da.Fill(ds, "Item_Master");

            TextBox2.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[2].ToString();

            TextBox4.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["Item_Master"].DefaultView;

            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_Master values (@Item_Name,@Category,@Rate,@Balance_Quantity)";
            SqlCommand command = new SqlCommand(str,con);

            command.Parameters.AddWithValue("Item_Name", TextBox4.Text);
            command.Parameters.AddWithValue("Category",DropDownList1.SelectedValue);
            command.Parameters.AddWithValue("Rate",Convert.ToDecimal(TextBox2.Text));
            command.Parameters.AddWithValue("Balance_Quantity", Convert.ToInt32(TextBox3.Text));
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
            str = "update Item_Master set Item_Name=@Item_Name,Category=@Category,Rate=@Rate,Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("Item_Id",Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("Item_Name", TextBox4.Text);
            command.Parameters.AddWithValue("Category", DropDownList1.SelectedValue);
            command.Parameters.AddWithValue("Rate", Convert.ToDecimal(TextBox2.Text));
            command.Parameters.AddWithValue("Balance_Quantity", Convert.ToInt32(TextBox3.Text));
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
            str = "delete from Item_Master where Item_Name=@Item_Name";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("Item_Name", TextBox4.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Deleted";
            loaddata();
            TextBox1.Text = "";
            TextBox1.Focus();
        }


        
    }
}