namespace QuanLyGarage.GUI
{
    partial class FormTiepNhan
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
            grpTraCuu = new GroupBox();
            lblTra = new Label();
            txtBienSoTra = new TextBox();
            btnTraCuu = new Button();
            lblKetQua = new Label();
            grpXe = new GroupBox();
            lblBienSo = new Label();
            txtBienSo = new TextBox();
            lblHieuXe = new Label();
            cboHieuXe = new ComboBox();
            lblNamSX = new Label();
            nudNamSX = new NumericUpDown();
            grpChuXe = new GroupBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            btnTimChu = new Button();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblLoaiChu = new Label();
            btnLuuXe = new Button();
            btnLamMoi = new Button();
            btnLapPhieu = new Button();
            dgvXe = new DataGridView();
            colBienSo = new DataGridViewTextBoxColumn();
            colHieuXe = new DataGridViewTextBoxColumn();
            colNamSX = new DataGridViewTextBoxColumn();
            colTenKH = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            grpTraCuu.SuspendLayout();
            grpXe.SuspendLayout();
            grpChuXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNamSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvXe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpTraCuu
            //
            grpTraCuu.Controls.Add(lblTra);
            grpTraCuu.Controls.Add(txtBienSoTra);
            grpTraCuu.Controls.Add(btnTraCuu);
            grpTraCuu.Controls.Add(lblKetQua);
            grpTraCuu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTraCuu.Location = new Point(12, 10);
            grpTraCuu.Name = "grpTraCuu";
            grpTraCuu.Size = new Size(936, 64);
            grpTraCuu.TabStop = false;
            grpTraCuu.Text = "Tra cứu biển số xe";
            //
            // lblTra
            //
            lblTra.Location = new Point(14, 30);
            lblTra.Name = "lblTra";
            lblTra.AutoSize = true;
            lblTra.Text = "Biển số:";
            //
            // txtBienSoTra
            //
            txtBienSoTra.Location = new Point(72, 26);
            txtBienSoTra.Name = "txtBienSoTra";
            txtBienSoTra.Size = new Size(170, 23);
            txtBienSoTra.CharacterCasing = CharacterCasing.Upper;
            txtBienSoTra.TextChanged += txtBienSoTra_TextChanged;
            txtBienSoTra.KeyDown += txtBienSoTra_KeyDown;
            //
            // btnTraCuu
            //
            btnTraCuu.Location = new Point(250, 24);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(100, 28);
            btnTraCuu.Text = "Tra cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            //
            // lblKetQua
            //
            lblKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblKetQua.Location = new Point(364, 30);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(560, 20);
            lblKetQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKetQua.ForeColor = Color.SteelBlue;
            lblKetQua.Text = "Nhập biển số rồi bấm Tra cứu (ví dụ 51H-123.45).";
            //
            // grpXe
            //
            grpXe.Controls.Add(lblBienSo);
            grpXe.Controls.Add(txtBienSo);
            grpXe.Controls.Add(lblHieuXe);
            grpXe.Controls.Add(cboHieuXe);
            grpXe.Controls.Add(lblNamSX);
            grpXe.Controls.Add(nudNamSX);
            grpXe.Location = new Point(12, 84);
            grpXe.Name = "grpXe";
            grpXe.Size = new Size(460, 170);
            grpXe.TabStop = false;
            grpXe.Text = "Thông tin xe";
            //
            // lblBienSo
            //
            lblBienSo.Location = new Point(14, 32);
            lblBienSo.Name = "lblBienSo";
            lblBienSo.AutoSize = true;
            lblBienSo.Text = "Biển số:";
            //
            // txtBienSo
            //
            txtBienSo.Location = new Point(110, 28);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(180, 23);
            txtBienSo.CharacterCasing = CharacterCasing.Upper;
            txtBienSo.MaxLength = 20;
            //
            // lblHieuXe
            //
            lblHieuXe.Location = new Point(14, 66);
            lblHieuXe.Name = "lblHieuXe";
            lblHieuXe.AutoSize = true;
            lblHieuXe.Text = "Hiệu xe:";
            //
            // cboHieuXe
            //
            cboHieuXe.Items.AddRange(new object[] { "Toyota", "Honda", "Hyundai", "Kia", "Mazda", "Ford", "Mitsubishi", "VinFast", "Mercedes-Benz", "Khác" });
            cboHieuXe.Location = new Point(110, 62);
            cboHieuXe.Name = "cboHieuXe";
            cboHieuXe.Size = new Size(180, 23);
            //
            // lblNamSX
            //
            lblNamSX.Location = new Point(14, 100);
            lblNamSX.Name = "lblNamSX";
            lblNamSX.AutoSize = true;
            lblNamSX.Text = "Năm sản xuất:";
            //
            // nudNamSX
            //
            nudNamSX.Location = new Point(110, 96);
            nudNamSX.Name = "nudNamSX";
            nudNamSX.Size = new Size(90, 23);
            nudNamSX.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudNamSX.TextAlign = HorizontalAlignment.Right;
            nudNamSX.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            nudNamSX.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            //
            // grpChuXe
            //
            grpChuXe.Controls.Add(lblDienThoai);
            grpChuXe.Controls.Add(txtDienThoai);
            grpChuXe.Controls.Add(btnTimChu);
            grpChuXe.Controls.Add(lblTenKH);
            grpChuXe.Controls.Add(txtTenKH);
            grpChuXe.Controls.Add(lblDiaChi);
            grpChuXe.Controls.Add(txtDiaChi);
            grpChuXe.Controls.Add(lblLoaiChu);
            grpChuXe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpChuXe.Location = new Point(484, 84);
            grpChuXe.Name = "grpChuXe";
            grpChuXe.Size = new Size(464, 170);
            grpChuXe.TabStop = false;
            grpChuXe.Text = "Thông tin chủ xe";
            //
            // lblDienThoai
            //
            lblDienThoai.Location = new Point(14, 32);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.AutoSize = true;
            lblDienThoai.Text = "Điện thoại:";
            //
            // txtDienThoai
            //
            txtDienThoai.Location = new Point(100, 28);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(160, 23);
            txtDienThoai.MaxLength = 15;
            //
            // btnTimChu
            //
            btnTimChu.Location = new Point(268, 26);
            btnTimChu.Name = "btnTimChu";
            btnTimChu.Size = new Size(180, 27);
            btnTimChu.Text = "Tìm chủ xe cũ theo SĐT";
            btnTimChu.UseVisualStyleBackColor = true;
            btnTimChu.Click += btnTimChu_Click;
            //
            // lblTenKH
            //
            lblTenKH.Location = new Point(14, 66);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.AutoSize = true;
            lblTenKH.Text = "Tên chủ xe:";
            //
            // txtTenKH
            //
            txtTenKH.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKH.Location = new Point(100, 62);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(348, 23);
            //
            // lblDiaChi
            //
            lblDiaChi.Location = new Point(14, 100);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.AutoSize = true;
            lblDiaChi.Text = "Địa chỉ:";
            //
            // txtDiaChi
            //
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Location = new Point(100, 96);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(348, 23);
            //
            // lblLoaiChu
            //
            lblLoaiChu.Location = new Point(100, 130);
            lblLoaiChu.Name = "lblLoaiChu";
            lblLoaiChu.Size = new Size(348, 20);
            lblLoaiChu.ForeColor = Color.DimGray;
            lblLoaiChu.Text = "";
            //
            // btnLuuXe
            //
            btnLuuXe.Location = new Point(12, 264);
            btnLuuXe.Name = "btnLuuXe";
            btnLuuXe.Size = new Size(170, 34);
            btnLuuXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuuXe.Text = "Lưu xe / chủ xe";
            btnLuuXe.UseVisualStyleBackColor = true;
            btnLuuXe.Click += btnLuuXe_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Location = new Point(190, 264);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 34);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // btnLapPhieu
            //
            btnLapPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLapPhieu.Location = new Point(718, 264);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(230, 34);
            btnLapPhieu.BackColor = Color.SeaGreen;
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.FlatStyle = FlatStyle.Flat;
            btnLapPhieu.UseVisualStyleBackColor = false;
            btnLapPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLapPhieu.Text = "Lập phiếu sửa chữa ▶";
            btnLapPhieu.Click += btnLapPhieu_Click;
            //
            // dgvXe
            //
            dgvXe.Columns.AddRange(new DataGridViewColumn[] { colBienSo, colHieuXe, colNamSX, colTenKH, colDienThoai, colDiaChi });
            dgvXe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvXe.Location = new Point(12, 308);
            dgvXe.Name = "dgvXe";
            dgvXe.Size = new Size(936, 280);
            dgvXe.AllowUserToAddRows = false;
            dgvXe.AllowUserToDeleteRows = false;
            dgvXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXe.BackgroundColor = Color.White;
            dgvXe.MultiSelect = false;
            dgvXe.RowHeadersVisible = false;
            dgvXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXe.ReadOnly = true;
            dgvXe.CellClick += dgvXe_CellClick;
            //
            // colBienSo
            //
            colBienSo.Name = "colBienSo";
            colBienSo.DataPropertyName = "BienSo";
            colBienSo.FillWeight = 14F;
            colBienSo.ReadOnly = true;
            colBienSo.HeaderText = "Biển số";
            //
            // colHieuXe
            //
            colHieuXe.Name = "colHieuXe";
            colHieuXe.DataPropertyName = "HieuXe";
            colHieuXe.FillWeight = 12F;
            colHieuXe.ReadOnly = true;
            colHieuXe.HeaderText = "Hiệu xe";
            //
            // colNamSX
            //
            colNamSX.Name = "colNamSX";
            colNamSX.DataPropertyName = "NamSanXuat";
            colNamSX.FillWeight = 8F;
            colNamSX.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNamSX.ReadOnly = true;
            colNamSX.HeaderText = "Năm SX";
            //
            // colTenKH
            //
            colTenKH.Name = "colTenKH";
            colTenKH.DataPropertyName = "TenKH";
            colTenKH.FillWeight = 22F;
            colTenKH.ReadOnly = true;
            colTenKH.HeaderText = "Chủ xe";
            //
            // colDienThoai
            //
            colDienThoai.Name = "colDienThoai";
            colDienThoai.DataPropertyName = "DienThoai";
            colDienThoai.FillWeight = 13F;
            colDienThoai.ReadOnly = true;
            colDienThoai.HeaderText = "Điện thoại";
            //
            // colDiaChi
            //
            colDiaChi.Name = "colDiaChi";
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.FillWeight = 31F;
            colDiaChi.ReadOnly = true;
            colDiaChi.HeaderText = "Địa chỉ";
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // FormTiepNhan
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 600);
            Controls.Add(grpTraCuu);
            Controls.Add(grpXe);
            Controls.Add(grpChuXe);
            Controls.Add(btnLuuXe);
            Controls.Add(btnLamMoi);
            Controls.Add(btnLapPhieu);
            Controls.Add(dgvXe);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(976, 560);
            Name = "FormTiepNhan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tiếp nhận xe & Quản lý chủ xe";
            Load += FormTiepNhan_Load;
            grpTraCuu.ResumeLayout(false);
            grpTraCuu.PerformLayout();
            grpXe.ResumeLayout(false);
            grpXe.PerformLayout();
            grpChuXe.ResumeLayout(false);
            grpChuXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNamSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvXe).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTraCuu;
        private Label lblTra;
        private TextBox txtBienSoTra;
        private Button btnTraCuu;
        private Label lblKetQua;
        private GroupBox grpXe;
        private Label lblBienSo;
        private TextBox txtBienSo;
        private Label lblHieuXe;
        private ComboBox cboHieuXe;
        private Label lblNamSX;
        private NumericUpDown nudNamSX;
        private GroupBox grpChuXe;
        private Label lblDienThoai;
        private TextBox txtDienThoai;
        private Button btnTimChu;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblLoaiChu;
        private Button btnLuuXe;
        private Button btnLamMoi;
        private Button btnLapPhieu;
        private DataGridView dgvXe;
        private DataGridViewTextBoxColumn colBienSo;
        private DataGridViewTextBoxColumn colHieuXe;
        private DataGridViewTextBoxColumn colNamSX;
        private DataGridViewTextBoxColumn colTenKH;
        private DataGridViewTextBoxColumn colDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private ErrorProvider errorProvider1;
    }
}
