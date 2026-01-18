namespace BTLWindowForm
{
    partial class FrmQuanlyHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            label1 = new Label();
            pnlLeft = new Panel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnQuayLai = new Button();
            txtNgaySinh = new MaskedTextBox();
            cboGioiTinh = new ComboBox();
            txtMaLop = new TextBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaHS = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlRight = new Panel();
            dgvHocSinh = new DataGridView();
            panel1 = new Panel();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            pnlTop.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(44, 62, 80);
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1105, 70);
            pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(380, 18);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ HỌC SINH ";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(236, 240, 241);
            pnlLeft.Controls.Add(btnThem);
            pnlLeft.Controls.Add(btnSua);
            pnlLeft.Controls.Add(btnXoa);
            pnlLeft.Controls.Add(btnLamMoi);
            pnlLeft.Controls.Add(btnQuayLai);
            pnlLeft.Controls.Add(txtNgaySinh);
            pnlLeft.Controls.Add(cboGioiTinh);
            pnlLeft.Controls.Add(txtMaLop);
            pnlLeft.Controls.Add(txtDiaChi);
            pnlLeft.Controls.Add(txtHoTen);
            pnlLeft.Controls.Add(txtMaHS);
            pnlLeft.Controls.Add(label7);
            pnlLeft.Controls.Add(label6);
            pnlLeft.Controls.Add(label5);
            pnlLeft.Controls.Add(label4);
            pnlLeft.Controls.Add(label3);
            pnlLeft.Controls.Add(label2);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 70);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10, 0, 0, 0);
            pnlLeft.Size = new Size(330, 566);
            pnlLeft.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.RosyBrown;
            btnThem.Dock = DockStyle.Bottom;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.MidnightBlue;
            btnThem.Location = new Point(10, 366);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(320, 40);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.WhiteSmoke;
            btnSua.Dock = DockStyle.Bottom;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.MidnightBlue;
            btnSua.Location = new Point(10, 406);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(320, 40);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.RosyBrown;
            btnXoa.Dock = DockStyle.Bottom;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.MidnightBlue;
            btnXoa.Location = new Point(10, 446);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(320, 40);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.WhiteSmoke;
            btnLamMoi.Dock = DockStyle.Bottom;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.MidnightBlue;
            btnLamMoi.Location = new Point(10, 486);
            btnLamMoi.Margin = new Padding(4, 3, 4, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(320, 40);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.RosyBrown;
            btnQuayLai.Dock = DockStyle.Bottom;
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.ForeColor = Color.MidnightBlue;
            btnQuayLai.Location = new Point(10, 526);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(320, 40);
            btnQuayLai.TabIndex = 14;
            btnQuayLai.Text = "Quay lại ";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(127, 133);
            txtNgaySinh.Mask = "00/00/0000";
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(125, 30);
            txtNgaySinh.TabIndex = 13;
            txtNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(127, 189);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(125, 31);
            cboGioiTinh.TabIndex = 12;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(127, 300);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 30);
            txtMaLop.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(127, 245);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 30);
            txtDiaChi.TabIndex = 10;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(127, 80);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 30);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(127, 30);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(125, 30);
            txtMaHS.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(12, 305);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 5;
            label7.Text = "Mã lớp ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(12, 238);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 15, 0, 0);
            label6.Size = new Size(67, 38);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 15, 0, 0);
            label5.Size = new Size(75, 38);
            label5.TabIndex = 3;
            label5.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 15, 0, 0);
            label4.Size = new Size(86, 38);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 15, 0, 0);
            label3.Size = new Size(62, 38);
            label3.TabIndex = 1;
            label3.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 15, 0, 0);
            label2.Size = new Size(60, 38);
            label2.TabIndex = 0;
            label2.Text = "Mã HS";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(dgvHocSinh);
            pnlRight.Controls.Add(panel1);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(330, 70);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(10, 0, 0, 0);
            pnlRight.Size = new Size(775, 566);
            pnlRight.TabIndex = 2;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.AllowUserToDeleteRows = false;
            dgvHocSinh.AllowUserToResizeColumns = false;
            dgvHocSinh.AllowUserToResizeRows = false;
            dgvHocSinh.BackgroundColor = Color.Gainsboro;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Dock = DockStyle.Fill;
            dgvHocSinh.Location = new Point(10, 60);
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.RowHeadersVisible = false;
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.Size = new Size(765, 506);
            dgvHocSinh.TabIndex = 1;
            dgvHocSinh.CellContentClick += dgvHocSinh_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 60);
            panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(177, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(576, 30);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(115, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(13, 19);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 0;
            label8.Text = "Tìm kiếm ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmQuanlyHocSinh
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 636);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTop);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            Name = "FrmQuanlyHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý học sinh ";
            Load += FrmQuanlyHocSinh_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label label1;
        private Panel pnlLeft;
        private Label label3;
        private Label label2;
        private Panel pnlRight;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtMaLop;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaHS;
        private ComboBox cboGioiTinh;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnQuayLai;
        private MaskedTextBox txtNgaySinh;
        private Button btnThem;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtTimKiem;
        private DataGridView dgvHocSinh;
    }
}