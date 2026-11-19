using System.Text.RegularExpressions;

namespace QuanLyGarage.GUI
{
    using QuanLyGarage.BUS;
    using QuanLyGarage.DTO;

    public partial class FormTiepNhan : Form
    {
        private readonly XeBUS bus = new XeBUS();

        private XeDTO xeDangXem = null;   // null = đang nhập xe mới
        private int maChuXe = 0;          // 0 = chủ xe mới

        public FormTiepNhan()
        {
            InitializeComponent();
        }

        private void FormTiepNhan_Load(object sender, EventArgs e)
        {
            dgvXe.AutoGenerateColumns = false;
            LamMoi();
            TaiDanhSach("");
        }

        private void TaiDanhSach(string tuKhoa)
        {
            try
            {
                dgvXe.DataSource = bus.TimKiem(tuKhoa);
                dgvXe.ClearSelection();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ===================== TRA CỨU BIỂN SỐ =====================

        private void txtBienSoTra_TextChanged(object sender, EventArgs e)
        {
            TaiDanhSach(txtBienSoTra.Text.Trim());     // lọc nhanh danh sách bên dưới
        }

        private void txtBienSoTra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnTraCuu_Click(sender, e); }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string bienSo = XeBUS.ChuanHoaBienSo(txtBienSoTra.Text);
            if (bienSo == "")
            {
                errorProvider1.SetError(txtBienSoTra, "Nhập biển số cần tra cứu.");
                return;
            }
            errorProvider1.Clear();
            try
            {
                XeDTO xe = bus.TraCuu(bienSo);       // SqlParameter: WHERE BienSo = @BienSo
                if (xe != null)
                {
                    HienXe(xe);
                    lblKetQua.ForeColor = Color.SeaGreen;
                    lblKetQua.Text = "Xe " + bienSo + " đã có trong hệ thống (chủ xe: " + xe.TenKH + ").";
                }
                else
                {
                    LamMoi();
                    txtBienSo.Text = bienSo;
                    lblKetQua.ForeColor = Color.DarkOrange;
                    lblKetQua.Text = "Xe mới! Hãy nhập thông tin xe và chủ xe rồi bấm \"Lưu xe / chủ xe\".";
                    txtDienThoai.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            XeDTO xe = dgvXe.Rows[e.RowIndex].DataBoundItem as XeDTO;
            if (xe == null) return;
            HienXe(xe);
            lblKetQua.ForeColor = Color.SteelBlue;
            lblKetQua.Text = "Đang xem xe " + xe.BienSo + ".";
        }

        private void HienXe(XeDTO xe)
        {
            errorProvider1.Clear();
            xeDangXem = xe;
            maChuXe = xe.MaKH;
            txtBienSo.Text = xe.BienSo;
            txtBienSo.ReadOnly = true;
            cboHieuXe.Text = xe.HieuXe;
            nudNamSX.Value = xe.NamSanXuat.HasValue ? Math.Max(nudNamSX.Minimum, Math.Min(nudNamSX.Maximum, xe.NamSanXuat.Value)) : 2020;
            txtDienThoai.Text = xe.DienThoai;
            txtTenKH.Text = xe.TenKH;
            txtDiaChi.Text = xe.DiaChi;
            lblLoaiChu.Text = "Chủ xe đã có trong hệ thống (mã " + xe.MaKH + ").";
        }

        // ===================== CHỦ XE =====================

        private void btnTimChu_Click(object sender, EventArgs e)
        {
            string sdt = txtDienThoai.Text.Trim();
            if (sdt == "")
            {
                errorProvider1.SetError(txtDienThoai, "Nhập số điện thoại để tìm chủ xe.");
                return;
            }
            try
            {
                KhachHangDTO kh = bus.TimChuXe(sdt);
                if (kh == null)
                {
                    maChuXe = 0;
                    lblLoaiChu.Text = "Chưa có chủ xe này -> sẽ tạo chủ xe mới.";
                    MessageBox.Show("Không có chủ xe nào dùng số " + sdt + ". Hãy nhập tên và địa chỉ để tạo chủ xe mới.",
                        "Chủ xe mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenKH.Focus();
                    return;
                }
                maChuXe = kh.MaKH;
                txtTenKH.Text = kh.TenKH;
                txtDiaChi.Text = kh.DiaChi;
                lblLoaiChu.Text = "Chủ xe đã có trong hệ thống (mã " + kh.MaKH + ").";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ===================== LƯU =====================

        private void btnLuuXe_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();
            string bienSo = XeBUS.ChuanHoaBienSo(txtBienSo.Text);
            string sdt = txtDienThoai.Text.Trim();

            if (bienSo == "") BaoLoi(txtBienSo, "Biển số không được để trống.", loi);
            else if (!Regex.IsMatch(bienSo, @"^\d{2}[A-Z]{1,2}\d?-?[\d\.]{4,7}$"))
                BaoLoi(txtBienSo, "Biển số không đúng dạng (ví dụ: 51H-123.45, 30G-67890).", loi);
            if (cboHieuXe.Text.Trim() == "") BaoLoi(cboHieuXe, "Vui lòng nhập hiệu xe.", loi);
            if (txtTenKH.Text.Trim() == "") BaoLoi(txtTenKH, "Tên chủ xe không được để trống.", loi);
            if (sdt == "") BaoLoi(txtDienThoai, "Số điện thoại không được để trống.", loi);
            else if (!Regex.IsMatch(sdt, @"^0\d{9}$")) BaoLoi(txtDienThoai, "Số điện thoại phải gồm 10 chữ số, bắt đầu bằng 0.", loi);
            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            XeDTO xe = new XeDTO { BienSo = bienSo, HieuXe = cboHieuXe.Text.Trim(), NamSanXuat = (int)nudNamSX.Value };
            KhachHangDTO kh = new KhachHangDTO { MaKH = maChuXe, TenKH = txtTenKH.Text.Trim(), DienThoai = sdt, DiaChi = txtDiaChi.Text.Trim() };

            string kq = xeDangXem == null ? bus.TiepNhanXeMoi(xe, kh) : bus.CapNhat(xe, kh);
            if (kq != "") { MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            MessageBox.Show((xeDangXem == null ? "Đã tiếp nhận xe mới " : "Đã cập nhật thông tin xe ") + bienSo + ".",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBienSoTra.Text = bienSo;
            TaiDanhSach("");
            try { XeDTO moi = bus.TraCuu(bienSo); if (moi != null) HienXe(moi); } catch { }
        }

        private void BaoLoi(Control c, string thongBao, List<string> loi)
        {
            errorProvider1.SetError(c, thongBao);
            loi.Add(thongBao);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtBienSoTra.Clear();
            LamMoi();
            lblKetQua.ForeColor = Color.SteelBlue;
            lblKetQua.Text = "Nhập biển số rồi bấm Tra cứu (ví dụ 51H-123.45).";
        }

        private void LamMoi()
        {
            errorProvider1.Clear();
            xeDangXem = null;
            maChuXe = 0;
            txtBienSo.ReadOnly = false;
            txtBienSo.Clear();
            cboHieuXe.Text = "";
            cboHieuXe.SelectedIndex = -1;
            nudNamSX.Value = DateTime.Today.Year;
            txtDienThoai.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            lblLoaiChu.Text = "";
            dgvXe.ClearSelection();
        }

        // ===================== LẬP PHIẾU =====================

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (xeDangXem == null)
            {
                MessageBox.Show("Hãy tra cứu hoặc chọn 1 xe đã có trong hệ thống (nếu là xe mới thì bấm Lưu trước).",
                    "Chưa chọn xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (FormLapPhieu f = new FormLapPhieu(xeDangXem.BienSo))
            {
                f.ShowDialog(this);
            }
        }
    }
}
