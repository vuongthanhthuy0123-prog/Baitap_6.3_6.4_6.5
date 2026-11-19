namespace QuanLyDuAn.GUI
{
    partial class FormDuAn
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
            lblMaDuAn = new Label();
            txtMaDuAn = new TextBox();
            lblTenDuAn = new Label();
            txtTenDuAn = new TextBox();
            lblNgayBatDau = new Label();
            dtpNgayBatDau = new DateTimePicker();
            lblNgayKetThuc = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvDuAn = new DataGridView();
            colMaDuAn = new DataGridViewTextBoxColumn();
            colTenDuAn = new DataGridViewTextBoxColumn();
            colNgayBatDau = new DataGridViewTextBoxColumn();
            colNgayKetThuc = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colTienDo = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(lblMaDuAn);
            grpThongTin.Controls.Add(txtMaDuAn);
            grpThongTin.Controls.Add(lblTenDuAn);
            grpThongTin.Controls.Add(txtTenDuAn);
            grpThongTin.Controls.Add(lblNgayBatDau);
            grpThongTin.Controls.Add(dtpNgayBatDau);
            grpThongTin.Controls.Add(lblNgayKetThuc);
            grpThongTin.Controls.Add(dtpNgayKetThuc);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(cboTrangThai);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(430, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin dự án";
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
            // lblMaDuAn
            //
            lblMaDuAn.AutoSize = true;
            lblMaDuAn.Location = new Point(16, 33);
            lblMaDuAn.Name = "lblMaDuAn";
            lblMaDuAn.Text = "Mã dự án:";
            //
            // txtMaDuAn
            //
            txtMaDuAn.Location = new Point(140, 30);
            txtMaDuAn.Name = "txtMaDuAn";
            txtMaDuAn.Size = new Size(100, 23);
            txtMaDuAn.TabIndex = 1;
            txtMaDuAn.ReadOnly = true;
            txtMaDuAn.TabStop = false;
            //
            // lblTenDuAn
            //
            lblTenDuAn.AutoSize = true;
            lblTenDuAn.Location = new Point(16, 65);
            lblTenDuAn.Name = "lblTenDuAn";
            lblTenDuAn.Text = "Tên dự án:";
            //
            // txtTenDuAn
            //
            txtTenDuAn.Location = new Point(140, 62);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(260, 23);
            txtTenDuAn.TabIndex = 3;
            //
            // lblNgayBatDau
            //
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new Point(16, 97);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            //
            // dtpNgayBatDau
            //
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(140, 94);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(140, 23);
            dtpNgayBatDau.TabIndex = 5;
            //
            // lblNgayKetThuc
            //
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new Point(16, 129);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            //
            // dtpNgayKetThuc
            //
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(140, 126);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(140, 23);
            dtpNgayKetThuc.TabIndex = 7;
            //
            // lblTrangThai
            //
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(16, 161);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Text = "Trạng thái:";
            //
            // cboTrangThai
            //
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.AddRange(new object[] { "Đang chạy", "Hoàn thành", "Tạm dừng" });
            cboTrangThai.Location = new Point(140, 158);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(160, 23);
            cboTrangThai.TabIndex = 9;
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
            lblTimKiem.Text = "Tìm theo tên dự án:";
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
            // dgvDuAn
            //
            dgvDuAn.AllowUserToAddRows = false;
            dgvDuAn.AllowUserToDeleteRows = false;
            dgvDuAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDuAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuAn.BackgroundColor = Color.White;
            dgvDuAn.Columns.AddRange(new DataGridViewColumn[] { colMaDuAn, colTenDuAn, colNgayBatDau, colNgayKetThuc, colTrangThai, colTienDo });
            dgvDuAn.Location = new Point(12, 222);
            dgvDuAn.MultiSelect = false;
            dgvDuAn.Name = "dgvDuAn";
            dgvDuAn.ReadOnly = true;
            dgvDuAn.RowHeadersVisible = false;
            dgvDuAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDuAn.Size = new Size(872, 300);
            dgvDuAn.TabIndex = 2;
            dgvDuAn.CellClick += dgvDuAn_CellClick;
            //
            // colMaDuAn
            //
            colMaDuAn.DataPropertyName = "MaDuAn";
            colMaDuAn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaDuAn.FillWeight = 7F;
            colMaDuAn.HeaderText = "Mã";
            colMaDuAn.Name = "colMaDuAn";
            colMaDuAn.ReadOnly = true;
            //
            // colTenDuAn
            //
            colTenDuAn.DataPropertyName = "TenDuAn";
            colTenDuAn.FillWeight = 34F;
            colTenDuAn.HeaderText = "Tên dự án";
            colTenDuAn.Name = "colTenDuAn";
            colTenDuAn.ReadOnly = true;
            //
            // colNgayBatDau
            //
            colNgayBatDau.DataPropertyName = "NgayBatDau";
            colNgayBatDau.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNgayBatDau.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayBatDau.FillWeight = 13F;
            colNgayBatDau.HeaderText = "Bắt đầu";
            colNgayBatDau.Name = "colNgayBatDau";
            colNgayBatDau.ReadOnly = true;
            //
            // colNgayKetThuc
            //
            colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            colNgayKetThuc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNgayKetThuc.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayKetThuc.FillWeight = 13F;
            colNgayKetThuc.HeaderText = "Kết thúc";
            colNgayKetThuc.Name = "colNgayKetThuc";
            colNgayKetThuc.ReadOnly = true;
            //
            // colTrangThai
            //
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 14F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            //
            // colTienDo
            //
            colTienDo.DataPropertyName = "TienDo";
            colTienDo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTienDo.FillWeight = 15F;
            colTienDo.HeaderText = "Tiến độ (Done/Tổng)";
            colTienDo.Name = "colTienDo";
            colTienDo.ReadOnly = true;
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
            // FormDuAn
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 558);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Controls.Add(dgvDuAn);
            Controls.Add(lblTongSo);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(912, 597);
            Name = "FormDuAn";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Dự án";
            Load += FormDuAn_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaDuAn;
        private TextBox txtMaDuAn;
        private Label lblTenDuAn;
        private TextBox txtTenDuAn;
        private Label lblNgayBatDau;
        private DateTimePicker dtpNgayBatDau;
        private Label lblNgayKetThuc;
        private DateTimePicker dtpNgayKetThuc;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvDuAn;
        private DataGridViewTextBoxColumn colMaDuAn;
        private DataGridViewTextBoxColumn colTenDuAn;
        private DataGridViewTextBoxColumn colNgayBatDau;
        private DataGridViewTextBoxColumn colNgayKetThuc;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTienDo;
        private Label lblTongSo;
        private ErrorProvider errorProvider1;
    }
}
