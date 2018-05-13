using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        public int player = 2; 
        public int turns = 0; 
        public int s1 = 0;
        public int s2 = 0; 
        public int sd = 0;

        private void buttonClicked(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            if (b.Text == "")
            {
                if (player % 2 == 0)
                {
                    b.Text = "X";
                    player++;
                    turns++;
                }
                
                else
                {
                    b.Text = "O";
                    player++;
                    turns++;
                }
                if (CheckDraws() == true)
                {
                    MessageBox.Show("Tie Game!", "Result");
                    sd++;
                    NewGame();
                }
                if(CheckWinner() == true)
                {
                    if(b.Text=="X")
                    {
                        MessageBox.Show("X is Won", "Result");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O is Won","Result");
                        s2++;
                        NewGame();
                    }
                }
            }
        }

        private void Exitbtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            Xwin.Text = "X :  " + s1;
            Owin.Text = "O :  " + s2;
            Draws.Text = "Draws:  " + sd;
        }
        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            Xwin.Text = "X :  " + s1;
            Owin.Text = "O :  " + s2;
            Draws.Text = "Draws:  " + sd;
        }

        private void NewGamebtn(object sender, EventArgs e)
        {
            NewGame();
        }
        bool CheckDraws()
        {
            if((turns==9)&&(CheckWinner()==false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool CheckWinner()
        {
            if((A00.Text==A01.Text)&&(A01.Text==A02.Text)&&A00.Text!="")
            {
                return true;
            }
           else if((A10.Text==A11.Text)&&(A11.Text==A12.Text)&&A10.Text!="")
            {
                return true;
            }
           else if((A20.Text==A21.Text)&&(A21.Text==A22.Text)&&A20.Text!="")
            {
                return true;
            }
            
            if((A00.Text==A10.Text)&&(A10.Text==A20.Text)&&A00.Text!="")
            {
                return true;
            }
            else if((A01.Text==A11.Text)&&(A11.Text==A21.Text)&&A01.Text!="")
            {
                return true;
            }
            else if((A02.Text==A12.Text)&&(A12.Text==A22.Text)&&A02.Text!="")
            {
                return true;
            }

            if((A00.Text==A11.Text)&&(A11.Text==A22.Text)&&A00.Text!="")
            {
                return true;
            }
            else if((A02.Text==A11.Text)&&(A11.Text==A20.Text)&&A02.Text!="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ResetbtnClicked(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
