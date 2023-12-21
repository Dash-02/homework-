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
using System.Data.OleDb;

namespace Sample
{
    public partial class CheckAdmin : Form
    {
        Query controller;
      
        public CheckAdmin()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void CheckAdmin_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            bool isCheck;
            // подключение файла базы данных
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Test.mdb");
            // запрос на проверку данных
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From Users where Log = '" + textBox1.Text + "' and Pas = '" + textBox2.Text + "'", con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            List<string> usersList = new List<string>();
            List<string> PassList = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                // Предположим, что в таблице есть столбец "UserName", в котором хранятся имена пользователей
                usersList.Add(row["Log"].ToString());
                PassList.Add(row["Pas"].ToString());
            }
            if (textBox1.Text == "admin")
            {
                if (usersList.Contains("admin") && usersList.Contains("admin"))
                {

                    isCheck = true;
                    Form1 ss = new Form1(isCheck);
                   
                    // форма после ввода верных значений логина и пароля
                    this.Hide();
                    ss.Show(); // открыть форму Form1
                    // пользователь с именем "admin" найден в списке пользователей
                }

            }
            if(usersList.Contains(textBox1.Text) && textBox1.Text != "admin" && PassList.Contains(textBox2.Text))
            {
                isCheck = false;
                Form1 ss = new Form1(isCheck);
                ss.Value = true;
                // форма после ввода верных значений логина и пароля
                this.Hide();
                ss.Show(); // открыть форму Form1
            }
            else if (!usersList.Contains(textBox1.Text))
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
           /* else
            {
                isCheck = false;
                this.Hide();
                Form1 ss = new Form1(); // форма после ввода верных значений логина и пароля
                ss.Show(); // открыть форму Form2
                           // пользователь с именем "admin" не найден в списке пользователей
            }*/

            /*for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text == "admin"  && textBox2.Text == "admin" )
                {
                    if(dt.Rows[0][0].ToString() == textBox1.Text)
                    {
                        //Console.WriteLine();
                        i.MessageBox
                        isCheck = true;
                        this.Hide();
                        Form1 ss = new Form1(); // форма после ввода верных значений логина и пароля
                        ss.Show(); // открыть форму Form1
                    }
                 
                }   
                if (dt.Rows[0][i].ToString()  == textBox1.Text)
                {
                    isCheck = false;
                    this.Hide();
                    Form2 ss = new Form2(); // форма после ввода верных значений логина и пароля
                    ss.Show(); // открыть форму Form2
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    Mesa
                } */
        }


    }
}
