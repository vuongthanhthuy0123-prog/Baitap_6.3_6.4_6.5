namespace QuanLyKaraoke.DTO
{
    public class PhongHatDTO
    {
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public decimal GiaTheoGio { get; set; }
        public string TrangThai { get; set; }       // "Trống" / "Đang hát"

        // Hóa đơn đang mở của phòng (nếu đang hát)
        public int? MaHD { get; set; }
        public DateTime? GioVao { get; set; }

        public bool DangHat
        {
            get { return TrangThai == "Đang hát"; }
        }
    }
}
