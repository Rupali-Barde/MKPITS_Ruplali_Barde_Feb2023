using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor
{
    public static  class Class1
    {
        public static SqlConnection con = null;
        public static SqlConnection getConnection()
        {
         con = new SqlConnection("server=.\\sqlexpress;integrtaed security = true;database=trust");
            return con;
        }
    }
}
