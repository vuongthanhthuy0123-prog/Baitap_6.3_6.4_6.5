using System.Data;

namespace QuanLyDuAn.DAL
{
    using QuanLyDuAn.DTO;

    public class DuAnDAL
    {
        public List<DuAnDTO> TimKiem(string tuKhoa)
        {
            string sql = "SELECT d.MaDuAn, d.TenDuAn, d.NgayBatDau, d.NgayKetThuc, d.TrangThai, " +
                         "(SELECT COUNT(*) FROM CongViec c WHERE c.MaDuAn = d.MaDuAn) AS SoTask, " +
                         "(SELECT COUNT(*) FROM CongViec c WHERE c.MaDuAn = d.MaDuAn AND c.TrangThai = N'Done') AS SoTaskDone " +
                         "FROM DuAn d WHERE d.TenDuAn LIKE @TuKhoa ORDER BY d.MaDuAn";
            DataTable dt = DataProvider.ExecuteQuery(sql, DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            List<DuAnDTO> ds = new List<DuAnDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new DuAnDTO
                {
                    MaDuAn = Convert.ToInt32(r["MaDuAn"]),
                    TenDuAn = r["TenDuAn"].ToString(),
                    NgayBatDau = r["NgayBatDau"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayBatDau"]),
                    NgayKetThuc = r["NgayKetThuc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayKetThuc"]),
                    TrangThai = r["TrangThai"].ToString(),
                    SoTask = Convert.ToInt32(r["SoTask"]),
                    SoTaskDone = Convert.ToInt32(r["SoTaskDone"])
                });
            }
            return ds;
        }

        public bool Them(DuAnDTO d)
        {
            return DataProvider.ExecuteNonQuery(
                "INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES (@Ten, @BatDau, @KetThuc, @TrangThai)",
                DataProvider.TS("@Ten", d.TenDuAn), DataProvider.TS("@BatDau", d.NgayBatDau),
                DataProvider.TS("@KetThuc", d.NgayKetThuc), DataProvider.TS("@TrangThai", d.TrangThai)) > 0;
        }

        public bool Sua(DuAnDTO d)
        {
            return DataProvider.ExecuteNonQuery(
                "UPDATE DuAn SET TenDuAn = @Ten, NgayBatDau = @BatDau, NgayKetThuc = @KetThuc, TrangThai = @TrangThai WHERE MaDuAn = @Ma",
                DataProvider.TS("@Ma", d.MaDuAn), DataProvider.TS("@Ten", d.TenDuAn), DataProvider.TS("@BatDau", d.NgayBatDau),
                DataProvider.TS("@KetThuc", d.NgayKetThuc), DataProvider.TS("@TrangThai", d.TrangThai)) > 0;
        }

        // Xóa dự án -> các công việc con và phân công bị xóa theo (ON DELETE CASCADE)
        public bool Xoa(int maDuAn)
        {
            return DataProvider.ExecuteNonQuery("DELETE FROM DuAn WHERE MaDuAn = @Ma", DataProvider.TS("@Ma", maDuAn)) > 0;
        }
    }
}
