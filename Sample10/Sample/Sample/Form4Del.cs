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
    public partial class Form4Del : Form
    {
        public Form4Del()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVariables1.GlobalString = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVariables1.GlobalString = false;
        }
    }
}
