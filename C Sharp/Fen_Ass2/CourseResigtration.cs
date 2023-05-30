using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Fen_Ass2
{
    static class CourseRegistration
    {
        private static string ConnectionString = "Server=.\\sqlexpress;integrated security=true;database=Fen2_Proj";
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
            string query = "select * from TableNation";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds,"TableNation");
            return ds;
        }

        public static DataSet getState(string NationName) 
        {
            // System.Windows.Forms.MessageBox.Show(NationID);
            SqlConnection con = GetConnection();
            string query = "select s.StateID,s.StateName from TableState s inner join  TableNation t on s.NationID = t.NationID where NationName=@NationName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query ,con);
            da.SelectCommand.Parameters.AddWithValue("@NationName",NationName);
            da.Fill(ds, "TableState");
            return ds;
        }

        public static DataSet getCity (string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select c.CityID,c.CityName from TableCity c inner join TableState s on c.StateID = s.StateID where StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query ,con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;


        }

        public static string saveTableCourseRegDetail(int CategoryID, string FullName, int GenderID)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetail values(@categoryid,@fullname,@genderid)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@categoryid", CategoryID);
            command.Parameters.AddWithValue("@fullname", FullName);
            command.Parameters.AddWithValue("@genderid", GenderID);
            command.ExecuteNonQuery();
            con.Close();
            return "record saved in TableCourseRegDetail";
        }
        static int CourseRegID = 0;
        public static string saveTableRegAddress (int NationID,int StateID,int CityID)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "SELECT top 1 courseregid FROM tablecourseregdetail ORDER BY courseregid DESC ";
            SqlCommand command = new SqlCommand(query, con);
            CourseRegID = Convert.ToInt32(command.ExecuteScalar());
             query = "insert into TableRegAddress values(@CourseRegId,@NationID,@StateID,@CityID)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            command.Parameters.AddWithValue("@NationID", NationID);
            command.Parameters.AddWithValue("@StateID", StateID);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.ExecuteNonQuery();
            con.Close();
            return "Record Save in TableRegAddress";

        }

        public static string SaveTableFeeDetail(double TotalAmount,double MinPer,double PaidAmount,double BalAmount,DateTime PaidDate)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableFeeDetail values(@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand command = new SqlCommand (query, con);
            command.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            command.Parameters.AddWithValue("@TotalAmount",TotalAmount);
            command.Parameters.AddWithValue("@MinPer", MinPer);
            command.Parameters.AddWithValue("@PaidAmount",PaidAmount);
            command.Parameters.AddWithValue("@BalAmount", BalAmount);
            command.Parameters.AddWithValue("PaidDate", PaidDate);
            command.ExecuteNonQuery();
            con.Close();
            return "Record save In TableFeedetails";


        }
    }
}
