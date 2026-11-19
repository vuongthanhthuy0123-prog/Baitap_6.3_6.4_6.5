using System.Data;

namespace QuanLyKaraoke.BUS
{
    using QuanLyKaraoke.DAL;
    using QuanLyKaraoke.DTO;

    public class HoaDonBUS
    {
        private readonly HoaDonDAL dal = new HoaDonDAL();
        private readonly ChiTietDichVuDAL chiTietDAL = new ChiTietDichVuDAL();

        // ---------- Tính giờ ----------
        public static double SoGio(DateTime gioVao, DateTime gioRa)
        {
            return Math.Max(0, (gioRa - gioVao).TotalHours);           // thời gian hát = GioRa - GioVao
        }

        public static decimal TienPhong(DateTime gioVao, DateTime gioRa, decimal giaTheoGio)
        {
            return Math.Round((decimal)SoGio(gioVao, gioRa) * giaTheoGio, 0);   // TongTienPhong = Số giờ × GiaTheoGio
        }

        public static string ThoiGianHat(DateTime gioVao, DateTime gioRa)
        {
            TimeSpan t = gioRa - gioVao;
            if (t.TotalMinutes < 0) t = TimeSpan.Zero;
            return (int)t.TotalHours + " giờ " + t.Minutes.ToString("00") + " phút";
        }

        public DateTime GioHienTai()
        {
            return dal.GioHienTaiServer();
        }

        public int MoPhong(int maPhong, out string loi) { return dal.MoPhong(maPhong, out loi); }

        // ---------- Dịch vụ (DataTable ngắt kết nối) ----------
        public DataTable NapDichVu(int maHD, List<DichVuDTO> danhMuc)
        {
            DataTable dt = chiTietDAL.NapDichVuCuaHoaDon(maHD);
            dt.Columns.Add("TenDV", typeof(string));                                 // cột hiển thị
            dt.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");        // cột tính toán
            foreach (DataRow r in dt.Rows)
            {
                DichVuDTO dv = danhMuc.FirstOrDefault(x => x.MaDV == Convert.ToInt32(r["MaDV"]));
                r["TenDV"] = dv == null ? "?" : dv.TenDV;
            }
            dt.AcceptChanges();
            return dt;
        }

        // Thêm dịch vụ vào DataTable: đã có thì cộng dồn số lượng
        public static void ThemDichVu(DataTable dt, int maHD, DichVuDTO dv, int soLuong)
        {
            DataRow dong = dt.Rows.Cast<DataRow>().FirstOrDefault(r => r.RowState != DataRowState.Deleted &&
                                                                       Convert.ToInt32(r["MaDV"]) == dv.MaDV);
            if (dong != null)
            {
                dong["SoLuong"] = Convert.ToInt32(dong["SoLuong"]) + soLuong;
                return;
            }
            dong = dt.NewRow();
            dong["MaHD"] = maHD;
            dong["MaDV"] = dv.MaDV;
            dong["SoLuong"] = soLuong;
            dong["DonGia"] = dv.DonGia;
            dong["TenDV"] = dv.TenDV;
            dt.Rows.Add(dong);
        }

        public static decimal TienDichVu(DataTable dt)
        {
            decimal tong = 0;
            if (dt == null) return 0;
            foreach (DataRow r in dt.Rows)
                if (r.RowState != DataRowState.Deleted)
                    tong += Convert.ToInt32(r["SoLuong"]) * Convert.ToDecimal(r["DonGia"]);
            return tong;
        }

        public int LuuDichVu(DataTable dt)
        {
            return chiTietDAL.Luu(dt);       // SqlCommandBuilder + adapter.Update()
        }

        // ---------- Thanh toán ----------
        public bool ThanhToan(PhongHatDTO phong, DataTable dichVu, out HoaDonDTO hoaDon, out string loi)
        {
            hoaDon = null;
            if (!phong.MaHD.HasValue || !phong.GioVao.HasValue) { loi = "Phòng này chưa được mở."; return false; }

            // Lưu các dịch vụ chưa lưu trước khi thanh toán
            if (dichVu != null && dichVu.GetChanges() != null) chiTietDAL.Luu(dichVu);

            DateTime gioRa = dal.GioHienTaiServer();
            hoaDon = new HoaDonDTO
            {
                MaHD = phong.MaHD.Value,
                MaPhong = phong.MaPhong,
                TenPhong = phong.TenPhong,
                GioVao = phong.GioVao.Value,
                GioRa = gioRa,
                TongTienPhong = TienPhong(phong.GioVao.Value, gioRa, phong.GiaTheoGio),
                TongTienDichVu = TienDichVu(dichVu)
            };
            return dal.ThanhToan(hoaDon, dichVu ?? new DataTable(), out loi);
        }

        // ---------- Báo cáo ----------
        public decimal DoanhThuNgay(DateTime ngay) { return dal.DoanhThuNgay(ngay); }
        public decimal DoanhThuThang(int thang, int nam) { return dal.DoanhThuThang(thang, nam); }
        public List<HoaDonDTO> HoaDonDaThanhToan(DateTime ngay) { return dal.HoaDonDaThanhToan(ngay); }
        public List<TopDichVuDTO> TopDichVu() { return dal.TopDichVu(); }
        public int DemPhongDangHat() { return dal.DemPhongDangHat(); }
    }
}
