using System.Data;

namespace QuanLyDuAn.DAL
{
    using QuanLyDuAn.DTO;

    public class ThanhVienDAL
    {
        public List<ThanhVienDTO> TimKiem(string tuKhoa)
        {
            string sql = "SELECT MaThanhVien, HoTen, Email, ChuyenMon FROM ThanhVien " +
                         "WHERE HoTen LIKE @TuKhoa OR Email LIKE @TuKhoa OR ChuyenMon LIKE @TuKhoa ORDER BY MaThanhVien";
            DataTable dt = DataProvider.ExecuteQuery(sql, DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            List<ThanhVienDTO> ds = new List<ThanhVienDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new ThanhVienDTO
                {
                    MaThanhVien = Convert.ToInt32(r["MaThanhVien"]),
                    HoTen = r["HoTen"].ToString(),
                    Email = r["Email"].ToString(),
                    ChuyenMon = r["ChuyenMon"].ToString()
                });
            }
            return ds;
        }

        public bool Them(ThanhVienDTO tv)
        {
            return DataProvider.ExecuteNonQuery(
                "INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) VALUES (@HoTen, @Email, @ChuyenMon)",
                DataProvider.TS("@HoTen", tv.HoTen), DataProvider.TS("@Email", tv.Email), DataProvider.TS("@ChuyenMon", tv.ChuyenMon)) > 0;
        }

        public bool Sua(ThanhVienDTO tv)
        {
            return DataProvider.ExecuteNonQuery(
                "UPDATE ThanhVien SET HoTen = @HoTen, Email = @Email, ChuyenMon = @ChuyenMon WHERE MaThanhVien = @Ma",
                DataProvider.TS("@Ma", tv.MaThanhVien), DataProvider.TS("@HoTen", tv.HoTen),
                DataProvider.TS("@Email", tv.Email), DataProvider.TS("@ChuyenMon", tv.ChuyenMon)) > 0;
        }

        public bool Xoa(int ma)
        {
            return DataProvider.ExecuteNonQuery("DELETE FROM ThanhVien WHERE MaThanhVien = @Ma", DataProvider.TS("@Ma", ma)) > 0;
        }
    }
}
