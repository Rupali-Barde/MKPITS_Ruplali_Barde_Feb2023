﻿using System;
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
            getvendorid();
            TextBox2.Text = "";
        }
        public void getvendorid()
        {
            int res =Convert.ToInt32(VendorClass.getVendor_Id());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = VendorClass.updateVendor_Mast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));

            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = VendorClass.deleteVendor_Mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searchVendor_mast(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
}