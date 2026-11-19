namespace QuanLyGarage.GUI
{
    partial class FormLapPhieu
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
            grpXe = new GroupBox();
            lblBienSo = new Label();
            txtBienSo = new TextBox();
            btnTraCuu = new Button();
            lblThongTinXe = new Label();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            grpThem = new GroupBox();
            lblPhuTung = new Label();
            cboPhuTung = new ComboBox();
            lblSL = new Label();
            nudSoLuong = new NumericUpDown();
            lblTienCong = new Label();
            txtTienCong = new TextBox();
            btnThem = new Button();
            dgvChiTiet = new DataGridView();
            colTenPhuTung = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colTienPhuTung = new DataGridViewTextBoxColumn();
            colTienCong = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            btnXoaDong = new Button();
            btnXoaHet = new Button();
            lblTien = new Label();
            lblTongTien = new Label();
            btnHoanTat = new Button();
            errorProvider1 = new ErrorProvider(components);
            grpXe.SuspendLayout();
            grpThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpXe
            //
            grpXe.Controls.Add(lblBienSo);
            grpXe.Controls.Add(txtBienSo);
            grpXe.Controls.Add(btnTraCuu);
            grpXe.Controls.Add(lblThongTinXe);
            grpXe.Controls.Add(lblNoiDung);
            grpXe.Controls.Add(txtNoiDung);
            grpXe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpXe.Location = new Point(12, 10);
            grpXe.Name = "grpXe";
            grpXe.Size = new Size(956, 92);
            grpXe.TabStop = false;
            grpXe.Text = "Xe cần sửa";
            //
            // lblBienSo
            //
            lblBienSo.Location = new Point(14, 30);
            lblBienSo.Name = "lblBienSo";
            lblBienSo.AutoSize = true;
            lblBienSo.Text = "Biển số:";
            //
            // txtBienSo
            //
            txtBienSo.Location = new Point(110, 26);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(150, 23);
            txtBienSo.CharacterCasing = CharacterCasing.Upper;
            txtBienSo.KeyDown += txtBienSo_KeyDown;
            //
            // btnTraCuu
            //
            btnTraCuu.Location = new Point(268, 24);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(90, 28);
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            //
            // lblThongTinXe
            //
            lblThongTinXe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblThongTinXe.Location = new Point(370, 30);
            lblThongTinXe.Name = "lblThongTinXe";
            lblThongTinXe.Size = new Size(574, 20);
            lblThongTinXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblThongTinXe.ForeColor = Color.SteelBlue;
            lblThongTinXe.Text = "Nhập biển số xe đã tiếp nhận rồi bấm Tra cứu.";
            //
            // lblNoiDung
            //
            lblNoiDung.Location = new Point(14, 62);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.AutoSize = true;
            lblNoiDung.Text = "Nội dung sửa:";
            //
            // txtNoiDung
            //
            txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNoiDung.Location = new Point(110, 58);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(834, 23);
            //
            // grpThem
            //
            grpThem.Controls.Add(lblPhuTung);
            grpThem.Controls.Add(cboPhuTung);
            grpThem.Controls.Add(lblSL);
            grpThem.Controls.Add(nudSoLuong);
            grpThem.Controls.Add(lblTienCong);
            grpThem.Controls.Add(txtTienCong);
            grpThem.Controls.Add(btnThem);
            grpThem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThem.Location = new Point(12, 110);
            grpThem.Name = "grpThem";
            grpThem.Size = new Size(956, 64);
            grpThem.TabStop = false;
            grpThem.Text = "Thêm phụ tùng / dịch vụ";
            //
            // lblPhuTung
            //
            lblPhuTung.Location = new Point(14, 30);
            lblPhuTung.Name = "lblPhuTung";
            lblPhuTung.AutoSize = true;
            lblPhuTung.Text = "Phụ tùng:";
            //
            // cboPhuTung
            //
            cboPhuTung.Location = new Point(80, 26);
            cboPhuTung.Name = "cboPhuTung";
            cboPhuTung.Size = new Size(330, 23);
            cboPhuTung.DropDownStyle = ComboBoxStyle.DropDown;
            cboPhuTung.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPhuTung.AutoCompleteSource = AutoCompleteSource.ListItems;
            //
            // lblSL
            //
            lblSL.Location = new Point(422, 30);
            lblSL.Name = "lblSL";
            lblSL.AutoSize = true;
            lblSL.Text = "SL:";
            //
            // nudSoLuong
            //
            nudSoLuong.Location = new Point(448, 26);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(60, 23);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.TextAlign = HorizontalAlignment.Right;
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblTienCong
            //
            lblTienCong.Location = new Point(522, 30);
            lblTienCong.Name = "lblTienCong";
            lblTienCong.AutoSize = true;
            lblTienCong.Text = "Tiền công (đ):";
            //
            // txtTienCong
            //
            txtTienCong.Location = new Point(608, 26);
            txtTienCong.Name = "txtTienCong";
            txtTienCong.Size = new Size(110, 23);
            txtTienCong.TextAlign = HorizontalAlignment.Right;
            //
            // btnThem
            //
            btnThem.Location = new Point(730, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 29);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            //
            // dgvChiTiet
            //
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colTenPhuTung, colSoLuong, colDonGia, colTienPhuTung, colTienCong, colThanhTien });
            dgvChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTiet.Location = new Point(12, 184);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.Size = new Size(956, 300);
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.CellFormatting += dgvChiTiet_CellFormatting;
            //
            // colTenPhuTung
            //
            colTenPhuTung.Name = "colTenPhuTung";
            colTenPhuTung.DataPropertyName = "TenPhuTung";
            colTenPhuTung.FillWeight = 34F;
            colTenPhuTung.ReadOnly = true;
            colTenPhuTung.HeaderText = "Phụ tùng / dịch vụ";
            //
            // colSoLuong
            //
            colSoLuong.Name = "colSoLuong";
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.FillWeight = 7F;
            colSoLuong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoLuong.ReadOnly = true;
            colSoLuong.HeaderText = "SL";
            //
            // colDonGia
            //
            colDonGia.Name = "colDonGia";
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.FillWeight = 13F;
            colDonGia.DefaultCellStyle.Format = "N0";
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDonGia.ReadOnly = true;
            colDonGia.HeaderText = "Đơn giá";
            //
            // colTienPhuTung
            //
            colTienPhuTung.Name = "colTienPhuTung";
            colTienPhuTung.DataPropertyName = "TienPhuTung";
            colTienPhuTung.FillWeight = 15F;
            colTienPhuTung.DefaultCellStyle.Format = "N0";
            colTienPhuTung.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTienPhuTung.ReadOnly = true;
            colTienPhuTung.HeaderText = "Tiền phụ tùng";
            //
            // colTienCong
            //
            colTienCong.Name = "colTienCong";
            colTienCong.DataPropertyName = "TienCong";
            colTienCong.FillWeight = 13F;
            colTienCong.DefaultCellStyle.Format = "N0";
            colTienCong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTienCong.ReadOnly = true;
            colTienCong.HeaderText = "Tiền công";
            //
            // colThanhTien
            //
            colThanhTien.Name = "colThanhTien";
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.FillWeight = 15F;
            colThanhTien.DefaultCellStyle.Format = "N0";
            colThanhTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colThanhTien.ReadOnly = true;
            colThanhTien.HeaderText = "Thành tiền";
            //
            // btnXoaDong
            //
            btnXoaDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaDong.Location = new Point(12, 494);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(130, 32);
            btnXoaDong.Text = "Bỏ dòng đã chọn";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            //
            // btnXoaHet
            //
            btnXoaHet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaHet.Location = new Point(150, 494);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(110, 32);
            btnXoaHet.ForeColor = Color.Firebrick;
            btnXoaHet.Text = "Xóa hết";
            btnXoaHet.UseVisualStyleBackColor = true;
            btnXoaHet.Click += btnXoaHet_Click;
            //
            // lblTien
            //
            lblTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTien.Location = new Point(470, 492);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(330, 44);
            lblTien.TextAlign = ContentAlignment.MiddleRight;
            lblTien.Text = "Tiền phụ tùng: 0 đ\nTiền công: 0 đ";
            //
            // lblTongTien
            //
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.Location = new Point(470, 540);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(330, 34);
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Firebrick;
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            lblTongTien.Text = "TỔNG: 0 đ";
            //
            // btnHoanTat
            //
            btnHoanTat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHoanTat.Location = new Point(812, 494);
            btnHoanTat.Name = "btnHoanTat";
            btnHoanTat.Size = new Size(156, 80);
            btnHoanTat.BackColor = Color.SeaGreen;
            btnHoanTat.ForeColor = Color.White;
            btnHoanTat.FlatStyle = FlatStyle.Flat;
            btnHoanTat.UseVisualStyleBackColor = false;
            btnHoanTat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHoanTat.Text = "HOÀN TẤT\nPHIẾU SỬA CHỮA";
            btnHoanTat.Click += btnHoanTat_Click;
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // FormLapPhieu
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 586);
            Controls.Add(grpXe);
            Controls.Add(grpThem);
            Controls.Add(dgvChiTiet);
            Controls.Add(btnXoaDong);
            Controls.Add(btnXoaHet);
            Controls.Add(lblTien);
            Controls.Add(lblTongTien);
            Controls.Add(btnHoanTat);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(996, 560);
            Name = "FormLapPhieu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lập phiếu sửa chữa & Thay thế phụ tùng";
            Load += FormLapPhieu_Load;
            grpXe.ResumeLayout(false);
            grpXe.PerformLayout();
            grpThem.ResumeLayout(false);
            grpThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpXe;
        private Label lblBienSo;
        private TextBox txtBienSo;
        private Button btnTraCuu;
        private Label lblThongTinXe;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private GroupBox grpThem;
        private Label lblPhuTung;
        private ComboBox cboPhuTung;
        private Label lblSL;
        private NumericUpDown nudSoLuong;
        private Label lblTienCong;
        private TextBox txtTienCong;
        private Button btnThem;
        private DataGridView dgvChiTiet;
        private DataGridViewTextBoxColumn colTenPhuTung;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colTienPhuTung;
        private DataGridViewTextBoxColumn colTienCong;
        private DataGridViewTextBoxColumn colThanhTien;
        private Button btnXoaDong;
        private Button btnXoaHet;
        private Label lblTien;
        private Label lblTongTien;
        private Button btnHoanTat;
        private ErrorProvider errorProvider1;
    }
}
