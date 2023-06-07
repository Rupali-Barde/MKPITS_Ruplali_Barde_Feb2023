using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie2 = new HttpCookie("cook1");
            cookie2.Values.Add( "UserName ", TextBox1.Text);
            cookie2.Values.Add("Email" , TextBox2.Text);
            DateTime dt     = DateTime.Now;
            TimeSpan ts =  new TimeSpan(0,1,0);
            cookie2.Expires = dt.Add (ts);
            Label1.Text = "permanent cookie added to client machine";
            Response.Cookies.Add(cookie2);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie2 = Request.Cookies["cook1"];
            if (cookie2 != null)
            {
                string uname = cookie2.Values["UserName"].ToString();
                string email = cookie2.Values["Email"].ToString();
                Label1.Text =  "UserName:" +uname;
                Label1.Text = "Email:" +email;


            }
            else
            {
                Label1.Text = "No Peremenant Cookie Exist";
            }

        }
    }
}