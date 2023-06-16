using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using StoreLibrary;

namespace Vendor_Mast1
{
    public partial class Vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(!Page.IsPostBack)
            //{
            //    getvendorid();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = VendorClass.insertVendor_Mast(TextBox2.Text);
            Label1.Text = res;
            //getvendorid();
            TextBox2.Text = "";
        }
        //public void getvendorid()
        //{
        //    int res =VendorClass.getVendor_Id(Convert.ToInt32(TextBox1.Text));
        //    res = res + 1;
        //    TextBox1.Text = res.ToString();
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            //string res = VendorClass.updateVendor_Mast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));
            //Label1.Text = res;
        }
    }
}