using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_input.Text, out double number))
            {
                lb_output.Items.Add(txt_input.Text);
                txt_input.Clear();
            }
            else
            {
                MessageBox.Show("Nhập số");
                txt_input.Clear();
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(var item in lb_output.Items)
            {
                sum += double.Parse(item.ToString());
            }
            MessageBox.Show("Tổng các phần tử trong Listbox là: " + sum);
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_input_Click(sender, e);
            }
        }

        private void btn_delete_firt_last_Click(object sender, EventArgs e)
        {
            if (lb_output.Items.Count > 0)
            {
                lb_output.Items.RemoveAt(0);
                lb_output.Items.RemoveAt(lb_output.Items.Count - 1);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lb_output.SelectedIndex != -1)
            {
                lb_output.Items.RemoveAt(lb_output.SelectedIndex);
            }
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lb_output.Items.Count; i++)
            {
                lb_output.Items[i] = double.Parse(lb_output.Items[i].ToString()) + 2;
            }
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lb_output.Items.Count; i++)
            {
                lb_output.Items[i] = Math.Pow(double.Parse(lb_output.Items[i].ToString()), 2);
            }
        }
    }
}
