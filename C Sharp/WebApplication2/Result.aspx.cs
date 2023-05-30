using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int subject1 = 0;
            int subject2 = 0;
            int subject3 = 0;
            int total = 0;
            double percentage;
            int grade;
            subject1=Convert.ToInt32(TextBox1.Text);
            subject2=Convert.ToInt32(TextBox2.Text);
            subject3=Convert.ToInt32(TextBox3.Text);

            total = subject1 + subject2 + subject3;
            Label1.Text = total.ToString();

            percentage = (total/300)*100 ;
            Label2.Text = percentage.ToString();


        }
    }
}