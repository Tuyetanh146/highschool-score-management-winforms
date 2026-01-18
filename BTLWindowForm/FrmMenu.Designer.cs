namespace BTLWindowForm
{
    partial class FrmMenu
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
            pnlMenu = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDangXuat = new Button();
            btnBaoCao = new Button();
            btnNhapDiem = new Button();
            btnQuanLyMonhoc = new Button();
            btnQuanLyHocSinh = new Button();
            btnQuanLyLop = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(236, 240, 241);
            pnlMenu.Controls.Add(pictureBox5);
            pnlMenu.Controls.Add(pictureBox4);
            pnlMenu.Controls.Add(pictureBox3);
            pnlMenu.Controls.Add(pictureBox2);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(btnDangXuat);
            pnlMenu.Controls.Add(btnBaoCao);
            pnlMenu.Controls.Add(btnNhapDiem);
            pnlMenu.Controls.Add(btnQuanLyMonhoc);
            pnlMenu.Controls.Add(btnQuanLyHocSinh);
            pnlMenu.Controls.Add(btnQuanLyLop);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 553);
            pnlMenu.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.bar_chart;
            pictureBox5.Location = new Point(5, 269);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pencil;
            pictureBox4.Location = new Point(5, 224);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.stack_of_books;
            pictureBox3.Location = new Point(5, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.student;
            pictureBox2.Location = new Point(5, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.open_book1;
            pictureBox1.Location = new Point(5, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(160, 170, 175);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10F);
            btnDangXuat.ForeColor = Color.Navy;
            btnDangXuat.Location = new Point(0, 493);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(50, 0, 0, 0);
            btnDangXuat.Size = new Size(220, 60);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.FromArgb(200, 210, 215);
            btnBaoCao.Cursor = Cursors.Hand;
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI", 10F);
            btnBaoCao.ForeColor = Color.Navy;
            btnBaoCao.Location = new Point(0, 260);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(35, 0, 0, 0);
            btnBaoCao.Size = new Size(220, 45);
            btnBaoCao.TabIndex = 5;
            btnBaoCao.Text = "Báo cáo ";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // btnNhapDiem
            // 
            btnNhapDiem.BackColor = Color.FromArgb(200, 210, 215);
            btnNhapDiem.Cursor = Cursors.Hand;
            btnNhapDiem.Dock = DockStyle.Top;
            btnNhapDiem.FlatAppearance.BorderSize = 0;
            btnNhapDiem.FlatStyle = FlatStyle.Flat;
            btnNhapDiem.Font = new Font("Segoe UI", 10F);
            btnNhapDiem.ForeColor = Color.Navy;
            btnNhapDiem.Location = new Point(0, 215);
            btnNhapDiem.Name = "btnNhapDiem";
            btnNhapDiem.Padding = new Padding(35, 0, 0, 0);
            btnNhapDiem.Size = new Size(220, 45);
            btnNhapDiem.TabIndex = 4;
            btnNhapDiem.Text = "Quản lý điểm";
            btnNhapDiem.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapDiem.UseVisualStyleBackColor = false;
            btnNhapDiem.Click += btnNhapDiem_Click;
            // 
            // btnQuanLyMonhoc
            // 
            btnQuanLyMonhoc.BackColor = Color.FromArgb(200, 210, 215);
            btnQuanLyMonhoc.Cursor = Cursors.Hand;
            btnQuanLyMonhoc.Dock = DockStyle.Top;
            btnQuanLyMonhoc.FlatAppearance.BorderSize = 0;
            btnQuanLyMonhoc.FlatStyle = FlatStyle.Flat;
            btnQuanLyMonhoc.Font = new Font("Segoe UI", 10F);
            btnQuanLyMonhoc.ForeColor = Color.Navy;
            btnQuanLyMonhoc.Location = new Point(0, 170);
            btnQuanLyMonhoc.Name = "btnQuanLyMonhoc";
            btnQuanLyMonhoc.Padding = new Padding(35, 0, 0, 0);
            btnQuanLyMonhoc.Size = new Size(220, 45);
            btnQuanLyMonhoc.TabIndex = 3;
            btnQuanLyMonhoc.Text = "Quản lý môn học";
            btnQuanLyMonhoc.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyMonhoc.UseVisualStyleBackColor = false;
            btnQuanLyMonhoc.Click += btnQuanLyMonhoc_Click;
            // 
            // btnQuanLyHocSinh
            // 
            btnQuanLyHocSinh.BackColor = Color.FromArgb(200, 210, 215);
            btnQuanLyHocSinh.Cursor = Cursors.Hand;
            btnQuanLyHocSinh.Dock = DockStyle.Top;
            btnQuanLyHocSinh.FlatAppearance.BorderSize = 0;
            btnQuanLyHocSinh.FlatStyle = FlatStyle.Flat;
            btnQuanLyHocSinh.Font = new Font("Segoe UI", 10F);
            btnQuanLyHocSinh.ForeColor = Color.Navy;
            btnQuanLyHocSinh.Location = new Point(0, 125);
            btnQuanLyHocSinh.Name = "btnQuanLyHocSinh";
            btnQuanLyHocSinh.Padding = new Padding(35, 0, 0, 0);
            btnQuanLyHocSinh.Size = new Size(220, 45);
            btnQuanLyHocSinh.TabIndex = 2;
            btnQuanLyHocSinh.Text = "Quản lý học sinh ";
            btnQuanLyHocSinh.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyHocSinh.UseVisualStyleBackColor = false;
            btnQuanLyHocSinh.Click += btnQuanLyHocSinh_Click;
            // 
            // btnQuanLyLop
            // 
            btnQuanLyLop.BackColor = Color.FromArgb(200, 210, 215);
            btnQuanLyLop.Cursor = Cursors.Hand;
            btnQuanLyLop.Dock = DockStyle.Top;
            btnQuanLyLop.FlatAppearance.BorderSize = 0;
            btnQuanLyLop.FlatStyle = FlatStyle.Flat;
            btnQuanLyLop.Font = new Font("Segoe UI", 10F);
            btnQuanLyLop.ForeColor = Color.Navy;
            btnQuanLyLop.Location = new Point(0, 80);
            btnQuanLyLop.Name = "btnQuanLyLop";
            btnQuanLyLop.Padding = new Padding(35, 0, 0, 0);
            btnQuanLyLop.Size = new Size(220, 45);
            btnQuanLyLop.TabIndex = 1;
            btnQuanLyLop.Text = "Quản lý lớp";
            btnQuanLyLop.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyLop.UseVisualStyleBackColor = false;
            btnQuanLyLop.Click += btnQuanLyLop_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(236, 239, 241);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 80);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM HS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox6);
            panel2.Location = new Point(220, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 550);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(124, 193);
            label3.Name = "label3";
            label3.Size = new Size(480, 38);
            label3.TabIndex = 3;
            label3.Text = "HỌC SINH TRUNG HỌC PHỔ THÔNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(192, 129);
            label2.Name = "label2";
            label2.Size = new Size(350, 38);
            label2.TabIndex = 2;
            label2.Text = "HỆ THỐNG QUẢN LÝ ĐIỂM";
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.m_monk_E813FON0wDQ_unsplash;
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(762, 550);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(pnlMenu);
            ForeColor = Color.Blue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý điểm học sinh ";
            Load += FormMenu_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel panel2;
        private Button btnDangXuat;
        private Button btnBaoCao;
        private Button btnNhapDiem;
        private Button btnQuanLyMonhoc;
        private Button btnQuanLyHocSinh;
        private Button btnQuanLyLop;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private Label label2;
        private Label label3;
    }
}