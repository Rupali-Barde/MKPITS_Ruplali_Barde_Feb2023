using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlTypes;
using System.CodeDom;

namespace WindowsFormsApp38
{
    public static class insertupadate
    {
        //creating a static variable
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=company";

        //creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;


            }
            catch (SqlException ee)
            {
                return null;
            }
        }

        //Creating a static method to insert record into employee table
        public static string InsertRecord(int Empid, string Empname, string Gender, string Email, int MobileNo,
 string city, string DOB)
        {
            SqlConnection con = GetConnection();

            //creating a insert command
            string query = "insert into employee values(@Empid,@Empname,@Gender,@Email,@MobileNo,@City,@DOB)";

            //@Empid,@Empname are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);

                //defining sqlparameters
                command.Parameters.AddWithValue("@Empid", Empid);
                command.Parameters.AddWithValue("@Empname", Empname);
                command.Parameters.AddWithValue("Gender", Gender);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@MobileNo", MobileNo);
                command.Parameters.AddWithValue("@City", City);
                command.Parameters.AddWithValue("@DOB", DOB);

                //Executing the command using exeuctenonquery method
                command.ExecuteNonQuery();
                return "Record Inserted Successfully";
            }
            catch (SqlException ee)
            {
                return ee.ToString();

            }
            finally
            {
                con.Close();
            }

        }

        //Creating a static method to update record into employee table
        public static string UpdateEmployee(int Empid, string Empname, string Gender, string Email, int MobileNo, string city, string DOB)
            SqlConnection con = GetConnection();

        //Creaitng a iinsert command
        string query = "update employee set Email=@Emial where Empname=@Empname";

        //@Email and @Empname are sqlparameters
        try
        {
        //Craeting an object of sqlcommand class
        SqlCommand command = new SqlCommand(Queryable, con);

        //defining sqlparameters
        command.Parameters.AddWithValue("@Empname",empname);

            //Executing the command using executenonquery method
            command.ExecuteNonQuery();
            return "Record Updated Successfully";
            }
    catch (Exception ee)
        {
        return ee.ToString();
        }
finally
{
    const.Close();
}




    }
}
