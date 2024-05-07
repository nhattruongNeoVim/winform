using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = Math.Pow(b, 2) - (4 * a * c);
            if (a == 0)
            {
                if (b != 0)
                {
                    textBox4.Text = "x1 = x2 = " + (-b / a);
                }
                else
                {
                    MessageBox.Show("A phải khác 0");
                    button2_Click(sender, e);
                }
            }
            else if (d < 0)
            {
                textBox4.Text = "Phương trình vô nghiệm";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                textBox4.Text = string.Format("x1 = {0};    x2 = {1}", x1, x2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void updateButtonStatus()
        {
            bool check = !string.IsNullOrWhiteSpace(textBox1.Text) &&
            !string.IsNullOrWhiteSpace(textBox2.Text) &&
            !string.IsNullOrWhiteSpace(textBox3.Text);

            button1.Enabled = check;
            button2.Enabled = check;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateButtonStatus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            updateButtonStatus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            updateButtonStatus();
        }
    }
}
