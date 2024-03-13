using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Winform
{
    public partial class frm_Login : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Code_Space\\Do_An_Winform\\Do_An_Winform\\DataBase.mdf;Integrated Security=True";
        private int soLanNhapSai = 5;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckb_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienMatKhau.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false; // Sử dụng hiển thị mật khẩu theo kiểu "Normal"
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true; // Sử dụng hiển thị mật khẩu theo kiểu "Password"
            }

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TAIKHOAN = @TenTaiKhoan AND MATKHAU = @MatKhau";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenTaiKhoan", txt_TaiKhoan.Text);
                command.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text);

                connection.Open();
                int result = (int)command.ExecuteScalar();

                if (soLanNhapSai <= 0)
                {
                    MessageBox.Show("Bạn đã hết số lần nhập sai. Ứng dụng sẽ tự động thoát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                if (result > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    // Sau khi đăng nhập thành công, bạn có thể thực hiện các hành động khác tại đây
                    frm_Main mainForm = new frm_Main();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    soLanNhapSai--;
                    if (soLanNhapSai > 0)
                    {
                        MessageBox.Show($"Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại! Bạn còn {soLanNhapSai} lần nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã hết số lần nhập sai. Ứng dụng sẽ tự động thoát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}
