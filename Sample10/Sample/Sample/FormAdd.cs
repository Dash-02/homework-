using Sample.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sample.Controller;
using static Sample.GlobalVariables;

namespace Sample
{
    public partial class FormAdd : Form
    {
        Query controller;
        public FormAdd()
        {
            
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Add(textBox1.Text, textBox2.Text, textBox4.Text, int.Parse(textBox5.Text));
            controller.UpdatePerson();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
           
        }
    }
}
