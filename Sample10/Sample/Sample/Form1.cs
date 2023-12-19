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
    public partial class Form1 : Form
    {
        Query controller;
        bool isAdmin = true;
        CheckAdmin Checks;
        public bool Value { get; set; }

        public Form1(bool isCheck)
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
            Checks = new CheckAdmin(); // создаем экземпляр класса CheckAdmin
            if (isCheck)
            {
                button5.Visible = true;
            }
            else
            {
                button5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdatePerson();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            controller.Add(textBox1.Text, textBox2.Text, textBox4.Text,  int.Parse(textBox3.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       


        private void button5_Click(object sender, EventArgs e)
        {
          
            Form3 ss = new Form3();
            this.Hide();
            ss.Show();
        }

        private void редактированиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void редактированиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите изменить эти данные?", "Подтверждение измение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString());
                    GlobalVariables1.GLOBALID = 36;
                    
                    FormEditor Editor = new FormEditor(ID);
                    Editor.Show();
               


                }
                else
                {
                    MessageBox.Show("Невозможно определить ID клиента для изменения.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdd ss = new FormAdd();
            ss.Show();
            
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          /*  bool isTrue = GlobalVariables1.GlobalString;
            Form4Del del = new Form4Del();
            del.Show();
            if(isTrue)
            {
                controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
                del.Hide();
            }*/
          if(dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить эти данные?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes) 
                {
                    controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
                    dataGridView1.DataSource = controller.UpdatePerson();
                } 
                else
                {
                    MessageBox.Show("Невозможно определить ID клиента для удаления.", "Ошибка Удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
