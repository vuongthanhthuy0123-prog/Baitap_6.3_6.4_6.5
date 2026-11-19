namespace QuanLyDuAn.BUS
{
    using QuanLyDuAn.DAL;
    using QuanLyDuAn.DTO;

    public class CongViecBUS
    {
        public static readonly string[] CAC_TRANG_THAI = { "To Do", "In Progress", "Review", "Done" };
        public static readonly string[] CAC_MUC_UU_TIEN = { "Cao", "Trung bình", "Thấp" };

        private readonly CongViecDAL dal = new CongViecDAL();

        public List<CongViecDTO> Loc(int maDuAn, string trangThai, string tuKhoa)
        {
            return dal.Loc(maDuAn, trangThai, (tuKhoa ?? "").Trim());
        }

        // Trả về mã task mới (> 0) hoặc -1 nếu lỗi
        public int Them(CongViecDTO cv, out string loi)
        {
            loi = "";
            try { return dal.Them(cv); }
            catch (Exception ex) { loi = LoiCSDL.DichLoi(ex, "công việc"); return -1; }
        }

        public string Sua(CongViecDTO cv)
        {
            try { return dal.Sua(cv) ? "" : "Không tìm thấy công việc để sửa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "công việc"); }
        }

        public string Xoa(int maTask)
        {
            try { return dal.Xoa(maTask) ? "" : "Không tìm thấy công việc để xóa."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "công việc"); }
        }

        public string ChuyenTrangThai(int maTask, string trangThaiMoi)
        {
            if (!CAC_TRANG_THAI.Contains(trangThaiMoi)) return "Trạng thái không hợp lệ.";
            try { return dal.CapNhatTrangThai(maTask, trangThaiMoi) ? "" : "Không tìm thấy công việc."; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "công việc"); }
        }

        // Trạng thái kế tiếp / trước đó theo thứ tự To Do -> In Progress -> Review -> Done
        public static string TrangThaiKe(string hienTai, int buoc)
        {
            int i = Array.IndexOf(CAC_TRANG_THAI, hienTai);
            if (i < 0) return null;
            int j = i + buoc;
            return j < 0 || j >= CAC_TRANG_THAI.Length ? null : CAC_TRANG_THAI[j];
        }

        public List<int> LayThanhVienDuocGiao(int maTask) { return dal.LayThanhVienDuocGiao(maTask); }

        public string LuuPhanCong(int maTask, List<int> dsThanhVien)
        {
            try { dal.LuuPhanCong(maTask, dsThanhVien); return ""; }
            catch (Exception ex) { return LoiCSDL.DichLoi(ex, "phân công"); }
        }
    }
}
