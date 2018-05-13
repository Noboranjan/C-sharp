using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Counter
{
    public partial class Form1 : Form
    {
        private Random ran;
        private Timer Tobj;
        private int x ;
        private int score = 0;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
            this.ScoreTbox.Text = "";
            this.ScoreTbox.Text = this.ScoreTbox.Text+this.score.ToString();
            ran = new Random();
            Tobj = new Timer();
            Tobj.Enabled = true;
            Tobj.Interval = 900;
            Tobj.Tick += Tobj_Tick;

            PlayAgainbtn.Enabled = false;
        }

        private void Tobj_Tick(object sender, EventArgs e)
        {
            this.btn1.BackColor = Color.OrangeRed;
            this.btn2.BackColor = Color.OrangeRed;
            this.btn3.BackColor = Color.OrangeRed;
            this.btn4.BackColor = Color.OrangeRed;
            this.btn5.BackColor = Color.OrangeRed;
            this.btn6.BackColor = Color.OrangeRed;
            this.btn7.BackColor = Color.OrangeRed;
            this.btn8.BackColor = Color.OrangeRed;
            this.btn9.BackColor = Color.OrangeRed;
            this.btn10.BackColor = Color.OrangeRed;

            x = ran.Next(1, 10);
            switch(x)
            {
                case 1:
                    this.btn1.BackColor = Color.Gold;
                    break;
                case 2:
                    this.btn2.BackColor = Color.Gold;
                    break;
                case 3:
                    this.btn3.BackColor = Color.Gold;
                    break;
                case 4:
                    this.btn4.BackColor = Color.Gold;
                    break;
                case 5:
                    this.btn5.BackColor = Color.Gold;
                    break;
                case 6:
                    this.btn6.BackColor = Color.Gold;
                    break;
                case 7:
                    this.btn7.BackColor = Color.Gold;
                    break;
                case 8:
                    this.btn8.BackColor = Color.Gold;
                    break;
                case 9:
                    this.btn9.BackColor = Color.Gold;
                    break;
                case 10:
                    this.btn10.BackColor = Color.Gold;
                    break;
                default:
                    Console.WriteLine("Default Color");
                    break;

            }
            count++;
            if(count==30)
            {
                this.btn1.BackColor = Color.OrangeRed;
                this.btn2.BackColor = Color.OrangeRed;
                this.btn3.BackColor = Color.OrangeRed;
                this.btn4.BackColor = Color.OrangeRed;
                this.btn5.BackColor = Color.OrangeRed;
                this.btn6.BackColor = Color.OrangeRed;
                this.btn7.BackColor = Color.OrangeRed;
                this.btn8.BackColor = Color.OrangeRed;
                this.btn9.BackColor = Color.OrangeRed;
                this.btn10.BackColor = Color.OrangeRed;

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;

               // ScoreTbox.Enabled = false;


                Tobj.Enabled = false;
                PlayAgainbtn.Enabled = true;
                MessageBox.Show("Game Over","Click Counter");
            }
        }

        private void btn1Clicked(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn2Clicked(object sender, EventArgs e)
        {
            if(btn2.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn3Clicked(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn4Clicked(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn5Clicked(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn6Clicked(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn7Clicked(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn8Clicked(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn9Clicked(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void btn10Clicked(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.Gold)
            {
                score = score + 10;
            }
            else
            {
                score = score - 5;
            }
            this.ScoreTbox.Text = " ";
            this.ScoreTbox.Text = this.ScoreTbox.Text + this.score.ToString();
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgainbtnClicked(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
