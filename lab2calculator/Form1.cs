using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2calculator
{
    public partial class Form1 : Form
    {
        private string op = "";
        private double res;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                res = Convert.ToDouble(textBox1.Text);
                op = "/";
                textBox1.Clear();
            }
            else
            {
                calculus();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                res = Convert.ToDouble(textBox1.Text);
                op = "*";
                textBox1.Clear();
            }
            else
            {
                calculus();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                res = Convert.ToDouble(textBox1.Text);
                op = "-";
                textBox1.Clear();
            }
            else
            {
                calculus();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                res = Convert.ToDouble(textBox1.Text);
                op = "+";
                textBox1.Clear();
            }
            else
            {
                calculus();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculus();

                }

        private void calculus()
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (op == "+")
            {
                Result = (res + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                res = Result;
            }
            if (op == "-")
            {
                Result = (res - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                res = Result;
            }
            if (op == "*")
            {
                Result = (res * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                res = Result;
            }
            if (op == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Impartire gresita";

                }
                else
                {
                    Result = (res / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    res = Result;
                }
            }
            op = "";
        }

       
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_KeyPress(object sender, KeyPressEventArgs e)
        {
            button10_Click(sender, e);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            button5_Click(sender, e);
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            button6_Click(sender, e);
        }

        private void button7_KeyPress(object sender, KeyPressEventArgs e)
        {
            button7_Click(sender, e);
        }

        private void button8_KeyPress(object sender, KeyPressEventArgs e)
        {
            button8_Click(sender, e);
        }

        private void button9_KeyPress(object sender, KeyPressEventArgs e)
        {
            button9_Click(sender, e);
        }

        private void button17_KeyPress(object sender, KeyPressEventArgs e)
        {
            button17_Click(sender, e);
        }

        private void button14_KeyPress(object sender, KeyPressEventArgs e)
        {
            button14_Click(sender, e);
        }

        private void button13_KeyPress(object sender, KeyPressEventArgs e)
        {
            button13_Click(sender, e);
        }

        private void button12_KeyPress(object sender, KeyPressEventArgs e)
        {
            button12_Click(sender, e);
        }

        private void button11_KeyPress(object sender, KeyPressEventArgs e)
        {
            button11_Click(sender, e);
        }

        private void button18_KeyPress(object sender, KeyPressEventArgs e)
        {
            button18_Click(sender, e);
        }

        private void button15_KeyPress(object sender, KeyPressEventArgs e)
        {
            button15_Click(sender, e);
        }
    }
}

