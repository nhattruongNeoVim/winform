using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace KTR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String conString = "Data Source=172.28.29.235;Initial Catalog=ktra;Persist Security Info=True;User ID=sa;Password=1234567890p*;Encrypt=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
            LoadDB();
        }

        private void LoadDB()
        {
            dataGrid.ItemsSource = null;
            cb_Khoa.ItemsSource = null;
            dt.Clear();
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand("select * from SINHVIEN", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
                cb_Khoa.ItemsSource = dt.DefaultView.ToTable(true, "Khoa").DefaultView;
                cb_Khoa.DisplayMemberPath = "Khoa";
                cb_Khoa.SelectedIndex = 0;
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

        private void ClearCotrol()
        {
            txt_SDT.Clear();
            txt_Name.Clear();
            txt_Address.Clear();
            cb_Khoa.ItemsSource = null;
            date_Birthday.Text = null;
            date_ToSchool.Text = null;
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand("insert into SINHVIEN values(@hoten, @ngaysinh, @diachi, @sdt, @namvaotruong, @khoa)", con);
                cmd.Parameters.AddWithValue("@hoten", txt_Name.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(date_Birthday.Text));
                cmd.Parameters.AddWithValue("@diachi", txt_Address.Text);
                cmd.Parameters.AddWithValue("@sdt", txt_SDT.Text);
                cmd.Parameters.AddWithValue("@namvaotruong", DateTime.Parse(date_ToSchool.Text));
                cmd.Parameters.AddWithValue("@khoa", cb_Khoa.Text);
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

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để xoá");
                return;
            }
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand("delete from DANGKYHOCPHAN where MaSV = @masv; delete from SINHVIEN where MaSV = @masv", con);
                cmd.Parameters.AddWithValue("@masv", (int)((DataRowView)dataGrid.SelectedItem)["MaSV"]);
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

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để sửa");
                return;
            }
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                cmd = new SqlCommand("update SINHVIEN set HoTen=@hoten, Ngaysinh=@ngaysinh, Diachi=@diachi, SDT=@SDT, NamVaoTruong=@namvaotruong, Khoa=@Khoa where MaSV=@masv", con);
                cmd.Parameters.AddWithValue("@hoten", txt_Name.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(date_Birthday.Text));
                cmd.Parameters.AddWithValue("@diachi", txt_Address.Text);
                cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                cmd.Parameters.AddWithValue("@namvaotruong", DateTime.Parse(date_ToSchool.Text));
                cmd.Parameters.AddWithValue("@khoa", cb_Khoa.Text);
                cmd.Parameters.AddWithValue("@masv", (int)((DataRowView)dataGrid.SelectedItem)["MaSV"]);
                cmd.ExecuteNonQuery();
                ClearCotrol();
                LoadDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItem is DataRowView row)
            {
                txt_Name.Text = row["HoTen"].ToString();
                date_Birthday.Text = row["NgaySinh"].ToString();
                txt_Address.Text = row["DiaChi"].ToString();
                txt_SDT.Text = row["SDT"].ToString();
                cb_Khoa.Text = row["Khoa"].ToString();
                date_ToSchool.Text = row["NamVaoTruong"].ToString();
            }
        }
    }
}