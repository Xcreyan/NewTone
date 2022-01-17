using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int j = Convert.ToInt32(textBox2.Text);
            double x = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < j; i++)
            {

            }
        }
    }
}
