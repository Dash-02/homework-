using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Учет_готовой_продукции.Controller;

namespace Учет_готовой_продукции
{
    public partial class Form1 : Form
    {
        Users users;
        Transaction transaction;
        Customers customers;
        Products products;
        Parametr parametr;
        public Form1()
        {
            users = new Users(ConnectionString.ConnStr);
            transaction = new Transaction(ConnectionString.ConnStr);
            customers = new Customers(ConnectionString.ConnStr);
            products = new Products(ConnectionString.ConnStr);
            parametr = new Parametr(ConnectionString.ConnStr);
            InitializeComponent();
            dataGridView1.DataSource = parametr.upDateParametr();
            dataGridView2.DataSource=products.upDateProducts();
            dataGridView3.DataSource = customers.upDateCustomers();
            dataGridView4.DataSource = transaction.upDateTransaction();
            dataGridView5.DataSource =  users.upDateUsers();
            comboBox1.DataSource = dataGridView1.DataSource;
            comboBox1.ValueMember = "Код продукции";
            comboBox1.DisplayMember = "Наименование";
            comboBox4.DataSource = dataGridView2.DataSource;
            comboBox4.ValueMember = "Код продукции";
            comboBox4.DisplayMember = "Наименование";
            comboBox3.DataSource = dataGridView3.DataSource;
            comboBox3.ValueMember = "Код клиента";
            comboBox3.DisplayMember = "ФИО";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Вывод_правельный". При необходимости она может быть перемещена или удалена.
            this.вывод_правельныйTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Вывод_правельный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Сделки". При необходимости она может быть перемещена или удалена.
            this.сделкиTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Сделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Характеристики". При необходимости она может быть перемещена или удалена.
            this.характеристикиTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Характеристики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Продукция_вывод". При необходимости она может быть перемещена или удалена.
            this.продукция_выводTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Продукция_вывод);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Сделки_вывод". При необходимости она может быть перемещена или удалена.
            //this.сделки_выводTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Сделки_вывод);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Продукция". При необходимости она может быть перемещена или удалена.
          //  this.продукцияTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Продукция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_готовой_продукцииDataSet.Характеристики". При необходимости она может быть перемещена или удалена.
            this.характеристикиTableAdapter.Fill(this.учет_готовой_продукцииDataSet.Характеристики);

        }

        private void button1_Click(object sender, EventArgs e) //добавление в характеристики
        {
            DateTime date1 = Convert.ToDateTime(dateTimePicker2.Text);
            parametr.AddParametr(textBox1.Text, textBox2.Text, textBox3.Text,  textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, date1.ToString("MM/dd/yyyy").Replace('.', '/'));
            dataGridView1.DataSource = parametr.upDateParametr();
        }

