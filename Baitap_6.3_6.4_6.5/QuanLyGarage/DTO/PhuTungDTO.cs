namespace QuanLyGarage.DTO
{
    public class PhuTungDTO
    {
        public int MaPhuTung { get; set; }
        public string TenPhuTung { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }

        public string HienThi
        {
            get { return TenPhuTung + "  (tồn " + SoLuongTon + ")"; }
        }
    }
}
