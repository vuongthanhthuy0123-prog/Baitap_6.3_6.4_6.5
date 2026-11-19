namespace QuanLyGarage.GUI
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
            menuStrip1 = new MenuStrip();
            mnuTiepNhan = new ToolStripMenuItem();
            mnuKho = new ToolStripMenuItem();
            mnuSuaChua = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuXe = new ToolStripMenuItem();
            mnuPhuTung = new ToolStripMenuItem();
            mnuLapPhieu = new ToolStripMenuItem();
            mnuThanhToan = new ToolStripMenuItem();
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            lblSinhVien = new Label();
            pnlSoXe = new Panel();
            lblSoXeTitle = new Label();
            lblSoXe = new Label();
            pnlChoThanhToan = new Panel();
            lblChoThanhToanTitle = new Label();
            lblChoThanhToan = new Label();
            pnlDoanhThu = new Panel();
            lblDoanhThuTitle = new Label();
            lblDoanhThu = new Label();
            pnlSapHet = new Panel();
            lblSapHetTitle = new Label();
            lblSapHet = new Label();
            btnTiepNhan = new Button();
            btnLapPhieu = new Button();
            btnThanhToan = new Button();
            btnPhuTung = new Button();
            lblHuongDan = new Label();
            statusStrip1 = new StatusStrip();
            lblKetNoi = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            pnlHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTiepNhan, mnuKho, mnuSuaChua, mnuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 0;
            //
            // mnuXe
            //
            mnuXe.Name = "mnuXe";
            mnuXe.Text = "Tiếp nhận xe && chủ xe";
            mnuXe.Click += btnTiepNhan_Click;
            //
            // mnuTiepNhan
            //
            mnuTiepNhan.DropDownItems.AddRange(new ToolStripItem[] { mnuXe });
            mnuTiepNhan.Name = "mnuTiepNhan";
            mnuTiepNhan.Text = "Tiếp nhận";
            //
            // mnuPhuTung
            //
            mnuPhuTung.Name = "mnuPhuTung";
            mnuPhuTung.Text = "Phụ tùng / vật tư";
            mnuPhuTung.Click += btnPhuTung_Click;
            //
            // mnuKho
            //
            mnuKho.DropDownItems.AddRange(new ToolStripItem[] { mnuPhuTung });
            mnuKho.Name = "mnuKho";
            mnuKho.Text = "Kho";
            //
            // mnuLapPhieu
            //
            mnuLapPhieu.Name = "mnuLapPhieu";
            mnuLapPhieu.Text = "Lập phiếu sửa chữa";
            mnuLapPhieu.Click += btnLapPhieu_Click;
            //
            // mnuThanhToan
            //
            mnuThanhToan.Name = "mnuThanhToan";
            mnuThanhToan.Text = "Thanh toán && hóa đơn";
            mnuThanhToan.Click += btnThanhToan_Click;
            //
            // mnuSuaChua
            //
            mnuSuaChua.DropDownItems.AddRange(new ToolStripItem[] { mnuLapPhieu, mnuThanhToan });
            mnuSuaChua.Name = "mnuSuaChua";
            mnuSuaChua.Text = "Sửa chữa";
            //
            // mnuThoat
            //
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(0, 102, 153);
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Controls.Add(lblSinhVien);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 24);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 70);
            pnlHeader.TabIndex = 1;
            //
            // lblTieuDe
            //
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(20, 8);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Text = "GARAGE Ô TÔ - QUẢN LÝ SỬA CHỮA && BẢO DƯỠNG";
            //
            // lblSinhVien
            //
            lblSinhVien.AutoSize = true;
            lblSinhVien.ForeColor = Color.Gainsboro;
            lblSinhVien.Location = new Point(23, 44);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Text = "Sinh viên: Vương Thanh Thúy  |  MSV: 24810310270  |  Lớp: D19CNPM3";
            //
            // pnlSoXe
            //
            pnlSoXe.BackColor = Color.SteelBlue;
            pnlSoXe.Controls.Add(lblSoXeTitle);
            pnlSoXe.Controls.Add(lblSoXe);
            pnlSoXe.Location = new Point(24, 112);
            pnlSoXe.Name = "pnlSoXe";
            pnlSoXe.Size = new Size(204, 86);
            pnlSoXe.TabIndex = 2;
            //
            // lblSoXeTitle
            //
            lblSoXeTitle.AutoSize = true;
            lblSoXeTitle.ForeColor = Color.White;
            lblSoXeTitle.Location = new Point(12, 10);
            lblSoXeTitle.Name = "lblSoXeTitle";
            lblSoXeTitle.Text = "Số xe đã tiếp nhận";
            //
            // lblSoXe
            //
            lblSoXe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSoXe.ForeColor = Color.White;
            lblSoXe.Location = new Point(10, 36);
            lblSoXe.Name = "lblSoXe";
            lblSoXe.Size = new Size(186, 34);
            lblSoXe.Text = "...";
            //
            // pnlChoThanhToan
            //
            pnlChoThanhToan.BackColor = Color.DarkOrange;
            pnlChoThanhToan.Controls.Add(lblChoThanhToanTitle);
            pnlChoThanhToan.Controls.Add(lblChoThanhToan);
            pnlChoThanhToan.Location = new Point(240, 112);
            pnlChoThanhToan.Name = "pnlChoThanhToan";
            pnlChoThanhToan.Size = new Size(204, 86);
            pnlChoThanhToan.TabIndex = 3;
            //
            // lblChoThanhToanTitle
            //
            lblChoThanhToanTitle.AutoSize = true;
            lblChoThanhToanTitle.ForeColor = Color.White;
            lblChoThanhToanTitle.Location = new Point(12, 10);
            lblChoThanhToanTitle.Name = "lblChoThanhToanTitle";
            lblChoThanhToanTitle.Text = "Phiếu chưa thanh toán";
            //
            // lblChoThanhToan
            //
            lblChoThanhToan.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblChoThanhToan.ForeColor = Color.White;
            lblChoThanhToan.Location = new Point(10, 36);
            lblChoThanhToan.Name = "lblChoThanhToan";
            lblChoThanhToan.Size = new Size(186, 34);
            lblChoThanhToan.Text = "...";
            //
            // pnlDoanhThu
            //
            pnlDoanhThu.BackColor = Color.SeaGreen;
            pnlDoanhThu.Controls.Add(lblDoanhThuTitle);
            pnlDoanhThu.Controls.Add(lblDoanhThu);
            pnlDoanhThu.Location = new Point(456, 112);
            pnlDoanhThu.Name = "pnlDoanhThu";
            pnlDoanhThu.Size = new Size(204, 86);
            pnlDoanhThu.TabIndex = 4;
            //
            // lblDoanhThuTitle
            //
            lblDoanhThuTitle.AutoSize = true;
            lblDoanhThuTitle.ForeColor = Color.White;
            lblDoanhThuTitle.Location = new Point(12, 10);
            lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            lblDoanhThuTitle.Text = "Doanh thu tháng này";
            //
            // lblDoanhThu
            //
            lblDoanhThu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDoanhThu.ForeColor = Color.White;
            lblDoanhThu.Location = new Point(10, 36);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(186, 34);
            lblDoanhThu.Text = "...";
            //
            // pnlSapHet
            //
            pnlSapHet.BackColor = Color.IndianRed;
            pnlSapHet.Controls.Add(lblSapHetTitle);
            pnlSapHet.Controls.Add(lblSapHet);
            pnlSapHet.Location = new Point(672, 112);
            pnlSapHet.Name = "pnlSapHet";
            pnlSapHet.Size = new Size(204, 86);
            pnlSapHet.TabIndex = 5;
            //
            // lblSapHetTitle
            //
            lblSapHetTitle.AutoSize = true;
            lblSapHetTitle.ForeColor = Color.White;
            lblSapHetTitle.Location = new Point(12, 10);
            lblSapHetTitle.Name = "lblSapHetTitle";
            lblSapHetTitle.Text = "Phụ tùng sắp hết (< 5)";
            //
            // lblSapHet
            //
            lblSapHet.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSapHet.ForeColor = Color.White;
            lblSapHet.Location = new Point(10, 36);
            lblSapHet.Name = "lblSapHet";
            lblSapHet.Size = new Size(186, 34);
            lblSapHet.Text = "...";
            //
            // btnTiepNhan
            //
            btnTiepNhan.BackColor = Color.FromArgb(0, 102, 153);
            btnTiepNhan.FlatStyle = FlatStyle.Flat;
            btnTiepNhan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTiepNhan.ForeColor = Color.White;
            btnTiepNhan.Location = new Point(24, 224);
            btnTiepNhan.Name = "btnTiepNhan";
            btnTiepNhan.Size = new Size(204, 104);
            btnTiepNhan.TabIndex = 10;
            btnTiepNhan.Text = "Tiếp nhận xe";
            btnTiepNhan.UseVisualStyleBackColor = false;
            btnTiepNhan.Click += btnTiepNhan_Click;
            //
            // btnLapPhieu
            //
            btnLapPhieu.BackColor = Color.SeaGreen;
            btnLapPhieu.FlatStyle = FlatStyle.Flat;
            btnLapPhieu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.Location = new Point(240, 224);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(204, 104);
            btnLapPhieu.TabIndex = 11;
            btnLapPhieu.Text = "LẬP PHIẾU SỬA";
            btnLapPhieu.UseVisualStyleBackColor = false;
            btnLapPhieu.Click += btnLapPhieu_Click;
            //
            // btnThanhToan
            //
            btnThanhToan.BackColor = Color.DarkOrange;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(456, 224);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(204, 104);
            btnThanhToan.TabIndex = 12;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            //
            // btnPhuTung
            //
            btnPhuTung.BackColor = Color.FromArgb(0, 102, 153);
            btnPhuTung.FlatStyle = FlatStyle.Flat;
            btnPhuTung.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPhuTung.ForeColor = Color.White;
            btnPhuTung.Location = new Point(672, 224);
            btnPhuTung.Name = "btnPhuTung";
            btnPhuTung.Size = new Size(204, 104);
            btnPhuTung.TabIndex = 13;
            btnPhuTung.Text = "Phụ tùng";
            btnPhuTung.UseVisualStyleBackColor = false;
            btnPhuTung.Click += btnPhuTung_Click;
            //
            // lblHuongDan
            //
            lblHuongDan.ForeColor = Color.DimGray;
            lblHuongDan.Location = new Point(24, 344);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(852, 44);
            lblHuongDan.Text = "Quy trình: 1) Tiếp nhận xe (tra biển số, xe mới thì nhập chủ xe)  ->  2) Lập phiếu sửa chữa, thêm phụ tùng  ->  3) Hoàn tất phiếu (trừ kho)  ->  4) Thanh toán và xuất hóa đơn.";
            //
            // statusStrip1
            //
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblKetNoi });
            statusStrip1.Location = new Point(0, 398);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 22);
            statusStrip1.TabIndex = 20;
            //
            // lblKetNoi
            //
            lblKetNoi.Name = "lblKetNoi";
            lblKetNoi.Text = "Đang kết nối CSDL...";
            //
            // FormMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 420);
            Controls.Add(pnlSoXe);
            Controls.Add(pnlChoThanhToan);
            Controls.Add(pnlDoanhThu);
            Controls.Add(pnlSapHet);
            Controls.Add(btnTiepNhan);
            Controls.Add(btnLapPhieu);
            Controls.Add(btnThanhToan);
            Controls.Add(btnPhuTung);
            Controls.Add(lblHuongDan);
            Controls.Add(pnlHeader);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Garage & Bảo dưỡng ô tô";
            Activated += FormMain_Activated;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTiepNhan;
        private ToolStripMenuItem mnuKho;
        private ToolStripMenuItem mnuSuaChua;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuXe;
        private ToolStripMenuItem mnuPhuTung;
        private ToolStripMenuItem mnuLapPhieu;
        private ToolStripMenuItem mnuThanhToan;
        private Panel pnlHeader;
        private Label lblTieuDe;
        private Label lblSinhVien;
        private Panel pnlSoXe;
        private Label lblSoXeTitle;
        private Label lblSoXe;
        private Panel pnlChoThanhToan;
        private Label lblChoThanhToanTitle;
        private Label lblChoThanhToan;
        private Panel pnlDoanhThu;
        private Label lblDoanhThuTitle;
        private Label lblDoanhThu;
        private Panel pnlSapHet;
        private Label lblSapHetTitle;
        private Label lblSapHet;
        private Button btnTiepNhan;
        private Button btnLapPhieu;
        private Button btnThanhToan;
        private Button btnPhuTung;
        private Label lblHuongDan;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblKetNoi;
    }
}
