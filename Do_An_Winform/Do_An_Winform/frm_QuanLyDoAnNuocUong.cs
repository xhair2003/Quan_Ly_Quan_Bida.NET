using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Winform
{
    public partial class frm_QuanLyDoAnNuocUong : Form
    {
        LopDungChung lopDungChung = new LopDungChung();
        public frm_QuanLyDoAnNuocUong()
        {
            InitializeComponent();
        }
        private void frm_QuanLyDoAnNuocUong_Load(object sender, EventArgs e)
        {
            LoadDoAn();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadDoAn()
        {
            string sql = "Select * from BangGia";
            data_DoAn.DataSource = lopDungChung.LoadDL(sql);
        }
        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            frm_Main mainForm = new frm_Main();
            mainForm.Show();
            this.Hide();
        }


        private void data_DoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = data_DoAn.CurrentRow.Cells["ID"].Value.ToString();
            txt_Ten.Text = data_DoAn.CurrentRow.Cells["TEN"].Value.ToString();
            txt_SL.Text = data_DoAn.CurrentRow.Cells["SL"].Value.ToString();
            txt_Gia.Text = data_DoAn.CurrentRow.Cells["GIA"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into BangGia values ('" + txt_ID.Text + "','" + txt_Ten.Text + "','" + txt_SL.Text + "','" + txt_Gia.Text + "')";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm mặt hàng thành công");
            else MessageBox.Show("Thêm mặt hàng thất bại");
            LoadDoAn();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE BangGia SET TEN = '" + txt_Ten.Text + "', SL = '" + txt_SL.Text + "', GIA = '" + txt_Gia.Text + "' WHERE ID = '" + txt_ID.Text + "'";
            int kq = lopDungChung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
            LoadDoAn();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "Delete BangGia where ID = '" + txt_ID.Text + "'";
                int kq = lopDungChung.ThemXoaSua(sql);
                if (kq >= 1) MessageBox.Show("Xóa thành công");
                else MessageBox.Show("Xóa thất bại");
                LoadDoAn();
            }
        }
    }
}
