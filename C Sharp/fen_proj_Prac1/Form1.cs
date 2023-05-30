using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fen_proj_Prac1
{
    public partial class Form1 : Form
    {
        //Creating an enum Nationality
        enum Nationality { Indian,NRI}
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.INDIAN;

            //MessageBox.show(nationality.ToString());
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5 = Convert.ToString(Convert.ToInt32(textBox3.Text) + (Convert.ToInt16(textBox4.Text));

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();

        }
    }
}
