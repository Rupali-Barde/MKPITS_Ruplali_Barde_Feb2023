using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj2_prac
{
    public static class CourseRegistration2
    {
        private static string ConnectionString = "Server=.\\Sqlexpress;integrated security = true;database=project2";
         public static SqlConnection GetConnection()
         {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                return con;
            }
            catch (Exception ee)
            {
                return null;
            }
         }

        public static DataSet getNation()
        {

            SqlConnection con = GetConnection();
            string query = "select * from TableNation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds, "TableNation");
            return ds;
        }

        public static DataSet getState(string NationName)
        {
            SqlConnection con = GetConnection();
            string query = "select s.StateID,s.StateName from TableState s inner join TableNation  t on s.NationID =t.NationID where NationName =@NationName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@NationName", NationName);
            da.Fill(ds,"NationName");
            return ds;
        }

        public static DataSet getCity (string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityID,c.CityName from TableCity c inner join TableState s on c.StateID = s.StateID where StateName =@StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "StateName");
            return ds;

        }
    }
}
