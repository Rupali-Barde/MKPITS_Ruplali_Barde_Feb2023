using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hyperlink
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook1");
            cookie.Values.Add("Username", TextBox1.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "Temprory Cookie Added To Client Machine";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if (cookie != null) 
            {
                string uname = cookie.Values["Username"].ToString();
                Label1.Text = "Username" + uname;

            }
            else
            {
                Label1.Text = "Cookie Does Not Exist";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook2");
            cookie.Values.Add("Username",  TextBox1.Text);
            cookie.Values.Add("Email",  TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 1, 0);
            cookie.Expires = dt.Add(ts);
            Label1.Text = "Permanent Cookie Added To Client Machine";
            Response.Cookies.Add(cookie);


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if (cookie != null) 
            {
                string uname = cookie.Values["Username"].ToString();
                string email = cookie.Values["Email"].ToString();
                Label1.Text = "Username" + uname;
                Label2.Text = "Email" + email;
            }
            else
            {
                Label1.Text = "No Permanent Cookie Exist";
            }
        }
    }
}