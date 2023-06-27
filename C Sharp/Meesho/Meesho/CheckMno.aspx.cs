using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Meesho
{
    public partial class CheckMno : System.Web.UI.Page
    {
        string ProdId;
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meesho2");
        SqlCommand command;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdId = Convert.ToString(Session["ProdId"]);
            Response.Write("ProdId" + ProdId);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Save The Data Into Cart Table
            string res = TextBox1.Text;
            string ProdName = null;
            int ProdPrice = 0;
            int Qty = 0;
            string SessionId = null;
            if(res == "123456")
            {
                query = "select * from Product where ProdId=@ProdId";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ProdId", ProdId);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    ProdName = dr["ProdName"].ToString();
                    ProdPrice = Convert.ToInt32(dr["ProdPrice"].ToString());
                    Qty = 1;
                    SessionId = Session.SessionID;
                }
                con.Close();
                Response.Write("ProdName"+ProdName +"<br>");
                Response.Write("ProdPrice" + ProdPrice + "<br>");
                Response.Write("Qty" + Qty + "<br>");
                Response.Write("SessionId" + SessionId + "<br>");
                //Response.Redirect("Cart1.aspx");
            }
            else
            {
                Label1.Text = "Invalid OTP";
            }

            //code to insert data into cart table
            query = "insert into Cart values(@CartId,@ProdId,@ProdPrice,@Qty,@SessionId)";
            command = new SqlCommand(query, con);
            con.Open();
           // command.Parameters.AddWithValue("@CartID",CartId);
            command.Parameters.AddWithValue("@ProdId",ProdId);
            command.Parameters.AddWithValue("@ProdPrice", ProdPrice);
            command.Parameters.AddWithValue("@Qty",Qty);
            command.Parameters.AddWithValue("SessionId",SessionId);

            //con.Open();
            command.ExecuteNonQuery();
            con.Close();

        }
    }
}