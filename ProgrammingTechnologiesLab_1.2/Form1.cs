using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ProgrammingTechnologiesLab_1._2
{
    public partial class Form1 : Form
    {
        double min, max;
        double a, b, c;
        int sign = 0;

        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        private void outLine_TextChanged(object sender, EventArgs e)
        {
            Regex reg1 = new Regex(@"^[\-+.1234567890]$");
            Regex reg2 = new Regex(@"^[\+-]?\d{1,7}[.]?\d{0,1}$");
            if (outLine.Text.Length == 1)
            {
                if (!reg1.IsMatch(outLine.Text))
                {
                    outLine.Text = "";
                }
            }
            else
            {
                if (reg2.IsMatch(outLine.Text))
                {
                    //if (outLine.Text.IndexOf(',', 0, outLine.Text.Length) != -1)
                    //{
                    //    outLine.Text = Regex.Replace(outLine.Text, @"\,", ".");
                    //}
                }
                else
                {
                    outLine.Text = "";
                }
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            outLine.Clear();
            outLineUper.Clear();
            outLine.Focus();
        }

        private void backSpase_Click(object sender, EventArgs e)
        {
            if (outLine.Text != "")
            {
                outLine.Text = outLine.Text.Remove(outLine.Text.Length - 1, 1);
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                sign = 1;
                outLineUper.Text = outLine.Text + "+";
                outLine.Clear();
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                sign = 2;
                outLineUper.Text = outLine.Text + "-";
                outLine.Clear();
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if(outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                sign = 3;
                outLineUper.Text = outLine.Text + "x";
                outLine.Clear();
            }
            else
            {
                MessageBox.Show("Input first number!", "Message");
            }
            outLine.Focus();

        }

        private void division_Click(object sender, EventArgs e)
        {
            if(outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                sign = 4;
                outLineUper.Text = outLine.Text + "/";
                outLine.Clear();
            }
            else
            {
                MessageBox.Show("Input first number!", "Message");
            }
            outLine.Focus();

        }

        private void factorial_Click(object sender, EventArgs e)
        {
            int i = 1;
            c = 1;
            if (outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                //if (a > 4000000 || a < -2000000)
                //{
                //    MessageBox.Show("Input number among 4.000.000 and -2.000.000!", "Message");
                //}
                while (i <= a)
                {
                    c *= i;
                    i++;
                }
                outLine.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Input number!", "Message");
            }
            outLine.Focus();
        }

        private void sinus_Click(object sender, EventArgs e)
        {
            if (outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                //if (a > 4000000 || a < -2000000)
                //{
                //    MessageBox.Show("Input number among 4.000.000 and -2.000.000!", "Message");
                //}
                c = System.Math.Sin(a * Math.PI / 180);
                outLine.Text = c.ToString("G1");
            }
            else
            {
                MessageBox.Show("Input number!", "Message");
            }
            outLine.Focus();
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            if(outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                if(a >= 0)
                {
                    c = System.Math.Sqrt(a);
                    outLine.Text = c.ToString("G1");
                }
            }
            else
            {
                MessageBox.Show("Input number!", "Message");
            }
            outLine.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(outLine.Text != "")
            {
                switch (sign)
                {
                    case 1:
                        {
                            b = double.Parse(outLine.Text);
                            outLineUper.Text += b.ToString();
                            c = Math.Round(a + b, 1);
                            outLine.Text = c.ToString();
                        }
                        break;
                    case 2:
                        {
                            b = double.Parse(outLine.Text);
                            outLineUper.Text += b.ToString();
                            c = Math.Round(a - b, 1);
                            outLine.Text = c.ToString();
                        }
                        break;
                    case 3:
                        {
                            b = double.Parse(outLine.Text);
                            outLineUper.Text += b.ToString();
                            c = Math.Round(a * b, 1);
                            outLine.Text = c.ToString();
                        }
                        break;
                    case 4:
                        {
                            b = double.Parse(outLine.Text);
                            if (b != 0)
                            {
                                c = Math.Round(a / b, 1);
                                outLineUper.Text += b.ToString();
                                outLine.Text = c.ToString(); 
                            }
                            else
                            {
                                outLine.Clear();
                                outLineUper.Clear();
                                MessageBox.Show("Second number 0!", "Message");
                                outLine.Focus();
                            }
                        }
                        break;
                }
            }
        }

        private void swapSign_Click(object sender, EventArgs e)
        {
            if (outLine.Text != "")
            {
                if (outLine.Text[0] == '-')
                {
                    outLine.Text = outLine.Text.Remove(0, 1);
                }
                else
                {
                    outLine.Text = '-' + outLine.Text;
                }
            }
        }
        private void numeralZero_Click(object sender, EventArgs e)
        {
            outLine.Text += (sender as Button).Text;
        }
    }
}
