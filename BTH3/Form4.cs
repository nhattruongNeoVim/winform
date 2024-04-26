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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadEducationLevels();
            LoadDepartments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Name is " + textBox1.Text);
            MessageBox.Show("Employee Address is " + textBox2.Text);
            MessageBox.Show("Joined on " + textBox3.Text + " has education " + comboBox1.SelectedItem.ToString() 
                + " and belongs to dept " + comboBox2.SelectedItem.ToString());
            //button2_Click(sender, e);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEducationLevels()
        {
            string[] educationLevels = new string[] { "Tiến sĩ", "Thạc sĩ", "Đại học", "Cao đẳng", "Trung cấp", "Trung học", "Cấp hai", "Cấp một" };

            foreach (string level in educationLevels)
            {
                comboBox1.Items.Add(level);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void LoadDepartments()
        {
            string[] departments = new string[] { "Phòng kinh doanh", "Phòng nhân sự", "Phòng kỹ thuật", "Phòng hành chính" };

            foreach (string department in departments)
            {
                comboBox2.Items.Add(department);
            }

            comboBox2.SelectedIndex = 0;
        }
    }
}
