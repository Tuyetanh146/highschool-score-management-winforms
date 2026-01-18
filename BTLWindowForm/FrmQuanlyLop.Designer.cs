namespace BTLWindowForm
{
    partial class FrmQuanlyLop
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
            panelTop = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnQuaylai = new Button();
            btnThem = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtSiSo = new TextBox();
            txtTenLop = new TextBox();
            txtMaLop = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgvLop = new DataGridView();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.LightCyan;
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(992, 70);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(391, 18);
            label1.Name = "label1";
            label1.Size = new Size(202, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(btnQuaylai);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnLamMoi);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(txtSiSo);
            panel2.Controls.Add(txtTenLop);
            panel2.Controls.Add(txtMaLop);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 376);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 180);
            panel2.TabIndex = 1;
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = Color.LightBlue;
            btnQuaylai.Cursor = Cursors.Hand;
            btnQuaylai.FlatAppearance.BorderSize = 0;
            btnQuaylai.FlatStyle = FlatStyle.Flat;
            btnQuaylai.ForeColor = Color.Indigo;
            btnQuaylai.Location = new Point(861, 126);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(116, 35);
            btnQuaylai.TabIndex = 11;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Indigo;
            btnThem.Location = new Point(23, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 35);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.LightBlue;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.Indigo;
            btnLamMoi.Location = new Point(665, 126);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(116, 35);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới ";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightBlue;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Indigo;
            btnXoa.Location = new Point(463, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 35);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Indigo;
            btnSua.Location = new Point(235, 126);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 35);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtSiSo
            // 
            txtSiSo.BackColor = Color.FromArgb(250, 250, 250);
            txtSiSo.BorderStyle = BorderStyle.FixedSingle;
            txtSiSo.ForeColor = Color.Indigo;
            txtSiSo.Location = new Point(706, 67);
            txtSiSo.Name = "txtSiSo";
            txtSiSo.Size = new Size(166, 30);
            txtSiSo.TabIndex = 5;
            // 
            // txtTenLop
            // 
            txtTenLop.BackColor = Color.FromArgb(250, 250, 250);
            txtTenLop.BorderStyle = BorderStyle.FixedSingle;
            txtTenLop.ForeColor = Color.Indigo;
            txtTenLop.Location = new Point(410, 67);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(166, 30);
            txtTenLop.TabIndex = 4;
            // 
            // txtMaLop
            // 
            txtMaLop.BackColor = Color.FromArgb(250, 250, 250);
            txtMaLop.BorderStyle = BorderStyle.FixedSingle;
            txtMaLop.ForeColor = Color.Indigo;
            txtMaLop.Location = new Point(112, 67);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(166, 30);
            txtMaLop.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(760, 25);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 2;
            label4.Text = "Sĩ số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(463, 25);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 1;
            label3.Text = "Tên lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(168, 25);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã lớp";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvLop);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(992, 308);
            panel3.TabIndex = 2;
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.AllowUserToResizeColumns = false;
            dgvLop.AllowUserToResizeRows = false;
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLop.BackgroundColor = Color.White;
            dgvLop.BorderStyle = BorderStyle.None;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Dock = DockStyle.Fill;
            dgvLop.EnableHeadersVisualStyles = false;
            dgvLop.Location = new Point(0, 0);
            dgvLop.Name = "dgvLop";
            dgvLop.RowHeadersVisible = false;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.RowTemplate.ReadOnly = true;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(992, 308);
            dgvLop.TabIndex = 0;
            dgvLop.CellContentClick += dgvQuanlyLop_CellContentClick;
            dgvLop.CellDoubleClick += dgvQuanlyLop_CellDoubleClick;
            // 
            // FrmQuanlyLop
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 557);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            Name = "FrmQuanlyLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            Load += FrmQuanlyLop_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSiSo;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dgvLop;
        private Button btnThem;
        private Button btnQuaylai;
    }
}