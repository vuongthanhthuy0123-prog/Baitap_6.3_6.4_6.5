using System.ComponentModel;
using System.Globalization;

namespace QuanLyGarage.GUI
{
    using QuanLyGarage.BUS;
    using QuanLyGarage.DTO;

    public partial class FormLapPhieu : Form
    {
        private readonly XeBUS xeBUS = new XeBUS();
        private readonly PhuTungBUS phuTungBUS = new PhuTungBUS();
        private readonly PhieuSuaChuaBUS phieuBUS = new PhieuSuaChuaBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");

        private readonly BindingList<ChiTietSuaChuaDTO> chiTiet = new BindingList<ChiTietSuaChuaDTO>();
        private readonly Dictionary<int, int> tonKho = new Dictionary<int, int>();
        private XeDTO xeDangSua = null;
        private string bienSoBanDau = "";

        public FormLapPhieu()
        {
            InitializeComponent();
        }

        // Mở từ màn hình Tiếp nhận xe: điền sẵn biển số đã chọn
        public FormLapPhieu(string bienSo) : this()
        {
            bienSoBanDau = bienSo;
        }

        private void FormLapPhieu_Load(object sender, EventArgs e)
        {
            dgvChiTiet.AutoGenerateColumns = false;
            foreach (DataGridViewColumn c in new DataGridViewColumn[] { colDonGia, colTienPhuTung, colTienCong, colThanhTien })
                c.DefaultCellStyle.FormatProvider = vi;
            dgvChiTiet.DataSource = chiTiet;
            NapPhuTung();
            CapNhatTongTien();
            if (bienSoBanDau != "")
            {
                txtBienSo.Text = bienSoBanDau;
                btnTraCuu_Click(null, EventArgs.Empty);
            }
        }

        private void NapPhuTung()
        {
            try
            {
                List<PhuTungDTO> ds = phuTungBUS.TimKiem("");
                tonKho.Clear();
                foreach (PhuTungDTO pt in ds) tonKho[pt.MaPhuTung] = pt.SoLuongTon;
                cboPhuTung.DisplayMember = "HienThi";
                cboPhuTung.ValueMember = "MaPhuTung";
                cboPhuTung.DataSource = ds;
                cboPhuTung.SelectedIndex = -1;
                cboPhuTung.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ===================== XE =====================

        private void txtBienSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnTraCuu_Click(sender, e); }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string bienSo = XeBUS.ChuanHoaBienSo(txtBienSo.Text);
            if (bienSo == "") { errorProvider1.SetError(txtBienSo, "Nhập biển số."); return; }
            try
            {
                xeDangSua = xeBUS.TraCuu(bienSo);
                if (xeDangSua == null)
                {
                    errorProvider1.SetError(txtBienSo, "Xe chưa được tiếp nhận.");
                    lblThongTinXe.ForeColor = Color.Firebrick;
                    lblThongTinXe.Text = "Không tìm thấy xe " + bienSo + ". Hãy tiếp nhận xe ở màn hình Tiếp nhận trước.";
                    return;
                }
                errorProvider1.SetError(txtBienSo, "");
                lblThongTinXe.ForeColor = Color.SeaGreen;
                lblThongTinXe.Text = xeDangSua.HieuXe + " " + xeDangSua.NamSanXuat + "  |  Chủ xe: " + xeDangSua.TenKH + " - " + xeDangSua.DienThoai;
                txtNoiDung.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ===================== THÊM PHỤ TÙNG =====================

        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            PhuTungDTO pt = cboPhuTung.SelectedItem as PhuTungDTO;
            if (pt == null)
            {
                errorProvider1.SetError(cboPhuTung, "Chọn phụ tùng trong danh sách.");
                return;
            }
            decimal tienCong = 0;
            string s = txtTienCong.Text.Trim().Replace(".", "").Replace(",", "").Replace(" ", "");
            if (s != "" && (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out tienCong) || tienCong < 0))
            {
                errorProvider1.SetError(txtTienCong, "Tiền công phải là số không âm.");
                return;
            }

            ChiTietSuaChuaDTO dong = chiTiet.FirstOrDefault(x => x.MaPhuTung == pt.MaPhuTung);
            if (dong == null)
            {
                chiTiet.Add(new ChiTietSuaChuaDTO
                {
                    MaPhuTung = pt.MaPhuTung, TenPhuTung = pt.TenPhuTung,
                    SoLuong = (int)nudSoLuong.Value, DonGia = pt.DonGia, TienCong = tienCong
                });
            }
            else
            {
                dong.SoLuong += (int)nudSoLuong.Value;
                dong.TienCong += tienCong;
                chiTiet.ResetBindings();
            }
            nudSoLuong.Value = 1;
            txtTienCong.Clear();
            cboPhuTung.SelectedIndex = -1;
            cboPhuTung.Text = "";
            CapNhatTongTien();
        }

