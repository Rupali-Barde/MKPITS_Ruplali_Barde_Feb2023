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

namespace Fen_Ass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        enum Category { Student, ITProfessional }
        Category category;

        enum Gender { Male, Female, Other }
        Gender gender;

        private void Form1_Load(object sender, EventArgs e)
        {


            textBox2.Text = "1000";
            DataSet ds = new DataSet();
            ds = CourseRegistration.getNation();
            comboBox1.DataSource = ds.Tables["TableNation"];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //MessageBox.Show(comboBox1.Text);
            DataSet ds = new DataSet();
            ds = CourseRegistration.getState(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration.getCity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox3.Clear();
            textBox4.Clear();
            category = Category.Student;
            double Student = 1000;
            textBox2.Text = Student.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            category = Category.ITProfessional;
            double ITProfessional = 3000;
            textBox2.Text = ITProfessional.ToString();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount();
        }

        public void check_balance_amount()
        {
            double total = Convert.ToDouble(textBox2.Text);
            double fp = 0;
            if (category == 0)
            {
                fp = total * 0.5;
            }
            else
            {
                fp = total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {
                MessageBox.Show("Paid Amount Should Be Atleast 50% For Student And 80% For IT_Professional");
            }
            else
            {
                double bal_amount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = bal_amount.ToString();


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string result = CourseRegistration.saveTableCourseRegDetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
            MessageBox.Show(result);

            string result1 = CourseRegistration.saveTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);

            string result2 = CourseRegistration.SaveTableFeeDetail(Convert.ToDouble(textBox2.Text), FixedPanel, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), dateTimePicker1.value);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)

                gender = Gender.Male;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)

                gender = Gender.Female;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)

                gender = Gender.Other;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
                
        }

       
        
    }
}
