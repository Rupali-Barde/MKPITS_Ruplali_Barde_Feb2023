using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj2_prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate=DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
            enum Category {Student,IT_Professional}
            enum Gender {Male,Female,Other }
            Category category;
            DataSet ds = new DataSet();
            ds = CourseRegistration2.getNation();
            comboBox1.DataSource= ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration2.getState(comboBox1.Text);
            comboBox2.DataSource= ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration2.getCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
        }
    }
}
