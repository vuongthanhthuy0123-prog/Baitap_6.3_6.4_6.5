using System.Data;
using System.Globalization;

namespace QuanLyKaraoke.GUI
{
    using QuanLyKaraoke.BUS;
    using QuanLyKaraoke.DAL;
    using QuanLyKaraoke.DTO;

    public partial class FormMain : Form
    {
        private readonly PhongHatBUS phongBUS = new PhongHatBUS();
        private readonly DichVuBUS dichVuBUS = new DichVuBUS();
        private readonly HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");

        private bool daKetNoi = false;
        private List<PhongHatDTO> dsPhong = new List<PhongHatDTO>();
        private List<DichVuDTO> dsDichVu = new List<DichVuDTO>();
        private PhongHatDTO phongDangChon = null;
        private DataTable dtDichVu = null;               // dịch vụ của phòng đang chọn (ngắt kết nối)
        private DateTime gioServer = DateTime.Now;       // giờ hiện tại của SQL Server
        private DateTime gioMayLucLay = DateTime.Now;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dgvDichVu.AutoGenerateColumns = false;
            colDonGia.DefaultCellStyle.FormatProvider = vi;
            colThanhTien.DefaultCellStyle.FormatProvider = vi;
            try
            {
                string chuoi = DataProvider.ChuoiKetNoi;
                daKetNoi = true;
                lblKetNoi.Text = "Đã kết nối CSDL KaraokeDB trên server: " + DataProvider.TenServer;
            }
            catch (Exception ex)
            {
                lblKetNoi.Text = "Chưa kết nối được CSDL";
                MessageBox.Show(ex.Message, "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienPhongDangChon();
            TaiLai();
            tmrDongHo.Start();
            CapNhatDongHo();
        }

        // Giờ hiện tại theo SQL Server (lấy 1 lần, sau đó cộng thêm thời gian đã trôi trên máy)
        private DateTime BayGio
        {
            get { return gioServer + (DateTime.Now - gioMayLucLay); }
        }

        private void TaiLai()
        {
            if (!daKetNoi) return;
            try
            {
                gioServer = hoaDonBUS.GioHienTai();
                gioMayLucLay = DateTime.Now;
                dsPhong = phongBUS.LayDanhSach();
                dsDichVu = dichVuBUS.TimKiem("");

                cboDichVu.DisplayMember = "HienThi";
                cboDichVu.ValueMember = "MaDV";
                cboDichVu.DataSource = new List<DichVuDTO>(dsDichVu);
                cboDichVu.SelectedIndex = -1;

                VeSoDoPhong();

                // Giữ phòng đang chọn
                if (phongDangChon != null)
                {
                    PhongHatDTO moi = dsPhong.FirstOrDefault(x => x.MaPhong == phongDangChon.MaPhong);
                    ChonPhong(moi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== SƠ ĐỒ PHÒNG (Button động) =====================

        private void VeSoDoPhong()
        {
            flpPhong.SuspendLayout();
            flpPhong.Controls.Clear();
            foreach (PhongHatDTO p in dsPhong)
            {
                Button b = new Button();
                b.Size = new Size(156, 104);
                b.Margin = new Padding(8);
                b.FlatStyle = FlatStyle.Flat;
                b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                b.BackColor = p.DangHat ? Color.Firebrick : Color.SeaGreen;     // Trống: xanh, Đang hát: đỏ
                b.FlatAppearance.BorderColor = Color.Gold;
                b.FlatAppearance.BorderSize = phongDangChon != null && phongDangChon.MaPhong == p.MaPhong ? 4 : 0;
                b.Tag = p;
                b.Text = ChuTrenNut(p);
                b.Click += NutPhong_Click;
                flpPhong.Controls.Add(b);
            }
            flpPhong.ResumeLayout();
            int dangHat = dsPhong.Count(x => x.DangHat);
            lblDemPhong.Text = "Tổng " + dsPhong.Count + " phòng  |  " + dangHat + " đang hát  |  " + (dsPhong.Count - dangHat) + " trống";
        }

        private string ChuTrenNut(PhongHatDTO p)
        {
            string s = p.TenPhong + "\n" + p.LoaiPhong + " - " + p.GiaTheoGio.ToString("N0", vi) + "đ/giờ\n";
            if (p.DangHat && p.GioVao.HasValue)
                s += "● Đang hát: " + HoaDonBUS.ThoiGianHat(p.GioVao.Value, BayGio);
            else
                s += "○ Trống";
            return s;
        }

        private void NutPhong_Click(object sender, EventArgs e)
        {
            PhongHatDTO p = ((Button)sender).Tag as PhongHatDTO;
            ChonPhong(p);
            foreach (Control c in flpPhong.Controls)
            {
                Button b = c as Button;
                if (b != null) b.FlatAppearance.BorderSize = b.Tag == p ? 4 : 0;
            }
        }

        private void ChonPhong(PhongHatDTO p)
        {
            phongDangChon = p;
            dtDichVu = null;
            if (p != null && p.DangHat && p.MaHD.HasValue)
            {
                try
                {
                    // SqlDataAdapter nạp dịch vụ đã gọi của phòng vào DataTable
                    dtDichVu = hoaDonBUS.NapDichVu(p.MaHD.Value, dsDichVu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dgvDichVu.DataSource = dtDichVu;
            HienPhongDangChon();
        }

        private void HienPhongDangChon()
        {
            PhongHatDTO p = phongDangChon;
            bool dangHat = p != null && p.DangHat;
            btnMoPhong.Enabled = p != null && !p.DangHat;
            btnThemDV.Enabled = dangHat;
            btnXoaDV.Enabled = dangHat;
            btnLuuDV.Enabled = dangHat;
            btnThanhToan.Enabled = dangHat;
            dgvDichVu.ReadOnly = !dangHat;

            if (p == null)
            {
                lblTenPhong.Text = "(chưa chọn phòng)";
                lblThongTin.Text = "Bấm vào 1 phòng ở sơ đồ bên trái.";
                lblTien.Text = "Tiền phòng (tạm tính): 0 đ\nTiền dịch vụ: 0 đ";
                lblTongCong.Text = "TỔNG: 0 đ";
                return;
            }

            lblTenPhong.Text = p.TenPhong + (dangHat ? "  -  ĐANG HÁT" : "  -  TRỐNG");
            lblTenPhong.ForeColor = dangHat ? Color.Firebrick : Color.SeaGreen;
            string s = "Loại phòng: " + p.LoaiPhong + "\nGiá: " + p.GiaTheoGio.ToString("N0", vi) + " đ / giờ\n";
            decimal tienPhong = 0;
            if (dangHat && p.GioVao.HasValue)
            {
                s += "Giờ vào: " + p.GioVao.Value.ToString("HH:mm  dd/MM/yyyy") + "\n" +
                     "Đã hát: " + HoaDonBUS.ThoiGianHat(p.GioVao.Value, BayGio);
                tienPhong = HoaDonBUS.TienPhong(p.GioVao.Value, BayGio, p.GiaTheoGio);
            }
            else
            {
                s += "Phòng đang trống. Bấm \"MỞ PHÒNG\" khi có khách.";
            }
            lblThongTin.Text = s;

            decimal tienDV = HoaDonBUS.TienDichVu(dtDichVu);
            int chuaLuu = dtDichVu == null || dtDichVu.GetChanges() == null ? 0 : dtDichVu.GetChanges().Rows.Count;
            lblTien.Text = "Tiền phòng (tạm tính): " + tienPhong.ToString("N0", vi) + " đ\n" +
                           "Tiền dịch vụ: " + tienDV.ToString("N0", vi) + " đ" + (chuaLuu > 0 ? "   (" + chuaLuu + " dòng chưa lưu)" : "");
            lblTongCong.Text = "TỔNG: " + (tienPhong + tienDV).ToString("N0", vi) + " đ";
        }

        // ===================== MỞ PHÒNG =====================

        private void btnMoPhong_Click(object sender, EventArgs e)
        {
            if (phongDangChon == null || phongDangChon.DangHat) return;
            if (MessageBox.Show("Mở " + phongDangChon.TenPhong + " cho khách?", "Mở phòng",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            string loi;
            int maHD = hoaDonBUS.MoPhong(phongDangChon.MaPhong, out loi);
            if (maHD < 0) { MessageBox.Show(loi, "Không mở được phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            lblKetNoi.Text = "Đã mở " + phongDangChon.TenPhong + " - hóa đơn #" + maHD + " lúc " + DateTime.Now.ToString("HH:mm");
            TaiLai();
        }

        // ===================== GỌI DỊCH VỤ (DataTable ngắt kết nối) =====================

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (dtDichVu == null || phongDangChon == null || !phongDangChon.MaHD.HasValue) return;
            DichVuDTO dv = cboDichVu.SelectedItem as DichVuDTO;
            if (dv == null)
            {
                errorProvider1.SetError(cboDichVu, "Chọn dịch vụ / đồ uống.");
                return;
            }
            errorProvider1.SetError(cboDichVu, "");
            HoaDonBUS.ThemDichVu(dtDichVu, phongDangChon.MaHD.Value, dv, (int)nudSoLuong.Value);
            nudSoLuong.Value = 1;
            cboDichVu.SelectedIndex = -1;
            HienPhongDangChon();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (dtDichVu == null || dgvDichVu.CurrentRow == null) return;
            DataRowView drv = dgvDichVu.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null) return;
            drv.Row.Delete();
            HienPhongDangChon();
        }

        private void dgvDichVu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDichVu == null) return;
            DataRowView drv = dgvDichVu.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv != null && (drv.Row["SoLuong"] == DBNull.Value || Convert.ToInt32(drv.Row["SoLuong"]) <= 0))
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                drv.Row["SoLuong"] = 1;
            }
            HienPhongDangChon();
        }

        private void dgvDichVu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Số lượng phải là số nguyên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLuuDV_Click(object sender, EventArgs e)
        {
            if (dtDichVu == null) return;
            dgvDichVu.EndEdit();
            if (dtDichVu.GetChanges() == null)
            {
                MessageBox.Show("Không có thay đổi nào cần lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                int n = hoaDonBUS.LuuDichVu(dtDichVu);       // SqlCommandBuilder + adapter.Update()
                MessageBox.Show("Đã lưu " + n + " thay đổi dịch vụ của " + phongDangChon.TenPhong + ".", "Lưu thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienPhongDangChon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== THANH TOÁN (SqlTransaction ở DAL) =====================

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (phongDangChon == null || !phongDangChon.DangHat) return;
            dgvDichVu.EndEdit();
            decimal tamTinh = HoaDonBUS.TienPhong(phongDangChon.GioVao.Value, BayGio, phongDangChon.GiaTheoGio) + HoaDonBUS.TienDichVu(dtDichVu);
            if (MessageBox.Show("Thanh toán " + phongDangChon.TenPhong + "?\nTạm tính: " + tamTinh.ToString("N0", vi) + " đ",
                    "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                HoaDonDTO hd;
                string loi;
                if (!hoaDonBUS.ThanhToan(phongDangChon, dtDichVu, out hd, out loi))
                {
                    MessageBox.Show(loi, "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TaiLai();
                    return;
                }
                MessageBox.Show(
                    "HÓA ĐƠN #" + hd.MaHD + " - " + hd.TenPhong + "\n" +
                    "Giờ vào: " + hd.GioVao.ToString("HH:mm") + "   Giờ ra: " + hd.GioRa.Value.ToString("HH:mm") + "\n" +
                    "Thời gian hát: " + HoaDonBUS.ThoiGianHat(hd.GioVao, hd.GioRa.Value) +
                    " (" + HoaDonBUS.SoGio(hd.GioVao, hd.GioRa.Value).ToString("0.00") + " giờ)\n" +
                    "----------------------------------\n" +
                    "Tiền phòng: " + hd.TongTienPhong.ToString("N0", vi) + " đ\n" +
                    "Tiền dịch vụ: " + hd.TongTienDichVu.ToString("N0", vi) + " đ\n" +
                    "TỔNG CỘNG: " + hd.TongCong.ToString("N0", vi) + " đ\n\nPhòng đã được trả về trạng thái Trống.",
                    "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== ĐỒNG HỒ: cập nhật thời gian hát =====================

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            CapNhatDongHo();
        }

        private void CapNhatDongHo()
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm  dd/MM/yyyy");
            foreach (Control c in flpPhong.Controls)
            {
                Button b = c as Button;
                PhongHatDTO p = b == null ? null : b.Tag as PhongHatDTO;
                if (p != null) b.Text = ChuTrenNut(p);
            }
            if (phongDangChon != null) HienPhongDangChon();
        }

        // ===================== MENU =====================

        private void MoForm(Form f)
        {
            if (!daKetNoi)
            {
                MessageBox.Show("Chưa kết nối được CSDL. Hãy chạy file Database\\ScriptDB.sql rồi mở lại chương trình.",
                    "Chưa có CSDL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (f) { f.ShowDialog(this); }
            TaiLai();
        }

        private void mnuPhong_Click(object sender, EventArgs e) { MoForm(new FormPhong()); }
        private void mnuDichVu_Click(object sender, EventArgs e) { MoForm(new FormDichVu()); }
        private void mnuBaoCao_Click(object sender, EventArgs e) { MoForm(new FormBaoCao()); }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
