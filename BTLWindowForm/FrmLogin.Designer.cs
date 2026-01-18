namespace BTLWindowForm
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            BtnDangNhap = new Button();
            btnThoat = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(267, 404);
            pnlLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(227, 242, 253);
            pictureBox1.Image = Properties.Resources.open_book__1_;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(424, 37);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 134);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 216);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu ";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(513, 132);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(182, 27);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(513, 214);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(182, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // BtnDangNhap
            // 
            BtnDangNhap.BackColor = Color.LightSkyBlue;
            BtnDangNhap.Cursor = Cursors.Hand;
            BtnDangNhap.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            BtnDangNhap.FlatAppearance.BorderSize = 0;
            BtnDangNhap.FlatStyle = FlatStyle.Flat;
            BtnDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDangNhap.Location = new Point(361, 302);
            BtnDangNhap.Name = "BtnDangNhap";
            BtnDangNhap.Size = new Size(114, 39);
            BtnDangNhap.TabIndex = 6;
            BtnDangNhap.Text = "Đăng nhập ";
            BtnDangNhap.UseVisualStyleBackColor = false;
            BtnDangNhap.Click += BtnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightSkyBlue;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(567, 302);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 39);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(467, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.show;
            pictureBox3.Location = new Point(467, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            ClientSize = new Size(790, 404);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnThoat);
            Controls.Add(BtnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlLeft);
            ForeColor = Color.Indigo;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập Hệ Thống ";
            Load += Form1_Load;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLeft;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button BtnDangNhap;
        private Button btnThoat;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
