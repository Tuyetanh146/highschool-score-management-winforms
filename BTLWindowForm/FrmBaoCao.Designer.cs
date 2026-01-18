namespace BTLWindowForm
{
    partial class FrmBaoCao
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
            lblTitle = new Label();
            panel2 = new Panel();
            txtXepLoai = new TextBox();
            txtDiemTB = new TextBox();
            txtTenHS = new TextBox();
            txtMaHS = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnQuayLai = new Button();
            btnTinhTB = new Button();
            btnInXuat = new Button();
            panel3 = new Panel();
            label1 = new Label();
            dgvDiemMon = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiemMon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(317, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(415, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÁO CÁO KẾT QUẢ HỌC TẬP";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtXepLoai);
            panel2.Controls.Add(txtDiemTB);
            panel2.Controls.Add(txtTenHS);
            panel2.Controls.Add(txtMaHS);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnQuayLai);
            panel2.Controls.Add(btnTinhTB);
            panel2.Controls.Add(btnInXuat);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Segoe UI", 10F);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 501);
            panel2.TabIndex = 1;
            // 
            // txtXepLoai
            // 
            txtXepLoai.Location = new Point(126, 271);
            txtXepLoai.Name = "txtXepLoai";
            txtXepLoai.Size = new Size(175, 30);
            txtXepLoai.TabIndex = 21;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(126, 207);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(175, 30);
            txtDiemTB.TabIndex = 20;
            // 
            // txtTenHS
            // 
            txtTenHS.Location = new Point(126, 140);
            txtTenHS.Name = "txtTenHS";
            txtTenHS.Size = new Size(175, 30);
            txtTenHS.TabIndex = 19;
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(126, 76);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(175, 30);
            txtMaHS.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 17;
            label5.Text = "Xếp loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 16;
            label4.Text = "Điểm TB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 15;
            label3.Text = "Tên HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 14;
            label2.Text = "Mã HS";
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.LightBlue;
            btnQuayLai.Cursor = Cursors.Hand;
            btnQuayLai.Dock = DockStyle.Bottom;
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Location = new Point(0, 366);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(398, 45);
            btnQuayLai.TabIndex = 13;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnTinhTB
            // 
            btnTinhTB.BackColor = Color.LightBlue;
            btnTinhTB.Cursor = Cursors.Hand;
            btnTinhTB.Dock = DockStyle.Bottom;
            btnTinhTB.FlatAppearance.BorderSize = 0;
            btnTinhTB.FlatStyle = FlatStyle.Flat;
            btnTinhTB.Location = new Point(0, 411);
            btnTinhTB.Name = "btnTinhTB";
            btnTinhTB.Size = new Size(398, 45);
            btnTinhTB.TabIndex = 10;
            btnTinhTB.Text = "Tính TB";
            btnTinhTB.UseVisualStyleBackColor = false;
            btnTinhTB.Click += btnTinhTB_Click;
            // 
            // btnInXuat
            // 
            btnInXuat.BackColor = Color.LightBlue;
            btnInXuat.Cursor = Cursors.Hand;
            btnInXuat.Dock = DockStyle.Bottom;
            btnInXuat.FlatAppearance.BorderSize = 0;
            btnInXuat.FlatStyle = FlatStyle.Flat;
            btnInXuat.Location = new Point(0, 456);
            btnInXuat.Name = "btnInXuat";
            btnInXuat.Size = new Size(398, 45);
            btnInXuat.TabIndex = 9;
            btnInXuat.Text = "In/Xuất";
            btnInXuat.UseVisualStyleBackColor = false;
            btnInXuat.Click += btnInXuat_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 43);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 3);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 0;
            label1.Text = "Điều khiển báo cáo ";
            // 
            // dgvDiemMon
            // 
            dgvDiemMon.AllowUserToResizeColumns = false;
            dgvDiemMon.AllowUserToResizeRows = false;
            dgvDiemMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiemMon.BackgroundColor = Color.White;
            dgvDiemMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiemMon.Dock = DockStyle.Right;
            dgvDiemMon.Location = new Point(404, 60);
            dgvDiemMon.Name = "dgvDiemMon";
            dgvDiemMon.RowHeadersVisible = false;
            dgvDiemMon.RowHeadersWidth = 51;
            dgvDiemMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiemMon.Size = new Size(678, 501);
            dgvDiemMon.TabIndex = 2;
            dgvDiemMon.CellContentClick += dgvDiemMon_CellContentClick;
            // 
            // FrmBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 561);
            Controls.Add(dgvDiemMon);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmBaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBaoCao";
            Load += FrmBaoCao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDiemMon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private DataGridView dgvDiemMon;
        private Panel panel3;
        private Label label1;
        private Button btnInXuat;
        private Button btnTinhTB;
        private Button btnQuayLai;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtXepLoai;
        private TextBox txtDiemTB;
        private TextBox txtTenHS;
        private TextBox txtMaHS;
    }
}