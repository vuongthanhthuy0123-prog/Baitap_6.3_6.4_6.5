using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyDuAn.DAL
{
    using QuanLyDuAn.DTO;

    public class CongViecDAL
    {
        // Lọc task theo dự án (0 = tất cả), trạng thái ("" = tất cả) và từ khóa
        public List<CongViecDTO> Loc(int maDuAn, string trangThai, string tuKhoa)
        {
            string sql =
                "SELECT cv.MaTask, cv.MaDuAn, d.TenDuAn, cv.TenTask, cv.MoTa, cv.HanNop, cv.DoUuTien, cv.TrangThai, " +
                "  STUFF((SELECT N', ' + tv.HoTen FROM PhanCong pc JOIN ThanhVien tv ON pc.MaThanhVien = tv.MaThanhVien " +
                "         WHERE pc.MaTask = cv.MaTask FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS NguoiLam " +
                "FROM CongViec cv JOIN DuAn d ON cv.MaDuAn = d.MaDuAn " +
                "WHERE (@MaDuAn = 0 OR cv.MaDuAn = @MaDuAn) AND (@TrangThai = N'' OR cv.TrangThai = @TrangThai) " +
                "  AND cv.TenTask LIKE @TuKhoa " +
                "ORDER BY CASE cv.TrangThai WHEN N'To Do' THEN 1 WHEN N'In Progress' THEN 2 WHEN N'Review' THEN 3 ELSE 4 END, cv.HanNop";
            DataTable dt = DataProvider.ExecuteQuery(sql, DataProvider.TS("@MaDuAn", maDuAn),
                DataProvider.TS("@TrangThai", trangThai ?? ""), DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));

            List<CongViecDTO> ds = new List<CongViecDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new CongViecDTO
                {
                    MaTask = Convert.ToInt32(r["MaTask"]),
                    MaDuAn = Convert.ToInt32(r["MaDuAn"]),
                    TenDuAn = r["TenDuAn"].ToString(),
                    TenTask = r["TenTask"].ToString(),
                    MoTa = r["MoTa"].ToString(),
                    HanNop = r["HanNop"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["HanNop"]),
                    DoUuTien = r["DoUuTien"].ToString(),
                    TrangThai = r["TrangThai"].ToString(),
                    NguoiLam = r["NguoiLam"].ToString()
                });
            }
            return ds;
        }

        public int Them(CongViecDTO cv)
        {
            object kq = DataProvider.ExecuteScalar(
                "INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) OUTPUT INSERTED.MaTask " +
                "VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai)", ThamSo(cv));
            return Convert.ToInt32(kq);
        }

        public bool Sua(CongViecDTO cv)
        {
            return DataProvider.ExecuteNonQuery(
                "UPDATE CongViec SET MaDuAn = @MaDuAn, TenTask = @TenTask, MoTa = @MoTa, HanNop = @HanNop, " +
                "DoUuTien = @DoUuTien, TrangThai = @TrangThai WHERE MaTask = @MaTask", ThamSo(cv)) > 0;
        }

        public bool Xoa(int maTask)
        {
            return DataProvider.ExecuteNonQuery("DELETE FROM CongViec WHERE MaTask = @MaTask", DataProvider.TS("@MaTask", maTask)) > 0;
        }

        // Chuyển trạng thái task: lệnh UPDATE có tham số (Parameterized SQL)
        public bool CapNhatTrangThai(int maTask, string trangThaiMoi)
        {
            return DataProvider.ExecuteNonQuery(
                "UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask",
                DataProvider.TS("@TrangThai", trangThaiMoi), DataProvider.TS("@MaTask", maTask)) > 0;
        }

        public List<int> LayThanhVienDuocGiao(int maTask)
        {
            DataTable dt = DataProvider.ExecuteQuery("SELECT MaThanhVien FROM PhanCong WHERE MaTask = @MaTask",
                DataProvider.TS("@MaTask", maTask));
            return dt.AsEnumerable().Select(r => Convert.ToInt32(r["MaThanhVien"])).ToList();
        }

        // Giao việc cho nhiều thành viên: bỏ người không còn được chọn, thêm người mới (trong 1 transaction)
        public void LuuPhanCong(int maTask, List<int> dsThanhVien)
        {
            List<int> hienTai = LayThanhVienDuocGiao(maTask);
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    foreach (int ma in hienTai.Where(x => !dsThanhVien.Contains(x)))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM PhanCong WHERE MaTask = @MaTask AND MaThanhVien = @MaTV", conn, trans);
                        cmd.Parameters.Add(DataProvider.TS("@MaTask", maTask));
                        cmd.Parameters.Add(DataProvider.TS("@MaTV", ma));
                        cmd.ExecuteNonQuery();
                    }
                    foreach (int ma in dsThanhVien.Where(x => !hienTai.Contains(x)))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO PhanCong (MaTask, MaThanhVien, NgayGiao) VALUES (@MaTask, @MaTV, GETDATE())", conn, trans);
                        cmd.Parameters.Add(DataProvider.TS("@MaTask", maTask));
                        cmd.Parameters.Add(DataProvider.TS("@MaTV", ma));
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        private static SqlParameter[] ThamSo(CongViecDTO cv)
        {
            return new[]
            {
                DataProvider.TS("@MaTask", cv.MaTask),
                DataProvider.TS("@MaDuAn", cv.MaDuAn),
                DataProvider.TS("@TenTask", cv.TenTask),
                DataProvider.TS("@MoTa", string.IsNullOrWhiteSpace(cv.MoTa) ? null : cv.MoTa),
                DataProvider.TS("@HanNop", cv.HanNop),
                DataProvider.TS("@DoUuTien", cv.DoUuTien),
                DataProvider.TS("@TrangThai", cv.TrangThai)
            };
        }
    }
}
