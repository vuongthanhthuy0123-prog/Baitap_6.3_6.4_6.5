using System.Globalization;

namespace QuanLyKaraoke.GUI
{
    using QuanLyKaraoke.BUS;
    using QuanLyKaraoke.DTO;

    public partial class FormDichVu : Form
    {
        private readonly DichVuBUS bus = new DichVuBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
        private int maDangChon = 0;

        public FormDichVu()
        {
            InitializeComponent();
        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            dgvDichVu.AutoGenerateColumns = false;
            colDonGia.DefaultCellStyle.FormatProvider = vi;
            LamMoiONhap();
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                List<DichVuDTO> ds = bus.TimKiem(txtTimKiem.Text);
                dgvDichVu.DataSource = ds;
                dgvDichVu.ClearSelection();
                lblTongSo.Text = "Tổng: " + ds.Count + " dịch vụ";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DichVuDTO pt = dgvDichVu.Rows[e.RowIndex].DataBoundItem as DichVuDTO;
            if (pt == null) return;
            errorProvider1.Clear();
            maDangChon = pt.MaDV;
            txtMaDV.Text = pt.MaDV.ToString();
            txtTenDV.Text = pt.TenDV;
            txtDonGia.Text = pt.DonGia.ToString("N0", vi);
            nudTonKho.Value = Math.Min(pt.TonKho, nudTonKho.Maximum);
        }

        private DichVuDTO DocONhap()
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            decimal gia = 0;
            if (txtTenDV.Text.Trim() == "") BaoLoi(txtTenDV, "Tên dịch vụ không được để trống.", loi);
            string s = txtDonGia.Text.Trim().Replace(".", "").Replace(",", "").Replace(" ", "");
            if (s == "") BaoLoi(txtDonGia, "Đơn giá không được để trống.", loi);
            else if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out gia)) BaoLoi(txtDonGia, "Đơn giá phải là số.", loi);
            else if (gia < 0) BaoLoi(txtDonGia, "Đơn giá không được âm.", loi);
            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new DichVuDTO { MaDV = maDangChon, TenDV = txtTenDV.Text.Trim(), DonGia = gia, TonKho = (int)nudTonKho.Value };
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
                MessageBox.Show("Bạn đang xem 1 dịch vụ có sẵn. Bấm \"Làm mới\" trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DichVuDTO pt = DocONhap();
            if (pt == null) return;
            string loi = bus.Them(pt);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã thêm dịch vụ " + pt.TenDV + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 dịch vụ trong bảng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DichVuDTO pt = DocONhap();
            if (pt == null) return;
            string loi = bus.Sua(pt);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã cập nhật dịch vụ " + pt.TenDV + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 dịch vụ trong bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa dịch vụ " + txtTenDV.Text + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
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
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonGia.Clear();
            nudTonKho.Value = 0;
            dgvDichVu.ClearSelection();
            txtTenDV.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e) { TaiDanhSach(); }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; TaiDanhSach(); }
        }
    }
}
