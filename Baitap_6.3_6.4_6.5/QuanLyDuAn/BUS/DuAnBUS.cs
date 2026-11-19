namespace QuanLyDuAn.BUS
{
    using QuanLyDuAn.DAL;
    using QuanLyDuAn.DTO;

    public class DuAnBUS
    {
        public static readonly string[] CAC_TRANG_THAI = { "Đang chạy", "Hoàn thành", "Tạm dừng" };
        private readonly DuAnDAL dal = new DuAnDAL();

        public List<DuAnDTO> TimKiem(string tuKhoa) { return dal.TimKiem((tuKhoa ?? "").Trim()); }

        public string Them(DuAnDTO d)
        {
            string loi = KiemTra(d);
            if (loi != "") return loi;
            try { return dal.Them(d) ? "" : "Không thêm được dự án."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "dự án"); }
        }

        public string Sua(DuAnDTO d)
        {
            string loi = KiemTra(d);
            if (loi != "") return loi;
            try { return dal.Sua(d) ? "" : "Không tìm thấy dự án để sửa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "dự án"); }
        }

        public string Xoa(int ma)
        {
            try { return dal.Xoa(ma) ? "" : "Không tìm thấy dự án để xóa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "dự án"); }
        }

        private static string KiemTra(DuAnDTO d)
        {
            if (d.NgayBatDau.HasValue && d.NgayKetThuc.HasValue && d.NgayKetThuc.Value.Date < d.NgayBatDau.Value.Date)
                return "Ngày kết thúc không được trước ngày bắt đầu.";
            return "";
        }
    }
}
