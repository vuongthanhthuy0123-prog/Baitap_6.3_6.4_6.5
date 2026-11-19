namespace QuanLyKaraoke.BUS
{
    using QuanLyKaraoke.DAL;
    using QuanLyKaraoke.DTO;

    public class DichVuBUS
    {
        private readonly DichVuDAL dal = new DichVuDAL();

        public List<DichVuDTO> TimKiem(string tuKhoa) { return dal.TimKiem((tuKhoa ?? "").Trim()); }

        public string Them(DichVuDTO dv)
        {
            try { return dal.Them(dv) ? "" : "Không thêm được dịch vụ."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "dịch vụ"); }
        }

        public string Sua(DichVuDTO dv)
        {
            try { return dal.Sua(dv) ? "" : "Không tìm thấy dịch vụ để sửa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "dịch vụ"); }
        }

        public string Xoa(int ma)
        {
            try { return dal.Xoa(ma) ? "" : "Không tìm thấy dịch vụ để xóa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "dịch vụ"); }
        }
    }
}
