using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cook1"];
            if (cookie != null)
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