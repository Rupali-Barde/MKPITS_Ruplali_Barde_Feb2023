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

namespace Fen_Prac2
{
    public partial class Form1 : Form
    {
        enum Nationality { INDIAN,NRI}
        Nationality nationality;
        double cgst =0;
        double sgst = 0;
        double igst = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            DataSet ds = Product_Store2.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            //comboBox1.ValueMember = "Product_Category_ID";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Product_Store2.GetTableProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            //comboBox2.ValueMember = "ProductID";

            //Filling The GST textboxes
            

            DataSet ds1 = Product_Store2.GetTableGSTDetails(comboBox1.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToDouble(dr["cgst"]);
                sgst = Convert.ToDouble(dr["sgst"]);
                igst = Convert.ToDouble(dr["igst"]);
                
            }
            GSTDetails();

            //textBox3.Text = cgst.ToString();
            //textBox4.Text = sgst.ToString();
            //textBox5.Text = igst.ToString();
        }

        public void GSTDetails()
        {
             if (nationality == 0)
            {
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = (sgst+cgst).ToString();
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
            DataSet ds = Product_Store2.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           nationality = Nationality.INDIAN;

            //textBox3.Text = cgst.ToString();
            //textBox4.Text = sgst.ToString();
            //textBox5.Text =Convert.ToString(Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text));
            //calculate_total();
            GSTDetails();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            //textBox3.Text = cgst.ToString();
            //textBox4.Text = sgst.ToString();
            //textBox5.Text = igst.ToString();
            //calculate_total();
            GSTDetails();
        }
       
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                calculate_total() ;
            }


        }
            public void calculate_total()
            {
                double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
                textBox11.Text = totalamount.ToString();

                double cgstamount = (Convert.ToDouble(textBox10.Text) * (Convert.ToDouble(textBox3.Text) / 100));
                textBox6.Text = cgstamount.ToString();

                double sgstamount = (Convert.ToDouble(textBox10.Text) * (Convert.ToDouble(textBox4.Text) / 100));
                textBox7.Text = sgstamount.ToString();

                double igstamount = (Convert.ToDouble(textBox10.Text) * (Convert.ToDouble(textBox5.Text) / 100));
                textBox8.Text = igstamount.ToString();
            }
    }
}


        
    