        // Dòng nào cần nhiều hơn tồn kho thì tô đỏ
        private void dgvChiTiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= chiTiet.Count) return;
            ChiTietSuaChuaDTO ct = chiTiet[e.RowIndex];
            int ton;
            if (tonKho.TryGetValue(ct.MaPhuTung, out ton) && ct.SoLuong > ton) e.CellStyle.ForeColor = Color.Red;
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count == 0) return;
            ChiTietSuaChuaDTO ct = dgvChiTiet.SelectedRows[0].DataBoundItem as ChiTietSuaChuaDTO;
            if (ct != null) chiTiet.Remove(ct);
            CapNhatTongTien();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            if (chiTiet.Count == 0) return;
            if (MessageBox.Show("Xóa hết các dòng trong phiếu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            chiTiet.Clear();
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            List<ChiTietSuaChuaDTO> ds = chiTiet.ToList();
            lblTien.Text = "Tiền phụ tùng: " + PhieuSuaChuaBUS.TienPhuTung(ds).ToString("N0", vi) + " đ\n" +
                           "Tiền công: " + PhieuSuaChuaBUS.TienCong(ds).ToString("N0", vi) + " đ";
            lblTongTien.Text = "TỔNG: " + PhieuSuaChuaBUS.TongChiPhi(ds).ToString("N0", vi) + " đ";
        }

        // ===================== HOÀN TẤT (SqlTransaction ở DAL) =====================

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (xeDangSua == null)
            {
                errorProvider1.SetError(txtBienSo, "Tra cứu xe trước.");
                MessageBox.Show("Hãy nhập biển số và bấm Tra cứu để chọn xe cần sửa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNoiDung.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNoiDung, "Nhập nội dung sửa chữa.");
                MessageBox.Show("Hãy nhập nội dung sửa chữa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (chiTiet.Count == 0)
            {
                MessageBox.Show("Phiếu chưa có phụ tùng / dịch vụ nào.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tong = PhieuSuaChuaBUS.TongChiPhi(chiTiet.ToList());
            if (MessageBox.Show("Hoàn tất phiếu sửa chữa cho xe " + xeDangSua.BienSo + "?\nTổng chi phí: " + tong.ToString("N0", vi) + " đ",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string loi;
            int maPhieu = phieuBUS.HoanTatPhieu(xeDangSua.BienSo, txtNoiDung.Text.Trim(), chiTiet.ToList(), out loi);
            if (maPhieu < 0)
            {
                MessageBox.Show(loi, "Không lập được phiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đã lập phiếu sửa chữa #" + maPhieu + " cho xe " + xeDangSua.BienSo + ".\n" +
                            "Tổng chi phí: " + tong.ToString("N0", vi) + " đ\nĐã trừ phụ tùng trong kho.\n\n" +
                            "Vào màn hình Thanh toán để thu tiền và xuất hóa đơn.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            chiTiet.Clear();
            txtNoiDung.Clear();
            NapPhuTung();          // tồn kho đã thay đổi
            CapNhatTongTien();
        }
    }
}
