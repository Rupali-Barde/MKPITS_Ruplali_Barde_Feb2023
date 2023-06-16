using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vendor_Mast1
{
    public partial class Transaction_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked) 
            {
                Label2.Visible = false;
                DropDownList3.Visible = false;
                Label1.Visible = true;
                DropDownList2.Visible = true;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked)
            {
                Label1.Visible=false;
                DropDownList2.Visible=false;
                Label2.Visible=true;
                DropDownList3.Visible=true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                string res = Transaction_Details.TransactionIssue(Convert.ToInt32)
            }
        }
    }
}