using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FendhalPreparation
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1Save_Click(object sender, EventArgs e)
        {
           

        }

        private void button1Reset_Click(object sender, EventArgs e)
        {
            textBox1Name.Text = "";
            textBox2Age.Text = "";
            textBox3MobileNo.Text = "";


        }
    }
}
