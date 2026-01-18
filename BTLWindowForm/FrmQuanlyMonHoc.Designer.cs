namespace BTLWindowForm
{
    partial class FrmQuanlyMonHoc
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
            groupBox1 = new GroupBox();
            txtHeSo = new TextBox();
            txtTenMH = new TextBox();
            txtMaMH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnMoi = new Button();
            btnThoat = new Button();
            dgvMonhoc = new DataGridView();
            pnlTop.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonhoc).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.GradientActiveCaption;
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(882, 66);
            pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản lý môn học ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(244, 246, 247);
            groupBox1.Controls.Add(txtHeSo);
            groupBox1.Controls.Add(txtTenMH);
            groupBox1.Controls.Add(txtMaMH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(0, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 385);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin môn học ";
            // 
            // txtHeSo
            // 
            txtHeSo.Location = new Point(123, 263);
            txtHeSo.Name = "txtHeSo";
            txtHeSo.Size = new Size(179, 27);
            txtHeSo.TabIndex = 5;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(123, 179);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(179, 27);
            txtTenMH.TabIndex = 4;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(123, 97);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(179, 27);
            txtMaMH.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(7, 270);
            label4.Margin = new Padding(5, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 2;
            label4.Text = "Hệ số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(6, 179);
            label3.Margin = new Padding(5, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 1;
            label3.Text = "Tên môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(7, 94);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã môn";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSteelBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Indigo;
            btnThem.Location = new Point(36, 487);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightSteelBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Indigo;
            btnSua.Location = new Point(221, 487);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightSteelBlue;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Indigo;
            btnXoa.Location = new Point(396, 487);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnMoi
            // 
            btnMoi.BackColor = Color.LightSteelBlue;
            btnMoi.Cursor = Cursors.Hand;
            btnMoi.FlatAppearance.BorderSize = 0;
            btnMoi.FlatStyle = FlatStyle.Flat;
            btnMoi.ForeColor = Color.Indigo;
            btnMoi.Location = new Point(581, 487);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 29);
            btnMoi.TabIndex = 7;
            btnMoi.Text = "Mới ";
            btnMoi.UseVisualStyleBackColor = false;
            btnMoi.Click += btnMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightSteelBlue;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Indigo;
            btnThoat.Location = new Point(751, 487);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvMonhoc
            // 
            dgvMonhoc.AllowUserToAddRows = false;
            dgvMonhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonhoc.BackgroundColor = SystemColors.Control;
            dgvMonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonhoc.Cursor = Cursors.Hand;
            dgvMonhoc.Location = new Point(343, 83);
            dgvMonhoc.Name = "dgvMonhoc";
            dgvMonhoc.ReadOnly = true;
            dgvMonhoc.RowHeadersVisible = false;
            dgvMonhoc.RowHeadersWidth = 51;
            dgvMonhoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonhoc.Size = new Size(539, 374);
            dgvMonhoc.TabIndex = 9;
            dgvMonhoc.CellContentClick += dgvMonhoc_CellContentClick;
            // 
            // FrmQuanlyMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvMonhoc);
            Controls.Add(btnThoat);
            Controls.Add(btnMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(pnlTop);
            MaximizeBox = false;
            Name = "FrmQuanlyMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý môn học ";
            Load += FrmQuanlyMonHoc_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonhoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtHeSo;
        private TextBox txtTenMH;
        private TextBox txtMaMH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnMoi;
        private Button btnThoat;
        private DataGridView dgvMonhoc;
    }
}