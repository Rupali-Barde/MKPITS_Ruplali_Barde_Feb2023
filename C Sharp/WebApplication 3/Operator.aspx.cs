using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_3
{
    public partial class Operator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            int result = 0;
            number1 = Convert.ToInt32(TextBox1.Text);
            number2 = Convert.ToInt32(TextBox3.Text);
            string Operator = TextBox2.Text;

            switch (Operator)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                    case "/":
                    result = number1 / number2;
                    break;

            }
            Label1.Text = result.ToString();

        }
    }
}