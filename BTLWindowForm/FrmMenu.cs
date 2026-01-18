using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BTLWindowForm
{
    public partial class FrmMenu : Form
    {

        string _quyen;

        public FrmMenu(string quyen)
        {
            InitializeComponent();
            _quyen = quyen;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

                if (_quyen == "Admin")
                {
                    // Toàn quyền
                    btnQuanLyHocSinh.Enabled = true;
                    btnQuanLyLop.Enabled = true;
                    btnQuanLyMonhoc.Enabled = true;
                    btnNhapDiem.Enabled = true;
                    btnBaoCao.Enabled = true;
                }
                else if (_quyen == "GiaoVien")
                {
                    // Toàn quyền 
                    btnQuanLyHocSinh.Enabled = true;
                    btnQuanLyLop.Enabled = true;
                    btnQuanLyMonhoc.Enabled = true;
                    btnNhapDiem.Enabled = true;
                    btnBaoCao.Enabled = true;
                }
                else if (_quyen == "GiaoVu")
                {
                    //  Chỉ xem báo cáo
                    btnBaoCao.Enabled = true;
                }
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close(); // quay lại FormLogin
            }
        }

        private void btnQuanLyLop_Click(object sender, EventArgs e)
        {
            FrmQuanlyLop frm = new FrmQuanlyLop();
            frm.ShowDialog();
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            FrmQuanlyHocSinh frm = new FrmQuanlyHocSinh();
            frm.ShowDialog();
        }

        private void btnQuanLyMonhoc_Click(object sender, EventArgs e)
        {
            FrmQuanlyMonHoc frm = new FrmQuanlyMonHoc();
            frm.ShowDialog();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            FrmQuanlyDiem frm = new FrmQuanlyDiem();
            frm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frm = new FrmBaoCao();
            frm.ShowDialog();
        }
    }
}
