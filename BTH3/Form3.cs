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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals("Admin"))
            {
                if (this.textBox2.Text.Equals("Admin"))
                {
                    Form4 employee = new Form4();
                    employee.FormClosed += showFormAgain;
                    employee.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Password is invalid");
            }
            else
                MessageBox.Show("User Name is invalid");
        }

        private void showFormAgain(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
