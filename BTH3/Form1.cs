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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            if (a == 0)
            {
                MessageBox.Show("A Phải khác 0");
                button2_Click(sender, e);
            }
            else
            {
                textBox3.Text = (-b / a).ToString();
            }
        }

        public void updateButtonStatus()
        {
            bool check = !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text);

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
    }
}
