using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WindowsFormsApp40
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        //Code for city incombobox
        private void Employee_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = EmployeeDetails.GetCity();
            while (dr.Read()) 
            {
                comboBox1.Items.Add(dr["cityname"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
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
            radioButton1.Checked = false;
            textBox1.Focus();
        }
    }
}
        