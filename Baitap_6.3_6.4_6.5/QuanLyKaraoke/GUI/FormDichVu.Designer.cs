namespace QuanLyKaraoke.GUI
{
    partial class FormDichVu
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
            lblMaDV = new Label();
            txtMaDV = new TextBox();
            lblTenDV = new Label();
            txtTenDV = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblTonKho = new Label();
            nudTonKho = new NumericUpDown();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvDichVu = new DataGridView();
            colMaDV = new DataGridViewTextBoxColumn();
            colTenDV = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTonKho = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTonKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(lblMaDV);
            grpThongTin.Controls.Add(txtMaDV);
            grpThongTin.Controls.Add(lblTenDV);
            grpThongTin.Controls.Add(txtTenDV);
            grpThongTin.Controls.Add(lblDonGia);
            grpThongTin.Controls.Add(txtDonGia);
            grpThongTin.Controls.Add(lblTonKho);
            grpThongTin.Controls.Add(nudTonKho);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(430, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin dịch vụ";
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
            // lblMaDV
            //
            lblMaDV.AutoSize = true;
            lblMaDV.Location = new Point(16, 33);
            lblMaDV.Name = "lblMaDV";
            lblMaDV.Text = "Mã dịch vụ:";
            //
            // txtMaDV
            //
            txtMaDV.Location = new Point(140, 30);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(100, 23);
            txtMaDV.TabIndex = 1;
            txtMaDV.ReadOnly = true;
            txtMaDV.TabStop = false;
            //
            // lblTenDV
            //
            lblTenDV.AutoSize = true;
            lblTenDV.Location = new Point(16, 65);
            lblTenDV.Name = "lblTenDV";
            lblTenDV.Text = "Tên dịch vụ:";
            //
            // txtTenDV
            //
            txtTenDV.Location = new Point(140, 62);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(260, 23);
            txtTenDV.TabIndex = 3;
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
            // lblTonKho
            //
            lblTonKho.AutoSize = true;
            lblTonKho.Location = new Point(16, 129);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Text = "Tồn kho:";
            //
            // nudTonKho
            //
            nudTonKho.DecimalPlaces = 0;
            nudTonKho.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudTonKho.Location = new Point(140, 126);
            nudTonKho.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudTonKho.Name = "nudTonKho";
            nudTonKho.Size = new Size(120, 23);
            nudTonKho.TabIndex = 7;
            nudTonKho.TextAlign = HorizontalAlignment.Right;
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
            lblTimKiem.Text = "Tìm theo tên dịch vụ:";
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
            // dgvDichVu
            //
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.AllowUserToDeleteRows = false;
            dgvDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.BackgroundColor = Color.White;
            dgvDichVu.Columns.AddRange(new DataGridViewColumn[] { colMaDV, colTenDV, colDonGia, colTonKho });
            dgvDichVu.Location = new Point(12, 222);
            dgvDichVu.MultiSelect = false;
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.ReadOnly = true;
            dgvDichVu.RowHeadersVisible = false;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.Size = new Size(872, 300);
            dgvDichVu.TabIndex = 2;
            dgvDichVu.CellClick += dgvDichVu_CellClick;
            //
            // colMaDV
            //
            colMaDV.DataPropertyName = "MaDV";
            colMaDV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaDV.FillWeight = 8F;
            colMaDV.HeaderText = "Mã";
            colMaDV.Name = "colMaDV";
            colMaDV.ReadOnly = true;
            //
            // colTenDV
            //
            colTenDV.DataPropertyName = "TenDV";
            colTenDV.FillWeight = 46F;
            colTenDV.HeaderText = "Tên dịch vụ";
            colTenDV.Name = "colTenDV";
            colTenDV.ReadOnly = true;
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
            // colTonKho
            //
            colTonKho.DataPropertyName = "TonKho";
            colTonKho.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTonKho.FillWeight = 14F;
            colTonKho.HeaderText = "Tồn kho";
            colTonKho.Name = "colTonKho";
            colTonKho.ReadOnly = true;
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
            // FormDichVu
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 558);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Controls.Add(dgvDichVu);
            Controls.Add(lblTongSo);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(912, 597);
            Name = "FormDichVu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Dịch vụ / Đồ uống";
            Load += FormDichVu_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTonKho).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaDV;
        private TextBox txtMaDV;
        private Label lblTenDV;
        private TextBox txtTenDV;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblTonKho;
        private NumericUpDown nudTonKho;
        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvDichVu;
        private DataGridViewTextBoxColumn colMaDV;
        private DataGridViewTextBoxColumn colTenDV;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTonKho;
        private Label lblTongSo;
        private ErrorProvider errorProvider1;
    }
}
