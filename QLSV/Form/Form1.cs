using System.Data;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class Form1 : Form
    {
        string connectString = @"Data Source=172.29.41.75;Initial Catalog=QLSV;Persist Security Info=True;User ID=sa;Password=1234567890p*;Encrypt=False";

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
            LoadData();

        }


        private void LoadData()
        {
            con = new SqlConnection(connectString);
            dt.Clear();
            dataGridView1.DataSource = null;
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from SINHVIEN", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally {
                con.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txt_MaSV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_NgaySinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_SDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            cb_K.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cb_Khoa.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO SINHVIEN (MaSV, HoTen, NgaySinh, DiaChi, SDT, Khoa, NamVaoTruong) VALUES (@MaSV, @HoTen, @NgaySinh, @DiaChi, @SDT, @Khoa, @NamVaoTruong)", con);
                cmd.Parameters.AddWithValue("@MaSV", txt_MaSV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_HoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", txt_NgaySinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                cmd.Parameters.AddWithValue("@Khoa", cb_Khoa.Text);
                cmd.Parameters.AddWithValue("@NamVaoTruong", cb_K.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM SINHVIEN WHERE MaSV=@MaSV", con);
                cmd.Parameters.AddWithValue("@MaSV", txt_MaSV.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE SINHVIEN SET HoTen=@HoTen, NgaySinh=@NgaySinh, DiaChi=@DiaChi, SDT=@SDT, Khoa=@Khoa, NamVaoTruong=@NamVaoTruong WHERE MaSV=@MaSV", con);
                cmd.Parameters.AddWithValue("@MaSV", txt_MaSV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_HoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", txt_NgaySinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                cmd.Parameters.AddWithValue("@Khoa", cb_Khoa.Text);
                cmd.Parameters.AddWithValue("@NamVaoTruong", cb_K.Text);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
