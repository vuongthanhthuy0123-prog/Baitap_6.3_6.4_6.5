using Microsoft.Data.SqlClient;

namespace QuanLyDuAn.DAL
{
    using QuanLyDuAn.DTO;

    public class BaoCaoDAL
    {
        // SqlDataReader: các task đã quá hạn nộp mà chưa Done
        public List<CongViecDTO> TaskTreHan()
        {
            List<CongViecDTO> ds = new List<CongViecDTO>();
            string sql =
                "SELECT cv.MaTask, d.TenDuAn, cv.TenTask, cv.HanNop, cv.DoUuTien, cv.TrangThai, " +
                "  ISNULL(STUFF((SELECT N', ' + tv.HoTen FROM PhanCong pc JOIN ThanhVien tv ON pc.MaThanhVien = tv.MaThanhVien " +
                "         WHERE pc.MaTask = cv.MaTask FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''), N'(chưa giao)') AS NguoiLam " +
                "FROM CongViec cv JOIN DuAn d ON cv.MaDuAn = d.MaDuAn " +
                "WHERE cv.HanNop < GETDATE() AND cv.TrangThai <> N'Done' ORDER BY cv.HanNop";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        ds.Add(new CongViecDTO
                        {
                            MaTask = rd.GetInt32(0),
                            TenDuAn = rd.GetString(1),
                            TenTask = rd.GetString(2),
                            HanNop = rd.GetDateTime(3),
                            DoUuTien = rd.IsDBNull(4) ? "" : rd.GetString(4),
                            TrangThai = rd.GetString(5),
                            NguoiLam = rd.GetString(6)
                        });
                    }
                }
            }
            return ds;
        }

        public int DemTreHan()
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar(
                "SELECT COUNT(*) FROM CongViec WHERE HanNop < GETDATE() AND TrangThai <> N'Done'"));
        }

        public int DemDuAn()
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar("SELECT COUNT(*) FROM DuAn"));
        }

        public int DemTask()
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar("SELECT COUNT(*) FROM CongViec"));
        }

        // ExecuteScalar: % task đã Done của 1 dự án (0 = tất cả dự án)
        public double TyLeHoanThanh(int maDuAn)
        {
            object kq = DataProvider.ExecuteScalar(
                "SELECT ISNULL(100.0 * SUM(CASE WHEN TrangThai = N'Done' THEN 1 ELSE 0 END) / NULLIF(COUNT(*), 0), 0) " +
                "FROM CongViec WHERE (@MaDuAn = 0 OR MaDuAn = @MaDuAn)", DataProvider.TS("@MaDuAn", maDuAn));
            return Math.Round(Convert.ToDouble(kq), 1);
        }

        // GROUP BY: số task được giao và số task đã xong của từng thành viên
        public List<TienDoThanhVienDTO> TienDoThanhVien(int maDuAn)
        {
            List<TienDoThanhVienDTO> ds = new List<TienDoThanhVienDTO>();
            string sql =
                "SELECT tv.HoTen, COUNT(*) AS TongTask, SUM(CASE WHEN cv.TrangThai = N'Done' THEN 1 ELSE 0 END) AS SoDone " +
                "FROM PhanCong pc JOIN ThanhVien tv ON pc.MaThanhVien = tv.MaThanhVien " +
                "JOIN CongViec cv ON pc.MaTask = cv.MaTask " +
                "WHERE (@MaDuAn = 0 OR cv.MaDuAn = @MaDuAn) " +
                "GROUP BY tv.MaThanhVien, tv.HoTen ORDER BY tv.HoTen";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(DataProvider.TS("@MaDuAn", maDuAn));
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        ds.Add(new TienDoThanhVienDTO
                        {
                            HoTen = rd.GetString(0),
                            TongTask = rd.GetInt32(1),
                            SoDone = rd.GetInt32(2)
                        });
                    }
                }
            }
            return ds;
        }
    }
}
