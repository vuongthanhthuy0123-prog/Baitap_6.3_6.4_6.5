namespace QuanLyKaraoke.GUI
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            mnuQuanLy = new ToolStripMenuItem();
            mnuPhong = new ToolStripMenuItem();
            mnuDichVu = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            lblSinhVien = new Label();
            statusStrip1 = new StatusStrip();
            lblKetNoi = new ToolStripStatusLabel();
            lblDongHo = new ToolStripStatusLabel();
            grpPhong = new GroupBox();
            lblTenPhong = new Label();
            lblThongTin = new Label();
            btnMoPhong = new Button();
            lblGoiDV = new Label();
            cboDichVu = new ComboBox();
            nudSoLuong = new NumericUpDown();
            btnThemDV = new Button();
            dgvDichVu = new DataGridView();
            colTenDV = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            btnXoaDV = new Button();
            btnLuuDV = new Button();
            lblTien = new Label();
            lblTongCong = new Label();
            btnThanhToan = new Button();
            grpSoDo = new GroupBox();
            flpChuThich = new FlowLayoutPanel();
            lblTrong = new Label();
            lblDangHat = new Label();
            lblDemPhong = new Label();
            flpPhong = new FlowLayoutPanel();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            pnlHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            grpPhong.SuspendLayout();
            grpSoDo.SuspendLayout();
            flpChuThich.SuspendLayout();
            flpPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuQuanLy, mnuBaoCao, mnuThoat });
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.Name = "menuStrip1";
            //
            // mnuQuanLy
            //
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuPhong, mnuDichVu });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Text = "Quản lý";
            //
            // mnuPhong
            //
            mnuPhong.Name = "mnuPhong";
            mnuPhong.Text = "Phòng hát";
            mnuPhong.Click += mnuPhong_Click;
            //
            // mnuDichVu
            //
            mnuDichVu.Name = "mnuDichVu";
            mnuDichVu.Text = "Dịch vụ / đồ uống";
            mnuDichVu.Click += mnuDichVu_Click;
            //
            // mnuBaoCao
            //
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Text = "Báo cáo";
            mnuBaoCao.Click += mnuBaoCao_Click;
            //
            // mnuThoat
            //
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            //
            // pnlHeader
            //
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Controls.Add(lblSinhVien);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 60);
            pnlHeader.BackColor = Color.FromArgb(76, 29, 149);
            //
            // lblTieuDe
            //
            lblTieuDe.Location = new Point(18, 6);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Text = "KARAOKE - SƠ ĐỒ PHÒNG HÁT";
            //
            // lblSinhVien
            //
            lblSinhVien.Location = new Point(21, 38);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.AutoSize = true;
            lblSinhVien.ForeColor = Color.Gainsboro;
            lblSinhVien.Text = "Sinh viên: Vương Thanh Thúy  |  MSV: 24810310270  |  Lớp: D19CNPM3";
            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblKetNoi, lblDongHo });
            statusStrip1.Dock = DockStyle.Bottom;
            statusStrip1.Name = "statusStrip1";
            //
            // lblKetNoi
            //
            lblKetNoi.Name = "lblKetNoi";
            lblKetNoi.Spring = true;
            lblKetNoi.TextAlign = ContentAlignment.MiddleLeft;
            lblKetNoi.Text = "Đang kết nối CSDL...";
            //
            // lblDongHo
            //
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Text = "--:--";
            //
            // grpPhong
            //
            grpPhong.Controls.Add(lblTenPhong);
            grpPhong.Controls.Add(lblThongTin);
            grpPhong.Controls.Add(btnMoPhong);
            grpPhong.Controls.Add(lblGoiDV);
            grpPhong.Controls.Add(cboDichVu);
            grpPhong.Controls.Add(nudSoLuong);
            grpPhong.Controls.Add(btnThemDV);
            grpPhong.Controls.Add(dgvDichVu);
            grpPhong.Controls.Add(btnXoaDV);
            grpPhong.Controls.Add(btnLuuDV);
            grpPhong.Controls.Add(lblTien);
            grpPhong.Controls.Add(lblTongCong);
            grpPhong.Controls.Add(btnThanhToan);
            grpPhong.Dock = DockStyle.Right;
            grpPhong.Location = new Point(0, 0);
            grpPhong.Name = "grpPhong";
            grpPhong.Size = new Size(460, 600);
            grpPhong.Padding = new Padding(8);
            grpPhong.TabStop = false;
            grpPhong.Text = "Phòng đang chọn";
            //
            // lblTenPhong
            //
            lblTenPhong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTenPhong.Location = new Point(14, 24);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(432, 30);
            lblTenPhong.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTenPhong.ForeColor = Color.FromArgb(76, 29, 149);
            lblTenPhong.Text = "(chưa chọn phòng)";
            //
            // lblThongTin
            //
            lblThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblThongTin.Location = new Point(14, 58);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(432, 92);
            lblThongTin.Text = "Bấm vào 1 phòng ở sơ đồ bên trái.";
            //
            // btnMoPhong
            //
            btnMoPhong.Location = new Point(14, 152);
            btnMoPhong.Name = "btnMoPhong";
            btnMoPhong.Size = new Size(200, 36);
            btnMoPhong.BackColor = Color.SeaGreen;
            btnMoPhong.ForeColor = Color.White;
            btnMoPhong.FlatStyle = FlatStyle.Flat;
            btnMoPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoPhong.UseVisualStyleBackColor = false;
            btnMoPhong.Text = "MỞ PHÒNG";
            btnMoPhong.Click += btnMoPhong_Click;
            //
            // lblGoiDV
            //
            lblGoiDV.Location = new Point(14, 200);
            lblGoiDV.Name = "lblGoiDV";
            lblGoiDV.AutoSize = true;
            lblGoiDV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGoiDV.Text = "Gọi dịch vụ / đồ uống:";
            //
            // cboDichVu
            //
            cboDichVu.Location = new Point(14, 222);
            cboDichVu.Name = "cboDichVu";
            cboDichVu.Size = new Size(262, 23);
            cboDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // nudSoLuong
            //
            nudSoLuong.Location = new Point(284, 222);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(56, 23);
            nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoLuong.TextAlign = HorizontalAlignment.Right;
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnThemDV
            //
            btnThemDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemDV.Location = new Point(348, 220);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(98, 28);
            btnThemDV.Text = "Thêm";
            btnThemDV.UseVisualStyleBackColor = true;
            btnThemDV.Click += btnThemDV_Click;
            //
            // dgvDichVu
            //
            dgvDichVu.Columns.AddRange(new DataGridViewColumn[] { colTenDV, colSoLuong, colDonGia, colThanhTien });
            dgvDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDichVu.Location = new Point(14, 256);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.Size = new Size(432, 176);
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.AllowUserToDeleteRows = false;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.BackgroundColor = Color.White;
            dgvDichVu.MultiSelect = false;
            dgvDichVu.RowHeadersVisible = false;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.CellEndEdit += dgvDichVu_CellEndEdit;
            dgvDichVu.DataError += dgvDichVu_DataError;
            //
            // colTenDV
            //
            colTenDV.Name = "colTenDV";
            colTenDV.DataPropertyName = "TenDV";
            colTenDV.FillWeight = 40F;
            colTenDV.ReadOnly = true;
            colTenDV.HeaderText = "Dịch vụ";
            //
            // colSoLuong
            //
            colSoLuong.Name = "colSoLuong";
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.FillWeight = 16F;
            colSoLuong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoLuong.HeaderText = "SL (sửa được)";
            //
            // colDonGia
            //
            colDonGia.Name = "colDonGia";
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.FillWeight = 20F;
            colDonGia.DefaultCellStyle.Format = "N0";
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDonGia.ReadOnly = true;
            colDonGia.HeaderText = "Đơn giá";
            //
            // colThanhTien
            //
            colThanhTien.Name = "colThanhTien";
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.FillWeight = 24F;
            colThanhTien.DefaultCellStyle.Format = "N0";
            colThanhTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colThanhTien.ReadOnly = true;
            colThanhTien.HeaderText = "Thành tiền";
            //
            // btnXoaDV
            //
            btnXoaDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaDV.Location = new Point(14, 440);
            btnXoaDV.Name = "btnXoaDV";
            btnXoaDV.Size = new Size(120, 30);
            btnXoaDV.Text = "Bỏ dịch vụ";
            btnXoaDV.UseVisualStyleBackColor = true;
            btnXoaDV.Click += btnXoaDV_Click;
            //
            // btnLuuDV
            //
            btnLuuDV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLuuDV.Location = new Point(142, 440);
            btnLuuDV.Name = "btnLuuDV";
            btnLuuDV.Size = new Size(190, 30);
            btnLuuDV.Text = "Lưu dịch vụ (Update)";
            btnLuuDV.UseVisualStyleBackColor = true;
            btnLuuDV.Click += btnLuuDV_Click;
            //
            // lblTien
            //
            lblTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTien.Location = new Point(14, 476);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(432, 44);
            lblTien.TextAlign = ContentAlignment.MiddleRight;
            lblTien.Text = "Tiền phòng (tạm tính): 0 đ\nTiền dịch vụ: 0 đ";
            //
            // lblTongCong
            //
            lblTongCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongCong.Location = new Point(14, 518);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(432, 30);
            lblTongCong.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongCong.ForeColor = Color.Firebrick;
            lblTongCong.TextAlign = ContentAlignment.MiddleRight;
            lblTongCong.Text = "TỔNG: 0 đ";
            //
            // btnThanhToan
            //
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThanhToan.Location = new Point(14, 552);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(432, 46);
            btnThanhToan.BackColor = Color.Firebrick;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.Click += btnThanhToan_Click;
            //
            // grpSoDo
            //
            grpSoDo.Controls.Add(flpPhong);
            grpSoDo.Controls.Add(flpChuThich);
            grpSoDo.Dock = DockStyle.Fill;
            grpSoDo.Location = new Point(0, 0);
            grpSoDo.Name = "grpSoDo";
            grpSoDo.Size = new Size(740, 600);
            grpSoDo.Padding = new Padding(8);
            grpSoDo.TabStop = false;
            grpSoDo.Text = "Sơ đồ phòng hát";
            //
            // flpChuThich
            //
            flpChuThich.Controls.Add(lblTrong);
            flpChuThich.Controls.Add(lblDangHat);
            flpChuThich.Controls.Add(lblDemPhong);
            flpChuThich.Dock = DockStyle.Top;
            flpChuThich.Name = "flpChuThich";
            flpChuThich.Size = new Size(724, 30);
            //
            // lblTrong
            //
            lblTrong.Name = "lblTrong";
            lblTrong.AutoSize = true;
            lblTrong.BackColor = Color.SeaGreen;
            lblTrong.ForeColor = Color.White;
            lblTrong.Margin = new Padding(3, 6, 6, 3);
            lblTrong.Text = "   Trống   ";
            //
            // lblDangHat
            //
            lblDangHat.Name = "lblDangHat";
            lblDangHat.AutoSize = true;
            lblDangHat.BackColor = Color.Firebrick;
            lblDangHat.ForeColor = Color.White;
            lblDangHat.Margin = new Padding(3, 6, 6, 3);
            lblDangHat.Text = "   Đang hát   ";
            //
            // lblDemPhong
            //
            lblDemPhong.Name = "lblDemPhong";
            lblDemPhong.AutoSize = true;
            lblDemPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDemPhong.Margin = new Padding(16, 6, 3, 3);
            lblDemPhong.Text = "";
            //
            // flpPhong
            //
            flpPhong.Dock = DockStyle.Fill;
            flpPhong.Name = "flpPhong";
            flpPhong.AutoScroll = true;
            flpPhong.Padding = new Padding(4);
            //
            // tmrDongHo
            //
            tmrDongHo.Interval = 30000;
            tmrDongHo.Tick += tmrDongHo_Tick;
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // FormMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 740);
            Controls.Add(grpSoDo);
            Controls.Add(grpPhong);
            Controls.Add(statusStrip1);
            Controls.Add(pnlHeader);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            StartPosition = FormStartPosition.CenterScreen;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1100, 720);
            Name = "FormMain";
            Text = "Hệ thống Quản lý Karaoke";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpPhong.ResumeLayout(false);
            grpPhong.PerformLayout();
            grpSoDo.ResumeLayout(false);
            grpSoDo.PerformLayout();
            flpChuThich.ResumeLayout(false);
            flpChuThich.PerformLayout();
            flpPhong.ResumeLayout(false);
            flpPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuPhong;
        private ToolStripMenuItem mnuDichVu;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuThoat;
        private Panel pnlHeader;
        private Label lblTieuDe;
        private Label lblSinhVien;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblKetNoi;
        private ToolStripStatusLabel lblDongHo;
        private GroupBox grpPhong;
        private Label lblTenPhong;
        private Label lblThongTin;
        private Button btnMoPhong;
        private Label lblGoiDV;
        private ComboBox cboDichVu;
        private NumericUpDown nudSoLuong;
        private Button btnThemDV;
        private DataGridView dgvDichVu;
        private DataGridViewTextBoxColumn colTenDV;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Button btnXoaDV;
        private Button btnLuuDV;
        private Label lblTien;
        private Label lblTongCong;
        private Button btnThanhToan;
        private GroupBox grpSoDo;
        private FlowLayoutPanel flpChuThich;
        private Label lblTrong;
        private Label lblDangHat;
        private Label lblDemPhong;
        private FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Timer tmrDongHo;
        private ErrorProvider errorProvider1;
    }
}
