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
using static Sample.GlobalVariables;

namespace Sample
{
   
    public partial class FormEditor : Form
    {
        Query controller;
        GlobalVariables variables;
        public int id_local;
        public FormEditor(int ID)
        {
          
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            id_local = Convert.ToInt32(ID);
            label6.Text = ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           controller.Edit(textBox1.Text, textBox2.Text, textBox4.Text, int.Parse(textBox5.Text), id_local);
           controller.UpdatePerson();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
