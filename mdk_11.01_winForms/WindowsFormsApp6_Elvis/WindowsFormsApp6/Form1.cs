using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp6.Тест;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

       
        //private bool isTestStarted = false;
        private bool isTestingMode = true;

        public Form1()
        {
            InitializeComponent();
       
  
        }


        private void ShowQuestion(int index)
        {
           
            
               
                label1.Text = "Введите свое имя:";
               
            
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                string userName = textBoxName.Text;

                if (isTestingMode)
                {
                    
                    Тест testForm = new Тест();
                    testForm.UserName = userName;
                    testForm.Show();
                }
                else
                {
                    
                    Exams examForm = new Exams();
                    examForm.UserName = userName;
                    examForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите свое имя перед началом теста.");
            }
        }
        
        private void radioButtonTesting_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                isTestingMode = true;
                

               
                buttonNext.Enabled = true;
               
            }
        }
        private void radioButtonExam_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                isTestingMode = false;
                

          
                buttonNext.Enabled = true;
                
            }
        }
        

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }
    }

  
}

