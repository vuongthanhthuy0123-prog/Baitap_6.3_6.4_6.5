namespace QuanLyGarage.DTO
{
    public class XeDTO
    {
        public string BienSo { get; set; }
        public int MaKH { get; set; }
        public string HieuXe { get; set; }
        public int? NamSanXuat { get; set; }

        // Thông tin chủ xe (lấy kèm khi tra cứu)
        public string TenKH { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
    }
}
