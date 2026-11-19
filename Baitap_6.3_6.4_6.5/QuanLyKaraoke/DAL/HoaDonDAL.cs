using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyKaraoke.DAL
{
    using QuanLyKaraoke.DTO;

    public class HoaDonDAL
    {
        // MỞ PHÒNG: tạo hóa đơn (GioVao = GETDATE()) + đổi phòng sang "Đang hát"
        public int MoPhong(int maPhong, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlCommand cmdKT = new SqlCommand("SELECT TrangThai FROM PhongHat WITH (UPDLOCK) WHERE MaPhong = @Ma", conn, trans);
                    cmdKT.Parameters.Add(DataProvider.TS("@Ma", maPhong));
                    object tt = cmdKT.ExecuteScalar();
                    if (tt == null || tt.ToString() != "Trống")
                    {
                        trans.Rollback();
                        thongBaoLoi = "Phòng này không còn trống.";
                        return -1;
                    }

                    SqlCommand cmdHD = new SqlCommand(
                        "INSERT INTO HoaDon (MaPhong, GioVao, TongTienPhong, TongTienDichVu, TrangThai) OUTPUT INSERTED.MaHD " +
                        "VALUES (@Ma, GETDATE(), 0, 0, 0)", conn, trans);
                    cmdHD.Parameters.Add(DataProvider.TS("@Ma", maPhong));
                    int maHD = Convert.ToInt32(cmdHD.ExecuteScalar());

                    SqlCommand cmdPhong = new SqlCommand("UPDATE PhongHat SET TrangThai = N'Đang hát' WHERE MaPhong = @Ma", conn, trans);
                    cmdPhong.Parameters.Add(DataProvider.TS("@Ma", maPhong));
                    cmdPhong.ExecuteNonQuery();

                    trans.Commit();
                    return maHD;
                }
                catch (Exception ex)
                {
                    try { trans.Rollback(); } catch { }
                    thongBaoLoi = "Lỗi khi mở phòng: " + ex.Message;
                    return -1;
                }
            }
        }

        public DateTime GioHienTaiServer()
        {
            return Convert.ToDateTime(DataProvider.ExecuteScalar("SELECT GETDATE()"));
        }

        // THANH TOÁN = 1 SqlTransaction:
        // 1. cập nhật hóa đơn (GioRa, tiền, TrangThai = 1)  2. trừ TonKho dịch vụ  3. trả phòng về "Trống"  4. Commit
        public bool ThanhToan(HoaDonDTO hd, DataTable dichVu, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật hóa đơn
                    SqlCommand cmdHD = new SqlCommand(
                        "UPDATE HoaDon SET GioRa = @GioRa, TongTienPhong = @TienPhong, TongTienDichVu = @TienDV, TrangThai = 1 " +
                        "WHERE MaHD = @MaHD AND TrangThai = 0", conn, trans);
                    cmdHD.Parameters.Add(DataProvider.TS("@GioRa", hd.GioRa));
                    cmdHD.Parameters.Add(DataProvider.TS("@TienPhong", hd.TongTienPhong));
                    cmdHD.Parameters.Add(DataProvider.TS("@TienDV", hd.TongTienDichVu));
                    cmdHD.Parameters.Add(DataProvider.TS("@MaHD", hd.MaHD));
                    if (cmdHD.ExecuteNonQuery() == 0)
                    {
                        trans.Rollback();
                        thongBaoLoi = "Hóa đơn này đã được thanh toán trước đó.";
                        return false;
                    }

                    // 2. Trừ tồn kho từng dịch vụ đã gọi
                    foreach (DataRow r in dichVu.Rows)
                    {
                        if (r.RowState == DataRowState.Deleted) continue;
                        int maDV = Convert.ToInt32(r["MaDV"]);
                        int soLuong = Convert.ToInt32(r["SoLuong"]);

                        SqlCommand cmdTon = new SqlCommand("SELECT TonKho FROM DichVu WITH (UPDLOCK, ROWLOCK) WHERE MaDV = @MaDV", conn, trans);
                        cmdTon.Parameters.Add(DataProvider.TS("@MaDV", maDV));
                        int ton = Convert.ToInt32(cmdTon.ExecuteScalar());
                        if (ton < soLuong)
                        {
                            trans.Rollback();
                            thongBaoLoi = "Dịch vụ \"" + r["TenDV"] + "\" chỉ còn " + ton + " trong kho, không đủ " + soLuong + ".\n" +
                                          "Giao dịch đã được hủy (Rollback): hóa đơn chưa thanh toán, phòng vẫn đang hát.";
                            return false;
                        }

                        SqlCommand cmdTru = new SqlCommand("UPDATE DichVu SET TonKho = TonKho - @SoLuong WHERE MaDV = @MaDV", conn, trans);
                        cmdTru.Parameters.Add(DataProvider.TS("@SoLuong", soLuong));
                        cmdTru.Parameters.Add(DataProvider.TS("@MaDV", maDV));
                        cmdTru.ExecuteNonQuery();
                    }

                    // 3. Trả phòng về trạng thái "Trống"
                    SqlCommand cmdPhong = new SqlCommand("UPDATE PhongHat SET TrangThai = N'Trống' WHERE MaPhong = @Ma", conn, trans);
                    cmdPhong.Parameters.Add(DataProvider.TS("@Ma", hd.MaPhong));
                    cmdPhong.ExecuteNonQuery();

                    // 4. Commit
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    try { trans.Rollback(); } catch { }
                    thongBaoLoi = "Lỗi khi thanh toán: " + ex.Message + "\nGiao dịch đã được hủy (Rollback).";
                    return false;
                }
            }
        }

        // ---------- BÁO CÁO ----------

        // ExecuteScalar: doanh thu (phòng + dịch vụ) của các hóa đơn đã thanh toán trong ngày
        public decimal DoanhThuNgay(DateTime ngay)
        {
            return Convert.ToDecimal(DataProvider.ExecuteScalar(
                "SELECT ISNULL(SUM(TongTienPhong + TongTienDichVu), 0) FROM HoaDon WHERE TrangThai = 1 AND CAST(GioRa AS DATE) = @Ngay",
                DataProvider.TS("@Ngay", ngay.Date)));
        }

        public decimal DoanhThuThang(int thang, int nam)
        {
            return Convert.ToDecimal(DataProvider.ExecuteScalar(
                "SELECT ISNULL(SUM(TongTienPhong + TongTienDichVu), 0) FROM HoaDon WHERE TrangThai = 1 AND MONTH(GioRa) = @Thang AND YEAR(GioRa) = @Nam",
                DataProvider.TS("@Thang", thang), DataProvider.TS("@Nam", nam)));
        }

        public List<HoaDonDTO> HoaDonDaThanhToan(DateTime ngay)
        {
            DataTable dt = DataProvider.ExecuteQuery(
                "SELECT h.MaHD, h.MaPhong, p.TenPhong, h.GioVao, h.GioRa, h.TongTienPhong, h.TongTienDichVu " +
                "FROM HoaDon h JOIN PhongHat p ON h.MaPhong = p.MaPhong " +
                "WHERE h.TrangThai = 1 AND CAST(h.GioRa AS DATE) = @Ngay ORDER BY h.GioRa DESC",
                DataProvider.TS("@Ngay", ngay.Date));
            List<HoaDonDTO> ds = new List<HoaDonDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new HoaDonDTO
                {
                    MaHD = Convert.ToInt32(r["MaHD"]),
                    MaPhong = Convert.ToInt32(r["MaPhong"]),
                    TenPhong = r["TenPhong"].ToString(),
                    GioVao = Convert.ToDateTime(r["GioVao"]),
                    GioRa = Convert.ToDateTime(r["GioRa"]),
                    TongTienPhong = Convert.ToDecimal(r["TongTienPhong"]),
                    TongTienDichVu = Convert.ToDecimal(r["TongTienDichVu"])
                });
            }
            return ds;
        }

        // SqlDataReader: dịch vụ bán chạy (các hóa đơn đã thanh toán)
        public List<TopDichVuDTO> TopDichVu()
        {
            List<TopDichVuDTO> ds = new List<TopDichVuDTO>();
            string sql = "SELECT TOP 5 dv.TenDV, SUM(ct.SoLuong) AS SoLuong, SUM(ct.SoLuong * ct.DonGia) AS DoanhThu " +
                         "FROM ChiTietDichVu ct JOIN DichVu dv ON ct.MaDV = dv.MaDV JOIN HoaDon h ON ct.MaHD = h.MaHD " +
                         "WHERE h.TrangThai = 1 GROUP BY dv.TenDV ORDER BY SoLuong DESC";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                        ds.Add(new TopDichVuDTO { TenDV = rd.GetString(0), SoLuong = rd.GetInt32(1), DoanhThu = rd.GetDecimal(2) });
                }
            }
            return ds;
        }

        public int DemPhongDangHat()
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar("SELECT COUNT(*) FROM PhongHat WHERE TrangThai = N'Đang hát'"));
        }
    }
}
