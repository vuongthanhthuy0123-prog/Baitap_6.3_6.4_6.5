namespace QuanLyKaraoke.GUI
{
    partial class FormPhong
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
            lblMaPhong = new Label();
            txtMaPhong = new TextBox();
            lblTenPhong = new Label();
            txtTenPhong = new TextBox();
            lblLoaiPhong = new Label();
            cboLoaiPhong = new ComboBox();
            lblGiaTheoGio = new Label();
            txtGiaTheoGio = new TextBox();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvPhong = new DataGridView();
            colMaPhong = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong = new DataGridViewTextBoxColumn();
            colGiaTheoGio = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(lblMaPhong);
            grpThongTin.Controls.Add(txtMaPhong);
            grpThongTin.Controls.Add(lblTenPhong);
            grpThongTin.Controls.Add(txtTenPhong);
            grpThongTin.Controls.Add(lblLoaiPhong);
            grpThongTin.Controls.Add(cboLoaiPhong);
            grpThongTin.Controls.Add(lblGiaTheoGio);
            grpThongTin.Controls.Add(txtGiaTheoGio);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(430, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin phòng hát";
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
            // lblMaPhong
            //
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(16, 33);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Text = "Mã phòng:";
            //
            // txtMaPhong
            //
            txtMaPhong.Location = new Point(140, 30);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(100, 23);
            txtMaPhong.TabIndex = 1;
            txtMaPhong.ReadOnly = true;
            txtMaPhong.TabStop = false;
            //
            // lblTenPhong
            //
            lblTenPhong.AutoSize = true;
            lblTenPhong.Location = new Point(16, 65);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Text = "Tên phòng:";
            //
            // txtTenPhong
            //
            txtTenPhong.Location = new Point(140, 62);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(260, 23);
            txtTenPhong.TabIndex = 3;
            //
            // lblLoaiPhong
            //
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Location = new Point(16, 97);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Text = "Loại phòng:";
            //
            // cboLoaiPhong
            //
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.Items.AddRange(new object[] { "VIP", "Thường" });
            cboLoaiPhong.Location = new Point(140, 94);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(160, 23);
            cboLoaiPhong.TabIndex = 5;
            //
            // lblGiaTheoGio
            //
            lblGiaTheoGio.AutoSize = true;
            lblGiaTheoGio.Location = new Point(16, 129);
            lblGiaTheoGio.Name = "lblGiaTheoGio";
            lblGiaTheoGio.Text = "Giá theo giờ (đ):";
            //
            // txtGiaTheoGio
            //
            txtGiaTheoGio.Location = new Point(140, 126);
            txtGiaTheoGio.Name = "txtGiaTheoGio";
            txtGiaTheoGio.Size = new Size(160, 23);
            txtGiaTheoGio.TabIndex = 7;
            txtGiaTheoGio.TextAlign = HorizontalAlignment.Right;
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
            lblTimKiem.Text = "Tìm theo tên phòng:";
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
            // dgvPhong
            //
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = Color.White;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { colMaPhong, colTenPhong, colLoaiPhong, colGiaTheoGio, colTrangThai });
            dgvPhong.Location = new Point(12, 222);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersVisible = false;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(872, 300);
            dgvPhong.TabIndex = 2;
            dgvPhong.CellClick += dgvPhong_CellClick;
            //
            // colMaPhong
            //
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaPhong.FillWeight = 8F;
            colMaPhong.HeaderText = "Mã";
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            //
            // colTenPhong
            //
            colTenPhong.DataPropertyName = "TenPhong";
            colTenPhong.FillWeight = 34F;
            colTenPhong.HeaderText = "Tên phòng";
            colTenPhong.Name = "colTenPhong";
            colTenPhong.ReadOnly = true;
            //
            // colLoaiPhong
            //
            colLoaiPhong.DataPropertyName = "LoaiPhong";
            colLoaiPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colLoaiPhong.FillWeight = 14F;
            colLoaiPhong.HeaderText = "Loại";
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.ReadOnly = true;
            //
            // colGiaTheoGio
            //
            colGiaTheoGio.DataPropertyName = "GiaTheoGio";
            colGiaTheoGio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colGiaTheoGio.DefaultCellStyle.Format = "N0";
            colGiaTheoGio.FillWeight = 20F;
            colGiaTheoGio.HeaderText = "Giá / giờ";
            colGiaTheoGio.Name = "colGiaTheoGio";
            colGiaTheoGio.ReadOnly = true;
            //
            // colTrangThai
            //
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTrangThai.FillWeight = 18F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
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
            // FormPhong
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 558);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Controls.Add(dgvPhong);
            Controls.Add(lblTongSo);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(912, 597);
            Name = "FormPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Phòng hát";
            Load += FormPhong_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private Label lblTenPhong;
        private TextBox txtTenPhong;
        private Label lblLoaiPhong;
        private ComboBox cboLoaiPhong;
        private Label lblGiaTheoGio;
        private TextBox txtGiaTheoGio;
        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvPhong;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colLoaiPhong;
        private DataGridViewTextBoxColumn colGiaTheoGio;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label lblTongSo;
        private ErrorProvider errorProvider1;
    }
}
