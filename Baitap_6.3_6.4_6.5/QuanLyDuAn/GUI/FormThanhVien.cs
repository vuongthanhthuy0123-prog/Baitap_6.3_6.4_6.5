using System.Text.RegularExpressions;

namespace QuanLyDuAn.GUI
{
    using QuanLyDuAn.BUS;
    using QuanLyDuAn.DTO;

    public partial class FormThanhVien : Form
    {
        private readonly ThanhVienBUS bus = new ThanhVienBUS();
        private int maDangChon = 0;

        public FormThanhVien()
        {
            InitializeComponent();
        }

        private void FormThanhVien_Load(object sender, EventArgs e)
        {
            dgvThanhVien.AutoGenerateColumns = false;
            LamMoiONhap();
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                List<ThanhVienDTO> ds = bus.TimKiem(txtTimKiem.Text);
                dgvThanhVien.DataSource = ds;
                dgvThanhVien.ClearSelection();
                lblTongSo.Text = "Tổng: " + ds.Count + " thành viên";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ThanhVienDTO tv = dgvThanhVien.Rows[e.RowIndex].DataBoundItem as ThanhVienDTO;
            if (tv == null) return;
            errorProvider1.Clear();
            maDangChon = tv.MaThanhVien;
            txtMaThanhVien.Text = tv.MaThanhVien.ToString();
            txtHoTen.Text = tv.HoTen;
            txtEmail.Text = tv.Email;
            txtChuyenMon.Text = tv.ChuyenMon;
        }

        private ThanhVienDTO DocONhap()
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            string email = txtEmail.Text.Trim();
            if (txtHoTen.Text.Trim() == "") BaoLoi(txtHoTen, "Họ tên không được để trống.", loi);
            if (email == "") BaoLoi(txtEmail, "Email không được để trống.", loi);
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) BaoLoi(txtEmail, "Email không đúng định dạng (ví dụ: ten@gmail.com).", loi);
            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new ThanhVienDTO { MaThanhVien = maDangChon, HoTen = txtHoTen.Text.Trim(), Email = email, ChuyenMon = txtChuyenMon.Text.Trim() };
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
                MessageBox.Show("Bạn đang xem 1 thành viên có sẵn. Bấm \"Làm mới\" trước khi thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ThanhVienDTO tv = DocONhap();
            if (tv == null) return;
            string loi = bus.Them(tv);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã thêm thành viên " + tv.HoTen + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 thành viên trong bảng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ThanhVienDTO tv = DocONhap();
            if (tv == null) return;
            string loi = bus.Sua(tv);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            MessageBox.Show("Đã cập nhật thành viên " + tv.HoTen + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
            TaiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDangChon == 0)
            {
                MessageBox.Show("Hãy chọn 1 thành viên trong bảng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xóa thành viên " + txtHoTen.Text + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
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
            txtMaThanhVien.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtChuyenMon.Clear();
            dgvThanhVien.ClearSelection();
            txtHoTen.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e) { TaiDanhSach(); }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; TaiDanhSach(); }
        }
    }
}
