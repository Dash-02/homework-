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
    public partial class Form2 : Form
    {
        Query controller;
        public Form2()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdatePerson();
        }
    }
}
