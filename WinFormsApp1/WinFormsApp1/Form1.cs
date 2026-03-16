using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        double firstnum;
        string oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vivod.Text == "0")
            {
                vivod.Text = "1";
            }
            else
            {
                vivod.Text = vivod.Text + '1';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(vivod.Text);
            oper = "+";
            vivod.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(vivod.Text);
            double result = 0;

            switch (oper)
            {
                case "+":
                    result = firstnum + secondNumber;
                    break;
                case "-":
                    result = firstnum - secondNumber;
                    break;
                case "*":
                    result = firstnum * secondNumber;
                    break;
                case "/":
                    result = firstnum / secondNumber;
                    break;
            }
            vivod.Text = result.ToString();
            oper = "";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (vivod.Text == "0")
            {
                vivod.Text = "4";
            }
            else
            {
                vivod.Text = vivod.Text + '4';
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (vivod.Text == "0")
            {
                vivod.Text = "2";
            }
            else
            {
                vivod.Text = vivod.Text + '2';
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (vivod.Text == "0")
            {
                vivod.Text = "3";
            }
            else
            {
                vivod.Text = vivod.Text + '3';
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (vivod.Text == "0")
            {
                vivod.Text = "5";
            }
            else
            {
                vivod.Text = vivod.Text + '5';
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (vivod.Text == "0")
            {
                vivod.Text = "6";
            }
            else
            {
                vivod.Text = vivod.Text + '6';
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            {
                if (vivod.Text == "0")
                {
                    vivod.Text = "7";
                }
                else
                {
                    vivod.Text = vivod.Text + '7';
                }
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            {
                if (vivod.Text == "0")
                {
                    vivod.Text = "8";
                }
                else
                {
                    vivod.Text = vivod.Text + '8';
                }
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            {
                if (vivod.Text == "0")
                {
                    vivod.Text = "9";
                }
                else
                {
                    vivod.Text = vivod.Text + '9';
                }
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            {
                if (vivod.Text == "0")
                {
                    vivod.Text = "0";
                }
                else
                {
                    vivod.Text = vivod.Text + '0';
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(vivod.Text);
            oper = "/";
            vivod.Clear();
        }


        private void minys_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(vivod.Text);
            oper = "-";
            vivod.Clear();
        }

        private void ymn_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(vivod.Text);
            oper = "*";
            vivod.Clear();
        }

        private void proc_Click(object sender, EventArgs e)
        {
            {
                double currentNumber = Convert.ToDouble(vivod.Text);
                if (string.IsNullOrEmpty(oper))
                {
                    vivod.Text = (currentNumber / 100).ToString();
                }
                else
                {

                    switch (oper)
                    {
                        case "+":
                        case "-":
                            double percentOfFirst = firstnum * (currentNumber / 100);
                            vivod.Text = percentOfFirst.ToString();
                            break;

                        case "*":
                        case "/":
                            vivod.Text = (currentNumber / 100).ToString();
                            break;
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            vivod.Text = "0";
            oper = "";
            firstnum = 0;
        }

    }
}


