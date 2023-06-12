using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Security;

namespace ADOEx1
{
    public partial class WebForm1ADO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("dTable");
            DataRow dr;
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("DOA", typeof(DateTime)));
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Rupali";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Mayuri";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "Mahima";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 4;
            dr[1] = "Shreya";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 5;
            dr[1] = "Akanksha";
            dr[2] = DateTime.Now;
            dt.Rows.Add(dr);

            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["dTable"].DefaultView;
            GridView1.DataBind();
        }
    }
}