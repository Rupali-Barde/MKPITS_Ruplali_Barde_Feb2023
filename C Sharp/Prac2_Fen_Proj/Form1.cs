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
using System.Security.Cryptography.X509Certificates;

namespace Prac2_Fen_Proj
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        public Form1()
        {
            InitializeComponent();

        }

        //Creating an enum nationality

        Nationality nationality;
        double  cgst = 0;
        double sgst = 0;
        double igst = 0;
        double tgst = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filling the product name in comboboxd2
            DataSet ds = ProductStore.GetTableProductTypeName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductId";

            //Filling the gst textboxes
            DataSet ds1 = ProductStore.GetGstDetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToDouble(dr["cgst"].ToString());
                sgst = Convert.ToDouble(dr["sgst"].ToString());
                igst = Convert.ToDouble(dr["igst"].ToString());
            }
            if (nationality == 0)
            {
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = (Convert.ToDouble(cgst) + Convert.ToDouble(sgst)).ToString();
            }
            else
            {
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = igst.ToString();
            }

        }
        public void GSTDetails()
        {
            if (nationality == 0)
            {
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = (Convert.ToDouble(cgst) + Convert.ToDouble(sgst)).ToString();
            }
            else
            {
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = igst.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                //Filling The product Price In Textbox.
                textBox9.Text = dr["productprice"].ToString();

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;

            //MessageBox.Show(nationality.ToString())


            GSTDetails();
            calculate_total();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;

            ////MessageBox.Show(nationality.ToString())
            GSTDetails();
            calculate_total();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
            

        }

        public void calculate_total()
        {
            double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = totalamount.ToString();

            //For CGST
            double cgst = (Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0));
            textBox6.Text = cgst.ToString();

            double sgst = (Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0));
            textBox7.Text = sgst.ToString();

            double igst = (Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0));
            textBox8.Text = igst.ToString();

            //Net Amount
            double netamount = 0;
            if(nationality == 0)
            {
                netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            }
            else 
            {
                netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            }
            textBox12.Text = netamount.ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }
        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill The Details");
            }
            else if (textBox3.Text == "0")
            {
               MessageBox.Show("Quantity Cannot Be Zero");
            }
            else
            {
                string result = ProductStore.saveTableInvoiceDetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(
   comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text),
   Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox11.Text),
   Convert.ToDecimal(textBox12.Text), Convert.ToDecimal(textBox8.Text));

                MessageBox.Show(result);
            }
                

            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && ! char.IsDigit (e.KeyChar))
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
    }
}



    

        
    



