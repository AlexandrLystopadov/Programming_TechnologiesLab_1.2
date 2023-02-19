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
            min = double.Parse(minTable.Text);
            max = double.Parse(maxTable.Text);
            if (outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                sign = 1;
                outLineUper.Text = outLine.Text + "+";
                outLine.Clear();
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            min = double.Parse(minTable.Text);
            max = double.Parse(maxTable.Text);
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
            min = double.Parse(minTable.Text);
            max = double.Parse(maxTable.Text);
            if (outLine.Text != "")
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
            min = double.Parse(minTable.Text);
            max = double.Parse(maxTable.Text);
            if (outLine.Text != "")
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
                if(a <= 0)
                {
                    c = 0;
                    MessageBox.Show("Number is negetive or zero!", "Message");
                    
                }

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
            min = double.Parse(minTable.Text);
            max = double.Parse(maxTable.Text);
            if (outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                c = System.Math.Sin(a * Math.PI / 180);
                outLine.Text = c.ToString("F1");
            }
            else
            {
                MessageBox.Show("Input number!", "Message");
            }
            outLine.Focus();
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            if (outLine.Text != "")
            {
                a = double.Parse(outLine.Text);
                if(a >= 0)
                {
                    c = Math.Round(Math.Sqrt(a), 1);
                    outLine.Text = c.ToString("F1");
                }
                else
                {
                    MessageBox.Show("Number is negetive!", "Message");
                }
            }
            else
            {
                MessageBox.Show("Input number!", "Message");
            }
            outLine.Focus();
        }

        private void minTable_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maxTable_TextChanged(object sender, EventArgs e)
        {
           
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
            min = double.Parse(minTable.Text);
            max = double.Parse(maxTable.Text);

            if(double.Parse(outLine.Text + (sender as Button).Text) >= min && 
               double.Parse(outLine.Text + (sender as Button).Text) <= max)
            {
                outLine.Text += (sender as Button).Text;
            }
        }
    }
}
