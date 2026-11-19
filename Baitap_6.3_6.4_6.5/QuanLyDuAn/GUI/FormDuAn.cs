namespace QuanLyDuAn.GUI
{
    using QuanLyDuAn.BUS;
    using QuanLyDuAn.DTO;

    public partial class FormDuAn : Form
    {
        private readonly DuAnBUS bus = new DuAnBUS();
        private int maDangChon = 0;      // 0 = chưa chọn dự án nào

        public FormDuAn()
        {
            InitializeComponent();
        }

        private void FormDuAn_Load(object sender, EventArgs e)
        {
            dgvDuAn.AutoGenerateColumns = false;
            LamMoiONhap();
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                List<DuAnDTO> ds = bus.TimKiem(txtTimKiem.Text);
                dgvDuAn.DataSource = ds;
                dgvDuAn.ClearSelection();
                lblTongSo.Text = "Tổng: " + ds.Count + " dự án";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DuAnDTO d = dgvDuAn.Rows[e.RowIndex].DataBoundItem as DuAnDTO;
            if (d == null) return;
            errorProvider1.Clear();
            maDangChon = d.MaDuAn;
            txtMaDuAn.Text = d.MaDuAn.ToString();
            txtTenDuAn.Text = d.TenDuAn;
            dtpNgayBatDau.Value = d.NgayBatDau ?? DateTime.Today;
            dtpNgayKetThuc.Value = d.NgayKetThuc ?? DateTime.Today;
            cboTrangThai.SelectedItem = d.TrangThai;
        }

        private DuAnDTO DocONhap()
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            if (txtTenDuAn.Text.Trim() == "") BaoLoi(txtTenDuAn, "Tên dự án không được để trống.", loi);
            if (dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date) BaoLoi(dtpNgayKetThuc, "Ngày kết thúc không được trước ngày bắt đầu.", loi);
            if (cboTrangThai.SelectedIndex < 0) BaoLoi(cboTrangThai, "Vui lòng chọn trạng thái.", loi);
            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new DuAnDTO
            {
                MaDuAn = maDangChon,
                TenDuAn = txtTenDuAn.Text.Trim(),
                NgayBatDau = dtpNgayBatDau.Value.Date,
                NgayKetThuc = dtpNgayKetThuc.Value.Date,
                TrangThai = cboTrangThai.Text
            };
        }

        private void BaoLoi(Control c, string thongBao, List<string> loi)
        {
            errorProvider1.SetError(c, thongBao);
            loi.Add(thongBao);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (maDangChon != 0)
            {
                MessageBox.Show("Bạn đang xem 1 dự án có sẵn. Bấm \"Làm mới\" trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DuAnDTO d = DocONhap();
            if (d == null) return;
            string loi = bus.Them(d);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã thêm dự án " + d.TenDuAn + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 dự án trong bảng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DuAnDTO d = DocONhap();
            if (d == null) return;
            string loi = bus.Sua(d);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã cập nhật dự án " + d.TenDuAn + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 dự án trong bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa dự án \"" + txtTenDuAn.Text + "\"?\nTất cả công việc của dự án này cũng sẽ bị xóa.", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            string loi = bus.Xoa(maDangChon);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LamMoiONhap();
            TaiDanhSach();
        }

        private void LamMoiONhap()
        {
            errorProvider1.Clear();
            maDangChon = 0;
            txtMaDuAn.Clear();
            txtTenDuAn.Clear();
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            cboTrangThai.SelectedIndex = -1;
            dgvDuAn.ClearSelection();
            txtTenDuAn.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e) { TaiDanhSach(); }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; TaiDanhSach(); }
        }
    }
}
