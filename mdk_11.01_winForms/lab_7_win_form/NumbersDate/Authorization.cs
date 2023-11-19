using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NumbersDate
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin FormAdmin = new FormAdmin();
            Form1 ss = new Form1();
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=User.mdb");
            
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select Count(*) From Users where Log = '" + textBox1.Text + "' and Pas = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "admin")
            {
                this.Hide();  
                FormAdmin.Show(); 
            }
        
            else
            {
                MessageBox.Show("Неправильно введен Логин и (или) Пароль");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
