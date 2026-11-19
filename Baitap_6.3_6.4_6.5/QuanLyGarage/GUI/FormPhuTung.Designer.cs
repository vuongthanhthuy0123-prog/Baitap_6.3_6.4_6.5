namespace QuanLyGarage.GUI
{
    partial class FormPhuTung
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpThongTin = new GroupBox();
            lblMaPhuTung = new Label();
            txtMaPhuTung = new TextBox();
            lblTenPhuTung = new Label();
            txtTenPhuTung = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuongTon = new Label();
            nudSoLuongTon = new NumericUpDown();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvPhuTung = new DataGridView();
            colMaPhuTung = new DataGridViewTextBoxColumn();
            colTenPhuTung = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colSoLuongTon = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhuTung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(lblMaPhuTung);
            grpThongTin.Controls.Add(txtMaPhuTung);
            grpThongTin.Controls.Add(lblTenPhuTung);
            grpThongTin.Controls.Add(txtTenPhuTung);
            grpThongTin.Controls.Add(lblDonGia);
            grpThongTin.Controls.Add(txtDonGia);
            grpThongTin.Controls.Add(lblSoLuongTon);
            grpThongTin.Controls.Add(nudSoLuongTon);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(430, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin phụ tùng";
            //
            // grpChucNang
            //
            grpChucNang.Controls.Add(btnThem);
            grpChucNang.Controls.Add(btnSua);
            grpChucNang.Controls.Add(btnXoa);
            grpChucNang.Controls.Add(btnLamMoi);
            grpChucNang.Controls.Add(lblTimKiem);
            grpChucNang.Controls.Add(txtTimKiem);
            grpChucNang.Controls.Add(btnTimKiem);
            grpChucNang.Location = new Point(454, 12);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(430, 200);
            grpChucNang.TabIndex = 1;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            //
            // lblMaPhuTung
            //
            lblMaPhuTung.AutoSize = true;
            lblMaPhuTung.Location = new Point(16, 33);
            lblMaPhuTung.Name = "lblMaPhuTung";
            lblMaPhuTung.Text = "Mã phụ tùng:";
            //
            // txtMaPhuTung
            //
            txtMaPhuTung.Location = new Point(140, 30);
            txtMaPhuTung.Name = "txtMaPhuTung";
            txtMaPhuTung.Size = new Size(100, 23);
            txtMaPhuTung.TabIndex = 1;
            txtMaPhuTung.ReadOnly = true;
            txtMaPhuTung.TabStop = false;
            //
            // lblTenPhuTung
            //
            lblTenPhuTung.AutoSize = true;
            lblTenPhuTung.Location = new Point(16, 65);
            lblTenPhuTung.Name = "lblTenPhuTung";
            lblTenPhuTung.Text = "Tên phụ tùng:";
            //
            // txtTenPhuTung
            //
            txtTenPhuTung.Location = new Point(140, 62);
            txtTenPhuTung.Name = "txtTenPhuTung";
            txtTenPhuTung.Size = new Size(260, 23);
            txtTenPhuTung.TabIndex = 3;
            //
            // lblDonGia
            //
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(16, 97);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Text = "Đơn giá (đ):";
            //
            // txtDonGia
            //
            txtDonGia.Location = new Point(140, 94);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(160, 23);
            txtDonGia.TabIndex = 5;
            txtDonGia.TextAlign = HorizontalAlignment.Right;
            //
            // lblSoLuongTon
            //
            lblSoLuongTon.AutoSize = true;
            lblSoLuongTon.Location = new Point(16, 129);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Text = "Số lượng tồn:";
            //
            // nudSoLuongTon
            //
            nudSoLuongTon.DecimalPlaces = 0;
            nudSoLuongTon.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuongTon.Location = new Point(140, 126);
            nudSoLuongTon.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudSoLuongTon.Name = "nudSoLuongTon";
            nudSoLuongTon.Size = new Size(120, 23);
            nudSoLuongTon.TabIndex = 7;
            nudSoLuongTon.TextAlign = HorizontalAlignment.Right;
            //
            // btnThem
            //
            btnThem.Location = new Point(16, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            //
            // btnSua
            //
            btnSua.Location = new Point(118, 28);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            //
            // btnXoa
            //
            btnXoa.ForeColor = Color.Firebrick;
            btnXoa.Location = new Point(220, 28);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Location = new Point(322, 28);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 34);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // lblTimKiem
            //
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(16, 76);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Text = "Tìm theo tên phụ tùng:";
            //
            // txtTimKiem
            //
            txtTimKiem.Location = new Point(16, 96);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 23);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            //
            // btnTimKiem
            //
            btnTimKiem.Location = new Point(324, 95);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 26);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            //
            // dgvPhuTung
            //
            dgvPhuTung.AllowUserToAddRows = false;
            dgvPhuTung.AllowUserToDeleteRows = false;
            dgvPhuTung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhuTung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhuTung.BackgroundColor = Color.White;
            dgvPhuTung.Columns.AddRange(new DataGridViewColumn[] { colMaPhuTung, colTenPhuTung, colDonGia, colSoLuongTon });
            dgvPhuTung.Location = new Point(12, 222);
            dgvPhuTung.MultiSelect = false;
            dgvPhuTung.Name = "dgvPhuTung";
            dgvPhuTung.ReadOnly = true;
            dgvPhuTung.RowHeadersVisible = false;
            dgvPhuTung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhuTung.Size = new Size(872, 300);
            dgvPhuTung.TabIndex = 2;
            dgvPhuTung.CellClick += dgvPhuTung_CellClick;
            //
            // colMaPhuTung
            //
            colMaPhuTung.DataPropertyName = "MaPhuTung";
            colMaPhuTung.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaPhuTung.FillWeight = 8F;
            colMaPhuTung.HeaderText = "Mã";
            colMaPhuTung.Name = "colMaPhuTung";
            colMaPhuTung.ReadOnly = true;
            //
            // colTenPhuTung
            //
            colTenPhuTung.DataPropertyName = "TenPhuTung";
            colTenPhuTung.FillWeight = 46F;
            colTenPhuTung.HeaderText = "Tên phụ tùng";
            colTenPhuTung.Name = "colTenPhuTung";
            colTenPhuTung.ReadOnly = true;
            //
            // colDonGia
            //
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDonGia.DefaultCellStyle.Format = "N0";
            colDonGia.FillWeight = 20F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            //
            // colSoLuongTon
            //
            colSoLuongTon.DataPropertyName = "SoLuongTon";
            colSoLuongTon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoLuongTon.FillWeight = 14F;
            colSoLuongTon.HeaderText = "Tồn kho";
            colSoLuongTon.Name = "colSoLuongTon";
            colSoLuongTon.ReadOnly = true;
            //
            // lblTongSo
            //
            lblTongSo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongSo.AutoSize = true;
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.Location = new Point(12, 530);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Text = "Tổng: 0";
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // FormPhuTung
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 558);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Controls.Add(dgvPhuTung);
            Controls.Add(lblTongSo);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(912, 597);
            Name = "FormPhuTung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Phụ tùng / Vật tư";
            Load += FormPhuTung_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhuTung).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaPhuTung;
        private TextBox txtMaPhuTung;
        private Label lblTenPhuTung;
        private TextBox txtTenPhuTung;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblSoLuongTon;
        private NumericUpDown nudSoLuongTon;
        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvPhuTung;
        private DataGridViewTextBoxColumn colMaPhuTung;
        private DataGridViewTextBoxColumn colTenPhuTung;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colSoLuongTon;
        private Label lblTongSo;
        private ErrorProvider errorProvider1;
    }
}
