namespace QuanLyGarage.BUS
{
    using QuanLyGarage.DAL;
    using QuanLyGarage.DTO;

    public class XeBUS
    {
        private readonly XeDAL xeDAL = new XeDAL();
        private readonly KhachHangDAL khachHangDAL = new KhachHangDAL();

        public static string ChuanHoaBienSo(string bienSo)
        {
            return (bienSo ?? "").Trim().ToUpper().Replace(" ", "");
        }

        public XeDTO TraCuu(string bienSo) { return xeDAL.TraCuu(ChuanHoaBienSo(bienSo)); }
        public List<XeDTO> TimKiem(string tuKhoa) { return xeDAL.TimKiem((tuKhoa ?? "").Trim()); }
        public int DemXe() { return xeDAL.DemXe(); }
        public KhachHangDTO TimChuXe(string dienThoai) { return khachHangDAL.TimTheoDienThoai((dienThoai ?? "").Trim()); }

        // Tiếp nhận xe mới. maKH = 0 nghĩa là chủ xe mới.
        public string TiepNhanXeMoi(XeDTO xe, KhachHangDTO chuXe)
        {
            try
            {
                if (xeDAL.TraCuu(xe.BienSo) != null) return "Biển số " + xe.BienSo + " đã có trong hệ thống.";
                if (chuXe.MaKH == 0)
                    xeDAL.ThemXeVaChuXeMoi(chuXe, xe);
                else
                {
                    khachHangDAL.Sua(chuXe);
                    xeDAL.ThemXeChoKhachCu(xe, chuXe.MaKH);
                }
                return "";
            }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "xe"); }
        }

        public string CapNhat(XeDTO xe, KhachHangDTO chuXe)
        {
            try
            {
                xeDAL.SuaXe(xe);
                khachHangDAL.Sua(chuXe);
                return "";
            }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "xe"); }
        }
    }
}
