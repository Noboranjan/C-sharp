using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Enquiry
{
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panel2.Width >= 180)
            {
                panel2.Width = 52;
            }
            else
            {
                panel2.Width = 180;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            add_train1.BringToFront();
            
         
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
