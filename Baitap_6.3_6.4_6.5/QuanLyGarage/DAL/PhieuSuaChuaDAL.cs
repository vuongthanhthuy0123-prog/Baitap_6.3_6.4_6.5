using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyGarage.DAL
{
    using QuanLyGarage.DTO;

    public class PhieuSuaChuaDAL
    {
        // HOÀN TẤT PHIẾU SỬA CHỮA = 1 SqlTransaction:
        // tạo PhieuSuaChua -> tạo ChiTietSuaChua -> trừ tồn kho phụ tùng; thiếu hàng thì Rollback.
        public int LapPhieu(PhieuSuaChuaDTO phieu, List<ChiTietSuaChuaDTO> chiTiet, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            using (SqlConnection conn = DataProvider.TaoKetNoi())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Tạo phiếu sửa chữa
                    SqlCommand cmdPhieu = new SqlCommand(
                        "INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) OUTPUT INSERTED.MaPhieu " +
                        "VALUES (@BienSo, GETDATE(), @NoiDung, @TongTien, @TrangThai)", conn, trans);
                    cmdPhieu.Parameters.Add(DataProvider.TS("@BienSo", phieu.BienSo));
                    cmdPhieu.Parameters.Add(DataProvider.TS("@NoiDung", phieu.NoiDungSua));
                    cmdPhieu.Parameters.Add(DataProvider.TS("@TongTien", phieu.TongTien));
                    cmdPhieu.Parameters.Add(DataProvider.TS("@TrangThai", phieu.TrangThai));
                    int maPhieu = Convert.ToInt32(cmdPhieu.ExecuteScalar());

                    foreach (ChiTietSuaChuaDTO ct in chiTiet)
                    {
                        // Kiểm tra tồn kho (khóa dòng phụ tùng trong lúc giao dịch)
                        SqlCommand cmdTon = new SqlCommand(
                            "SELECT SoLuongTon FROM PhuTung WITH (UPDLOCK, ROWLOCK) WHERE MaPhuTung = @Ma", conn, trans);
                        cmdTon.Parameters.Add(DataProvider.TS("@Ma", ct.MaPhuTung));
                        object kq = cmdTon.ExecuteScalar();
                        int ton = kq == null ? 0 : Convert.ToInt32(kq);
                        if (ton < ct.SoLuong)
                        {
                            trans.Rollback();     // 4. Không đủ phụ tùng -> hủy toàn bộ
                            thongBaoLoi = "Phụ tùng \"" + ct.TenPhuTung + "\" chỉ còn " + ton + " trong kho, không đủ " + ct.SoLuong + ".\n" +
                                          "Giao dịch đã được hủy (Rollback): không tạo phiếu, không trừ kho.";
                            return -1;
                        }

                        // 2. Tạo chi tiết sửa chữa
                        SqlCommand cmdCT = new SqlCommand(
                            "INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) VALUES (@MaPhieu, @Ma, @SoLuong, @TienCong)", conn, trans);
                        cmdCT.Parameters.Add(DataProvider.TS("@MaPhieu", maPhieu));
                        cmdCT.Parameters.Add(DataProvider.TS("@Ma", ct.MaPhuTung));
                        cmdCT.Parameters.Add(DataProvider.TS("@SoLuong", ct.SoLuong));
                        cmdCT.Parameters.Add(DataProvider.TS("@TienCong", ct.TienCong));
                        cmdCT.ExecuteNonQuery();

                        // 3. Trừ tồn kho: SoLuongTon -= SoLuong
                        SqlCommand cmdTru = new SqlCommand(
                            "UPDATE PhuTung SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaPhuTung = @Ma", conn, trans);
                        cmdTru.Parameters.Add(DataProvider.TS("@SoLuong", ct.SoLuong));
                        cmdTru.Parameters.Add(DataProvider.TS("@Ma", ct.MaPhuTung));
                        cmdTru.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return maPhieu;
                }
                catch (Exception ex)
                {
                    try { trans.Rollback(); } catch { }
                    thongBaoLoi = "Lỗi khi lập phiếu: " + ex.Message + "\nGiao dịch đã được hủy (Rollback).";
                    return -1;
                }
            }
        }

        public List<PhieuSuaChuaDTO> DanhSach(string trangThai, string tuKhoa)
        {
            DataTable dt = DataProvider.ExecuteQuery(
                "SELECT p.MaPhieu, p.BienSo, k.TenKH, x.HieuXe, p.NgayNhan, p.NoiDungSua, p.TongTien, p.TrangThai " +
                "FROM PhieuSuaChua p JOIN Xe x ON p.BienSo = x.BienSo JOIN KhachHang k ON x.MaKH = k.MaKH " +
                "WHERE (@TrangThai = N'' OR p.TrangThai = @TrangThai) AND (p.BienSo LIKE @TuKhoa OR k.TenKH LIKE @TuKhoa) " +
                "ORDER BY p.MaPhieu DESC",
                DataProvider.TS("@TrangThai", trangThai ?? ""), DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            List<PhieuSuaChuaDTO> ds = new List<PhieuSuaChuaDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new PhieuSuaChuaDTO
                {
                    MaPhieu = Convert.ToInt32(r["MaPhieu"]),
                    BienSo = r["BienSo"].ToString(),
                    TenKH = r["TenKH"].ToString(),
                    HieuXe = r["HieuXe"].ToString(),
                    NgayNhan = Convert.ToDateTime(r["NgayNhan"]),
                    NoiDungSua = r["NoiDungSua"].ToString(),
                    TongTien = Convert.ToDecimal(r["TongTien"]),
                    TrangThai = r["TrangThai"].ToString()
                });
            }
            return ds;
        }

        public List<ChiTietSuaChuaDTO> ChiTiet(int maPhieu)
        {
            DataTable dt = DataProvider.ExecuteQuery(
                "SELECT ct.MaPhieu, ct.MaPhuTung, pt.TenPhuTung, ct.SoLuong, pt.DonGia, ct.TienCong " +
                "FROM ChiTietSuaChua ct JOIN PhuTung pt ON ct.MaPhuTung = pt.MaPhuTung WHERE ct.MaPhieu = @MaPhieu",
                DataProvider.TS("@MaPhieu", maPhieu));
            List<ChiTietSuaChuaDTO> ds = new List<ChiTietSuaChuaDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new ChiTietSuaChuaDTO
                {
                    MaPhieu = Convert.ToInt32(r["MaPhieu"]),
                    MaPhuTung = Convert.ToInt32(r["MaPhuTung"]),
                    TenPhuTung = r["TenPhuTung"].ToString(),
                    SoLuong = Convert.ToInt32(r["SoLuong"]),
                    DonGia = Convert.ToDecimal(r["DonGia"]),
                    TienCong = Convert.ToDecimal(r["TienCong"])
                });
            }
            return ds;
        }

        // Thanh toán: chuyển trạng thái phiếu sang "Đã thanh toán" và chốt tổng tiền
        public bool ThanhToan(int maPhieu, decimal tongTien)
        {
            return DataProvider.ExecuteNonQuery(
                "UPDATE PhieuSuaChua SET TrangThai = N'Đã thanh toán', TongTien = @TongTien " +
                "WHERE MaPhieu = @MaPhieu AND TrangThai <> N'Đã thanh toán'",
                DataProvider.TS("@TongTien", tongTien), DataProvider.TS("@MaPhieu", maPhieu)) > 0;
        }

        // ExecuteScalar: doanh thu (phiếu đã thanh toán) trong tháng
        public decimal DoanhThuThang(int thang, int nam)
        {
            return Convert.ToDecimal(DataProvider.ExecuteScalar(
                "SELECT ISNULL(SUM(TongTien), 0) FROM PhieuSuaChua WHERE TrangThai = N'Đã thanh toán' " +
                "AND MONTH(NgayNhan) = @Thang AND YEAR(NgayNhan) = @Nam",
                DataProvider.TS("@Thang", thang), DataProvider.TS("@Nam", nam)));
        }

        public int DemChuaThanhToan()
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar("SELECT COUNT(*) FROM PhieuSuaChua WHERE TrangThai <> N'Đã thanh toán'"));
        }
    }
}
