using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSide_State_Managment
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cn = (string)Application["companyname"];
            Label1.Text = cn;
            int counter = (int)Application["counter"];
            counter = counter + 1;
            Application["counter"] = counter;
            Label2.Text = "You Are Visitor No :" + counter.ToString();

        }
    }
}