using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            label8.Text = EmployeeDetail.InsertRecord(textBox1.Text, textBox2.Text, gender, textBox3.Text, textBox4.Text, dateTimePicker1.Text, comboBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Connected

            //SqlDataReader dr = EmployeeDetail.GetCity();
            //while (dr.Read())
            //{
            //  comboBox1.Items.Add(dr["cityname"].ToString());
            //}

            //Disconnected
            DataSet ds = EmployeeDetail.GetCity();
            foreach(DataRow dr in ds.Tables["city"].Rows) 
            {
                comboBox1.Items.Add(dr["cityname"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

