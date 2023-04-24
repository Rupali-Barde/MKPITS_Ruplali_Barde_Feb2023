using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            
            switch (comboBox1.Text) 
            {
                case "Kisika Bhai Kisiki Jaan":
                    comboBox2.Items.Add("Liberty");
                    comboBox2.Items.Add("Cinemax");
                    break;
                case "Bhola":
                    comboBox2.Items.Add("Smruti");
                    comboBox2.Items.Add("Inox");
                    break;
                case "Bramhastra":
                    comboBox2.Items.Add("Alankar");
                    comboBox2.Items.Add("Sudama");
                    break;
                
                case "Pathan":
                    comboBox2.Items.Add("PVR");
                    comboBox2.Items.Add("Sudama");
                    break;
                    //Kisika Bhai Kisiki Jaan
                    //Bhola
                    //Bramhastra
                    //Pathan
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox3.Items.Clear();
            //comboBox2.Text = " ";
            //comboBox3.Text = " ";
            switch (comboBox2.Text) 
            {
                case "Liberty":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("03.00 PM");
                    textBox1.Text = "120";
                    break;
                case "Cinemax":
                    comboBox3.Items.Add("10.00 AM");
                    comboBox3.Items.Add("12.30 PM");
                    textBox1.Text = "420";
                    break;
                case "Smruti":
                    comboBox3.Items.Add("09.00 AM");
                    comboBox3.Items.Add("10.00 AM");
                    textBox1.Text = "310";
                    break;
                case "Inox":
                    comboBox3.Items.Add("09.30 AM");
                    comboBox3.Items.Add("10.30 AM");
                    textBox1.Text = "150";
                    break;
                case "Alankar":
                    comboBox3.Items.Add("03.00 AM");
                    comboBox3.Items.Add("12.00 PM");
                    textBox1.Text = "220";
                    break;
                case "Sudama":
                    comboBox3.Items.Add("09.30 AM");
                    comboBox3.Items.Add("10.00 AM");
                    textBox1.Text = "250";
                    break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Movie_Ticket mt = null;
            if(radioButton1.Checked)
            {
                mt = new Online_Booking(comboBox1.Text, comboBox2.Text, comboBox3.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            else if(radioButton2.Checked)
            {
                mt = new BoxOffice(comboBox1.Text, comboBox2.Text, comboBox3.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            label6.Text = mt.Calculate_Ticket_Price();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
