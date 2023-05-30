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
using System.CodeDom;
using System.Security.Cryptography;

namespace project1
{
    public partial class Form1 : Form
    {
        //creating an enum Nationality
        enum Nationality { Indian, NRI }
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStoreDatabase.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";


        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStoreDatabase.GetProduct_Type_Name(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";

            //percent gst

            DataSet ds2 = ProductStoreDatabase.GetGstDetails(comboBox1.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                // textBox3.Text = (dr["cgst"].ToString());
                //textBox4.Text = (dr["sgst"].ToString());
                //textBox5.Text = (dr["igst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
            }

            

            if (nationality == 0)
            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStoreDatabase.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //Selected Radio Button
        {
            nationality = Nationality.Indian;
            //%Gst 
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = (cgst + sgst).ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Selected Radio Button
            nationality = Nationality.NRI;
            //GST%
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();

        }

        

      private void textBox10_TextChanged(object sender, EventArgs e)
      {

      }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

            if (textBox10.Text == "")
            {

            }
            else
            {
                double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
                textBox11.Text = totalamount.ToString();

                double cgstamount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox3.Text));
                textBox3.Text = cgstamount.ToString();

                double sgstamount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox4.Text));
                textBox4.Text = cgstamount.ToString();

                double igstamount = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text));
                textBox5.Text = igstamount.ToString();

                double netamount = Convert.ToDouble(textBox11.Text)+ Convert.ToDouble(textBox8.Text);
                textBox12.Text = netamount.ToString();
            }
        }
    }
}
