using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                        if (charsArr[i] == '+')
                        {
                            charsArr = plusfunc(charsArr);
                        } 
                        if (charsArr[i] == '-')
                        {
                            charsArr = minusfunc(charsArr);
                        }
                        if (charsArr[i] == '/')
                        {
                            charsArr = divfunc(charsArr);
                        }
                        if (charsArr[i] == '*')
                        {
                            charsArr = multifunc(charsArr);
                        }

                       

                        char[]  plusfunc(char[] charsArr)
                        {
                            if (charsArr[i] == '+')
                            {
                                string wordString = charsArr.ToString();
                                string[] words = wordString.Split('+');
                                float init = 1;
                                for (int j = 0; j < words.Length; j++)
                                {
                                    init = init + Int32.Parse(words[j]);
                                }
                                string initString = init.ToString();
                                char[] initArr = initString.ToCharArray();
                                textBox1.Text = "";
                                return initArr;
                            } else
                            {
                                return null;
                            }
                        }

                        char[] minusfunc(char[] charsArr)
                        {
                            if (charsArr[i] == '-')
                            {
                                string wordString = charsArr.ToString();
                                string[] words = wordString.Split('-');
                                float init = 1;
                                for (int j = 0; j < words.Length; j++)
                                {
                                    init = init - Int32.Parse(words[j]);
                                }
                                string initString = init.ToString();
                                char[] initArr = initString.ToCharArray();
                                textBox1.Text = "";
                                return initArr;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        char[] divfunc(char[] charsArr)
                        {
                            if (charsArr[i] == '/')
                            {
                                string wordString = charsArr.ToString();
                                string[] words = wordString.Split('/');
                                float init = 1;
                                for (int j = 0; j < words.Length; j++)
                                {
                                    init = init / Int32.Parse(words[j]);
                                }
                                string initString = init.ToString();
                                char[] initArr = initString.ToCharArray();
                                textBox1.Text = "";
                                return initArr;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        char[] multifunc(char[] charsArr)
                        {
                            if (charsArr[i] == '*')
                            {
                                string wordString = charsArr.ToString();
                                string[] words = wordString.Split('*');
                                float init = 1;
                                for (int j = 0; j < words.Length; j++)
                                {
                                    init = init * Int32.Parse(words[j]);
                                }
                                string initString = init.ToString();
                                char[] initArr = initString.ToCharArray();
                                textBox1.Text = "";
                                return initArr;
                            }
                            else
                            {
                                return null;
                            }
                        }
                       

                    }
                    string result = string.Join("", charsArr);
                    textBox1.Text = result;

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
            textBox1.Text += "+";
            char multiChar = '+';
            List<char> someChar = textBox1.Text.ToList();
            List<char> list = somefunc(someChar, multiChar);
            string result = string.Join("", list);
            textBox1.Text = result;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            char multiChar = '-';
            List<char> someChar = textBox1.Text.ToList();
            List<char> list = somefunc(someChar, multiChar);
            string result = string.Join("", list);
            textBox1.Text = result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calc('=');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            char multiChar = '/';
            List<char> someChar = textBox1.Text.ToList();
            List<char> list = somefunc(someChar, multiChar);
            string result = string.Join("", list);
            textBox1.Text = result;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            char multiChar = '*';
            List<char> someChar = textBox1.Text.ToList();
            List<char> list = somefunc(someChar, multiChar);
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
        public List<char> somefunc(List<char> list, char multiChar)
        {
            
            List<int> listNumber = new List<int>();
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == multiChar)
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
            return list;

        }
    }
}
