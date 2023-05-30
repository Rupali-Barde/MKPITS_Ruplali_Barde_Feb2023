using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp36
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

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = insertdatabase.InsertRecord( textBox2.Text, comboBox1.Text);
            label4.Text = result;
            
            textBox2.Clear();
            comboBox1.Items.Clear();
            
            textBox2.Focus();
        }
    }
}
