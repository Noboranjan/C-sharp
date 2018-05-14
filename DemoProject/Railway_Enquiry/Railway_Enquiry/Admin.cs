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
    public partial class Admin : Form
    {
        
        //SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Admin",con);
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;


        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NILOY\Documents\Railway_EnquiryDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("insert into Admin (Password,Username,Name,Gender,DateOfBirth,Email,Position) values ('" + Password.Text + "','" + Username.Text + "','" + Name.Text + "','" + Gender.Text + "','" + DateofBirth.Value.ToShortDateString() + "','" + Email.Text + "','" + Position.Text + "') ", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved");
        }
    }
}
