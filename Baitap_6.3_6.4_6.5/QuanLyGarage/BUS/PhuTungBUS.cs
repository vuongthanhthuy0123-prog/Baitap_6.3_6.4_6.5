namespace QuanLyGarage.BUS
{
    using QuanLyGarage.DAL;
    using QuanLyGarage.DTO;

    public class PhuTungBUS
    {
        private readonly PhuTungDAL dal = new PhuTungDAL();

        public List<PhuTungDTO> TimKiem(string tuKhoa) { return dal.TimKiem((tuKhoa ?? "").Trim()); }
        public int DemSapHet() { return dal.DemSapHet(5); }

        public string Them(PhuTungDTO pt)
        {
            try { return dal.Them(pt) ? "" : "Không thêm được phụ tùng."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phụ tùng"); }
        }

        public string Sua(PhuTungDTO pt)
        {
            try { return dal.Sua(pt) ? "" : "Không tìm thấy phụ tùng để sửa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phụ tùng"); }
        }

        public string Xoa(int ma)
        {
            try { return dal.Xoa(ma) ? "" : "Không tìm thấy phụ tùng để xóa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phụ tùng"); }
        }
    }
}
