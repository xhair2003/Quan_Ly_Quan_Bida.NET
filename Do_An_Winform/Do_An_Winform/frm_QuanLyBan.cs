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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Do_An_Winform
{
    public partial class frm_QuanLyBan : Form
    {   
        LopDungChung lopDungChung = new LopDungChung();
        Timer timer;
        public frm_QuanLyBan()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void frm_QuanLyBan_Load(object sender, EventArgs e)
        {
            LoadBAN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Main mainForm = new frm_Main();
            mainForm.Show();
            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime.Value = DateTime.Now;
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
           
        }
        public void LoadBAN()
        {
            string sql = "Select * from QuanLyBan";
            data_Ban.DataSource = lopDungChung.LoadDL(sql);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_Ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SoBan.Text = data_Ban.CurrentRow.Cells["SOBAN"].Value.ToString();
            txt_ViTri.Text = data_Ban.CurrentRow.Cells["VITRI"].Value.ToString();
            txt_LoaiBan.Text = data_Ban.CurrentRow.Cells["LOAIBAN"].Value.ToString();
            txt_GioThue.Text = data_Ban.CurrentRow.Cells["GIOTHUE"].Value.ToString();
            txt_GioTra.Text = data_Ban.CurrentRow.Cells["GIOTRA"].Value.ToString();
            txt_DonGia.Text = data_Ban.CurrentRow.Cells["DONGIA"].Value.ToString();
        }

        private void btn_ChoThue_Click(object sender, EventArgs e)
        {
            txt_GioThue.Text = DateTime.Now.ToString();
            UpdateDatabase(txt_GioThue.Text);
        }

        private void btn_TraBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_GioThue.Text))
            {
                MessageBox.Show("Bạn phải cho thuê bàn trước khi trả bàn.");
                return;
            }
            txt_GioTra.Text = DateTime.Now.ToString();
            UpdateDatabase(txt_GioTra.Text);

            if (!string.IsNullOrWhiteSpace(txt_GioThue.Text) && !string.IsNullOrWhiteSpace(txt_GioTra.Text))
            {
                DateTime gioThue = DateTime.Parse(txt_GioThue.Text);
                DateTime gioTra = DateTime.Parse(txt_GioTra.Text);
                TimeSpan thoiGianThue = gioTra - gioThue;
                decimal gia = decimal.Parse(txt_DonGia.Text);
                decimal tonggia = gia * (decimal)thoiGianThue.TotalHours;

                string formattedTongGia = tonggia.ToString("0.##,### VND");

                // Hiển thị tổng giá đã được định dạng
                txt_TongTien.Text = formattedTongGia;

            }
        }

        private void UpdateDatabase(string valueToUpdate)
        {
            string sql = "UPDATE QuanLyBan SET VITRI = '" + txt_ViTri.Text + " ', LOAIBAN = '" + txt_LoaiBan.Text + "', GIOTHUE = '" + txt_GioThue.Text + "', GIOTRA = '" + txt_GioTra.Text +  "' WHERE SOBAN = '" + txt_SoBan.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            LoadBAN();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_GioThue.Text = "";
            txt_GioTra.Text = "";
            txt_TongTien.Text = "";
            txt_DonGia.Text = "";
            UpdateDatabase(txt_GioTra.Text);
            UpdateDatabase(txt_GioThue.Text);
        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {

            
           
        }
        
    }
}
