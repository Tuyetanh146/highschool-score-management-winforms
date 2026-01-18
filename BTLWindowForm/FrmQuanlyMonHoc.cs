using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace BTLWindowForm
{
    public partial class FrmQuanlyMonHoc : Form
    {
        public FrmQuanlyMonHoc()
        {
            InitializeComponent();
        }
        ClsThaoTacCSDL cls = new ClsThaoTacCSDL();

        private void FrmQuanlyMonHoc_Load(object sender, EventArgs e)
        {
            dgvMonhoc.DataSource = cls.ThucThiSQL("Select * From dbo.MonHoc");

            dgvMonhoc.Columns["MaMH"].HeaderText = "Mã lớp";
            dgvMonhoc.Columns["TenMH"].HeaderText = "Tên môn";
            dgvMonhoc.Columns["HeSo"].HeaderText = "Hệ số";
        }
        void LoadData()
        {
            string sql = "Select * From dbo.MonHoc";
            dgvMonhoc.DataSource = cls.ThucThiSQL(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            cls.ThucThiSQL("Insert into dbo.MonHoc values (MaMH = '" + txtMaMH.Text + "' ,TenMH = N'" + txtTenMH.Text + "' , HeSo = '" + txtHeSo.Text + "'  ) ");
            dgvMonhoc.DataSource = cls.ThucThiSQL("Select * From dbo.MonHoc");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Update MonHoc set TenMH = N'" + txtTenMH.Text + "' , HeSo = '" + txtHeSo.Text + "' where MaMH = '" + txtMaMH.Text + "' ");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cls.ThucThiNonQuery("Delete From MonHoc Where MaMH = '" + txtMaMH.Text + "' ");
            LoadData();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtHeSo.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonhoc.Rows[e.RowIndex];
                txtMaMH.Text = dgvMonhoc.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
                txtTenMH.Text = dgvMonhoc.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
                txtHeSo.Text = dgvMonhoc.Rows[e.RowIndex].Cells["HeSo"].Value.ToString();
            }
        }
    }
}
