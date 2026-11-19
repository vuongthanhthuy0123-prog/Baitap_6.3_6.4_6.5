namespace QuanLyDuAn.GUI
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
            grpTreHan = new GroupBox();
            lsvTreHan = new ListView();
            chMa = new ColumnHeader();
            chTen = new ColumnHeader();
            chDuAn = new ColumnHeader();
            chHan = new ColumnHeader();
            chTre = new ColumnHeader();
            chTrangThai = new ColumnHeader();
            chNguoi = new ColumnHeader();
            grpTienDo = new GroupBox();
            lblDuAn = new Label();
            cboDuAn = new ComboBox();
            lblTyLeDuAn = new Label();
            btnLamMoi = new Button();
            dgvTienDo = new DataGridView();
            colHoTen = new DataGridViewTextBoxColumn();
            colTongTask = new DataGridViewTextBoxColumn();
            colSoDone = new DataGridViewTextBoxColumn();
            colSoChuaXong = new DataGridViewTextBoxColumn();
            colTyLe = new DataGridViewTextBoxColumn();
            colBieuDo = new DataGridViewTextBoxColumn();
            grpTreHan.SuspendLayout();
            grpTienDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTienDo).BeginInit();
            SuspendLayout();
            //
            // grpTreHan
            //
            grpTreHan.Controls.Add(lsvTreHan);
            grpTreHan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTreHan.Location = new Point(12, 10);
            grpTreHan.Name = "grpTreHan";
            grpTreHan.Size = new Size(956, 250);
            grpTreHan.ForeColor = Color.Firebrick;
            grpTreHan.TabStop = false;
            grpTreHan.Text = "Cảnh báo: công việc đã quá hạn nộp mà chưa Done (SqlDataReader)";
            //
            // lsvTreHan
            //
            lsvTreHan.Columns.AddRange(new ColumnHeader[] { chMa, chTen, chDuAn, chHan, chTre, chTrangThai, chNguoi });
            lsvTreHan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsvTreHan.Location = new Point(12, 24);
            lsvTreHan.Name = "lsvTreHan";
            lsvTreHan.Size = new Size(932, 214);
            lsvTreHan.FullRowSelect = true;
            lsvTreHan.GridLines = true;
            lsvTreHan.UseCompatibleStateImageBehavior = false;
            lsvTreHan.View = View.Details;
            lsvTreHan.MultiSelect = false;
            lsvTreHan.ForeColor = Color.Black;
            //
            // chMa
            //
            chMa.Width = 50;
            chMa.TextAlign = HorizontalAlignment.Center;
            chMa.Text = "Mã";
            //
            // chTen
            //
            chTen.Width = 230;
            chTen.Text = "Tên công việc";
            //
            // chDuAn
            //
            chDuAn.Width = 190;
            chDuAn.Text = "Dự án";
            //
            // chHan
            //
            chHan.Width = 90;
            chHan.TextAlign = HorizontalAlignment.Center;
            chHan.Text = "Hạn nộp";
            //
            // chTre
            //
            chTre.Width = 75;
            chTre.TextAlign = HorizontalAlignment.Center;
            chTre.Text = "Trễ (ngày)";
            //
            // chTrangThai
            //
            chTrangThai.Width = 90;
            chTrangThai.TextAlign = HorizontalAlignment.Center;
            chTrangThai.Text = "Trạng thái";
            //
            // chNguoi
            //
            chNguoi.Width = 180;
            chNguoi.Text = "Người thực hiện";
            //
            // grpTienDo
            //
            grpTienDo.Controls.Add(lblDuAn);
            grpTienDo.Controls.Add(cboDuAn);
            grpTienDo.Controls.Add(lblTyLeDuAn);
            grpTienDo.Controls.Add(btnLamMoi);
            grpTienDo.Controls.Add(dgvTienDo);
            grpTienDo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpTienDo.Location = new Point(12, 270);
            grpTienDo.Name = "grpTienDo";
            grpTienDo.Size = new Size(956, 282);
            grpTienDo.TabStop = false;
            grpTienDo.Text = "Tỷ lệ hoàn thành công việc của từng thành viên (GROUP BY)";
            //
            // lblDuAn
            //
            lblDuAn.Location = new Point(14, 30);
            lblDuAn.Name = "lblDuAn";
            lblDuAn.AutoSize = true;
            lblDuAn.Text = "Dự án:";
            //
            // cboDuAn
            //
            cboDuAn.Location = new Point(64, 26);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(280, 23);
            cboDuAn.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDuAn.SelectionChangeCommitted += cboDuAn_SelectionChangeCommitted;
            //
            // lblTyLeDuAn
            //
            lblTyLeDuAn.Location = new Point(360, 28);
            lblTyLeDuAn.Name = "lblTyLeDuAn";
            lblTyLeDuAn.Size = new Size(460, 20);
            lblTyLeDuAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTyLeDuAn.ForeColor = Color.SeaGreen;
            lblTyLeDuAn.Text = "Hoàn thành: 0%";
            //
            // btnLamMoi
            //
            btnLamMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLamMoi.Location = new Point(836, 24);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(108, 28);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // dgvTienDo
            //
            dgvTienDo.Columns.AddRange(new DataGridViewColumn[] { colHoTen, colTongTask, colSoDone, colSoChuaXong, colTyLe, colBieuDo });
            dgvTienDo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTienDo.Location = new Point(12, 62);
            dgvTienDo.Name = "dgvTienDo";
            dgvTienDo.Size = new Size(932, 208);
            dgvTienDo.AllowUserToAddRows = false;
            dgvTienDo.AllowUserToDeleteRows = false;
            dgvTienDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTienDo.BackgroundColor = Color.White;
            dgvTienDo.MultiSelect = false;
            dgvTienDo.RowHeadersVisible = false;
            dgvTienDo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTienDo.ReadOnly = true;
            //
            // colHoTen
            //
            colHoTen.Name = "colHoTen";
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 24F;
            colHoTen.ReadOnly = true;
            colHoTen.HeaderText = "Thành viên";
            //
            // colTongTask
            //
            colTongTask.Name = "colTongTask";
            colTongTask.DataPropertyName = "TongTask";
            colTongTask.FillWeight = 11F;
            colTongTask.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTongTask.ReadOnly = true;
            colTongTask.HeaderText = "Được giao";
            //
            // colSoDone
            //
            colSoDone.Name = "colSoDone";
            colSoDone.DataPropertyName = "SoDone";
            colSoDone.FillWeight = 11F;
            colSoDone.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoDone.ReadOnly = true;
            colSoDone.HeaderText = "Đã xong";
            //
            // colSoChuaXong
            //
            colSoChuaXong.Name = "colSoChuaXong";
            colSoChuaXong.DataPropertyName = "SoChuaXong";
            colSoChuaXong.FillWeight = 11F;
            colSoChuaXong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSoChuaXong.ReadOnly = true;
            colSoChuaXong.HeaderText = "Chưa xong";
            //
            // colTyLe
            //
            colTyLe.Name = "colTyLe";
            colTyLe.DataPropertyName = "TyLe";
            colTyLe.FillWeight = 12F;
            colTyLe.DefaultCellStyle.Format = "0.0";
            colTyLe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTyLe.ReadOnly = true;
            colTyLe.HeaderText = "% hoàn thành";
            //
            // colBieuDo
            //
            colBieuDo.Name = "colBieuDo";
            colBieuDo.DataPropertyName = "BieuDo";
            colBieuDo.FillWeight = 20F;
            colBieuDo.ReadOnly = true;
            colBieuDo.HeaderText = "Biểu đồ";
            //
            // FormBaoCao
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 564);
            Controls.Add(grpTreHan);
            Controls.Add(grpTienDo);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(996, 520);
            Name = "FormBaoCao";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cảnh báo trễ hạn & Báo cáo tiến độ";
            Load += FormBaoCao_Load;
            grpTreHan.ResumeLayout(false);
            grpTreHan.PerformLayout();
            grpTienDo.ResumeLayout(false);
            grpTienDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTienDo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpTreHan;
        private ListView lsvTreHan;
        private ColumnHeader chMa;
        private ColumnHeader chTen;
        private ColumnHeader chDuAn;
        private ColumnHeader chHan;
        private ColumnHeader chTre;
        private ColumnHeader chTrangThai;
        private ColumnHeader chNguoi;
        private GroupBox grpTienDo;
        private Label lblDuAn;
        private ComboBox cboDuAn;
        private Label lblTyLeDuAn;
        private Button btnLamMoi;
        private DataGridView dgvTienDo;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colTongTask;
        private DataGridViewTextBoxColumn colSoDone;
        private DataGridViewTextBoxColumn colSoChuaXong;
        private DataGridViewTextBoxColumn colTyLe;
        private DataGridViewTextBoxColumn colBieuDo;
    }
}
