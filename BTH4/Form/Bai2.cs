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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            LoadYearList();
            LoadClassList();
            LoadSubjectList();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string year = null, yearInfo = null;
            foreach (RadioButton item in pn_year.Controls)
            {
                if (item.Checked)
                {
                    year = item.Text;
                    break;
                }
            }
            if (year == null)
            {
                yearInfo = "Chưa đăng ký học kỳ" + year;
            }
            else
            {
                yearInfo = "Đã đăng ký học kỳ " + year;
            }

            int d = 1;
            string subject = null, subjectInfo = null;
            for (int i = 0; i < cl_subject.Items.Count; i++)
            {
                if (cl_subject.GetItemChecked(i))
                {
                    subject += d++ + " " + cl_subject.Items[i].ToString() + "\n";
                }
            }
            if (subject != null)
            {
                subjectInfo += "Các môn học: \n";
                subjectInfo += subject;
            }

            MessageBox.Show("Mã số sinh viên: " + txt_MSSV.Text + "\n"
                + "Tên sinh viên: " + txt_Name.Text + "\n"
                + "Lớp: " + cbb_class.SelectedItem.ToString() + "\n"
                + "Niên khoá: " + cbb_year.SelectedItem.ToString() + "\n"
                + yearInfo + "\n"
                + subjectInfo);
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            txt_MSSV.Clear();
            txt_Name.Clear();
            LoadYearList();
            LoadClassList();
            LoadSubjectList();
            foreach (RadioButton item in pn_year.Controls)
            {
                if (item.Checked == true)
                {
                    item.Checked = false;
                }
            }
        }

        private void LoadYearList()
        {
            cbb_year.Items.Clear();

            string[] years = new string[] { "2022", "2023", "2024", "2025" };

            foreach (string year in years)
            {
                cbb_year.Items.Add(year);
            }

            cbb_year.SelectedIndex = 0;
        }

        private void LoadClassList()
        {
            cbb_class.Items.Clear();

            string[] class_list = new string[] { "CNTT45C", "CNTT44C", "KTPM45C", "TTNT45C" };

            foreach (string cl in class_list)
            {
                cbb_class.Items.Add(cl);
            }

            cbb_class.SelectedIndex = 0;
        }

        private void LoadSubjectList()
        {
            cl_subject.Items.Clear();

            string[] subjects = { "LT Windows", "LT Internet", "Mạng máy tính", "UML" };

            foreach (string subject in subjects)
            {
                cl_subject.Items.Add(subject);
            }
        }

        private void txt_MSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập số!");
                e.Handled = true;
            }
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập chữ!");
                e.Handled = true;
            }
        }
    }
}
