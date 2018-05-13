using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fool_Game
{
    public partial class Fool_Game : Form
    {
        public Fool_Game()
        {
            InitializeComponent();
            Random ran = new Random();
        }

        private void NobtnEntered(object sender, EventArgs e)
        {
            Random ran = new Random();
            int p1 = ran.Next(300);
            int p2 = ran.Next(400);
            Nobtn.Location = new Point(p1, p2);
        }

        private void NobtnClicked(object sender, EventArgs e)
        {
            string s = "You are not a Fool";
            Result r = new Result(s);
            r.Show();
            this.Hide();
        }

        private void YesbtnClicked(object sender, EventArgs e)
        {
            string s = "HAHAHA!! You are a Fool";
            Result r = new Result(s);
            r.Show();
            this.Hide();
        }
    }
}
