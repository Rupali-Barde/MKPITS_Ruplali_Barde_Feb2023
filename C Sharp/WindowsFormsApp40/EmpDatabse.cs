using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp40
{
    public static  class EmpDatabse
    {
        
        private static string ConnectionString = "server=.\\sqlexpress;integrated security = true;database = CreateDelete";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string InputEmployee(int employeeId, string employeeName, string gender, string email, long mobileNumber, string city, string DOB)
        {
            SqlConnection con = GetConnection();
            string query = "insert into Employee(employeeId, employeeName, gender, email, mobileNumber, city, DOB) " +
                           "values (@employeeId, @employeeName, @gender, @email, @mobileNumber, @city, @DOB)";

            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.ExecuteNonQuery();
                return "Values Inserted Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        public static string EmployeeUpdate(string employeeName, int employeeId)
        {
            SqlConnection con = GetConnection();
            string query = "update Employee set employeeName = @employeeName where employeeId = @employeeId";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.ExecuteNonQuery();
                return "Updated sucessfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }

        public static string EmployeeDelete(int employeeId)
        {
            SqlConnection con = GetConnection();
            string query = "delete from Employee where employeeId = @employeeId";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.ExecuteNonQuery();
                return "Deleted Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }

        /*public static SqlDataReader GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select  * from city";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader dr = command.ExecuteReader(); //read only forward only stream
                return dr;
            }
            catch
            {
                return null;
            }
        }*/

        public static DataSet GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from city";

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "city");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public static DataSet GetEmployeeDetails()
        {
            SqlConnection con = GetConnection();
            string query = "select * from Employee";
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Employee");
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public static DataSet SearchEmployee(int employeeId)
        {
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            string query = "select * from Employee where employeeId = @employeeId";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@employeeId", employeeId);
            da.Fill(ds, "Employee");
            return ds;
            //SqlConnection con = GetConnection();
            //string query = "select * from Employee where employeeId = @employeeId";
            //DataSet ds = new DataSet();
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //da.SelectCommand.Parameters.Add("@employeeId", employeeId);
            //da.Fill(ds, "Employee");
            //return ds;

        }
    }
}


    

