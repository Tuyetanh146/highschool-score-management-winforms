using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTLWindowForm
{
    public partial class FrmQuanlyHocSinh : Form
    {
        public FrmQuanlyHocSinh()
        {
            InitializeComponent();
        }
        ClsThaoTacCSDL cls = new ClsThaoTacCSDL();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanlyHocSinh_Load(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = cls.ThucThiSQL("Select * From dbo.HocSinh");
            dgvHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
            dgvHocSinh.Columns["HoTen"].HeaderText = "Họ tên ";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ ";
            dgvHocSinh.Columns["MaLop"].HeaderText = "Mã lớp ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cls.ThucThiSQL("Insert into dbo.HocSinh values ('" + txtMaHS.Text + "' , N'" + txtHoTen.Text + "' , '" + txtNgaySinh.Text + "' ,'" + cboGioiTinh.Text.Trim() + "',  '" + txtDiaChi.Text + "' , '" + txtMaLop.Text + "' )");
            dgvHocSinh.DataSource = cls.ThucThiSQL("Select * From dbo.HocSinh ");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Update HocSinh set HoTen =N'" + txtHoTen.Text + "',GioiTinh =N'" + cboGioiTinh.Text.Trim() + "',NgaySinh ='" + txtNgaySinh.Text + "',DiaChi = N'" + txtDiaChi.Text +"' ,MaLop ='" + txtMaLop.Text + "' where MaHS ='" + txtMaHS.Text + "'");
            dgvHocSinh.DataSource = cls.ThucThiNonQuery("Select * from dbo.HocSinh");
            LoadData();
        }
        void LoadData()
        {
            string sql = "Select * From dbo.HocSinh";
            dgvHocSinh.DataSource = cls.ThucThiSQL(sql);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Delete From HocSinh Where MaHS = '" + txtMaHS.Text + "' ");
            dgvHocSinh.DataSource = cls.ThucThiNonQuery("Select * From dbo.HocSinh");
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            cboGioiTinh.SelectedIndex = -1;
            txtDiaChi.Clear();
            txtMaLop.Clear();

        }


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            string sql = "Select * From HocSinh Where " + "MaHS like '%" + key + "%' " + "or HoTen like '%" + key + "%' " + "or MaLop like '%" + key + "%' " + "or GioiTinh like N'%" + key + "%'  ";
            dgvHocSinh.DataSource = cls.ThucThiSQL(sql);
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocSinh.Rows[e.RowIndex];
                txtMaHS.Text = dgvHocSinh.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                txtHoTen.Text = dgvHocSinh.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                cboGioiTinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtNgaySinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtMaLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();

            }
        }
    }
}
