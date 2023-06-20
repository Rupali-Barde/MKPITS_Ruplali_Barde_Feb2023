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
            int updatedqty = 0;
            //Response.Write("transaction id"+transid.ToString());
            
            //Response.Write("updated qty" + updatedqty.ToString());

            try
            {
                query = "update Transactions set ItemId=@ItemId,TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where TransId=@TransId";
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
                    command.Parameters.AddWithValue("@ItemId",DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@TransType",trans);
                    command.Parameters.AddWithValue("@TransQty",Convert.ToInt32(TextBox1.Text));
                    command.Parameters.AddWithValue("@TransDate",TextBox2.Text);
                    command.Parameters.AddWithValue("@TransId",transid);
                    con.Open();
                    command.ExecuteNonQuery();

                    //getting the balqty from itemmaster table for particular item id
                    query = "select max(BalQty)from ItemMaster where ItemId=@ItemId";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    int bq = Convert.ToInt32(command.ExecuteScalar());
                    updatedqty = Convert.ToInt32(TextBox1.Text) - oldtransqty;
                //Response.Write("bq" + bq.ToString());
                    Response.Write("<br>updateqty" + updatedqty.ToString());
                if (RadioButton1.Checked)
                {
                    bq = bq - updatedqty;
                }
                if (RadioButton2.Checked)
                {
                    bq = bq + updatedqty;
                }
                Response.Write("<br>newupdatedqty"+ bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "Stock Not Available";
                }
                else
                {
                    // if (trans == "I")
                    // {
                    //  bq = bq - Convert.ToInt32(TextBox1.Text);
                    //  }
                    // else if (trans == "R")
                    // {
                    //bq = bq + Convert.ToInt32(TextBox1.Text);
                    //}


                    //updating bal qty on item master table
                    query = "update ItemMaster set BalQty=@BalQty where ItemId=@ItemId";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@BalQty", bq);
                    command.Parameters.AddWithValue("@ItemId", DropDownList1.SelectedValue);
                    command.ExecuteNonQuery();
                    Label1.Text = "Record Updated Successfully";
                }
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
        static int transid = 0;
        static int oldtransqty = 0;

      //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
      //  {
      //      TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
      //      oldtransqty = Convert.ToInt32(TextBox1.Text);
      //      DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5]);
      //      TextBox2.Text = dd.ToString("yyyy-MM-dd");
      //      DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;
      //      string res = GridView1.SelectedRow.Cells[3].Text;
      //      if(res == "I")
      //      {
      //          RadioButton2.Checked = false;
      //          RadioButton1.Checked = true;
      //      }
      //      if(res =="R")
      //      {
      //          RadioButton1.Checked = false;
      //          RadioButton2.Checked = true;
      //      }
      //     transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
      //  }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            //oldtransqty = Convert.ToInt32(TextBox1.Text);

            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");

            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;

            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;
            }
            if (res == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;
            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete from Transactions where TransId=@TransId";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@TransId", transid);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Deleted";
            //TextBox1.Text = "";
            //TextBox1.Focus();
            
        }
    }


}
    
    