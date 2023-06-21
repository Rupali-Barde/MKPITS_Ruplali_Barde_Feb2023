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
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("Server=.\\sqlexpress;integrated security=true;database=meesho2");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                da = new SqlDataAdapter("select * from Product",con);
                ds = new DataSet();
                da.Fill(ds,"Product");
                DataList1.DataSource = ds.Tables["Product"].DefaultView;
                DataList1.DataBind();
            }
        }
    }
}