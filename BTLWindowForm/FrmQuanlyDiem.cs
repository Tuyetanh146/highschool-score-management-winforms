using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTLWindowForm
{
    public partial class FrmQuanlyDiem : Form
    {
        public FrmQuanlyDiem()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        ClsThaoTacCSDL cls = new ClsThaoTacCSDL();
        private void FrmQuanlyDiem_Load(object sender, EventArgs e)
        {
            dgvDiem.DataSource = cls.ThucThiSQL("Select * from dbo.Diem");
            dgvDiem.Columns["MaHS"].HeaderText = "Mã học sinh";
            dgvDiem.Columns["MaMH"].HeaderText = "Mã môn học  ";
            dgvDiem.Columns["HocKy"].HeaderText = "Học kỳ";
            dgvDiem.Columns["DiemMieng"].HeaderText = "Điểm miệng ";
            dgvDiem.Columns["Diem15p"].HeaderText = "Điểm 15 phút";
            dgvDiem.Columns["Diem1Tiet"].HeaderText = "Điểm 1 tiết ";
            dgvDiem.Columns["DiemThi"].HeaderText = "Điểm thi";
            // Nạp dữ liệu cho cboMaHS
            cboMaHS.DataSource = cls.ThucThiSQL("Select Distinct  MaHS From dbo.Diem");
            cboMaHS.DisplayMember = "MaHS";
            cboMaHS.ValueMember = "MaHS";

            // Nạp dữ liệu cho cboMaMH
            cboMaMH.DataSource = cls.ThucThiSQL("Select Distinct  MaMH FROM dbo.Diem");
            cboMaMH.DisplayMember = "MaMH";
            cboMaMH.ValueMember = "MaMH";

            // Nạp dữ liệu cho  cboHocKy
            cboHocKy.Items.Clear();
            cboHocKy.Items.Add("1");
            cboHocKy.Items.Add("2");

        }
        void LoadData()
        {
            string sql = "Select * From dbo.Diem";
            dgvDiem.DataSource = cls.ThucThiSQL(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            cls.ThucThiSQL("Insert into dbo.Diem values('" + cboMaHS.Text + "','" + cboMaMH.Text + "','" + cboHocKy.Text + "','" + txtDiemMieng.Text + "','" + txtDiem15p.Text + "','" + txtDiem1Tiet.Text + "','" + txtDiemThi.Text + "')");
            dgvDiem.DataSource = cls.ThucThiSQL("Select * From dbo.Diem");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Update dbo.Diem set MaMH ='" + cboMaMH.Text + "',HocKy = '" + cboHocKy.Text + "',DiemMieng = '" + txtDiemMieng.Text + "',Diem15p = '" + txtDiem15p.Text + "' ,Diem1Tiet = '" + txtDiem1Tiet.Text + "',DiemThi = '" + txtDiemThi.Text + "' where MaHS ='" + cboMaHS.Text + "' and MaMH = '" + cboMaMH.Text + "' and HocKy = '" + cboHocKy.Text + "'");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Delete from dbo.Diem Where MaHS='" + cboMaHS.Text + "' and MaMH='" + cboMaMH.Text + "' and HocKy='" + cboHocKy.Text + "'");
            dgvDiem.DataSource = cls.ThucThiNonQuery("Select * From dbo.Diem");
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaHS.Text = "";
            cboMaMH.Text = "";
            cboHocKy.Text = "";
            txtDiemMieng.Clear();
            txtDiem15p.Clear();
            txtDiem1Tiet.Clear();
            txtDiemThi.Clear();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDiem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];
                cboMaHS.Text = dgvDiem.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                cboMaMH.Text = dgvDiem.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
                cboHocKy.Text = dgvDiem.Rows[e.RowIndex].Cells["HocKy"].Value.ToString();

                txtDiemMieng.Text = dgvDiem.Rows[e.RowIndex].Cells["DiemMieng"].Value.ToString();
                txtDiem15p.Text = dgvDiem.Rows[e.RowIndex].Cells["Diem15p"].Value.ToString();
                txtDiem1Tiet.Text = dgvDiem.Rows[e.RowIndex].Cells["Diem1Tiet"].Value.ToString();
                txtDiemThi.Text = dgvDiem.Rows[e.RowIndex].Cells["DiemThi"].Value.ToString();
            }
        }

        private void dgvDiem_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];
                cboMaHS.Text = dgvDiem.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                cboMaMH.Text = dgvDiem.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
                cboHocKy.Text = dgvDiem.Rows[e.RowIndex].Cells["HocKy"].Value.ToString();

                txtDiemMieng.Text = dgvDiem.Rows[e.RowIndex].Cells["DiemMieng"].Value.ToString();
                txtDiem15p.Text = dgvDiem.Rows[e.RowIndex].Cells["Diem15p"].Value.ToString();
                txtDiem1Tiet.Text = dgvDiem.Rows[e.RowIndex].Cells["Diem1Tiet"].Value.ToString();
                txtDiemThi.Text = dgvDiem.Rows[e.RowIndex].Cells["DiemThi"].Value.ToString();
            }
        }
    }
}
