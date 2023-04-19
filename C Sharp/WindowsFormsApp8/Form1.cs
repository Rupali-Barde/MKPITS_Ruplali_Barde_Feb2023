using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int bal = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            int amt = Convert.ToInt32(textBox2.Text);
            if(amt > 0 )
            {
                bal = bal + amt;
                label3.Text = "Amount Deposite Balance is " + bal;

            }
            else
            {
                label3.Text = "Enter Amount Greater than 0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amt = Convert.ToInt32(textBox2.Text);
            if(amt <= bal ) 
            {
                bal = bal - amt;
                label3.Text = "Amount With ,Bal is" + bal;
            }
            else
            {
                label3.Text = " Insufficient Amount";
            }
        }
    }
}
