using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagment
{
    internal static class DbConnection
    {
        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust");
            return con;
        }
         


    }
}
    

