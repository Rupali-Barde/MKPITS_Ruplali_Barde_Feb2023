using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerObject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello From Webpage1 Form");
            Server.Execute("webform2.aspx");
            Response.Write("Welcome Back To WebPage1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Hello From Webpage1 Transfer Form");
            Server.Transfer("webform2.aspx");
            Response.Write("Welcome Back To WebPage1");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<h1> is an example of a Heading Tag</h1>"));
            Response.Write("<h1> Is An Example Of A Heading Tag");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost/code/map.aspx"));
            Response.Write("http://localhost/code/map.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string name = Server.UrlEncode("Rupali Barde");
            Response.Redirect("webform2.aspx?name=" +name);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            string name = Server.UrlEncode("Rupali Barde");

            string password = Server.UrlEncode("queen");

            Response.Redirect("Webform3.aspx?name=" + name + "&password=" + password);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Write(Server.MapPath("/webform3.aspx"));
        }
    }
}