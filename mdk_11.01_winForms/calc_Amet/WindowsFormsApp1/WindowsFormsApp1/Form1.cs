using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = true;
        string znakStr = "";
        string vivod;
        string firstPart;
        string secondPart;
        char plus;
        string text;
        char[] charsArr;

        public void calc(char plus)
        {
            switch (plus) {
                case '=':
                    charsArr = textBox1.Text.ToCharArray();
                    for (int i = 0; i < charsArr.Length; i++)
                    {
                        
                        vivod += charsArr[i];
                        if (charsArr[i] == '+')                        
                        {
                            
                            string[] words = textBox1.Text.Split('+');
                            string first = words[0];
                            double firstFloat = double.Parse(first);
                            string second = words[1];
                            double secondFloat = double.Parse(second);
                            double result = firstFloat + secondFloat;
                            textBox1.Text = "";
                            textBox1.Text = result + "";

                        }
                        if (charsArr[i] == '-')
                        {

                            string[] words = textBox1.Text.Split('-');
                            string first = words[0];
                            float firstFloat = float.Parse(first);
                            string second = words[1];
                            float secondFloat = float.Parse(second);
                            float result = firstFloat - secondFloat;
                            textBox1.Text = "";
                            textBox1.Text = result + "";

                        }
                        if (charsArr[i] == '/')
                        {

                            string[] words = textBox1.Text.Split('/');
                            string first = words[0];
                            float firstFloat = float.Parse(first);
                            string second = words[1];
                            float secondFloat = float.Parse(second);
                            float result = firstFloat / secondFloat;
                            textBox1.Text = "";
                            textBox1.Text = result + "";

                        }
                        if (charsArr[i] == '*')
                        {

                            string[] words = textBox1.Text.Split('*');
                            string first = words[0];
                            float firstFloat = float.Parse(first);
                            string second = words[1];
                            float secondFloat = float.Parse(second);
                            float result = firstFloat * secondFloat;
                            textBox1.Text = "";
                            textBox1.Text = result + "";

                        }

                    }

                    
                break;
                case ('C'):
                    Console.WriteLine("w");
                    char[] arrDeleteEl = textBox1.Text.ToArray();
                    List<char> list = arrDeleteEl.ToList();
                    var lengthList = list.Count;
                    lengthList -= 1;
                    list.RemoveRange(lengthList, 1);
                    textBox1.Text = "";
                    for(int i = 0; i < list.Count; i++)
                    {
                        textBox1.Text += list[i];
                    }
                    break;
                    

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int count = 1;
            count += 1;
            if(count >= 2)
            {
                textBox1.Text += "+";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calc('=');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            List<char> list = textBox1.Text.ToList();
            List<int> listNumber = new List<int>();
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == '*')
                {
                    count += 1;
                    listNumber.Add(i);
                }

                for (int j = 0; j < listNumber.Count - 1; j++)
                {
                    if (count > 1 && listNumber[j] - listNumber[j + 1] == -1)
                    {
                        list.RemoveRange(listNumber[j + 1], 1);
                        listNumber.RemoveAt(j + 1);
                    }
                }
            }

            string result = string.Join("", list);
            textBox1.Text = result;


            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //delete element
            calc('C');

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
