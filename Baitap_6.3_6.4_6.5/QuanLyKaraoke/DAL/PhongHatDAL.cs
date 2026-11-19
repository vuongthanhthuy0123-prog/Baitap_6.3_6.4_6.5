using System.Data;

namespace QuanLyKaraoke.DAL
{
    using QuanLyKaraoke.DTO;

    public class PhongHatDAL
    {
        // Danh sách phòng kèm hóa đơn đang mở (nếu phòng đang hát)
        public List<PhongHatDTO> LayDanhSach(string tuKhoa)
        {
            DataTable dt = DataProvider.ExecuteQuery(
                "SELECT p.MaPhong, p.TenPhong, p.LoaiPhong, p.GiaTheoGio, p.TrangThai, h.MaHD, h.GioVao " +
                "FROM PhongHat p LEFT JOIN HoaDon h ON h.MaPhong = p.MaPhong AND h.TrangThai = 0 " +
                "WHERE p.TenPhong LIKE @TuKhoa ORDER BY p.LoaiPhong DESC, p.TenPhong",
                DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            List<PhongHatDTO> ds = new List<PhongHatDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new PhongHatDTO
                {
                    MaPhong = Convert.ToInt32(r["MaPhong"]),
                    TenPhong = r["TenPhong"].ToString(),
                    LoaiPhong = r["LoaiPhong"].ToString(),
                    GiaTheoGio = Convert.ToDecimal(r["GiaTheoGio"]),
                    TrangThai = r["TrangThai"].ToString(),
                    MaHD = r["MaHD"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["MaHD"]),
                    GioVao = r["GioVao"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["GioVao"])
                });
            }
            return ds;
        }

        public bool Them(PhongHatDTO p)
        {
            return DataProvider.ExecuteNonQuery(
                "INSERT INTO PhongHat (TenPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES (@Ten, @Loai, @Gia, N'Trống')",
                DataProvider.TS("@Ten", p.TenPhong), DataProvider.TS("@Loai", p.LoaiPhong), DataProvider.TS("@Gia", p.GiaTheoGio)) > 0;
        }

        public bool Sua(PhongHatDTO p)
        {
            return DataProvider.ExecuteNonQuery(
                "UPDATE PhongHat SET TenPhong = @Ten, LoaiPhong = @Loai, GiaTheoGio = @Gia WHERE MaPhong = @Ma",
                DataProvider.TS("@Ma", p.MaPhong), DataProvider.TS("@Ten", p.TenPhong),
                DataProvider.TS("@Loai", p.LoaiPhong), DataProvider.TS("@Gia", p.GiaTheoGio)) > 0;
        }

        public bool Xoa(int ma)
        {
            return DataProvider.ExecuteNonQuery("DELETE FROM PhongHat WHERE MaPhong = @Ma AND TrangThai = N'Trống'",
                DataProvider.TS("@Ma", ma)) > 0;
        }
    }
}
