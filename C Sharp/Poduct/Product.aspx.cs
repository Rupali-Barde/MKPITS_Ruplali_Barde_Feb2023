using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace Poduct
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string itemname;
            int quantity;
            double price;
            double res = 0;
            
            itemname = Convert.ToString(TextBox1.Text);
            quantity = Convert.ToInt32(TextBox3.Text);
            price = Convert.ToDouble(TextBox4.Text);
            res = quantity * price;
            Label2.Text = res.ToString();

           


        }
    }
}