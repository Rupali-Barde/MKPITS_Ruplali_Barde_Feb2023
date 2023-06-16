using StoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace Vendor_Mast1
{
    public partial class Item_Mast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = StoreLibrary.Item_Master.insertItem_Master(TextBox2.Text, DropDownList1.Text, Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text));

            Label1.Text = res;
            // getItem_Id();
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string res = StoreLibrary.Item_Master.updateItem_Master(TextBox2.Text, Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = StoreLibrary.Item_Master.deleteItem_Master(Convert.ToInt32(TextBox1.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Item_Master.searchItem_Master(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox2.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "No Record Exist";
            }
        }
    }
}