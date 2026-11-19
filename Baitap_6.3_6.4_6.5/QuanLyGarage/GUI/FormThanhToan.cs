using System.Globalization;

namespace QuanLyGarage.GUI
{
    using QuanLyGarage.BUS;
    using QuanLyGarage.DTO;

    public partial class FormThanhToan : Form
    {
        private readonly PhieuSuaChuaBUS bus = new PhieuSuaChuaBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");

        private List<PhieuSuaChuaDTO> dsPhieu = new List<PhieuSuaChuaDTO>();
        private PhieuSuaChuaDTO phieuDangChon = null;
        private List<ChiTietSuaChuaDTO> chiTietDangChon = new List<ChiTietSuaChuaDTO>();

        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            dgvPhieu.AutoGenerateColumns = false;
            dgvChiTiet.AutoGenerateColumns = false;
            colTongTien.DefaultCellStyle.FormatProvider = vi;
            colCong.DefaultCellStyle.FormatProvider = vi;
            colTT.DefaultCellStyle.FormatProvider = vi;
            cboLoc.SelectedIndex = 2;        // mặc định xem các phiếu "Đã hoàn thành" (chờ thanh toán)
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                string trangThai = cboLoc.SelectedIndex > 0 ? cboLoc.Text : "";
                dsPhieu = bus.DanhSach(trangThai, txtTim.Text);
                dgvPhieu.DataSource = dsPhieu;
                dgvPhieu.ClearSelection();
                lblTongSo.Text = dsPhieu.Count + " phiếu";

                // ExecuteScalar: doanh thu tháng hiện tại
                decimal dt = bus.DoanhThuThang(DateTime.Today.Month, DateTime.Today.Year);
                lblDoanhThu.Text = "Doanh thu tháng " + DateTime.Today.ToString("MM/yyyy") + ": " + dt.ToString("N0", vi) + " đ";

                if (phieuDangChon != null)
                {
                    PhieuSuaChuaDTO moi = dsPhieu.FirstOrDefault(x => x.MaPhieu == phieuDangChon.MaPhieu);
                    if (moi != null) HienPhieu(moi); else XoaHoaDon();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BoLoc_Changed(object sender, EventArgs e)
        {
            if (dgvPhieu.Columns.Count == 0) return;
            TaiDanhSach();
        }

        private void dgvPhieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dsPhieu.Count) return;
            string tt = dsPhieu[e.RowIndex].TrangThai;
            if (tt == "Đã thanh toán") e.CellStyle.ForeColor = Color.Gray;
            else if (tt == "Đã hoàn thành") e.CellStyle.ForeColor = Color.SeaGreen;
            else e.CellStyle.ForeColor = Color.DarkOrange;
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            PhieuSuaChuaDTO p = dgvPhieu.Rows[e.RowIndex].DataBoundItem as PhieuSuaChuaDTO;
            if (p != null) HienPhieu(p);
        }

        private void HienPhieu(PhieuSuaChuaDTO p)
        {
            try
            {
                phieuDangChon = p;
                chiTietDangChon = bus.ChiTiet(p.MaPhieu);
                dgvChiTiet.DataSource = chiTietDangChon;
                dgvChiTiet.ClearSelection();

                lblThongTin.Text = "PHIẾU SỬA CHỮA #" + p.MaPhieu + "   (" + p.TrangThai + ")\n" +
                                   "Xe: " + p.BienSo + " - " + p.HieuXe + "\n" +
                                   "Chủ xe: " + p.TenKH + "\n" +
                                   "Ngày nhận: " + p.NgayNhan.ToString("dd/MM/yyyy HH:mm") + "\n" +
                                   "Nội dung: " + p.NoiDungSua;
                lblTien.Text = "Tiền phụ tùng: " + PhieuSuaChuaBUS.TienPhuTung(chiTietDangChon).ToString("N0", vi) + " đ\n" +
                               "Tiền công: " + PhieuSuaChuaBUS.TienCong(chiTietDangChon).ToString("N0", vi) + " đ";
                lblTongTien.Text = "TỔNG CHI PHÍ: " + PhieuSuaChuaBUS.TongChiPhi(chiTietDangChon).ToString("N0", vi) + " đ";
                btnThanhToan.Enabled = p.TrangThai != "Đã thanh toán";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void XoaHoaDon()
        {
            phieuDangChon = null;
            chiTietDangChon = new List<ChiTietSuaChuaDTO>();
            dgvChiTiet.DataSource = chiTietDangChon;
            lblThongTin.Text = "Chọn 1 phiếu ở danh sách bên trái.";
            lblTien.Text = "Tiền phụ tùng: 0 đ\nTiền công: 0 đ";
            lblTongTien.Text = "TỔNG CHI PHÍ: 0 đ";
            btnThanhToan.Enabled = true;
        }

        // Thanh toán: tính tổng chi phí rồi chuyển trạng thái phiếu sang "Đã thanh toán"
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (phieuDangChon == null)
            {
                MessageBox.Show("Hãy chọn 1 phiếu sửa chữa ở danh sách bên trái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal tong = PhieuSuaChuaBUS.TongChiPhi(chiTietDangChon);
            if (MessageBox.Show("Thu " + tong.ToString("N0", vi) + " đ cho phiếu #" + phieuDangChon.MaPhieu + " (xe " + phieuDangChon.BienSo + ")?",
                    "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string loi = bus.ThanhToan(phieuDangChon, tong);
            if (loi != "") { MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            MessageBox.Show(TaoHoaDon(phieuDangChon, chiTietDangChon, tong), "HÓA ĐƠN DỊCH VỤ - ĐÃ THANH TOÁN",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiDanhSach();
        }

        private string TaoHoaDon(PhieuSuaChuaDTO p, List<ChiTietSuaChuaDTO> ds, decimal tong)
        {
            string s = "GARAGE Ô TÔ - HÓA ĐƠN DỊCH VỤ\n" +
                       "Phiếu #" + p.MaPhieu + "   Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n" +
                       "Xe: " + p.BienSo + " (" + p.HieuXe + ")   Chủ xe: " + p.TenKH + "\n" +
                       "----------------------------------------\n";
            foreach (ChiTietSuaChuaDTO ct in ds)
                s += "• " + ct.TenPhuTung + " x" + ct.SoLuong + ": " + ct.TienPhuTung.ToString("N0", vi) +
                     " đ + công " + ct.TienCong.ToString("N0", vi) + " đ\n";
            s += "----------------------------------------\n" +
                 "Tiền phụ tùng: " + PhieuSuaChuaBUS.TienPhuTung(ds).ToString("N0", vi) + " đ\n" +
                 "Tiền công: " + PhieuSuaChuaBUS.TienCong(ds).ToString("N0", vi) + " đ\n" +
                 "TỔNG THANH TOÁN: " + tong.ToString("N0", vi) + " đ\n\nCảm ơn quý khách!";
            return s;
        }
    }
}
