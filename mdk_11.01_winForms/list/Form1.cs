using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        AboutBox1 a;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void InstertButton(object sender, EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            listBox1.Items.Insert(selected, textBox2.Text);
            textBox2.Clear();
        }

        private void PutStr(object sender, EventArgs e)
        {
            var selectedValue = listBox1.SelectedItem;
           

            int selectedIndex = listBox1.Items.IndexOf(selectedValue);

            listBox1.Items.Insert(selectedIndex, textBox2.Text);
            listBox1.Items.Remove(selectedValue);
            textBox2.Clear();
            //int selectedIndex = listBox1.Items.IndexOf(selectedValue);
            //listBox1.Items.Remove(selectedValue);
            //textBox2.Text = selectedValue.ToString();
            //listBox1.Items.Insert(selectedIndex, textBox2.Text);
            //listBox1.Items.Remove(textBox2.Text);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedValue = listBox1.SelectedItem;
            listBox1.Items.Remove(selectedValue);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\WSR-209-08\\Desktop\\text.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\WSR-209-08\\Desktop\\text.txt"))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    sw.WriteLine(listBox1.Items[i].ToString());
            }

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a = new AboutBox1();
            a.Show();
        }
    }
}