        private void отправитьНаРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, ind].Value.ToString();
            textBox2.Text = dataGridView1[1, ind].Value.ToString();
            textBox3.Text = dataGridView1[2, ind].Value.ToString();
            textBox4.Text = dataGridView1[3, ind].Value.ToString();
            textBox5.Text = dataGridView1[4, ind].Value.ToString();
            textBox6.Text = dataGridView1[5, ind].Value.ToString();
            textBox7.Text = dataGridView1[6, ind].Value.ToString();
            textBox8.Text = dataGridView1[7, ind].Value.ToString();
            textBox9.Text = dataGridView1[8, ind].Value.ToString();
            textBox10.Text = dataGridView1[9, ind].Value.ToString();
            dateTimePicker2.Text = dataGridView1[10, ind].Value.ToString();
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.CurrentRow.Index;
           int id = int.Parse(dataGridView1[0, ind].Value.ToString());
            parametr.DeleteParametr(id);
            dataGridView1.DataSource = parametr.upDateParametr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date1 = Convert.ToDateTime(dateTimePicker2.Text);
            parametr.EditParametr(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, date1.ToString("MM/dd/yyyy").Replace('.', '/'));
            dataGridView1.DataSource = parametr.upDateParametr();
            button2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            products.AddProducts(comboBox1.SelectedValue.ToString(), textBox12.Text, comboBox2.Text);
            dataGridView2.DataSource = products.upDateProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ind = dataGridView2.CurrentRow.Index;
            int id = int.Parse(dataGridView2[0, ind].Value.ToString());
            products.DeleteProducts(id);
            dataGridView2.DataSource = products.upDateProducts();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int ind = dataGridView2.CurrentRow.Index;
            comboBox1.Text = dataGridView2[1, ind].Value.ToString();
            textBox12.Text = dataGridView2[2, ind].Value.ToString();
            comboBox2.Text = dataGridView2[3, ind].Value.ToString();
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            products.EditProducts(int.Parse(comboBox1.SelectedValue.ToString()), textBox12.Text, comboBox2.SelectedValue.ToString());
            dataGridView2.DataSource = products.upDateProducts();
            button5.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            customers.AddCustomers(textBox13.Text, maskedTextBox1.Text, textBox14.Text);
            dataGridView3.DataSource = customers.upDateCustomers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ind = dataGridView3.CurrentRow.Index;
            int id = int.Parse(dataGridView3[0, ind].Value.ToString());
            customers.DeleteCustomers(id);
            dataGridView3.DataSource = customers.upDateCustomers();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView3.CurrentRow.Index;
            textBox13.Text = dataGridView3[1, ind].Value.ToString();
            maskedTextBox1.Text = dataGridView3[2, ind].Value.ToString();
            textBox14.Text = dataGridView3[3, ind].Value.ToString();
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ind = dataGridView3.CurrentRow.Index;
            customers.EditCustomers(int.Parse(dataGridView3[1, ind].Value.ToString()), textBox13.Text, maskedTextBox1.Text, textBox14.Text);
            dataGridView3.DataSource = customers.upDateCustomers(); 
            button8.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            users.AddUsers(textBox16.Text, textBox17.Text);
            dataGridView5.DataSource = users.upDateUsers();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            int ind = dataGridView5.CurrentRow.Index;
            int id = int.Parse(dataGridView5[0, ind].Value.ToString());
            users.DeleteUsers(id); dataGridView5.DataSource = users.upDateUsers();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int ind = dataGridView5.CurrentRow.Index;
            textBox16.Text = dataGridView5[1, ind].Value.ToString();
            textBox17.Text = dataGridView5[2, ind].Value.ToString();
            button14.Visible = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int ind = dataGridView5.CurrentRow.Index;
            users.EditUsers(int.Parse(dataGridView5[0, ind].Value.ToString()), textBox16.Text, textBox17.Text);
                   button14.Visible = false; dataGridView5.DataSource = users.upDateUsers();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
            transaction.AddTransaction(comboBox3.SelectedValue.ToString(), comboBox4.SelectedValue.ToString(), date1.ToString("MM/dd/yyyy").Replace('.', '/'), textBox15.Text);
            dataGridView4.DataSource = transaction.upDateTransaction();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ind = dataGridView4.CurrentRow.Index;
            int id = int.Parse(dataGridView4[0, ind].Value.ToString());
            transaction.DeleteTransaction(id); dataGridView4.DataSource = transaction.upDateTransaction();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int ind = dataGridView4.CurrentRow.Index;
            comboBox3.Text = dataGridView4[1, ind].Value.ToString();
            comboBox4.Text = dataGridView4[2, ind].Value.ToString();
            dateTimePicker1.Text = dataGridView4[3, ind].Value.ToString();
            textBox15.Text = dataGridView4[4, ind].Value.ToString();
            button11.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ind = dataGridView4.CurrentRow.Index;
            int id = int.Parse(dataGridView4[0, ind].Value.ToString());
            DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
            transaction.EditTransaction(id, comboBox3.SelectedValue.ToString(), comboBox4.SelectedValue.ToString(), date1.ToString("MM/dd/yyyy").Replace('.', '/'), textBox15.Text);
            dataGridView4.DataSource = transaction.upDateTransaction();
            button11.Visible = false;
        }
    }
}
