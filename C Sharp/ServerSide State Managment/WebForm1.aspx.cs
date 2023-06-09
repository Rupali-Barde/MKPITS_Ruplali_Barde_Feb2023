using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSide_State_Managment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int uc = (int)Session["usercount"];
            uc = uc + 1;
            Session["usercount"] = uc;
            Response.Write("User Session Count " + uc);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Session["email"] = TextBox2.Text;
            Label1.Text = "Value Stored in Session Variable";

        }
    }
}