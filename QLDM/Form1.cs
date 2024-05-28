using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nhattruongNeoVim
{
    public partial class Form1 : Form
    {
        public string connectString = @"Data Source=172.29.41.75;Initial Catalog=QLDM;User ID=sa;Password=1234567890p*;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
            Chi();
        }


        private void LoadDB()
        {
            con = new SqlConnection(connectString);
            dt.Clear();
            dataGridView1.DataSource = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SANPHAM", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void Chi()
        {
            try
            {
                con.Open();
                string query = "select id, tenDanhMuc from DANHMUC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb_idDanhMuc.DataSource = dt;
                    cb_idDanhMuc.DisplayMember = "tenDanhMuc";
                    cb_idDanhMuc.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO SANPHAM VALUES (@tenSanPham, @size, @soLuong, @mauSac, @ngayCapNhat, @idDanhMuc)", con);
                cmd.Parameters.AddWithValue("@tenSanPham", txt_tensp.Text);
                cmd.Parameters.AddWithValue("@size", cb_size.Text);
                cmd.Parameters.AddWithValue("@soLuong", txt_sl.Text);
                cmd.Parameters.AddWithValue("@mauSac", txt_mausac.Text);
                cmd.Parameters.AddWithValue("@ngayCapNhat", DateTime.Parse(dt_date.Text));
                cmd.Parameters.AddWithValue("@idDanhMuc", cb_idDanhMuc.SelectedValue);
                cmd.ExecuteNonQuery();
                LoadDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txt_tensp.Text = dataGridView1.Rows[i].Cells["tenSanPham"].Value.ToString();
            cb_size.Text = dataGridView1.Rows[i].Cells["size"].Value.ToString();
            txt_sl.Text = dataGridView1.Rows[i].Cells["soLuong"].Value.ToString();
            txt_mausac.Text = dataGridView1.Rows[i].Cells["mauSac"].Value.ToString();
            txt_idSanPham.Text = dataGridView1.Rows[i].Cells["idSanPham"].Value.ToString();
            dt_date.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["ngayCapNhat"].Value.ToString());
            int idDanhMuc = Convert.ToInt32(dataGridView1.Rows[i].Cells["idDanhMuc"].Value);
            cb_idDanhMuc.SelectedValue = idDanhMuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM SANPHAM WHERE idSanPham=@idSanPham", con);
                cmd.Parameters.AddWithValue("@idSanPham", txt_idSanPham.Text);
                cmd.ExecuteNonQuery();
                LoadDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }

}
