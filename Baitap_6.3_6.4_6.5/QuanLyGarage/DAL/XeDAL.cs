using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyGarage.DAL
{
    using QuanLyGarage.DTO;

    public class XeDAL
    {
        private const string SELECT_XE =
            "SELECT x.BienSo, x.MaKH, x.HieuXe, x.NamSanXuat, k.TenKH, k.DienThoai, k.DiaChi " +
            "FROM Xe x JOIN KhachHang k ON x.MaKH = k.MaKH ";

        // Tra cứu chính xác 1 biển số (SqlParameter)
        public XeDTO TraCuu(string bienSo)
        {
            DataTable dt = DataProvider.ExecuteQuery(SELECT_XE + "WHERE x.BienSo = @BienSo", DataProvider.TS("@BienSo", bienSo));
            List<XeDTO> ds = ChuyenDoi(dt);
            return ds.Count > 0 ? ds[0] : null;
        }

        // Tìm gần đúng theo biển số / tên chủ xe / số điện thoại
        public List<XeDTO> TimKiem(string tuKhoa)
        {
            DataTable dt = DataProvider.ExecuteQuery(SELECT_XE +
                "WHERE x.BienSo LIKE @TuKhoa OR k.TenKH LIKE @TuKhoa OR k.DienThoai LIKE @TuKhoa ORDER BY x.BienSo",
                DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            return ChuyenDoi(dt);
        }

        public int DemXe()
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar("SELECT COUNT(*) FROM Xe"));
        }

        // Xe mới của chủ xe mới: thêm KhachHang rồi thêm Xe trong 1 transaction
        public void ThemXeVaChuXeMoi(KhachHangDTO kh, XeDTO xe)
        {
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlCommand cmdKH = new SqlCommand(
                        "INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) OUTPUT INSERTED.MaKH VALUES (@TenKH, @DienThoai, @DiaChi)", conn, trans);
                    cmdKH.Parameters.Add(DataProvider.TS("@TenKH", kh.TenKH));
                    cmdKH.Parameters.Add(DataProvider.TS("@DienThoai", kh.DienThoai));
                    cmdKH.Parameters.Add(DataProvider.TS("@DiaChi", kh.DiaChi));
                    int maKH = Convert.ToInt32(cmdKH.ExecuteScalar());

                    ThemXe(xe, maKH, conn, trans);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // Xe mới của chủ xe đã có
        public void ThemXeChoKhachCu(XeDTO xe, int maKH)
        {
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                ThemXe(xe, maKH, conn, null);
            }
        }

        private static void ThemXe(XeDTO xe, int maKH, SqlConnection conn, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES (@BienSo, @MaKH, @HieuXe, @NamSX)", conn, trans);
            cmd.Parameters.Add(DataProvider.TS("@BienSo", xe.BienSo));
            cmd.Parameters.Add(DataProvider.TS("@MaKH", maKH));
            cmd.Parameters.Add(DataProvider.TS("@HieuXe", xe.HieuXe));
            cmd.Parameters.Add(DataProvider.TS("@NamSX", xe.NamSanXuat));
            cmd.ExecuteNonQuery();
        }

        public bool SuaXe(XeDTO xe)
        {
            return DataProvider.ExecuteNonQuery("UPDATE Xe SET HieuXe = @HieuXe, NamSanXuat = @NamSX WHERE BienSo = @BienSo",
                DataProvider.TS("@HieuXe", xe.HieuXe), DataProvider.TS("@NamSX", xe.NamSanXuat), DataProvider.TS("@BienSo", xe.BienSo)) > 0;
        }

        private static List<XeDTO> ChuyenDoi(DataTable dt)
        {
            List<XeDTO> ds = new List<XeDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new XeDTO
                {
                    BienSo = r["BienSo"].ToString(),
                    MaKH = Convert.ToInt32(r["MaKH"]),
                    HieuXe = r["HieuXe"].ToString(),
                    NamSanXuat = r["NamSanXuat"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["NamSanXuat"]),
                    TenKH = r["TenKH"].ToString(),
                    DienThoai = r["DienThoai"].ToString(),
                    DiaChi = r["DiaChi"].ToString()
                });
            }
            return ds;
        }
    }
}
