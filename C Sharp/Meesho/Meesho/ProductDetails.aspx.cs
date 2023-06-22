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
    public partial class ProductDetails : System.Web.UI.Page
    {
        //Create Connection
        SqlConnection con = new SqlConnection("Server=.\\sqlexpress;integrated security=true;database=meesho2");

        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["ProdId"].ToString();
            //Response.Write(prodid);

            da = new SqlDataAdapter("select * from Product where ProdId=@ProdId", con);

            da.SelectCommand.Parameters.AddWithValue("@ProdId", prodid);
            ds = new DataSet();
            da.Fill(ds, "productdetails");
            DataList1.DataSource = ds.Tables["productdetails"].DefaultView;
            DataList1.DataBind();

        }

        //protected void DataList1_selectedChanged(object sender, EventArgs e)
        //{

        //}

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}