namespace QuanLyDuAn.BUS
{
    using QuanLyDuAn.DAL;
    using QuanLyDuAn.DTO;

    public class ThanhVienBUS
    {
        private readonly ThanhVienDAL dal = new ThanhVienDAL();

        public List<ThanhVienDTO> TimKiem(string tuKhoa) { return dal.TimKiem((tuKhoa ?? "").Trim()); }

        public string Them(ThanhVienDTO tv)
        {
            try { return dal.Them(tv) ? "" : "Không thêm được thành viên."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "thành viên"); }
        }

        public string Sua(ThanhVienDTO tv)
        {
            try { return dal.Sua(tv) ? "" : "Không tìm thấy thành viên để sửa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "thành viên"); }
        }

        public string Xoa(int ma)
        {
            try { return dal.Xoa(ma) ? "" : "Không tìm thấy thành viên để xóa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "thành viên"); }
        }
    }
}
