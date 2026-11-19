using System.Globalization;

namespace QuanLyKaraoke.GUI
{
    using QuanLyKaraoke.BUS;
    using QuanLyKaraoke.DTO;

    public partial class FormPhong : Form
    {
        private readonly PhongHatBUS bus = new PhongHatBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
        private int maDangChon = 0;

        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.AutoGenerateColumns = false;
            colGiaTheoGio.DefaultCellStyle.FormatProvider = vi;
            LamMoiONhap();
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                List<PhongHatDTO> ds = bus.LayDanhSach(txtTimKiem.Text);
                dgvPhong.DataSource = ds;
                dgvPhong.ClearSelection();
                lblTongSo.Text = "Tổng: " + ds.Count + " phòng";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            PhongHatDTO pt = dgvPhong.Rows[e.RowIndex].DataBoundItem as PhongHatDTO;
            if (pt == null) return;
            errorProvider1.Clear();
            maDangChon = pt.MaPhong;
            txtMaPhong.Text = pt.MaPhong.ToString();
            txtTenPhong.Text = pt.TenPhong;
            txtGiaTheoGio.Text = pt.GiaTheoGio.ToString("N0", vi);
            cboLoaiPhong.SelectedItem = pt.LoaiPhong;
        }

        private PhongHatDTO DocONhap()
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            decimal gia = 0;
            if (txtTenPhong.Text.Trim() == "") BaoLoi(txtTenPhong, "Tên phòng không được để trống.", loi);
            string s = txtGiaTheoGio.Text.Trim().Replace(".", "").Replace(",", "").Replace(" ", "");
            if (s == "") BaoLoi(txtGiaTheoGio, "Giá theo giờ không được để trống.", loi);
            else if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out gia)) BaoLoi(txtGiaTheoGio, "Giá theo giờ phải là số.", loi);
            else if (gia < 0) BaoLoi(txtGiaTheoGio, "Giá theo giờ không được âm.", loi);
            if (cboLoaiPhong.SelectedIndex < 0) BaoLoi(cboLoaiPhong, "Vui lòng chọn loại phòng.", loi);

            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new PhongHatDTO { MaPhong = maDangChon, TenPhong = txtTenPhong.Text.Trim(), LoaiPhong = cboLoaiPhong.Text, GiaTheoGio = gia };
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
                MessageBox.Show("Bạn đang xem 1 phòng có sẵn. Bấm \"Làm mới\" trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PhongHatDTO pt = DocONhap();
            if (pt == null) return;
            string loi = bus.Them(pt);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã thêm phòng " + pt.TenPhong + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 phòng trong bảng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PhongHatDTO pt = DocONhap();
            if (pt == null) return;
            string loi = bus.Sua(pt);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã cập nhật phòng " + pt.TenPhong + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 phòng trong bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa phòng " + txtTenPhong.Text + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
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
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtGiaTheoGio.Clear();
            cboLoaiPhong.SelectedIndex = -1;
            dgvPhong.ClearSelection();
            txtTenPhong.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e) { TaiDanhSach(); }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; TaiDanhSach(); }
        }
    }
}
