namespace QuanLyGarage.DTO
{
    // Một dòng phụ tùng + tiền công trong phiếu sửa chữa
    public class ChiTietSuaChuaDTO
    {
        public int MaPhieu { get; set; }
        public int MaPhuTung { get; set; }
        public string TenPhuTung { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal TienCong { get; set; }

        public decimal TienPhuTung
        {
            get { return SoLuong * DonGia; }
        }

        public decimal ThanhTien
        {
            get { return TienPhuTung + TienCong; }
        }
    }
}
