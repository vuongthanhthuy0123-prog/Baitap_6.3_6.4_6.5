namespace QuanLyDuAn.GUI
{
    partial class FormCongViec
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
            grpLoc = new GroupBox();
            lblLocDuAn = new Label();
            cboLocDuAn = new ComboBox();
            lblLocTrangThai = new Label();
            cboLocTrangThai = new ComboBox();
            lblTim = new Label();
            txtTimKiem = new TextBox();
            chkTreHan = new CheckBox();
            lblTongSo = new Label();
            tabView = new TabControl();
            tabList = new TabPage();
            tabKanban = new TabPage();
            dgvTask = new DataGridView();
            colMaTask = new DataGridViewTextBoxColumn();
            colTenDuAn = new DataGridViewTextBoxColumn();
            colTenTask = new DataGridViewTextBoxColumn();
            colHanNop = new DataGridViewTextBoxColumn();
            colDoUuTien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colNguoiLam = new DataGridViewTextBoxColumn();
            tlpKanban = new TableLayoutPanel();
            grpToDo = new GroupBox();
            lstToDo = new ListBox();
            grpInProgress = new GroupBox();
            lstInProgress = new ListBox();
            grpReview = new GroupBox();
            lstReview = new ListBox();
            grpDone = new GroupBox();
            lstDone = new ListBox();
            grpTask = new GroupBox();
            lblDuAn = new Label();
            cboDuAn = new ComboBox();
            lblTenTask = new Label();
            txtTenTask = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            lblHanNop = new Label();
            dtpHanNop = new DateTimePicker();
            lblUuTien = new Label();
            cboDoUuTien = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblPhanCong = new Label();
            clbThanhVien = new CheckedListBox();
            btnLuuPhanCong = new Button();
            lblChuyen = new Label();
            btnLui = new Button();
            lblTrangThaiHT = new Label();
            btnTien = new Button();
            lblChuyenSang = new Label();
            cboChuyenTrangThai = new ComboBox();
            btnChuyenTrangThai = new Button();
            lblGhiChu = new Label();
            errorProvider1 = new ErrorProvider(components);
            grpLoc.SuspendLayout();
            tabView.SuspendLayout();
            tabList.SuspendLayout();
            tabKanban.SuspendLayout();
            tlpKanban.SuspendLayout();
            grpToDo.SuspendLayout();
            grpInProgress.SuspendLayout();
            grpReview.SuspendLayout();
            grpDone.SuspendLayout();
            grpTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // grpLoc
            //
            grpLoc.Controls.Add(lblLocDuAn);
            grpLoc.Controls.Add(cboLocDuAn);
            grpLoc.Controls.Add(lblLocTrangThai);
            grpLoc.Controls.Add(cboLocTrangThai);
            grpLoc.Controls.Add(lblTim);
            grpLoc.Controls.Add(txtTimKiem);
            grpLoc.Controls.Add(chkTreHan);
            grpLoc.Controls.Add(lblTongSo);
            grpLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLoc.Location = new Point(12, 8);
            grpLoc.Name = "grpLoc";
            grpLoc.Size = new Size(1156, 58);
            grpLoc.TabStop = false;
            grpLoc.Text = "Lọc công việc";
            //
            // lblLocDuAn
            //
            lblLocDuAn.Location = new Point(14, 27);
            lblLocDuAn.Name = "lblLocDuAn";
            lblLocDuAn.AutoSize = true;
            lblLocDuAn.Text = "Dự án:";
            //
            // cboLocDuAn
            //
            cboLocDuAn.Location = new Point(64, 23);
            cboLocDuAn.Name = "cboLocDuAn";
            cboLocDuAn.Size = new Size(240, 23);
            cboLocDuAn.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocDuAn.SelectionChangeCommitted += BoLoc_Changed;
            //
            // lblLocTrangThai
            //
            lblLocTrangThai.Location = new Point(320, 27);
            lblLocTrangThai.Name = "lblLocTrangThai";
            lblLocTrangThai.AutoSize = true;
            lblLocTrangThai.Text = "Trạng thái:";
            //
            // cboLocTrangThai
            //
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "To Do", "In Progress", "Review", "Done" });
            cboLocTrangThai.Location = new Point(390, 23);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(130, 23);
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.SelectionChangeCommitted += BoLoc_Changed;
            //
            // lblTim
            //
            lblTim.Location = new Point(536, 27);
            lblTim.Name = "lblTim";
            lblTim.AutoSize = true;
            lblTim.Text = "Tên task:";
            //
            // txtTimKiem
            //
            txtTimKiem.Location = new Point(596, 23);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 23);
            txtTimKiem.TextChanged += BoLoc_Changed;
            //
            // chkTreHan
            //
            chkTreHan.Location = new Point(814, 25);
            chkTreHan.Name = "chkTreHan";
            chkTreHan.Size = new Size(170, 19);
            chkTreHan.Text = "Chỉ hiện task trễ hạn";
            chkTreHan.CheckedChanged += BoLoc_Changed;
            //
            // lblTongSo
            //
            lblTongSo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongSo.Location = new Point(1000, 27);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.AutoSize = true;
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.Text = "0 công việc";
            //
            // tabView
            //
            tabView.Controls.Add(tabList);
            tabView.Controls.Add(tabKanban);
            tabView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabView.Location = new Point(12, 74);
            tabView.Name = "tabView";
            tabView.Size = new Size(760, 606);
            //
            // tabList
            //
            tabList.Controls.Add(dgvTask);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(4);
            tabList.UseVisualStyleBackColor = true;
            tabList.Text = "Dạng danh sách (List)";
            //
            // tabKanban
            //
            tabKanban.Controls.Add(tlpKanban);
            tabKanban.Name = "tabKanban";
            tabKanban.Padding = new Padding(4);
            tabKanban.UseVisualStyleBackColor = true;
            tabKanban.Text = "Dạng bảng Kanban";
            //
            // dgvTask
            //
            dgvTask.Columns.AddRange(new DataGridViewColumn[] { colMaTask, colTenDuAn, colTenTask, colHanNop, colDoUuTien, colTrangThai, colNguoiLam });
            dgvTask.Dock = DockStyle.Fill;
            dgvTask.Location = new Point(4, 4);
            dgvTask.Name = "dgvTask";
            dgvTask.Size = new Size(744, 568);
            dgvTask.AllowUserToAddRows = false;
            dgvTask.AllowUserToDeleteRows = false;
            dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTask.BackgroundColor = Color.White;
            dgvTask.MultiSelect = false;
            dgvTask.RowHeadersVisible = false;
            dgvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTask.ReadOnly = true;
            dgvTask.CellClick += dgvTask_CellClick;
            dgvTask.CellFormatting += dgvTask_CellFormatting;
            //
            // colMaTask
            //
            colMaTask.Name = "colMaTask";
            colMaTask.DataPropertyName = "MaTask";
            colMaTask.FillWeight = 6F;
            colMaTask.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaTask.ReadOnly = true;
            colMaTask.HeaderText = "Mã";
            //
            // colTenDuAn
            //
            colTenDuAn.Name = "colTenDuAn";
            colTenDuAn.DataPropertyName = "TenDuAn";
            colTenDuAn.FillWeight = 18F;
            colTenDuAn.ReadOnly = true;
            colTenDuAn.HeaderText = "Dự án";
            //
            // colTenTask
            //
            colTenTask.Name = "colTenTask";
            colTenTask.DataPropertyName = "TenTask";
            colTenTask.FillWeight = 26F;
            colTenTask.ReadOnly = true;
            colTenTask.HeaderText = "Tên công việc";
            //
            // colHanNop
            //
            colHanNop.Name = "colHanNop";
            colHanNop.DataPropertyName = "HanNop";
            colHanNop.FillWeight = 11F;
            colHanNop.DefaultCellStyle.Format = "dd/MM/yyyy";
            colHanNop.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colHanNop.ReadOnly = true;
            colHanNop.HeaderText = "Hạn nộp";
            //
            // colDoUuTien
            //
            colDoUuTien.Name = "colDoUuTien";
            colDoUuTien.DataPropertyName = "DoUuTien";
            colDoUuTien.FillWeight = 9F;
            colDoUuTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDoUuTien.ReadOnly = true;
            colDoUuTien.HeaderText = "Ưu tiên";
            //
            // colTrangThai
            //
            colTrangThai.Name = "colTrangThai";
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 11F;
            colTrangThai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTrangThai.ReadOnly = true;
            colTrangThai.HeaderText = "Trạng thái";
            //
            // colNguoiLam
            //
            colNguoiLam.Name = "colNguoiLam";
            colNguoiLam.DataPropertyName = "NguoiLam";
            colNguoiLam.FillWeight = 19F;
            colNguoiLam.ReadOnly = true;
            colNguoiLam.HeaderText = "Người thực hiện";
            //
            // tlpKanban
            //
            tlpKanban.Controls.Add(grpToDo);
            tlpKanban.Controls.Add(grpInProgress);
            tlpKanban.Controls.Add(grpReview);
            tlpKanban.Controls.Add(grpDone);
            tlpKanban.Dock = DockStyle.Fill;
            tlpKanban.Name = "tlpKanban";
            tlpKanban.ColumnCount = 4;
            tlpKanban.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKanban.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKanban.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKanban.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKanban.RowCount = 1;
            tlpKanban.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            //
            // grpToDo
            //
            grpToDo.Controls.Add(lstToDo);
            grpToDo.Dock = DockStyle.Fill;
            grpToDo.Location = new Point(0, 0);
            grpToDo.Name = "grpToDo";
            grpToDo.Size = new Size(180, 560);
            grpToDo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpToDo.TabStop = false;
            grpToDo.Text = "TO DO";
            //
            // lstToDo
            //
            lstToDo.Dock = DockStyle.Fill;
            lstToDo.Name = "lstToDo";
            lstToDo.BackColor = Color.FromArgb(240, 240, 240);
            lstToDo.Font = new Font("Segoe UI", 9F);
            lstToDo.HorizontalScrollbar = true;
            lstToDo.IntegralHeight = false;
            lstToDo.ItemHeight = 15;
            lstToDo.SelectedIndexChanged += lstKanban_SelectedIndexChanged;
            //
            // grpInProgress
            //
            grpInProgress.Controls.Add(lstInProgress);
            grpInProgress.Dock = DockStyle.Fill;
            grpInProgress.Location = new Point(0, 0);
            grpInProgress.Name = "grpInProgress";
            grpInProgress.Size = new Size(180, 560);
            grpInProgress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInProgress.TabStop = false;
            grpInProgress.Text = "IN PROGRESS";
            //
            // lstInProgress
            //
            lstInProgress.Dock = DockStyle.Fill;
            lstInProgress.Name = "lstInProgress";
            lstInProgress.BackColor = Color.FromArgb(255, 248, 220);
            lstInProgress.Font = new Font("Segoe UI", 9F);
            lstInProgress.HorizontalScrollbar = true;
            lstInProgress.IntegralHeight = false;
            lstInProgress.ItemHeight = 15;
            lstInProgress.SelectedIndexChanged += lstKanban_SelectedIndexChanged;
            //
            // grpReview
            //
            grpReview.Controls.Add(lstReview);
            grpReview.Dock = DockStyle.Fill;
            grpReview.Location = new Point(0, 0);
            grpReview.Name = "grpReview";
            grpReview.Size = new Size(180, 560);
            grpReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpReview.TabStop = false;
            grpReview.Text = "REVIEW";
            //
            // lstReview
            //
            lstReview.Dock = DockStyle.Fill;
            lstReview.Name = "lstReview";
            lstReview.BackColor = Color.FromArgb(232, 240, 254);
            lstReview.Font = new Font("Segoe UI", 9F);
            lstReview.HorizontalScrollbar = true;
            lstReview.IntegralHeight = false;
            lstReview.ItemHeight = 15;
            lstReview.SelectedIndexChanged += lstKanban_SelectedIndexChanged;
            //
            // grpDone
            //
            grpDone.Controls.Add(lstDone);
            grpDone.Dock = DockStyle.Fill;
            grpDone.Location = new Point(0, 0);
            grpDone.Name = "grpDone";
            grpDone.Size = new Size(180, 560);
            grpDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDone.TabStop = false;
            grpDone.Text = "DONE";
            //
            // lstDone
            //
            lstDone.Dock = DockStyle.Fill;
            lstDone.Name = "lstDone";
            lstDone.BackColor = Color.FromArgb(230, 245, 230);
            lstDone.Font = new Font("Segoe UI", 9F);
            lstDone.HorizontalScrollbar = true;
            lstDone.IntegralHeight = false;
            lstDone.ItemHeight = 15;
            lstDone.SelectedIndexChanged += lstKanban_SelectedIndexChanged;
            //
            // grpTask
            //
            grpTask.Controls.Add(lblDuAn);
            grpTask.Controls.Add(cboDuAn);
            grpTask.Controls.Add(lblTenTask);
            grpTask.Controls.Add(txtTenTask);
            grpTask.Controls.Add(lblMoTa);
            grpTask.Controls.Add(txtMoTa);
            grpTask.Controls.Add(lblHanNop);
            grpTask.Controls.Add(dtpHanNop);
            grpTask.Controls.Add(lblUuTien);
            grpTask.Controls.Add(cboDoUuTien);
            grpTask.Controls.Add(lblTrangThai);
            grpTask.Controls.Add(cboTrangThai);
            grpTask.Controls.Add(btnThem);
            grpTask.Controls.Add(btnSua);
            grpTask.Controls.Add(btnXoa);
            grpTask.Controls.Add(btnLamMoi);
            grpTask.Controls.Add(lblPhanCong);
            grpTask.Controls.Add(clbThanhVien);
            grpTask.Controls.Add(btnLuuPhanCong);
            grpTask.Controls.Add(lblChuyen);
            grpTask.Controls.Add(btnLui);
            grpTask.Controls.Add(lblTrangThaiHT);
            grpTask.Controls.Add(btnTien);
            grpTask.Controls.Add(lblChuyenSang);
            grpTask.Controls.Add(cboChuyenTrangThai);
            grpTask.Controls.Add(btnChuyenTrangThai);
            grpTask.Controls.Add(lblGhiChu);
            grpTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpTask.Location = new Point(784, 74);
            grpTask.Name = "grpTask";
            grpTask.Size = new Size(384, 606);
            grpTask.TabStop = false;
            grpTask.Text = "Thông tin công việc";
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
            cboDuAn.Location = new Point(100, 26);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(270, 23);
            cboDuAn.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // lblTenTask
            //
            lblTenTask.Location = new Point(14, 62);
            lblTenTask.Name = "lblTenTask";
            lblTenTask.AutoSize = true;
            lblTenTask.Text = "Tên task:";
            //
            // txtTenTask
            //
            txtTenTask.Location = new Point(100, 58);
            txtTenTask.Name = "txtTenTask";
            txtTenTask.Size = new Size(270, 23);
            //
            // lblMoTa
            //
            lblMoTa.Location = new Point(14, 94);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.AutoSize = true;
            lblMoTa.Text = "Mô tả:";
            //
            // txtMoTa
            //
            txtMoTa.Location = new Point(100, 90);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(270, 56);
            txtMoTa.Multiline = true;
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            //
            // lblHanNop
            //
            lblHanNop.Location = new Point(14, 158);
            lblHanNop.Name = "lblHanNop";
            lblHanNop.AutoSize = true;
            lblHanNop.Text = "Hạn nộp:";
            //
            // dtpHanNop
            //
            dtpHanNop.Location = new Point(100, 154);
            dtpHanNop.Name = "dtpHanNop";
            dtpHanNop.Size = new Size(110, 23);
            dtpHanNop.CustomFormat = "dd/MM/yyyy";
            dtpHanNop.Format = DateTimePickerFormat.Custom;
            //
            // lblUuTien
            //
            lblUuTien.Location = new Point(220, 158);
            lblUuTien.Name = "lblUuTien";
            lblUuTien.AutoSize = true;
            lblUuTien.Text = "Ưu tiên:";
            //
            // cboDoUuTien
            //
            cboDoUuTien.Items.AddRange(new object[] { "Cao", "Trung bình", "Thấp" });
            cboDoUuTien.Location = new Point(275, 154);
            cboDoUuTien.Name = "cboDoUuTien";
            cboDoUuTien.Size = new Size(95, 23);
            cboDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // lblTrangThai
            //
            lblTrangThai.Location = new Point(14, 190);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.AutoSize = true;
            lblTrangThai.Text = "Trạng thái:";
            //
            // cboTrangThai
            //
            cboTrangThai.Items.AddRange(new object[] { "To Do", "In Progress", "Review", "Done" });
            cboTrangThai.Location = new Point(100, 186);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(150, 23);
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // btnThem
            //
            btnThem.Location = new Point(14, 222);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(84, 32);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            //
            // btnSua
            //
            btnSua.Location = new Point(104, 222);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(84, 32);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            //
            // btnXoa
            //
            btnXoa.Location = new Point(194, 222);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 32);
            btnXoa.ForeColor = Color.Firebrick;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Location = new Point(284, 222);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 32);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // lblPhanCong
            //
            lblPhanCong.Location = new Point(14, 266);
            lblPhanCong.Name = "lblPhanCong";
            lblPhanCong.AutoSize = true;
            lblPhanCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhanCong.Text = "Phân công cho thành viên (tích chọn 1 hoặc nhiều):";
            //
            // clbThanhVien
            //
            clbThanhVien.Location = new Point(14, 288);
            clbThanhVien.Name = "clbThanhVien";
            clbThanhVien.Size = new Size(356, 112);
            clbThanhVien.CheckOnClick = true;
            clbThanhVien.IntegralHeight = false;
            //
            // btnLuuPhanCong
            //
            btnLuuPhanCong.Location = new Point(14, 406);
            btnLuuPhanCong.Name = "btnLuuPhanCong";
            btnLuuPhanCong.Size = new Size(356, 30);
            btnLuuPhanCong.Text = "Lưu phân công";
            btnLuuPhanCong.UseVisualStyleBackColor = true;
            btnLuuPhanCong.Click += btnLuuPhanCong_Click;
            //
            // lblChuyen
            //
            lblChuyen.Location = new Point(14, 450);
            lblChuyen.Name = "lblChuyen";
            lblChuyen.AutoSize = true;
            lblChuyen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChuyen.Text = "Chuyển trạng thái công việc đang chọn:";
            //
            // btnLui
            //
            btnLui.Location = new Point(14, 474);
            btnLui.Name = "btnLui";
            btnLui.Size = new Size(100, 32);
            btnLui.Text = "◀ Lùi lại";
            btnLui.UseVisualStyleBackColor = true;
            btnLui.Click += btnLui_Click;
            //
            // lblTrangThaiHT
            //
            lblTrangThaiHT.Location = new Point(118, 474);
            lblTrangThaiHT.Name = "lblTrangThaiHT";
            lblTrangThaiHT.Size = new Size(146, 32);
            lblTrangThaiHT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTrangThaiHT.TextAlign = ContentAlignment.MiddleCenter;
            lblTrangThaiHT.ForeColor = Color.SteelBlue;
            lblTrangThaiHT.Text = "(chưa chọn)";
            //
            // btnTien
            //
            btnTien.Location = new Point(270, 474);
            btnTien.Name = "btnTien";
            btnTien.Size = new Size(100, 32);
            btnTien.Text = "Tiến tới ▶";
            btnTien.UseVisualStyleBackColor = true;
            btnTien.Click += btnTien_Click;
            //
            // lblChuyenSang
            //
            lblChuyenSang.Location = new Point(14, 520);
            lblChuyenSang.Name = "lblChuyenSang";
            lblChuyenSang.AutoSize = true;
            lblChuyenSang.Text = "Hoặc chuyển sang:";
            //
            // cboChuyenTrangThai
            //
            cboChuyenTrangThai.Items.AddRange(new object[] { "To Do", "In Progress", "Review", "Done" });
            cboChuyenTrangThai.Location = new Point(132, 516);
            cboChuyenTrangThai.Name = "cboChuyenTrangThai";
            cboChuyenTrangThai.Size = new Size(118, 23);
            cboChuyenTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            // btnChuyenTrangThai
            //
            btnChuyenTrangThai.Location = new Point(258, 514);
            btnChuyenTrangThai.Name = "btnChuyenTrangThai";
            btnChuyenTrangThai.Size = new Size(112, 28);
            btnChuyenTrangThai.Text = "Cập nhật";
            btnChuyenTrangThai.UseVisualStyleBackColor = true;
            btnChuyenTrangThai.Click += btnChuyenTrangThai_Click;
            //
            // lblGhiChu
            //
            lblGhiChu.Location = new Point(14, 556);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(356, 40);
            lblGhiChu.ForeColor = Color.DimGray;
            lblGhiChu.Text = "Dòng màu đỏ / có dấu ⚠ là công việc đã quá hạn nộp mà chưa Done.";
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // FormCongViec
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 692);
            Controls.Add(grpLoc);
            Controls.Add(tabView);
            Controls.Add(grpTask);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 600);
            Name = "FormCongViec";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Công việc (List / Kanban)";
            Load += FormCongViec_Load;
            grpLoc.ResumeLayout(false);
            grpLoc.PerformLayout();
            tabView.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            tabKanban.ResumeLayout(false);
            tabKanban.PerformLayout();
            tlpKanban.ResumeLayout(false);
            tlpKanban.PerformLayout();
            grpToDo.ResumeLayout(false);
            grpToDo.PerformLayout();
            grpInProgress.ResumeLayout(false);
            grpInProgress.PerformLayout();
            grpReview.ResumeLayout(false);
            grpReview.PerformLayout();
            grpDone.ResumeLayout(false);
            grpDone.PerformLayout();
            grpTask.ResumeLayout(false);
            grpTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLoc;
        private Label lblLocDuAn;
        private ComboBox cboLocDuAn;
        private Label lblLocTrangThai;
        private ComboBox cboLocTrangThai;
        private Label lblTim;
        private TextBox txtTimKiem;
        private CheckBox chkTreHan;
        private Label lblTongSo;
        private TabControl tabView;
        private TabPage tabList;
        private TabPage tabKanban;
        private DataGridView dgvTask;
        private DataGridViewTextBoxColumn colMaTask;
        private DataGridViewTextBoxColumn colTenDuAn;
        private DataGridViewTextBoxColumn colTenTask;
        private DataGridViewTextBoxColumn colHanNop;
        private DataGridViewTextBoxColumn colDoUuTien;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colNguoiLam;
        private TableLayoutPanel tlpKanban;
        private GroupBox grpToDo;
        private ListBox lstToDo;
        private GroupBox grpInProgress;
        private ListBox lstInProgress;
        private GroupBox grpReview;
        private ListBox lstReview;
        private GroupBox grpDone;
        private ListBox lstDone;
        private GroupBox grpTask;
        private Label lblDuAn;
        private ComboBox cboDuAn;
        private Label lblTenTask;
        private TextBox txtTenTask;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Label lblHanNop;
        private DateTimePicker dtpHanNop;
        private Label lblUuTien;
        private ComboBox cboDoUuTien;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblPhanCong;
        private CheckedListBox clbThanhVien;
        private Button btnLuuPhanCong;
        private Label lblChuyen;
        private Button btnLui;
        private Label lblTrangThaiHT;
        private Button btnTien;
        private Label lblChuyenSang;
        private ComboBox cboChuyenTrangThai;
        private Button btnChuyenTrangThai;
        private Label lblGhiChu;
        private ErrorProvider errorProvider1;
    }
}
