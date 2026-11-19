namespace QuanLyKaraoke.BUS
{
    using QuanLyKaraoke.DAL;
    using QuanLyKaraoke.DTO;

    public class PhongHatBUS
    {
        private readonly PhongHatDAL dal = new PhongHatDAL();

        public List<PhongHatDTO> LayDanhSach(string tuKhoa = "") { return dal.LayDanhSach((tuKhoa ?? "").Trim()); }

        public string Them(PhongHatDTO p)
        {
            try { return dal.Them(p) ? "" : "Không thêm được phòng."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phòng"); }
        }

        public string Sua(PhongHatDTO p)
        {
            try { return dal.Sua(p) ? "" : "Không tìm thấy phòng để sửa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phòng"); }
        }

        public string Xoa(int ma)
        {
            try { return dal.Xoa(ma) ? "" : "Không xóa được: phòng đang có khách hát."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phòng"); }
        }
    }
}
