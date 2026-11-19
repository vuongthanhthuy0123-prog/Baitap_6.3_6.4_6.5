namespace QuanLyGarage.BUS
{
    using QuanLyGarage.DAL;
    using QuanLyGarage.DTO;

    public class PhieuSuaChuaBUS
    {
        private readonly PhieuSuaChuaDAL dal = new PhieuSuaChuaDAL();

        // Tổng chi phí = Tổng (Số lượng phụ tùng × Đơn giá) + Tổng tiền công
        public static decimal TienPhuTung(List<ChiTietSuaChuaDTO> ds) { return ds.Sum(x => x.TienPhuTung); }
        public static decimal TienCong(List<ChiTietSuaChuaDTO> ds) { return ds.Sum(x => x.TienCong); }
        public static decimal TongChiPhi(List<ChiTietSuaChuaDTO> ds) { return TienPhuTung(ds) + TienCong(ds); }

        public int HoanTatPhieu(string bienSo, string noiDung, List<ChiTietSuaChuaDTO> chiTiet, out string loi)
        {
            if (chiTiet == null || chiTiet.Count == 0)
            {
                loi = "Phiếu chưa có phụ tùng / dịch vụ nào.";
                return -1;
            }
            PhieuSuaChuaDTO phieu = new PhieuSuaChuaDTO
            {
                BienSo = bienSo,
                NoiDungSua = noiDung,
                TongTien = TongChiPhi(chiTiet),
                TrangThai = "Đã hoàn thành"
            };
            return dal.LapPhieu(phieu, chiTiet, out loi);
        }

        public List<PhieuSuaChuaDTO> DanhSach(string trangThai, string tuKhoa) { return dal.DanhSach(trangThai, (tuKhoa ?? "").Trim()); }
        public List<ChiTietSuaChuaDTO> ChiTiet(int maPhieu) { return dal.ChiTiet(maPhieu); }
        public decimal DoanhThuThang(int thang, int nam) { return dal.DoanhThuThang(thang, nam); }
        public int DemChuaThanhToan() { return dal.DemChuaThanhToan(); }

        public string ThanhToan(PhieuSuaChuaDTO phieu, decimal tongTien)
        {
            if (phieu.TrangThai == "Đã thanh toán") return "Phiếu này đã được thanh toán rồi.";
            try { return dal.ThanhToan(phieu.MaPhieu, tongTien) ? "" : "Không cập nhật được phiếu (có thể đã thanh toán)."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phiếu"); }
        }
    }
}
