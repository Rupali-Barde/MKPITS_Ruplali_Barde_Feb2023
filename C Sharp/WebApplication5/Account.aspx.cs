using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        double Balance = 1000;
        protected void Button1_Click(object sender, EventArgs e)
        {
            double AccountNo= Convert.ToDouble(TextBox1.Text);
            double Amount =Convert.ToDouble (TextBox2.Text);

            if(TextBox3.Text == "Deposite")
            {
                Balance = Amount + Balance;
            }

        }
    }
}