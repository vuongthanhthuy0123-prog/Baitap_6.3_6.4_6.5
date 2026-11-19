namespace QuanLyDuAn.GUI
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
            mnuDanhMuc = new ToolStripMenuItem();
            mnuCongViec = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDuAn = new ToolStripMenuItem();
            mnuThanhVien = new ToolStripMenuItem();
            mnuQuanLyTask = new ToolStripMenuItem();
            mnuTreHan = new ToolStripMenuItem();
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            lblSinhVien = new Label();
            pnlSoDuAn = new Panel();
            lblSoDuAnTitle = new Label();
            lblSoDuAn = new Label();
            pnlSoTask = new Panel();
            lblSoTaskTitle = new Label();
            lblSoTask = new Label();
            pnlTreHan = new Panel();
            lblTreHanTitle = new Label();
            lblTreHan = new Label();
            pnlTyLe = new Panel();
            lblTyLeTitle = new Label();
            lblTyLe = new Label();
            btnCongViec = new Button();
            btnDuAn = new Button();
            btnThanhVien = new Button();
            btnBaoCao = new Button();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuDanhMuc, mnuCongViec, mnuBaoCao, mnuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 0;
            //
            // mnuDuAn
            //
            mnuDuAn.Name = "mnuDuAn";
            mnuDuAn.Text = "Dự án";
            mnuDuAn.Click += btnDuAn_Click;
            //
            // mnuThanhVien
            //
            mnuThanhVien.Name = "mnuThanhVien";
            mnuThanhVien.Text = "Thành viên";
            mnuThanhVien.Click += btnThanhVien_Click;
            //
            // mnuDanhMuc
            //
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuDuAn, mnuThanhVien });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Text = "Danh mục";
            //
            // mnuQuanLyTask
            //
            mnuQuanLyTask.Name = "mnuQuanLyTask";
            mnuQuanLyTask.Text = "Quản lý task (List / Kanban)";
            mnuQuanLyTask.Click += btnCongViec_Click;
            //
            // mnuCongViec
            //
            mnuCongViec.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyTask });
            mnuCongViec.Name = "mnuCongViec";
            mnuCongViec.Text = "Công việc";
            //
            // mnuTreHan
            //
            mnuTreHan.Name = "mnuTreHan";
            mnuTreHan.Text = "Trễ hạn && tiến độ";
            mnuTreHan.Click += btnBaoCao_Click;
            //
            // mnuBaoCao
            //
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuTreHan });
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Text = "Báo cáo";
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
            lblTieuDe.Text = "QUẢN LÝ CÔNG VIỆC && TIẾN ĐỘ DỰ ÁN";
            //
            // lblSinhVien
            //
            lblSinhVien.AutoSize = true;
            lblSinhVien.ForeColor = Color.Gainsboro;
            lblSinhVien.Location = new Point(23, 44);
            lblSinhVien.Name = "lblSinhVien";
            lblSinhVien.Text = "Sinh viên: Vương Thanh Thúy  |  MSV: 24810310270  |  Lớp: D19CNPM3";
            //
            // pnlSoDuAn
            //
            pnlSoDuAn.BackColor = Color.SteelBlue;
            pnlSoDuAn.Controls.Add(lblSoDuAnTitle);
            pnlSoDuAn.Controls.Add(lblSoDuAn);
            pnlSoDuAn.Location = new Point(24, 112);
            pnlSoDuAn.Name = "pnlSoDuAn";
            pnlSoDuAn.Size = new Size(204, 86);
            pnlSoDuAn.TabIndex = 2;
            //
            // lblSoDuAnTitle
            //
            lblSoDuAnTitle.AutoSize = true;
            lblSoDuAnTitle.ForeColor = Color.White;
            lblSoDuAnTitle.Location = new Point(12, 10);
            lblSoDuAnTitle.Name = "lblSoDuAnTitle";
            lblSoDuAnTitle.Text = "Số dự án";
            //
            // lblSoDuAn
            //
            lblSoDuAn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSoDuAn.ForeColor = Color.White;
            lblSoDuAn.Location = new Point(10, 36);
            lblSoDuAn.Name = "lblSoDuAn";
            lblSoDuAn.Size = new Size(186, 34);
            lblSoDuAn.Text = "...";
            //
            // pnlSoTask
            //
            pnlSoTask.BackColor = Color.SeaGreen;
            pnlSoTask.Controls.Add(lblSoTaskTitle);
            pnlSoTask.Controls.Add(lblSoTask);
            pnlSoTask.Location = new Point(240, 112);
            pnlSoTask.Name = "pnlSoTask";
            pnlSoTask.Size = new Size(204, 86);
            pnlSoTask.TabIndex = 3;
            //
            // lblSoTaskTitle
            //
            lblSoTaskTitle.AutoSize = true;
            lblSoTaskTitle.ForeColor = Color.White;
            lblSoTaskTitle.Location = new Point(12, 10);
            lblSoTaskTitle.Name = "lblSoTaskTitle";
            lblSoTaskTitle.Text = "Tổng số công việc";
            //
            // lblSoTask
            //
            lblSoTask.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSoTask.ForeColor = Color.White;
            lblSoTask.Location = new Point(10, 36);
            lblSoTask.Name = "lblSoTask";
            lblSoTask.Size = new Size(186, 34);
            lblSoTask.Text = "...";
            //
            // pnlTreHan
            //
            pnlTreHan.BackColor = Color.IndianRed;
            pnlTreHan.Controls.Add(lblTreHanTitle);
            pnlTreHan.Controls.Add(lblTreHan);
            pnlTreHan.Location = new Point(456, 112);
            pnlTreHan.Name = "pnlTreHan";
            pnlTreHan.Size = new Size(204, 86);
            pnlTreHan.TabIndex = 4;
            //
            // lblTreHanTitle
            //
            lblTreHanTitle.AutoSize = true;
            lblTreHanTitle.ForeColor = Color.White;
            lblTreHanTitle.Location = new Point(12, 10);
            lblTreHanTitle.Name = "lblTreHanTitle";
            lblTreHanTitle.Text = "Công việc trễ hạn";
            //
            // lblTreHan
            //
            lblTreHan.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTreHan.ForeColor = Color.White;
            lblTreHan.Location = new Point(10, 36);
            lblTreHan.Name = "lblTreHan";
            lblTreHan.Size = new Size(186, 34);
            lblTreHan.Text = "...";
            //
            // pnlTyLe
            //
            pnlTyLe.BackColor = Color.DarkOrange;
            pnlTyLe.Controls.Add(lblTyLeTitle);
            pnlTyLe.Controls.Add(lblTyLe);
            pnlTyLe.Location = new Point(672, 112);
            pnlTyLe.Name = "pnlTyLe";
            pnlTyLe.Size = new Size(204, 86);
            pnlTyLe.TabIndex = 5;
            //
            // lblTyLeTitle
            //
            lblTyLeTitle.AutoSize = true;
            lblTyLeTitle.ForeColor = Color.White;
            lblTyLeTitle.Location = new Point(12, 10);
            lblTyLeTitle.Name = "lblTyLeTitle";
            lblTyLeTitle.Text = "Tỷ lệ hoàn thành";
            //
            // lblTyLe
            //
            lblTyLe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTyLe.ForeColor = Color.White;
            lblTyLe.Location = new Point(10, 36);
            lblTyLe.Name = "lblTyLe";
            lblTyLe.Size = new Size(186, 34);
            lblTyLe.Text = "...";
            //
            // btnCongViec
            //
            btnCongViec.BackColor = Color.SeaGreen;
            btnCongViec.FlatStyle = FlatStyle.Flat;
            btnCongViec.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCongViec.ForeColor = Color.White;
            btnCongViec.Location = new Point(24, 224);
            btnCongViec.Name = "btnCongViec";
            btnCongViec.Size = new Size(204, 104);
            btnCongViec.TabIndex = 10;
            btnCongViec.Text = "CÔNG VIỆC";
            btnCongViec.UseVisualStyleBackColor = false;
            btnCongViec.Click += btnCongViec_Click;
            //
            // btnDuAn
            //
            btnDuAn.BackColor = Color.FromArgb(0, 102, 153);
            btnDuAn.FlatStyle = FlatStyle.Flat;
            btnDuAn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDuAn.ForeColor = Color.White;
            btnDuAn.Location = new Point(240, 224);
            btnDuAn.Name = "btnDuAn";
            btnDuAn.Size = new Size(204, 104);
            btnDuAn.TabIndex = 11;
            btnDuAn.Text = "Dự án";
            btnDuAn.UseVisualStyleBackColor = false;
            btnDuAn.Click += btnDuAn_Click;
            //
            // btnThanhVien
            //
            btnThanhVien.BackColor = Color.FromArgb(0, 102, 153);
            btnThanhVien.FlatStyle = FlatStyle.Flat;
            btnThanhVien.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhVien.ForeColor = Color.White;
            btnThanhVien.Location = new Point(456, 224);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(204, 104);
            btnThanhVien.TabIndex = 12;
            btnThanhVien.Text = "Thành viên";
            btnThanhVien.UseVisualStyleBackColor = false;
            btnThanhVien.Click += btnThanhVien_Click;
            //
            // btnBaoCao
            //
            btnBaoCao.BackColor = Color.Firebrick;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBaoCao.ForeColor = Color.White;
            btnBaoCao.Location = new Point(672, 224);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(204, 104);
            btnBaoCao.TabIndex = 13;
            btnBaoCao.Text = "Trễ hạn && Báo cáo";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            //
            // lblHuongDan
            //
            lblHuongDan.ForeColor = Color.DimGray;
            lblHuongDan.Location = new Point(24, 344);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(852, 44);
            lblHuongDan.Text = "Vào CÔNG VIỆC để tạo task, giao việc cho thành viên và chuyển trạng thái (To Do → In Progress → Review → Done). Xem dạng danh sách hoặc bảng Kanban.";
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
            Controls.Add(pnlSoDuAn);
            Controls.Add(pnlSoTask);
            Controls.Add(pnlTreHan);
            Controls.Add(pnlTyLe);
            Controls.Add(btnCongViec);
            Controls.Add(btnDuAn);
            Controls.Add(btnThanhVien);
            Controls.Add(btnBaoCao);
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
            Text = "Hệ thống Quản lý Công việc & Tiến độ Dự án";
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
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuCongViec;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDuAn;
        private ToolStripMenuItem mnuThanhVien;
        private ToolStripMenuItem mnuQuanLyTask;
        private ToolStripMenuItem mnuTreHan;
        private Panel pnlHeader;
        private Label lblTieuDe;
        private Label lblSinhVien;
        private Panel pnlSoDuAn;
        private Label lblSoDuAnTitle;
        private Label lblSoDuAn;
        private Panel pnlSoTask;
        private Label lblSoTaskTitle;
        private Label lblSoTask;
        private Panel pnlTreHan;
        private Label lblTreHanTitle;
        private Label lblTreHan;
        private Panel pnlTyLe;
        private Label lblTyLeTitle;
        private Label lblTyLe;
        private Button btnCongViec;
        private Button btnDuAn;
        private Button btnThanhVien;
        private Button btnBaoCao;
        private Label lblHuongDan;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblKetNoi;
    }
}
