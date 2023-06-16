using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication6TRUST
{
    public partial class Transaction_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string query = null;
            SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transaction_Process(item_id,transaction_date,Department_id,quantity) values(@item_id,@transaction_date,@department_id,@quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@transaction_date", TextBox3.Text);
                    command.Parameters.AddWithValue("@department_id", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@quantity", TextBox2.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    //code to get balance_quantity from item_master table
                    int bal_qty = 0;
                    query = "select balance_quantity from item_master where item_id=@item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    //  Response.Write("bal qty " + bal_qty.ToString());
                    int qty = bal_qty - Convert.ToInt32(TextBox2.Text);

                    query = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id";

                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balance_quantity", qty);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();
                    //con.Close();
                    Label1.Text = "item issued to department successfully";


                }
                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally
                {
                    con.Close();
                }
            }
        }





        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Label2.Visible = true;
                DropDownList2.Visible = true;
                Label3.Visible = false;
                DropDownList3.Visible = false;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Label2.Visible = false;
                DropDownList2.Visible = false;
                Label3.Visible = true;
                DropDownList3.Visible = true;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}  
