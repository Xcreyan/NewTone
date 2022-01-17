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
            try
            {
                listBox1.Items.Clear();
                int j = Convert.ToInt32(textBox6.Text);
                double x = Convert.ToInt32(textBox7.Text);
                double otvet = 0;
                string comb = comboBox1.Text + comboBox2.Text;
                for (int i = 1; i <= j; i++)
                {
                    switch(comb)
                    {
                        case "--" :
                            otvet = (Convert.ToDouble(textBox3.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text)) - Convert.ToDouble(textBox4.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text)) - Convert.ToDouble(textBox5.Text))
                        /
                        ((Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox1.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text) - 1)) - (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox2.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text) - 1)));
                            x = x - otvet;
                            break;
                        case "-+":
                            otvet = (Convert.ToDouble(textBox3.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text)) - Convert.ToDouble(textBox4.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text)) + Convert.ToDouble(textBox5.Text))
                        /
                        ((Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox1.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text) - 1)) - (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox2.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text) - 1)));
                            x = x - otvet;
                            break;
                        case "++":
                            otvet = (Convert.ToDouble(textBox3.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text)) + Convert.ToDouble(textBox4.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text)) + Convert.ToDouble(textBox5.Text))
                        /
                        ((Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox1.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text) - 1)) + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox2.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text) - 1)));
                            x = x - otvet;
                            break;
                        case "+-":
                            otvet = (Convert.ToDouble(textBox3.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text)) + Convert.ToDouble(textBox4.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text)) - Convert.ToDouble(textBox5.Text))
                        /
                        ((Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox1.Text) * Math.Pow(x, Convert.ToDouble(textBox1.Text) - 1)) + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox2.Text) * Math.Pow(x, Convert.ToDouble(textBox2.Text) - 1)));
                            x = x - otvet;
                            break;
                    }
                }
                listBox1.Items.Add(x.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
