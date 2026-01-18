using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTLWindowForm
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }
        ClsThaoTacCSDL cls = new ClsThaoTacCSDL();

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtDiemTB.Text = "0.00";
            txtXepLoai.Clear();
            dgvDiemMon.DataSource = null;
            txtMaHS.Focus();
        }

        private void btnTinhTB_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();
            if (maHS == "")
            {
                MessageBox.Show("Nhập mã học sinh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Query SQL đã tính sẵn DiemTB và XepLoai
            string sql = $@"
        Select 
            hs.MaHS,
            hs.HoTen,
            l.Tenlop,
            d.DiemMieng,
            d.Diem15p,
            d.Diem1Tiet,
            d.DiemThi,
            Round((d.DiemMieng + d.Diem15p + d.Diem1Tiet*2 + d.DiemThi*3)/7,2) As DiemTB,
            Case
                When(d.DiemMieng + d.Diem15p + d.Diem1Tiet*2 + d.DiemThi*3)/7 >= 8 Then N'Giỏi'
                When (d.DiemMieng + d.Diem15p + d.Diem1Tiet*2 + d.DiemThi*3)/7 >= 6.5 Then N'Khá'
                When (d.DiemMieng + d.Diem15p + d.Diem1Tiet*2 + d.DiemThi*3)/7 >= 5 Then N'Trung bình'
                Else N'Yếu'
            End as XepLoai
        From HocSinh hs
        Join Lop l On hs.Malop = l.Malop
        Join Diem d On hs.MaHS = d.MaHS And d.HocKy = 1
        Where hs.MaHS = '{maHS}'";
            DataTable dt = cls.ThucThiSQL(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Học sinh chưa có dữ liệu điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDiemMon.DataSource = null;
                txtDiemTB.Text = "0.00";
                txtXepLoai.Text = "";
                txtTenHS.Text = "";
                return;
            }

            dgvDiemMon.Columns.Clear();
            dgvDiemMon.AutoGenerateColumns = true;
            dgvDiemMon.DataSource = dt;
            dgvDiemMon.Columns["MaHS"].HeaderText = "Mã học sinh";
            dgvDiemMon.Columns["HoTen"].HeaderText = "Họ tên";
            dgvDiemMon.Columns["Tenlop"].HeaderText = "Lớp";
            dgvDiemMon.Columns["DiemMieng"].HeaderText = "Điểm miệng";
            dgvDiemMon.Columns["Diem15p"].HeaderText = "Điểm 15 phút";
            dgvDiemMon.Columns["Diem1Tiet"].HeaderText = "Điểm 1 tiết";
            dgvDiemMon.Columns["DiemThi"].HeaderText = "Điểm thi";
            dgvDiemMon.Columns["DiemTB"].HeaderText = "Điểm trung bình";
            dgvDiemMon.Columns["XepLoai"].HeaderText = "Xếp loại";


            // Lấy dữ liệu trung bình và xếp loại từ row đầu tiên 
            txtTenHS.Text = dt.Rows[0]["HoTen"].ToString();
            txtDiemTB.Text = dt.Rows[0]["DiemTB"].ToString();
            txtXepLoai.Text = dt.Rows[0]["XepLoai"].ToString();
        }
        private void btnInXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng In/Xuất bảng điểm hiện đang giả lập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDiemMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

