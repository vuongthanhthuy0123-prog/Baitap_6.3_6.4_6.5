using System.Globalization;

namespace QuanLyGarage.GUI
{
    using QuanLyGarage.BUS;
    using QuanLyGarage.DTO;

    public partial class FormPhuTung : Form
    {
        private readonly PhuTungBUS bus = new PhuTungBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
        private int maDangChon = 0;

        public FormPhuTung()
        {
            InitializeComponent();
        }

        private void FormPhuTung_Load(object sender, EventArgs e)
        {
            dgvPhuTung.AutoGenerateColumns = false;
            colDonGia.DefaultCellStyle.FormatProvider = vi;
            LamMoiONhap();
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                List<PhuTungDTO> ds = bus.TimKiem(txtTimKiem.Text);
                dgvPhuTung.DataSource = ds;
                dgvPhuTung.ClearSelection();
                lblTongSo.Text = "Tổng: " + ds.Count + " phụ tùng";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            PhuTungDTO pt = dgvPhuTung.Rows[e.RowIndex].DataBoundItem as PhuTungDTO;
            if (pt == null) return;
            errorProvider1.Clear();
            maDangChon = pt.MaPhuTung;
            txtMaPhuTung.Text = pt.MaPhuTung.ToString();
            txtTenPhuTung.Text = pt.TenPhuTung;
            txtDonGia.Text = pt.DonGia.ToString("N0", vi);
            nudSoLuongTon.Value = Math.Min(pt.SoLuongTon, nudSoLuongTon.Maximum);
        }

        private PhuTungDTO DocONhap()
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            decimal gia = 0;
            if (txtTenPhuTung.Text.Trim() == "") BaoLoi(txtTenPhuTung, "Tên phụ tùng không được để trống.", loi);
            string s = txtDonGia.Text.Trim().Replace(".", "").Replace(",", "").Replace(" ", "");
            if (s == "") BaoLoi(txtDonGia, "Đơn giá không được để trống.", loi);
            else if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out gia)) BaoLoi(txtDonGia, "Đơn giá phải là số.", loi);
            else if (gia < 0) BaoLoi(txtDonGia, "Đơn giá không được âm.", loi);
            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new PhuTungDTO { MaPhuTung = maDangChon, TenPhuTung = txtTenPhuTung.Text.Trim(), DonGia = gia, SoLuongTon = (int)nudSoLuongTon.Value };
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
                MessageBox.Show("Bạn đang xem 1 phụ tùng có sẵn. Bấm \"Làm mới\" trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PhuTungDTO pt = DocONhap();
            if (pt == null) return;
            string loi = bus.Them(pt);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã thêm phụ tùng " + pt.TenPhuTung + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 phụ tùng trong bảng để sửa đơn giá / tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PhuTungDTO pt = DocONhap();
            if (pt == null) return;
            string loi = bus.Sua(pt);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã cập nhật phụ tùng " + pt.TenPhuTung + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 phụ tùng trong bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa phụ tùng " + txtTenPhuTung.Text + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
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
            txtMaPhuTung.Clear();
            txtTenPhuTung.Clear();
            txtDonGia.Clear();
            nudSoLuongTon.Value = 0;
            dgvPhuTung.ClearSelection();
            txtTenPhuTung.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e) { TaiDanhSach(); }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; TaiDanhSach(); }
        }
    }
}
