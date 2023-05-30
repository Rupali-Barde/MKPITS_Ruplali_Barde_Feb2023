using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp40
{
    public partial class Emp_Details_Form : Form
    {
        public Emp_Details_Form()
        {
            InitializeComponent();
        }

       

        //private void Emp_Details_Form_Load(object sender, EventArgs e)
        //{
        //    SqlDataReader dr = EmployeeDetails.GetCity();
            
        //    //reading the records from sqldatareader
        //    while(dr.Read())
        //    {
        //        comboBox1.Items.Add(dr["cityname"].ToString());
        //    }
        //    DataSet ds =EmployeeDatabase.GetCity();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = "Male";
            }
            else if(radioButton2.Checked)
            {
                gender = "Female";
            }
            label8.Text = EmployeeDetails.EmployeeInsert(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, textBox3.Text, Convert.ToInt64(textBox4.Text), comboBox1.Text, dateTimePicker1.Text);
            allClear();
            
        }
        public void allClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Text = "01 january 1900";
            radioButton1.Checked = false;
            radioButton1 .Checked = false;
            textBox1.Focus();
        }

        

      
    }
}
