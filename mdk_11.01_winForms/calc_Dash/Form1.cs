05using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        char[] elements = richTextBox1.Text;
       {
            switch (char m)
            {

                default:
                    break;
    }

    #region buttons
    private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        #endregion
        #region buttons_operations
        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.EndsWith("/") || richTextBox1.Text.EndsWith("+") || richTextBox1.Text.EndsWith("*") || richTextBox1.Text.EndsWith("-"))
            {

            }
            else
            {
                richTextBox1.Text += "/";
            }
            string x, y;
            double result;

            string[] mas = richTextBox1.Text.Split('/');
            x = mas[0];
            double first = Convert.ToDouble(x);
            y = mas[1];
            double second = Convert.ToDouble(y);
            result = first / second;
            richTextBox1.Text = "";
            richTextBox1.Text = result + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc();
            if (richTextBox1.Text.EndsWith("/") || richTextBox1.Text.EndsWith("+") || richTextBox1.Text.EndsWith("*") || richTextBox1.Text.EndsWith("-"))
            {

            }
            else
            {
                richTextBox1.Text += "+";
            }
            //string[] mas = richTextBox1.Text.Split(new char[] { '+' });
            //x = Convert.ToDouble(mas[0]);
            //y = Convert.ToDouble(mas[1]);
            //result = x + y;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.EndsWith("/") || richTextBox1.Text.EndsWith("+") || richTextBox1.Text.EndsWith("*") || richTextBox1.Text.EndsWith("-"))
            {

            }
            else
            {
                richTextBox1.Text += "-";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.EndsWith("/") || richTextBox1.Text.EndsWith("+") || richTextBox1.Text.EndsWith("*") || richTextBox1.Text.EndsWith("-"))
            {

            }
            else
            {
                richTextBox1.Text += "*";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        #endregion
        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // delete 1 element
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = result + "";
        }
    }
}
