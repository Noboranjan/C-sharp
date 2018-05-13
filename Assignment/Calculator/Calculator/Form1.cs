using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int clear = 1;
        decimal result, mresult = 0;
        string op;

        int Clear(int cl)
        {
            switch (cl)
            {
                case 1:
                    {
                        label1.Text = "";
                    }break;
                case 2:
                    {
                        label1.Text = "";
                        label2.Text = "";
                        op = "";
                    }break;
                case 3:
                    {
                        label1.Text = "";
                        label2.Text = label2.Text.Remove(label2.Text.IndexOf('r'));

                    }break;
                case 4:
                    {
                        label2.Text = label2.Text.Remove(label2.Text.IndexOf('s'));
                    }break;
                case 5:
                    {
                        label2.Text = label2.Text.Remove(label2.Text.IndexOf(' ')+1);
                    }break;

            }
            return 0;
        }

        private void ZeroClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "0";
            else SystemSounds.Beep.Play();

        }

        private void OneClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "1";
            else SystemSounds.Beep.Play();
        }

        private void twoClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "2";
            else SystemSounds.Beep.Play();
        }

        private void threeClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "3";
            else SystemSounds.Beep.Play();
        }

        private void fourClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "4";
            else SystemSounds.Beep.Play();
        }

        private void fiveClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "5";
            else SystemSounds.Beep.Play();
        }

        private void sixClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "6";
            else SystemSounds.Beep.Play();
        }

        private void sevenClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "7";
            else SystemSounds.Beep.Play();
        }

        private void eightClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "8";
            else SystemSounds.Beep.Play();
        }

        private void nineClicked(object sender, EventArgs e)
        {
            clear = Clear(clear); //check display clear
            if (label1.Text.Length < 28)//dec has max 28-29 digit
                label1.Text = label1.Text + "9";
            else SystemSounds.Beep.Play();
        }

        private void addClicked(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
                label2.Text = label2.Text + "+";
            else if(clear==2)
            {
                label2.Text = label2.Text + "+";
              //  result = 0;
            }
            else label2.Text = label2.Text + label1.Text + "+";
            label1.Text = eval(op).ToString();
            op = "+";
        }

        private void subClicked(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
                label2.Text = label2.Text + "-";
            else if (clear == 2)
            {
                label2.Text = label2.Text + "-";
               // result = Convert.ToDecimal(label1.Text);
            }
            else label2.Text = label2.Text + label1.Text + "-";
            label1.Text = eval(op).ToString();
            op = "-";
        }

        private void divideClicked(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
                label2.Text = label2.Text + "/";
            else if (clear == 2)
            {
                label2.Text = label2.Text + "/";
              //  result = 0;
            }
            else label2.Text = label2.Text + label1.Text + "/";
            label1.Text = eval(op).ToString();
            op = "/";
        }

        private void mulClicked(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
                label2.Text = label2.Text + "*";
            else if (clear == 2)
            {
                label2.Text = label2.Text + "*";
               // result = 0;
            }
            else label2.Text = label2.Text + label1.Text + "*";
            label1.Text = eval(op).ToString();
            op = "*";
        }

        private void modClicked(object sender, EventArgs e)
        {
            if (clear == 3 || clear == 4 || clear == 5)
                label2.Text = label2.Text + "Mod";
            else label2.Text = label2.Text + label1.Text + "Mod";
            label1.Text = eval(op).ToString();
            op = "Mod";
        }

        private void reciproClicked(object sender, EventArgs e)
        {
            if (label2.Text.Contains("recipro"))
            {
                label2.Text = label2.Text.Insert(label2.Text.IndexOf('r'), "recipro(");
                label2.Text = label2.Text.Insert(label2.Text.IndexOf(')'), ")");
            }
            else label2.Text = label2.Text + "reciproc(" + label2.Text + ")";
            label1.Text = (1 / Convert.ToDecimal(label1.Text)).ToString();
            clear = 3;
        }

        private void sqrtClicked(object sender, EventArgs e)
        {
            if (label2.Text.Contains("sqrt"))
            {
                label2.Text = label2.Text.Insert(label2.Text.IndexOf('s'), "sqrt(");
                label2.Text = label2.Text.Insert(label2.Text.IndexOf(')'), ")");
            }
            else label2.Text = label2.Text + "sqrt(" + label2.Text + ")";
            label1.Text = Math.Sqrt(Convert.ToDouble(label1.Text)).ToString();
            clear = 4;
        }


        private void plusMinusClicked(object sender, EventArgs e)
        {
            if (label1.Text.Contains('-'))
            {
                label1.Text = label1.Text.Remove(label1.Text.IndexOf('-'), 1);
            }
            else label1.Text = "-" + label1.Text;
        }

        private void equalClicked(object sender, EventArgs e)
        {
            if (clear == 2)
            {
                label2.Text = label2.Text;
                SystemSounds.Asterisk.Play();
            }
            else if (clear != 3 && clear != 4 && clear != 5)
                label2.Text = label2.Text + label1.Text;
            //op = "=";
            label1.Text = eval(op).ToString();
            op = "";
            
            clear = 2;
        }

        private void clearAllClicked(object sender, EventArgs e)
        {
            Clear(2);
            clear = 1;
            label1.Text = "0";
            result = 0;
        }

        private void clearClicked(object sender, EventArgs e)
        {
            Clear(1);
            clear = 1;
            label1.Text = "0";
        }

        private void memorySaveClicked(object sender, EventArgs e)
        {
            mresult = Convert.ToDecimal(label1.Text);
            clear = 1;
        }

        private void memoryReadClicked(object sender, EventArgs e)
        {
            label1.Text = mresult.ToString();
            clear = 1;
        }

        private void memoryAddClicked(object sender, EventArgs e)
        {
            mresult = mresult + Convert.ToDecimal(label1.Text);
            clear = 1;
        }

        private void memoryMinusClicked(object sender, EventArgs e)
        {
            mresult = mresult - Convert.ToDecimal(label1.Text);
            clear = 1;
        }

        private void memoryCleanClicked(object sender, EventArgs e)
        {
            mresult = 0;
            clear = 1;
        }


        private void dtClicked(object sender, EventArgs e)
        {
            if (label1.Text.Contains('.'))
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                label1.Text = label1.Text + ".";
            }
        }

        private void percClicked(object sender, EventArgs e)
        {
            label1.Text = (result * Convert.ToDecimal(label1.Text) / 100).ToString();
            label2.Text = label2.Text + label1.Text;
            clear = 5;

        }

        private void BackspaceClicked(object sender, EventArgs e)
        {
            if(label1.Text.Length>0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
        }

        decimal eval(string op)
        {
            clear = 1;
            try
            {
                switch (op)
                {
                    case "+": result = result + Convert.ToDecimal(label1.Text); break;
                    case "-": result = result - Convert.ToDecimal(label1.Text); break;
                    case "/": result = result / Convert.ToDecimal(label1.Text); break;
                    case "*": result = result * Convert.ToDecimal(label1.Text); break;
                    case "Mod": result = result % Convert.ToDecimal(label1.Text); break;
                    //case "=": result = Convert.ToDecimal(label1.Text); break;
                    default: result = Convert.ToDecimal(label1.Text); break;
                }
            }
            catch (System.OverflowException) { label2.Text = "";
                label2.Text = "Overflow";
                clear = 2;
                SystemSounds.Asterisk.Play();
            }
            catch (System.DivideByZeroException) { label2.Text = "";
                label2.Text = "Math Error";
                clear = 2; SystemSounds.Asterisk.Play(); }
            return result;
        }


    }
}
