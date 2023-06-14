using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace Methods
{
    public partial class Methods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c  = new Class1();
            Label1.Text = c.Addition(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label1.Text = c.Subtraction(Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label1.Text = c.Multiplication(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label1.Text = c.Division(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }
    }
    
    
}