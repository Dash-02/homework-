using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Калькулятор";

        }
        double result = 0;
        double currentNumber = 0;
        string currentOperator = " ";
        bool isNewNumber = true;
        bool commaEntered = false;

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
            button.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
            button.BackColor = Color.Transparent;
        }
        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                textBox1.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                if (!commaEntered && button.Text == "0")
                {
                    
                    if (textBox1.Text != "0")
                    {
                        textBox1.Text += button.Text;
                    }
                }
            
                else if (button.Text == "," && !commaEntered)
                {
                    textBox1.Text += button.Text;
                    commaEntered = true; 
                }
            
                else if (Char.IsDigit(button.Text, 0))
                {
                    
                    if (textBox1.Text.Contains(",") || textBox1.Text != "0")
                    {
                        textBox1.Text += button.Text;
                    }
                }
            }
           
        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                Calculate();
            }
            isNewNumber = true;
            Button operatorButton = (Button) sender;
            currentOperator = operatorButton.Text;
            currentNumber = result;
        }

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                Calculate();
                isNewNumber = true;
                currentOperator = " ";
                label1.Text = $"{result}";
            }
        }

        private void Calculate()
        {
            double newNumber = double.Parse(textBox1.Text);
            double previousNumber = currentNumber;
            switch (currentOperator)
            {
                case "+":
                    result += newNumber;
                    break;
                case "-":
                    result -= newNumber;
                    break;
                case "*":
                    result *= newNumber;
                    break;
                case "/":
                    if (newNumber != 0)
                    {
                        result /= newNumber;
                    }
                
               
                    else
                    {
                        MessageBox.Show("Деление на ноль невозможно.");
                    }
                    break;
                
                case "tan(x)":
                    
                    break;
                default:
                    result = newNumber;
                    break;
            }
            textBox1.Clear();
            label1.Text = $"{result}";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }

           

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
            }
        }

   

        private void button18_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                isNewNumber = true;
                double newNumber = double.Parse(textBox1.Text);
                if (newNumber > 0)
                {
                    result = Math.Log10(newNumber);
                    label1.Text = $"{result}";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Логарифм нельзя вычислить для неположительного числа.");
                }
            }
        }



        private void button21_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                isNewNumber = true;
                double newNumber = double.Parse(textBox1.Text);

                result = CalculateFactorial(newNumber);
                double CalculateFactorial(double x)
                {
                    if (x < 0)
                    {
                        throw new ArgumentException("Факториал определен только для неотрицательных целых чисел.");
                    }

                    if (x <= 1)
                    {
                        return 1;
                    }

                    long result = 1;
                    for (int i = 2; i <= x; i++)
                    {
                        result *= i;
                    }

                    return result;
                }
                label1.Text = $"{result}";
                textBox1.Clear();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                isNewNumber = true;
                double newNumber = double.Parse(textBox1.Text);
                if (newNumber > 0)
                {
                    double result = Math.Log(newNumber, 2);
                    label1.Text = $"{result}";
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Логарифм нельзя вычислить для неположительного числа.");
                }
            }
        
            }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                isNewNumber = true;
                double newNumber = double.Parse(textBox1.Text);
                if (newNumber > 0)
                {
                    double result = 1/newNumber;
                    label1.Text = $"{result}";
                    textBox1.Clear();
                }
               
            }

        }
    }
}

