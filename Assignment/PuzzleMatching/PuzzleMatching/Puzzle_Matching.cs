using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleMatching
{
    public partial class Puzzle_Matching : Form
    {
        private Timer timerObj;
        private int count = 0, score = 1;
        private int s = 20, win = 0;

        public Puzzle_Matching()
        {
            InitializeComponent();
            //position();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            timerObj = new Timer();
            timerObj.Interval = 1000;
            timerObj.Tick += TimerObj_Tick;
        }
        private void btnClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b == button1)
            {
                button1.BackgroundImage = Resource.img11;
                count++;
                if (count == 2)
                {
                    if (button10.BackgroundImage != null)
                    {
                        button10.BackgroundImage = Resource.img11;
                        button1.Hide();
                        button10.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button2)
            {
                button2.BackgroundImage = Resource.img6;
                count++;
                if (count == 2)
                {
                    if (button9.BackgroundImage != null)
                    {
                        button9.BackgroundImage = Resource.img6;
                        button2.Hide();
                        button9.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button3)
            {
                button3.BackgroundImage = Resource.img7;
                count++;
                if (count == 2)
                {
                    if (button8.BackgroundImage != null)
                    {
                        button8.BackgroundImage = Resource.img7;
                        button3.Hide();
                        button8.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button4)
            {
                button4.BackgroundImage = Resource.img8;
                count++;
                if (count == 2)
                {
                    if (button7.BackgroundImage != null)
                    {
                        button7.BackgroundImage = Resource.img8;
                        button4.Hide();
                        button7.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button5)
            {
                button5.BackgroundImage = Resource.img9;
                count++;
                if (count == 2)
                {
                    if (button6.BackgroundImage != null)
                    {
                        button6.BackgroundImage = Resource.img9;
                        button5.Hide();
                        button6.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button6)
            {
                button6.BackgroundImage = Resource.img9;
                count++;
                if (count == 2)
                {
                    if (button5.BackgroundImage != null)
                    {
                        button5.BackgroundImage = Resource.img9;
                        button5.Hide();
                        button6.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button7)
            {
                button7.BackgroundImage = Resource.img8;
                count++;
                if (count == 2)
                {
                    if (button4.BackgroundImage != null)
                    {
                        button4.BackgroundImage = Resource.img8;
                        button4.Hide();
                        button7.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button8)
            {
                button8.BackgroundImage = Resource.img7;
                count++;
                if (count == 2)
                {
                    if (button3.BackgroundImage != null)
                    {
                        button3.BackgroundImage = Resource.img7;
                        button3.Hide();
                        button8.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button9)
            {
                button9.BackgroundImage = Resource.img6;
                count++;
                if (count == 2)
                {
                    if (button2.BackgroundImage != null)
                    {
                        button2.BackgroundImage = Resource.img6;
                        button2.Hide();
                        button9.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            else if (b == button10)
            {
                button10.BackgroundImage = Resource.img11;
                count++;
                if (count == 2)
                {
                    if (button1.BackgroundImage != null)
                    {
                        button1.BackgroundImage = Resource.img11;
                        button1.Hide();
                        button10.Hide();
                        win++;
                    }
                    reset();
                    count = 0;
                }
            }
            if (win == 5)
            { Win(); }
        }
    
        void Win()
        {
            timerObj.Enabled = false;
            var play = MessageBox.Show("You Win !!", "Win Message");
            Puzzle_Matching p = new Puzzle_Matching();
            p.Show();
            this.Hide();
        }

        private void NewGamebtnClicked(object sender, EventArgs e)
        {
           
            timerObj.Enabled = true; s = 20;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            reset();
            position();
            NewGamebtn.Enabled = false;

        }

       

        private void TimerObj_Tick(object sender, EventArgs e)
        {
            Valuelbl.Text = s.ToString();
            s -= score;
            if (Valuelbl.Text == "0")
            {
                timerObj.Enabled = false;
                var play = MessageBox.Show("You Lost !!", "Lost Message");
                Puzzle_Matching p = new Puzzle_Matching();
                p.Show();
                this.Hide();

            }
        }

        private void ExitbtnClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void position()
        {
            Random ra = new Random();
            int b1 = ra.Next(5, 720);
            int b2 = ra.Next(170, 411);
            button1.Location = new Point(b1, b2);
            int b3 = ra.Next(5, 720);
            int b4 = ra.Next(200, 271);
            button2.Location = new Point(b3, b4);
            int b5 = ra.Next(161, 420);
            int b6 = ra.Next(200, 271);
            button3.Location = new Point(b5, b6);
            int b7 = ra.Next(161, 720);
            int b8 = ra.Next(170, 411);
            button4.Location = new Point(b7, b8);
            int b9 = ra.Next(161, 720);
            int b10 = ra.Next(170, 411);
            button5.Location = new Point(b9, b10);
            int b11 = ra.Next(161, 720);
            int b12 = ra.Next(170, 411);
            button6.Location = new Point(b11, b12);
            int b13 = ra.Next(161, 720);
            int b14 = ra.Next(170, 411);
            button7.Location = new Point(b13, b14);
            int b15 = ra.Next(161, 720);
            int b16 = ra.Next(170, 411);
            button8.Location = new Point(b15, b16);
            int b17 = ra.Next(161, 720);
            int b18 = ra.Next(170, 411);
            button9.Location = new Point(b17, b18);
            int b19 = ra.Next(161, 720);
            int b20 = ra.Next(170, 411);
            button10.Location = new Point(b19, b20);
        }
        private void reset()
        {
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
            button10.BackgroundImage = null;
        }
    }
}
