namespace BTLWindowForm
{
    partial class FrmQuanlyDiem
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dgvDiem = new DataGridView();
            btnQuaylai = new Button();
            cboHocKy = new ComboBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiemThi = new TextBox();
            txtDiem1Tiet = new TextBox();
            txtDiem15p = new TextBox();
            txtDiemMieng = new TextBox();
            cboMaMH = new ComboBox();
            cboMaHS = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 78, 121);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐIỂM ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(dgvDiem);
            panel2.Controls.Add(btnQuaylai);
            panel2.Controls.Add(cboHocKy);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtDiemThi);
            panel2.Controls.Add(txtDiem1Tiet);
            panel2.Controls.Add(txtDiem15p);
            panel2.Controls.Add(txtDiemMieng);
            panel2.Controls.Add(cboMaMH);
            panel2.Controls.Add(cboMaHS);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.DarkSlateBlue;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 659);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvDiem
            // 
            dgvDiem.AllowUserToAddRows = false;
            dgvDiem.AllowUserToDeleteRows = false;
            dgvDiem.AllowUserToResizeColumns = false;
            dgvDiem.AllowUserToResizeRows = false;
            dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiem.BackgroundColor = Color.White;
            dgvDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiem.ColumnHeadersVisible = false;
            dgvDiem.Dock = DockStyle.Top;
            dgvDiem.Location = new Point(0, 0);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.RowHeadersVisible = false;
            dgvDiem.RowHeadersWidth = 51;
            dgvDiem.Size = new Size(1009, 324);
            dgvDiem.TabIndex = 19;
            dgvDiem.CellContentClick += dgvDiem_CellContentClick_1;
            dgvDiem.CellContentDoubleClick += dgvDiem_CellContentDoubleClick_1;
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = Color.AliceBlue;
            btnQuaylai.Cursor = Cursors.Hand;
            btnQuaylai.FlatAppearance.BorderSize = 0;
            btnQuaylai.FlatStyle = FlatStyle.Flat;
            btnQuaylai.ForeColor = Color.Navy;
            btnQuaylai.Location = new Point(829, 585);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(94, 29);
            btnQuaylai.TabIndex = 18;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // cboHocKy
            // 
            cboHocKy.FormattingEnabled = true;
            cboHocKy.Location = new Point(819, 372);
            cboHocKy.Name = "cboHocKy";
            cboHocKy.Size = new Size(171, 28);
            cboHocKy.TabIndex = 17;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.AliceBlue;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F);
            btnLamMoi.ForeColor = Color.Navy;
            btnLamMoi.Location = new Point(623, 585);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.AliceBlue;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.ForeColor = Color.Navy;
            btnXoa.Location = new Point(427, 585);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.AliceBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.ForeColor = Color.Navy;
            btnSua.Location = new Point(242, 585);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.AliceBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.ForeColor = Color.Navy;
            btnThem.Location = new Point(49, 585);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = " Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiemThi
            // 
            txtDiemThi.Location = new Point(642, 500);
            txtDiemThi.Name = "txtDiemThi";
            txtDiemThi.Size = new Size(176, 27);
            txtDiemThi.TabIndex = 12;
            // 
            // txtDiem1Tiet
            // 
            txtDiem1Tiet.Location = new Point(642, 447);
            txtDiem1Tiet.Name = "txtDiem1Tiet";
            txtDiem1Tiet.Size = new Size(176, 27);
            txtDiem1Tiet.TabIndex = 11;
            // 
            // txtDiem15p
            // 
            txtDiem15p.Location = new Point(185, 500);
            txtDiem15p.Name = "txtDiem15p";
            txtDiem15p.Size = new Size(176, 27);
            txtDiem15p.TabIndex = 10;
            // 
            // txtDiemMieng
            // 
            txtDiemMieng.Location = new Point(185, 443);
            txtDiemMieng.Name = "txtDiemMieng";
            txtDiemMieng.Size = new Size(176, 27);
            txtDiemMieng.TabIndex = 9;
            // 
            // cboMaMH
            // 
            cboMaMH.FormattingEnabled = true;
            cboMaMH.Location = new Point(479, 371);
            cboMaMH.Name = "cboMaMH";
            cboMaMH.Size = new Size(151, 28);
            cboMaMH.TabIndex = 8;
            // 
            // cboMaHS
            // 
            cboMaHS.FormattingEnabled = true;
            cboMaHS.Location = new Point(146, 372);
            cboMaHS.Name = "cboMaHS";
            cboMaHS.Size = new Size(151, 28);
            cboMaHS.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(492, 500);
            label8.Name = "label8";
            label8.Size = new Size(78, 23);
            label8.TabIndex = 6;
            label8.Text = "Điểm Thi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(492, 447);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 5;
            label7.Text = "Điểm 1 tiết ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(38, 500);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 4;
            label6.Text = "Điểm 15p";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(38, 443);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 3;
            label5.Text = "Điểm Miệng ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(707, 373);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 2;
            label4.Text = "Học kỳ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(379, 377);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 1;
            label3.Text = "Mã MH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(25, 372);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã HS";
            // 
            // FrmQuanlyDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 736);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Navy;
            MaximizeBox = false;
            Name = "FrmQuanlyDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý điểm ";
            Load += FrmQuanlyDiem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDiemThi;
        private TextBox txtDiem1Tiet;
        private TextBox txtDiem15p;
        private TextBox txtDiemMieng;
        private ComboBox cboMaMH;
        private ComboBox cboMaHS;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboHocKy;
        private Button btnQuaylai;
        private DataGridView dgvDiem;
    }
}