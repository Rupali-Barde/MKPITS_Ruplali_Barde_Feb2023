using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie cookie1 = new HttpCookie("cook1");
            //cookie1.Values.Add("UserName", TextBox1.Text);
            //Response.Cookies.Add(cookie1);
            //Label1.Text = "Temporary Coookie Added To Client Machine";


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook1");
            cookie.Values.Add("UserName",TextBox1.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "Temporary Cookie Added To Client Machine";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if(cookie != null)
            {
                string uname = cookie.Values["UserName"].ToString();
                Label1.Text = "UserName" + uname;

            }
            else
            {
                Label1.Text = "No Cookie Exist";
            }
        }
    }
}