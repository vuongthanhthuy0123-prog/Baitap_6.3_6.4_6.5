namespace QuanLyDuAn.GUI
{
    partial class FormThanhVien
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
            lblMaThanhVien = new Label();
            txtMaThanhVien = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblChuyenMon = new Label();
            txtChuyenMon = new TextBox();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvThanhVien = new DataGridView();
            colMaThanhVien = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colChuyenMon = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpThongTin.SuspendLayout();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(lblMaThanhVien);
            grpThongTin.Controls.Add(txtMaThanhVien);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblChuyenMon);
            grpThongTin.Controls.Add(txtChuyenMon);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(430, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin thành viên";
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
            // lblMaThanhVien
            //
            lblMaThanhVien.AutoSize = true;
            lblMaThanhVien.Location = new Point(16, 33);
            lblMaThanhVien.Name = "lblMaThanhVien";
            lblMaThanhVien.Text = "Mã thành viên:";
            //
            // txtMaThanhVien
            //
            txtMaThanhVien.Location = new Point(140, 30);
            txtMaThanhVien.Name = "txtMaThanhVien";
            txtMaThanhVien.Size = new Size(100, 23);
            txtMaThanhVien.TabIndex = 1;
            txtMaThanhVien.ReadOnly = true;
            txtMaThanhVien.TabStop = false;
            //
            // lblHoTen
            //
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(16, 65);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ và tên:";
            //
            // txtHoTen
            //
            txtHoTen.Location = new Point(140, 62);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(260, 23);
            txtHoTen.TabIndex = 3;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            txtEmail.Location = new Point(140, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 5;
            txtEmail.MaxLength = 100;
            //
            // lblChuyenMon
            //
            lblChuyenMon.AutoSize = true;
            lblChuyenMon.Location = new Point(16, 129);
            lblChuyenMon.Name = "lblChuyenMon";
            lblChuyenMon.Text = "Chuyên môn:";
            //
            // txtChuyenMon
            //
            txtChuyenMon.Location = new Point(140, 126);
            txtChuyenMon.Name = "txtChuyenMon";
            txtChuyenMon.Size = new Size(260, 23);
            txtChuyenMon.TabIndex = 7;
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
            lblTimKiem.Text = "Tìm theo tên, email, chuyên môn:";
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
            // dgvThanhVien
            //
            dgvThanhVien.AllowUserToAddRows = false;
            dgvThanhVien.AllowUserToDeleteRows = false;
            dgvThanhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhVien.BackgroundColor = Color.White;
            dgvThanhVien.Columns.AddRange(new DataGridViewColumn[] { colMaThanhVien, colHoTen, colEmail, colChuyenMon });
            dgvThanhVien.Location = new Point(12, 222);
            dgvThanhVien.MultiSelect = false;
            dgvThanhVien.Name = "dgvThanhVien";
            dgvThanhVien.ReadOnly = true;
            dgvThanhVien.RowHeadersVisible = false;
            dgvThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhVien.Size = new Size(872, 300);
            dgvThanhVien.TabIndex = 2;
            dgvThanhVien.CellClick += dgvThanhVien_CellClick;
            //
            // colMaThanhVien
            //
            colMaThanhVien.DataPropertyName = "MaThanhVien";
            colMaThanhVien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaThanhVien.FillWeight = 8F;
            colMaThanhVien.HeaderText = "Mã";
            colMaThanhVien.Name = "colMaThanhVien";
            colMaThanhVien.ReadOnly = true;
            //
            // colHoTen
            //
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 30F;
            colHoTen.HeaderText = "Họ và tên";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            //
            // colEmail
            //
            colEmail.DataPropertyName = "Email";
            colEmail.FillWeight = 30F;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            //
            // colChuyenMon
            //
            colChuyenMon.DataPropertyName = "ChuyenMon";
            colChuyenMon.FillWeight = 30F;
            colChuyenMon.HeaderText = "Chuyên môn";
            colChuyenMon.Name = "colChuyenMon";
            colChuyenMon.ReadOnly = true;
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
            // FormThanhVien
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 558);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Controls.Add(dgvThanhVien);
            Controls.Add(lblTongSo);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(912, 597);
            Name = "FormThanhVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Thành viên nhóm";
            Load += FormThanhVien_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaThanhVien;
        private TextBox txtMaThanhVien;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblChuyenMon;
        private TextBox txtChuyenMon;
        private GroupBox grpChucNang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvThanhVien;
        private DataGridViewTextBoxColumn colMaThanhVien;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colChuyenMon;
        private Label lblTongSo;
        private ErrorProvider errorProvider1;
    }
}
