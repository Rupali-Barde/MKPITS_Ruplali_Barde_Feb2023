using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.GetConnection();
            if(con != null )
            {
                label1.Text = "Connected Successfully";
                con.Close();
            }
            else
            {
                label1.Text = "unable To Connect";
            }
        }
    }
}
