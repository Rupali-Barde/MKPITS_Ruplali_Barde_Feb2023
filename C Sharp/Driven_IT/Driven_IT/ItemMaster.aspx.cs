using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.CodeDom;

namespace Driven_IT
{
    public partial class ItemMaster : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security = true;database=DrivenIt");
        SqlCommand command = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions values(@ItemId,@TransType,@TransQty,@TransDate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                string trans = null;
                if (RadioButton1.Checked)
                {
                    trans = "I";
                }
                else if (RadioButton2.Checked)
                {
                    trans = "R";
                }
                command.Parameters.AddWithValue("@transType", trans);
                command.Parameters.AddWithValue("@transQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from Itemmaster table for particular item id
                query = "select max(BalQty)from ItemMaster where ItemId=@ItemId";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (trans == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (trans == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }

                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemId=@ItemId";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();
                Label1.Text = "Record Saved";

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();

            }
            finally
            {
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update Transactions set TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where ItemId=@ItemId";
                command = new SqlCommand(query, con);
                string trans = null;
                if (RadioButton1.Checked)
                {
                    trans = "I";
                }

                else if (RadioButton2.Checked)
                {
                    trans = "R";
                }
                    command.Parameters.AddWithValue("@TransType", trans);
                    command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                    command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                    command.Parameters.AddWithValue("ItemId", DropDownList1.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();

                    //getting the balqty from itemmaster table for particular item id
                    query = "select max(BalQty)from ItemMaster where ItemId=@ItemId";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    int bq = Convert.ToInt32(command.ExecuteScalar());
                if (trans == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (trans == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }


                        //updating bal qty on item master table
                        query = "update ItemMaster set BalQty=@BalQty where ItemId=@ItemId";
                        command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@BalQty", bq);
                        command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                        command.ExecuteNonQuery();
                        Label1.Text = "Record Updated Successfully";
            }
                    catch(Exception ex)
                   { 
                        Label1.Text = ex.ToString();
                    }
                    finally
            {
                con.Close();
            }

        }

        //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
           
        //}
    }


}
    
    