using System.Data;
using Microsoft .Data.SqlClient;

namespace BTLWindowForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ClsThaoTacCSDL cls = new ClsThaoTacCSDL();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDN = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            if (TenDN == "" || MatKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strSQL = $"Select * From TAIKHOAN Where TenDangNhap = N'{TenDN}' And MatKhau = N'{MatKhau}'";
            DataTable dt = cls.ThucThiSQL(strSQL);

            if (dt.Rows.Count > 0)
            {
                string quyen = dt.Rows[0]["Quyen"].ToString(); // lấy quyền từ CSDL
                MessageBox.Show("Đăng nhập thành công");
                FrmMenu formMenu = new FrmMenu(quyen); // truyền quyền sang FormMenu
                this.Hide();
                formMenu.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng ");
            }
        }
    }
}