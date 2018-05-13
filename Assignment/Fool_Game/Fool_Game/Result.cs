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
    public partial class Result : Form
    {
        public Result(string s)
        {
            InitializeComponent();
            label1.Text = s;

        }

        private void ExitbtnClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgainbtnClicked(object sender, EventArgs e)
        {
            Fool_Game f = new Fool_Game();
            f.Show();
            this.Hide();
        }
    }
}
