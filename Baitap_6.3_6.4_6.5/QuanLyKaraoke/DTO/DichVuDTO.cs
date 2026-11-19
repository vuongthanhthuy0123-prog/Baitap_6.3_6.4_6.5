namespace QuanLyKaraoke.DTO
{
    public class DichVuDTO
    {
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal DonGia { get; set; }
        public int TonKho { get; set; }

        public string HienThi
        {
            get { return TenDV + " - " + DonGia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " đ (còn " + TonKho + ")"; }
        }
    }
}
