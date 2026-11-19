namespace QuanLyDuAn.GUI
{
    using QuanLyDuAn.BUS;
    using QuanLyDuAn.DTO;

    public partial class FormCongViec : Form
    {
        private readonly CongViecBUS bus = new CongViecBUS();
        private readonly DuAnBUS duAnBUS = new DuAnBUS();
        private readonly ThanhVienBUS thanhVienBUS = new ThanhVienBUS();

        private List<CongViecDTO> dsHienThi = new List<CongViecDTO>();
        private CongViecDTO dangChon = null;     // task đang được chọn (null = chưa chọn)
        private bool dangNap = false;            // đang nạp lại dữ liệu -> bỏ qua sự kiện chọn

        public FormCongViec()
        {
            InitializeComponent();
        }

        private ListBox[] CotKanban
        {
            get { return new[] { lstToDo, lstInProgress, lstReview, lstDone }; }
        }

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            dgvTask.AutoGenerateColumns = false;
            try
            {
                List<DuAnDTO> dsDuAn = duAnBUS.TimKiem("");

                List<DuAnDTO> dsLoc = new List<DuAnDTO>();
                dsLoc.Add(new DuAnDTO { MaDuAn = 0, TenDuAn = "Tất cả dự án" });
                dsLoc.AddRange(dsDuAn);
                cboLocDuAn.DisplayMember = "TenDuAn";
                cboLocDuAn.ValueMember = "MaDuAn";
                cboLocDuAn.DataSource = dsLoc;

                cboDuAn.DisplayMember = "TenDuAn";
                cboDuAn.ValueMember = "MaDuAn";
                cboDuAn.DataSource = new List<DuAnDTO>(dsDuAn);

                clbThanhVien.DisplayMember = "HienThi";
                clbThanhVien.ValueMember = "MaThanhVien";
                clbThanhVien.DataSource = thanhVienBUS.TimKiem("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboLocTrangThai.SelectedIndex = 0;
            LamMoiONhap();
            TaiDanhSach();
        }

        // ===================== LỌC & HIỂN THỊ =====================

        private void TaiDanhSach()
        {
            try
            {
                int maDuAn = cboLocDuAn.SelectedValue is int ? (int)cboLocDuAn.SelectedValue : 0;
                string trangThai = cboLocTrangThai.SelectedIndex > 0 ? cboLocTrangThai.Text : "";
                List<CongViecDTO> ds = bus.Loc(maDuAn, trangThai, txtTimKiem.Text);
                if (chkTreHan.Checked) ds = ds.Where(x => x.TreHan).ToList();
                dsHienThi = ds;

                dangNap = true;
                dgvTask.DataSource = ds;
                dgvTask.ClearSelection();
                ListBox[] cot = CotKanban;
                for (int i = 0; i < cot.Length; i++)
                {
                    string tt = CongViecBUS.CAC_TRANG_THAI[i];
                    cot[i].Items.Clear();
                    foreach (CongViecDTO cv in ds.Where(x => x.TrangThai == tt)) cot[i].Items.Add(cv);
                }
                grpToDo.Text = "TO DO (" + lstToDo.Items.Count + ")";
                grpInProgress.Text = "IN PROGRESS (" + lstInProgress.Items.Count + ")";
                grpReview.Text = "REVIEW (" + lstReview.Items.Count + ")";
                grpDone.Text = "DONE (" + lstDone.Items.Count + ")";
                dangNap = false;

                lblTongSo.Text = ds.Count + " công việc  |  " + ds.Count(x => x.TreHan) + " trễ hạn";

                // Giữ lại task đang chọn sau khi nạp lại
                if (dangChon != null)
                {
                    CongViecDTO moi = ds.FirstOrDefault(x => x.MaTask == dangChon.MaTask);
                    if (moi != null) ChonTask(moi); else LamMoiONhap();
                }
            }
            catch (Exception ex)
            {
                dangNap = false;
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BoLoc_Changed(object sender, EventArgs e)
        {
            if (cboLocDuAn.DataSource == null) return;      // form chưa nạp xong
            TaiDanhSach();
        }

        private void dgvTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dsHienThi.Count) return;
            CongViecDTO cv = dsHienThi[e.RowIndex];
            if (cv.TreHan) e.CellStyle.ForeColor = Color.Red;
            else if (cv.TrangThai == "Done") e.CellStyle.ForeColor = Color.SeaGreen;
        }

        // ===================== CHỌN TASK =====================

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            CongViecDTO cv = dgvTask.Rows[e.RowIndex].DataBoundItem as CongViecDTO;
            if (cv != null) ChonTask(cv);
        }

        private void lstKanban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangNap) return;
            ListBox lst = (ListBox)sender;
            CongViecDTO cv = lst.SelectedItem as CongViecDTO;
            if (cv == null) return;

            dangNap = true;
            foreach (ListBox khac in CotKanban) if (khac != lst) khac.ClearSelected();
            dangNap = false;
            ChonTask(cv);
        }

        private void ChonTask(CongViecDTO cv)
        {
            dangChon = cv;
            errorProvider1.Clear();
            cboDuAn.SelectedValue = cv.MaDuAn;
            txtTenTask.Text = cv.TenTask;
            txtMoTa.Text = cv.MoTa;
            dtpHanNop.Value = cv.HanNop ?? DateTime.Today;
            cboDoUuTien.SelectedItem = cv.DoUuTien;
            cboTrangThai.SelectedItem = cv.TrangThai;
            cboChuyenTrangThai.SelectedItem = cv.TrangThai;
            lblTrangThaiHT.Text = "#" + cv.MaTask + ": " + cv.TrangThai;
            lblTrangThaiHT.ForeColor = cv.TreHan ? Color.Red : Color.SteelBlue;

            try
            {
                List<int> dsGiao = bus.LayThanhVienDuocGiao(cv.MaTask);
                for (int i = 0; i < clbThanhVien.Items.Count; i++)
                {
                    ThanhVienDTO tv = (ThanhVienDTO)clbThanhVien.Items[i];
                    clbThanhVien.SetItemChecked(i, dsGiao.Contains(tv.MaThanhVien));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== THÊM / SỬA / XÓA TASK =====================

        private CongViecDTO DocONhap()
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            if (cboDuAn.SelectedIndex < 0) BaoLoi(cboDuAn, "Vui lòng chọn dự án.", loi);
            if (txtTenTask.Text.Trim() == "") BaoLoi(txtTenTask, "Tên công việc không được để trống.", loi);
            if (cboDoUuTien.SelectedIndex < 0) BaoLoi(cboDoUuTien, "Vui lòng chọn độ ưu tiên.", loi);
            if (cboTrangThai.SelectedIndex < 0) BaoLoi(cboTrangThai, "Vui lòng chọn trạng thái.", loi);
            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new CongViecDTO
            {
                MaTask = dangChon == null ? 0 : dangChon.MaTask,
                MaDuAn = (int)cboDuAn.SelectedValue,
                TenTask = txtTenTask.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                HanNop = dtpHanNop.Value.Date.AddHours(23).AddMinutes(59),   // hạn đến cuối ngày
                DoUuTien = cboDoUuTien.Text,
                TrangThai = cboTrangThai.Text
            };
        }

        private void BaoLoi(Control c, string thongBao, List<string> loi)
        {
            errorProvider1.SetError(c, thongBao);
            loi.Add(thongBao);
        }

        private List<int> ThanhVienDaTich()
        {
            return clbThanhVien.CheckedItems.Cast<ThanhVienDTO>().Select(x => x.MaThanhVien).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dangChon != null)
            {
                MessageBox.Show("Bạn đang xem 1 công việc có sẵn. Bấm \"Làm mới\" trước khi thêm công việc mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CongViecDTO cv = DocONhap();
            if (cv == null) return;

            string loi;
            int maMoi = bus.Them(cv, out loi);
            if (maMoi < 0) { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Giao việc luôn cho các thành viên đã tích chọn
            List<int> dsGiao = ThanhVienDaTich();
            if (dsGiao.Count > 0)
            {
                loi = bus.LuuPhanCong(maMoi, dsGiao);
                if (loi != "") MessageBox.Show("Đã thêm công việc nhưng chưa phân công được: " + loi, "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MessageBox.Show("Đã thêm công việc #" + maMoi + " - " + cv.TenTask + (dsGiao.Count > 0 ? "\nĐã giao cho " + dsGiao.Count + " thành viên." : ""),
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dangChon == null)
            {
                MessageBox.Show("Hãy chọn 1 công việc trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CongViecDTO cv = DocONhap();
            if (cv == null) return;
            string loi = bus.Sua(cv);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã cập nhật công việc #" + cv.MaTask + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dangChon == null)
            {
                MessageBox.Show("Hãy chọn 1 công việc trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa công việc #" + dangChon.MaTask + " - " + dangChon.TenTask + "?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            string loi = bus.Xoa(dangChon.MaTask);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiONhap();
            TaiDanhSach();
        }

        private void LamMoiONhap()
        {
            dangChon = null;
            errorProvider1.Clear();
            cboDuAn.SelectedIndex = -1;
            txtTenTask.Clear();
            txtMoTa.Clear();
            dtpHanNop.Value = DateTime.Today;
            cboDoUuTien.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            cboChuyenTrangThai.SelectedIndex = -1;
            lblTrangThaiHT.Text = "(chưa chọn)";
            lblTrangThaiHT.ForeColor = Color.SteelBlue;
            for (int i = 0; i < clbThanhVien.Items.Count; i++) clbThanhVien.SetItemChecked(i, false);
            dgvTask.ClearSelection();
            dangNap = true;
            foreach (ListBox lst in CotKanban) lst.ClearSelected();
            dangNap = false;
        }

        // ===================== PHÂN CÔNG =====================

        private void btnLuuPhanCong_Click(object sender, EventArgs e)
        {
            if (dangChon == null)
            {
                MessageBox.Show("Hãy chọn 1 công việc, tích chọn thành viên rồi bấm \"Lưu phân công\".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<int> dsGiao = ThanhVienDaTich();
            string loi = bus.LuuPhanCong(dangChon.MaTask, dsGiao);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã giao công việc #" + dangChon.MaTask + " cho " + dsGiao.Count + " thành viên.", "Phân công thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach();
        }

        // ===================== CHUYỂN TRẠNG THÁI =====================

        private void ChuyenTrangThai(string trangThaiMoi)
        {
            if (dangChon == null)
            {
                MessageBox.Show("Hãy chọn 1 công việc trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (trangThaiMoi == null) return;
            if (trangThaiMoi == dangChon.TrangThai)
            {
                MessageBox.Show("Công việc đang ở trạng thái \"" + trangThaiMoi + "\" rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string cu = dangChon.TrangThai;
            string loi = bus.ChuyenTrangThai(dangChon.MaTask, trangThaiMoi);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            lblTongSo.Text = "Đã chuyển #" + dangChon.MaTask + ": " + cu + " → " + trangThaiMoi;
            TaiDanhSach();
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            if (dangChon == null) { MessageBox.Show("Hãy chọn 1 công việc trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            string ke = CongViecBUS.TrangThaiKe(dangChon.TrangThai, +1);
            if (ke == null) { MessageBox.Show("Công việc đã ở trạng thái cuối (Done).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            ChuyenTrangThai(ke);
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            if (dangChon == null) { MessageBox.Show("Hãy chọn 1 công việc trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            string truoc = CongViecBUS.TrangThaiKe(dangChon.TrangThai, -1);
            if (truoc == null) { MessageBox.Show("Công việc đang ở trạng thái đầu tiên (To Do).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            ChuyenTrangThai(truoc);
        }

        private void btnChuyenTrangThai_Click(object sender, EventArgs e)
        {
            if (cboChuyenTrangThai.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboChuyenTrangThai, "Chọn trạng thái mới.");
                return;
            }
            errorProvider1.SetError(cboChuyenTrangThai, "");
            ChuyenTrangThai(cboChuyenTrangThai.Text);
        }
    }
}
