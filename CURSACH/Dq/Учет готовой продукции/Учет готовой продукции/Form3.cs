using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Учет_готовой_продукции.Controller;

namespace Учет_готовой_продукции
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3()
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                OleDbConnection con = new OleDbConnection(ConnectionString.ConnStr);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select ID From Users where Log = '" + textBox1.Text + "' and Pas = '" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильно введен Логин и (или) Пароль");
                }
            }
            else
            {
                MessageBox.Show("Не был введен Логин и (или) Пароль");
            }
        }
    }
}
