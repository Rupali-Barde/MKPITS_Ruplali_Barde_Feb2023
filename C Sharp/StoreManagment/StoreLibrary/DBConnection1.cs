using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StoreLibrary
{
    internal class DBConnection1
    {

        public static SqlConnection con;
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=trust");
            con.Open();
            return con;
        }
    }
}
