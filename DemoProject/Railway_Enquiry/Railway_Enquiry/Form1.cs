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

namespace Railway_Enquiry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup sn = new Signup();
            sn.Show();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();// for backgroung close application
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NILOY\Documents\Railway_EnquiryDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query= "Select * from Admin Where Username = '" +name.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Admin_panel a = new Admin_panel();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }  
        }
    }
}
