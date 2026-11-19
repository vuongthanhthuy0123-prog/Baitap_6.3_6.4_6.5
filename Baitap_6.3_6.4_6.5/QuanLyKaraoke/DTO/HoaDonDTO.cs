namespace QuanLyKaraoke.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime? GioRa { get; set; }
        public decimal TongTienPhong { get; set; }
        public decimal TongTienDichVu { get; set; }

        public decimal TongCong
        {
            get { return TongTienPhong + TongTienDichVu; }
        }
    }
}
