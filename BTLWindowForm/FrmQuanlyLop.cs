using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTLWindowForm
{
    public partial class FrmQuanlyLop : Form
    {
        public FrmQuanlyLop()
        {
            InitializeComponent();
        }
        ClsThaoTacCSDL cls = new ClsThaoTacCSDL();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            string sql = "Select * From dbo.Lop";
            dgvLop.DataSource = cls.ThucThiSQL(sql);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Delete from dbo.Lop where MaLop='" + txtMaLop.Text + "'");
            dgvLop.DataSource = cls.ThucThiNonQuery("Select * from dbo.Lop");
            LoadData();
        }

        private void FrmQuanlyLop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = cls.ThucThiSQL("Select * from dbo.Lop");
            dgvLop.Columns["MaLop"].HeaderText = "Mã lớp";
            dgvLop.Columns["TenLop"].HeaderText = "Tên lớp  ";
            dgvLop.Columns["SiSo"].HeaderText = "Sĩ số";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cls.ThucThiSQL("Insert into dbo.Lop values('" + txtMaLop.Text + "',N'" + txtTenLop.Text + "','" + txtSiSo.Text + "')");
            dgvLop.DataSource = cls.ThucThiSQL("Select * from dbo.Lop");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Update dbo.Lop set TenLop=N'" + txtTenLop.Text + "',SiSo='" + txtSiSo.Text + "' where MaLop='" + txtMaLop.Text + "'");
            dgvLop.DataSource = cls.ThucThiNonQuery("Select * from dbo.Lop");
            LoadData();
        }
       

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
        }

        private void dgvQuanlyLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = dgvLop.Rows[e.RowIndex].Cells["Malop"].Value.ToString();
                txtTenLop.Text = dgvLop.Rows[e.RowIndex].Cells["Tenlop"].Value.ToString();
                txtSiSo.Text = dgvLop.Rows[e.RowIndex].Cells["Siso"].Value.ToString();
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuanlyLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLop.Text = dgvLop.Rows[e.RowIndex].Cells["Malop"].Value.ToString();
                txtTenLop.Text = dgvLop.Rows[e.RowIndex].Cells["Tenlop"].Value.ToString();
                txtSiSo.Text = dgvLop.Rows[e.RowIndex].Cells["Siso"].Value.ToString();
            }
        }
    }

}
