namespace QuanLyKaraoke.GUI
{
    partial class FormBaoCao
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
            grpDoanhThu = new GroupBox();
            lblNgay = new Label();
            dtpNgay = new DateTimePicker();
            lblDoanhThuNgay = new Label();
            lblDoanhThuThang = new Label();
            grpHoaDon = new GroupBox();
            dgvHoaDon = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colGioVao = new DataGridViewTextBoxColumn();
            colGioRa = new DataGridViewTextBoxColumn();
            colTienPhong = new DataGridViewTextBoxColumn();
            colTienDV = new DataGridViewTextBoxColumn();
            colTongCong = new DataGridViewTextBoxColumn();
            grpTop = new GroupBox();
            lsvTop = new ListView();
            chTen = new ColumnHeader();
            chSL = new ColumnHeader();
            chTien = new ColumnHeader();
            grpDoanhThu.SuspendLayout();
            grpHoaDon.SuspendLayout();
            grpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            //
            // grpDoanhThu
            //
            grpDoanhThu.Controls.Add(lblNgay);
            grpDoanhThu.Controls.Add(dtpNgay);
            grpDoanhThu.Controls.Add(lblDoanhThuNgay);
            grpDoanhThu.Controls.Add(lblDoanhThuThang);
            grpDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDoanhThu.Location = new Point(12, 10);
            grpDoanhThu.Name = "grpDoanhThu";
            grpDoanhThu.Size = new Size(956, 70);
            grpDoanhThu.TabStop = false;
            grpDoanhThu.Text = "Doanh thu (ExecuteScalar)";
            //
            // lblNgay
            //
            lblNgay.Location = new Point(14, 32);
            lblNgay.Name = "lblNgay";
            lblNgay.AutoSize = true;
            lblNgay.Text = "Ngày:";
            //
            // dtpNgay
            //
            dtpNgay.Location = new Point(58, 28);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(120, 23);
            dtpNgay.CustomFormat = "dd/MM/yyyy";
            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.ValueChanged += dtpNgay_ValueChanged;
            //
            // lblDoanhThuNgay
            //
            lblDoanhThuNgay.Location = new Point(196, 30);
            lblDoanhThuNgay.Name = "lblDoanhThuNgay";
            lblDoanhThuNgay.Size = new Size(380, 22);
            lblDoanhThuNgay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoanhThuNgay.ForeColor = Color.DarkGreen;
            lblDoanhThuNgay.Text = "Doanh thu ngày: 0 đ";
            //
            // lblDoanhThuThang
            //
            lblDoanhThuThang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDoanhThuThang.Location = new Point(584, 30);
            lblDoanhThuThang.Name = "lblDoanhThuThang";
            lblDoanhThuThang.Size = new Size(360, 22);
            lblDoanhThuThang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoanhThuThang.ForeColor = Color.SteelBlue;
            lblDoanhThuThang.Text = "Doanh thu tháng: 0 đ";
            //
            // grpHoaDon
            //
            grpHoaDon.Controls.Add(dgvHoaDon);
            grpHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpHoaDon.Location = new Point(12, 90);
            grpHoaDon.Name = "grpHoaDon";
            grpHoaDon.Size = new Size(610, 400);
            grpHoaDon.TabStop = false;
            grpHoaDon.Text = "Hóa đơn đã thanh toán trong ngày";
            //
            // dgvHoaDon
            //
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colTenPhong, colGioVao, colGioRa, colTienPhong, colTienDV, colTongCong });
            dgvHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDon.Location = new Point(12, 24);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.Size = new Size(586, 362);
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.ReadOnly = true;
            //
            // colMaHD
            //
            colMaHD.Name = "colMaHD";
            colMaHD.DataPropertyName = "MaHD";
            colMaHD.FillWeight = 9F;
            colMaHD.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaHD.ReadOnly = true;
            colMaHD.HeaderText = "Mã HĐ";
            //
            // colTenPhong
            //
            colTenPhong.Name = "colTenPhong";
            colTenPhong.DataPropertyName = "TenPhong";
            colTenPhong.FillWeight = 20F;
            colTenPhong.ReadOnly = true;
            colTenPhong.HeaderText = "Phòng";
            //
            // colGioVao
            //
            colGioVao.Name = "colGioVao";
            colGioVao.DataPropertyName = "GioVao";
            colGioVao.FillWeight = 12F;
            colGioVao.DefaultCellStyle.Format = "HH:mm";
            colGioVao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colGioVao.ReadOnly = true;
            colGioVao.HeaderText = "Giờ vào";
            //
            // colGioRa
            //
            colGioRa.Name = "colGioRa";
            colGioRa.DataPropertyName = "GioRa";
            colGioRa.FillWeight = 12F;
            colGioRa.DefaultCellStyle.Format = "HH:mm";
            colGioRa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colGioRa.ReadOnly = true;
            colGioRa.HeaderText = "Giờ ra";
            //
            // colTienPhong
            //
            colTienPhong.Name = "colTienPhong";
            colTienPhong.DataPropertyName = "TongTienPhong";
            colTienPhong.FillWeight = 15F;
            colTienPhong.DefaultCellStyle.Format = "N0";
            colTienPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTienPhong.ReadOnly = true;
            colTienPhong.HeaderText = "Tiền phòng";
            //
            // colTienDV
            //
            colTienDV.Name = "colTienDV";
            colTienDV.DataPropertyName = "TongTienDichVu";
            colTienDV.FillWeight = 15F;
            colTienDV.DefaultCellStyle.Format = "N0";
            colTienDV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTienDV.ReadOnly = true;
            colTienDV.HeaderText = "Tiền DV";
            //
            // colTongCong
            //
            colTongCong.Name = "colTongCong";
            colTongCong.DataPropertyName = "TongCong";
            colTongCong.FillWeight = 17F;
            colTongCong.DefaultCellStyle.Format = "N0";
            colTongCong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTongCong.ReadOnly = true;
            colTongCong.HeaderText = "Tổng";
            //
            // grpTop
            //
            grpTop.Controls.Add(lsvTop);
            grpTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpTop.Location = new Point(634, 90);
            grpTop.Name = "grpTop";
            grpTop.Size = new Size(334, 400);
            grpTop.TabStop = false;
            grpTop.Text = "Top 5 dịch vụ bán chạy (SqlDataReader)";
            //
            // lsvTop
            //
            lsvTop.Columns.AddRange(new ColumnHeader[] { chTen, chSL, chTien });
            lsvTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvTop.Location = new Point(12, 24);
            lsvTop.Name = "lsvTop";
            lsvTop.Size = new Size(310, 362);
            lsvTop.FullRowSelect = true;
            lsvTop.GridLines = true;
            lsvTop.UseCompatibleStateImageBehavior = false;
            lsvTop.View = View.Details;
            lsvTop.MultiSelect = false;
            //
            // chTen
            //
            chTen.Width = 140;
            chTen.Text = "Dịch vụ";
            //
            // chSL
            //
            chSL.Width = 50;
            chSL.TextAlign = HorizontalAlignment.Center;
            chSL.Text = "SL";
            //
            // chTien
            //
            chTien.Width = 100;
            chTien.TextAlign = HorizontalAlignment.Right;
            chTien.Text = "Doanh thu";
            //
            // FormBaoCao
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 502);
            Controls.Add(grpDoanhThu);
            Controls.Add(grpHoaDon);
            Controls.Add(grpTop);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(996, 480);
            Name = "FormBaoCao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Báo cáo doanh thu Karaoke";
            Load += FormBaoCao_Load;
            grpDoanhThu.ResumeLayout(false);
            grpDoanhThu.PerformLayout();
            grpHoaDon.ResumeLayout(false);
            grpHoaDon.PerformLayout();
            grpTop.ResumeLayout(false);
            grpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDoanhThu;
        private Label lblNgay;
        private DateTimePicker dtpNgay;
        private Label lblDoanhThuNgay;
        private Label lblDoanhThuThang;
        private GroupBox grpHoaDon;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colGioVao;
        private DataGridViewTextBoxColumn colGioRa;
        private DataGridViewTextBoxColumn colTienPhong;
        private DataGridViewTextBoxColumn colTienDV;
        private DataGridViewTextBoxColumn colTongCong;
        private GroupBox grpTop;
        private ListView lsvTop;
        private ColumnHeader chTen;
        private ColumnHeader chSL;
        private ColumnHeader chTien;
    }
}
