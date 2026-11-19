using System.Data;

namespace QuanLyGarage.DAL
{
    using QuanLyGarage.DTO;

    public class KhachHangDAL
    {
        public KhachHangDTO TimTheoDienThoai(string dienThoai)
        {
            DataTable dt = DataProvider.ExecuteQuery("SELECT MaKH, TenKH, DienThoai, DiaChi FROM KhachHang WHERE DienThoai = @DienThoai",
                DataProvider.TS("@DienThoai", dienThoai));
            if (dt.Rows.Count == 0) return null;
            DataRow r = dt.Rows[0];
            return new KhachHangDTO
            {
                MaKH = Convert.ToInt32(r["MaKH"]),
                TenKH = r["TenKH"].ToString(),
                DienThoai = r["DienThoai"].ToString(),
                DiaChi = r["DiaChi"].ToString()
            };
        }

        public bool Sua(KhachHangDTO kh)
        {
            return DataProvider.ExecuteNonQuery("UPDATE KhachHang SET TenKH = @TenKH, DienThoai = @DienThoai, DiaChi = @DiaChi WHERE MaKH = @MaKH",
                DataProvider.TS("@TenKH", kh.TenKH), DataProvider.TS("@DienThoai", kh.DienThoai),
                DataProvider.TS("@DiaChi", kh.DiaChi), DataProvider.TS("@MaKH", kh.MaKH)) > 0;
        }
    }
}
