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

namespace Sample
{
    public partial class Form3 : Form
    {
        bool isCheck = true;
        Query controller;
        public Form3()

        {
            controller = new Query(ConnectionString.ConnStr);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateUsers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1(isCheck);
            ss.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddUsers(textBox1.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteUsers(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
        }
    }
}
