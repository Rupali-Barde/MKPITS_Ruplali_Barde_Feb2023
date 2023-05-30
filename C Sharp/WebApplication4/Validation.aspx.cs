using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age=0;
            string res=string.Empty;
            age = Convert.ToInt32(TextBox1.Text);
            if (age < 18)
            {
                res = "You Are Age Is Not Valid For Voting"; 
                    
                Label1.Text =res.ToString();
            }
            else
            {
                res = "You Are Age Is Valid For Voting";
                Label1.Text = res.ToString();
            }
        }
    }
}