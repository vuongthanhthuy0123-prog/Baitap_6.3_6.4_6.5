namespace QuanLyGarage.GUI
{
    partial class FormThanhToan
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
            grpLoc = new GroupBox();
            lblLoc = new Label();
            cboLoc = new ComboBox();
            lblTim = new Label();
            txtTim = new TextBox();
            lblDoanhThu = new Label();
            dgvPhieu = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colBienSo = new DataGridViewTextBoxColumn();
            colTenKH = new DataGridViewTextBoxColumn();
            colNgayNhan = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            grpHoaDon = new GroupBox();
            lblThongTin = new Label();
            dgvChiTiet = new DataGridView();
            colTenPT = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colCong = new DataGridViewTextBoxColumn();
            colTT = new DataGridViewTextBoxColumn();
            lblTien = new Label();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            grpLoc.SuspendLayout();
            grpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            //
            // grpLoc
            //
            grpLoc.Controls.Add(lblLoc);
            grpLoc.Controls.Add(cboLoc);
            grpLoc.Controls.Add(lblTim);
            grpLoc.Controls.Add(txtTim);
            grpLoc.Controls.Add(lblDoanhThu);
            grpLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLoc.Location = new Point(12, 10);
            grpLoc.Name = "grpLoc";
            grpLoc.Size = new Size(976, 60);
            grpLoc.TabStop = false;
            grpLoc.Text = "Danh sách phiếu sửa chữa";
            //
            // lblLoc
            //
            lblLoc.Location = new Point(14, 28);
            lblLoc.Name = "lblLoc";
            lblLoc.AutoSize = true;
            lblLoc.Text = "Trạng thái:";
            //
            // cboLoc
            //
            cboLoc.Items.AddRange(new object[] { "Tất cả", "Đang sửa", "Đã hoàn thành", "Đã thanh toán" });
            cboLoc.Location = new Point(86, 24);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(150, 23);
            cboLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoc.SelectionChangeCommitted += BoLoc_Changed;
            //
            // lblTim
            //
            lblTim.Location = new Point(252, 28);
            lblTim.Name = "lblTim";
            lblTim.AutoSize = true;
            lblTim.Text = "Biển số / chủ xe:";
            //
            // txtTim
            //
            txtTim.Location = new Point(356, 24);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(170, 23);
            txtTim.TextChanged += BoLoc_Changed;
            //
            // lblDoanhThu
            //
            lblDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDoanhThu.Location = new Point(540, 26);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(424, 20);
            lblDoanhThu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoanhThu.ForeColor = Color.DarkGreen;
            lblDoanhThu.TextAlign = ContentAlignment.MiddleRight;
            lblDoanhThu.Text = "Doanh thu tháng: 0 đ";
            //
            // dgvPhieu
            //
            dgvPhieu.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colBienSo, colTenKH, colNgayNhan, colTongTien, colTrangThai });
            dgvPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvPhieu.Location = new Point(12, 80);
            dgvPhieu.Name = "dgvPhieu";
            dgvPhieu.Size = new Size(560, 470);
            dgvPhieu.AllowUserToAddRows = false;
            dgvPhieu.AllowUserToDeleteRows = false;
            dgvPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieu.BackgroundColor = Color.White;
            dgvPhieu.MultiSelect = false;
            dgvPhieu.RowHeadersVisible = false;
            dgvPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieu.ReadOnly = true;
            dgvPhieu.CellClick += dgvPhieu_CellClick;
            dgvPhieu.CellFormatting += dgvPhieu_CellFormatting;
            //
            // colMaPhieu
            //
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.DataPropertyName = "MaPhieu";
            colMaPhieu.FillWeight = 8F;
            colMaPhieu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaPhieu.ReadOnly = true;
            colMaPhieu.HeaderText = "Mã";
            //
            // colBienSo
            //
            colBienSo.Name = "colBienSo";
            colBienSo.DataPropertyName = "BienSo";
            colBienSo.FillWeight = 16F;
            colBienSo.ReadOnly = true;
            colBienSo.HeaderText = "Biển số";
            //
            // colTenKH
            //
            colTenKH.Name = "colTenKH";
            colTenKH.DataPropertyName = "TenKH";
            colTenKH.FillWeight = 22F;
            colTenKH.ReadOnly = true;
            colTenKH.HeaderText = "Chủ xe";
            //
            // colNgayNhan
            //
            colNgayNhan.Name = "colNgayNhan";
            colNgayNhan.DataPropertyName = "NgayNhan";
            colNgayNhan.FillWeight = 14F;
            colNgayNhan.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayNhan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNgayNhan.ReadOnly = true;
            colNgayNhan.HeaderText = "Ngày nhận";
            //
            // colTongTien
            //
            colTongTien.Name = "colTongTien";
            colTongTien.DataPropertyName = "TongTien";
            colTongTien.FillWeight = 17F;
            colTongTien.DefaultCellStyle.Format = "N0";
            colTongTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTongTien.ReadOnly = true;
            colTongTien.HeaderText = "Tổng tiền";
            //
            // colTrangThai
            //
            colTrangThai.Name = "colTrangThai";
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 17F;
            colTrangThai.ReadOnly = true;
            colTrangThai.HeaderText = "Trạng thái";
            //
            // lblTongSo
            //
            lblTongSo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongSo.Location = new Point(12, 558);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(560, 20);
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.Text = "0 phiếu";
            //
            // grpHoaDon
            //
            grpHoaDon.Controls.Add(lblThongTin);
            grpHoaDon.Controls.Add(dgvChiTiet);
            grpHoaDon.Controls.Add(lblTien);
            grpHoaDon.Controls.Add(lblTongTien);
            grpHoaDon.Controls.Add(btnThanhToan);
            grpHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpHoaDon.Location = new Point(584, 80);
            grpHoaDon.Name = "grpHoaDon";
            grpHoaDon.Size = new Size(404, 498);
            grpHoaDon.TabStop = false;
            grpHoaDon.Text = "Hóa đơn dịch vụ";
            //
            // lblThongTin
            //
            lblThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblThongTin.Location = new Point(14, 24);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(376, 96);
            lblThongTin.Text = "Chọn 1 phiếu ở danh sách bên trái.";
            //
            // dgvChiTiet
            //
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colTenPT, colSL, colCong, colTT });
            dgvChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTiet.Location = new Point(14, 124);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(376, 220);
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.ReadOnly = true;
            //
            // colTenPT
            //
            colTenPT.Name = "colTenPT";
            colTenPT.DataPropertyName = "TenPhuTung";
            colTenPT.FillWeight = 44F;
            colTenPT.ReadOnly = true;
            colTenPT.HeaderText = "Phụ tùng / dịch vụ";
            //
            // colSL
            //
            colSL.Name = "colSL";
            colSL.DataPropertyName = "SoLuong";
            colSL.FillWeight = 10F;
            colSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSL.ReadOnly = true;
            colSL.HeaderText = "SL";
            //
            // colCong
            //
            colCong.Name = "colCong";
            colCong.DataPropertyName = "TienCong";
            colCong.FillWeight = 20F;
            colCong.DefaultCellStyle.Format = "N0";
            colCong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colCong.ReadOnly = true;
            colCong.HeaderText = "Tiền công";
            //
            // colTT
            //
            colTT.Name = "colTT";
            colTT.DataPropertyName = "ThanhTien";
            colTT.FillWeight = 24F;
            colTT.DefaultCellStyle.Format = "N0";
            colTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTT.ReadOnly = true;
            colTT.HeaderText = "Thành tiền";
            //
            // lblTien
            //
            lblTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTien.Location = new Point(14, 352);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(376, 44);
            lblTien.TextAlign = ContentAlignment.MiddleRight;
            lblTien.Text = "Tiền phụ tùng: 0 đ\nTiền công: 0 đ";
            //
            // lblTongTien
            //
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongTien.Location = new Point(14, 398);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(376, 32);
            lblTongTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Firebrick;
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            lblTongTien.Text = "TỔNG CHI PHÍ: 0 đ";
            //
            // btnThanhToan
            //
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThanhToan.Location = new Point(14, 440);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(376, 46);
            btnThanhToan.BackColor = Color.SeaGreen;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThanhToan.Text = "THANH TOÁN && XUẤT HÓA ĐƠN";
            btnThanhToan.Click += btnThanhToan_Click;
            //
            // FormThanhToan
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 590);
            Controls.Add(grpLoc);
            Controls.Add(dgvPhieu);
            Controls.Add(lblTongSo);
            Controls.Add(grpHoaDon);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1016, 560);
            Name = "FormThanhToan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thanh toán & Xuất hóa đơn";
            Load += FormThanhToan_Load;
            grpLoc.ResumeLayout(false);
            grpLoc.PerformLayout();
            grpHoaDon.ResumeLayout(false);
            grpHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLoc;
        private Label lblLoc;
        private ComboBox cboLoc;
        private Label lblTim;
        private TextBox txtTim;
        private Label lblDoanhThu;
        private DataGridView dgvPhieu;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colBienSo;
        private DataGridViewTextBoxColumn colTenKH;
        private DataGridViewTextBoxColumn colNgayNhan;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label lblTongSo;
        private GroupBox grpHoaDon;
        private Label lblThongTin;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colTenPT;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colCong;
        private DataGridViewTextBoxColumn colTT;
        private Label lblTien;
        private Label lblTongTien;
        private Button btnThanhToan;
    }
}
