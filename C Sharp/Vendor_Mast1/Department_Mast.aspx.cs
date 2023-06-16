using StoreLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vendor_Mast1
{
    public partial class Department_Mast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = StoreLibrary.Department_Mast.insertDepartment_Mast(TextBox2.Text);
            Label1.Text = res;
            // getDepartment_Id();
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = StoreLibrary.Department_Mast.updateDepartment_Mast(TextBox2.Text, Convert.ToInt32(TextBox1.Text));

            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = StoreLibrary.Department_Mast.deleteDepartment_Mast(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {


            DataSet ds = new DataSet();
            ds =StoreLibrary. Department_Mast.searchDepartment_Mast(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "No Record Exist";
            }

        }

    }
}
    
