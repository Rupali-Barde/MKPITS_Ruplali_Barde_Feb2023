using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace validation
{
    public partial class validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String val = args.Value;
            int length = args.Value.Length;
            if(length == 10)
            {
                string d = val.Substring(0, 2);
                //Response.Write("dd" +d);
                int dd = Convert.ToInt32(d);
                if (dd > 31)
                {
                    args.IsValid = false;
                }
                else
                {
                    string m = val.Substring(3, 2);
                    //Response.Write("mm"+m);
                    int mm = Convert.ToInt32(m);
                    if (mm > 12) 
                    {
                        args.IsValid = false;
                    }
                    else
                    {
                        string y = val.Substring(6, 4);
                        //Response.Write("yy" + y)
                        //int mm = Convert.ToInt32(y);
                        int y1 = y.Length;
                        if(y1 == 4)
                        {
                            args.IsValid = true;
                        }
                        else
                        {
                            args.IsValid = false;
                        }
                    }
                }
                args.IsValid = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = TextBox1.Text;
            }
            else
            {
                Label1.Text =  "page is not valid" ;
            }

        }
    }
}