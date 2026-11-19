using System.Data;

namespace QuanLyKaraoke.DAL
{
    using QuanLyKaraoke.DTO;

    public class DichVuDAL
    {
        public List<DichVuDTO> TimKiem(string tuKhoa)
        {
            DataTable dt = DataProvider.ExecuteQuery(
                "SELECT MaDV, TenDV, DonGia, TonKho FROM DichVu WHERE TenDV LIKE @TuKhoa ORDER BY TenDV",
                DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            List<DichVuDTO> ds = new List<DichVuDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new DichVuDTO
                {
                    MaDV = Convert.ToInt32(r["MaDV"]),
                    TenDV = r["TenDV"].ToString(),
                    DonGia = Convert.ToDecimal(r["DonGia"]),
                    TonKho = Convert.ToInt32(r["TonKho"])
                });
            }
            return ds;
        }

        public bool Them(DichVuDTO dv)
        {
            return DataProvider.ExecuteNonQuery("INSERT INTO DichVu (TenDV, DonGia, TonKho) VALUES (@Ten, @Gia, @Ton)",
                DataProvider.TS("@Ten", dv.TenDV), DataProvider.TS("@Gia", dv.DonGia), DataProvider.TS("@Ton", dv.TonKho)) > 0;
        }

        public bool Sua(DichVuDTO dv)
        {
            return DataProvider.ExecuteNonQuery("UPDATE DichVu SET TenDV = @Ten, DonGia = @Gia, TonKho = @Ton WHERE MaDV = @Ma",
                DataProvider.TS("@Ma", dv.MaDV), DataProvider.TS("@Ten", dv.TenDV),
                DataProvider.TS("@Gia", dv.DonGia), DataProvider.TS("@Ton", dv.TonKho)) > 0;
        }

        public bool Xoa(int ma)
        {
            return DataProvider.ExecuteNonQuery("DELETE FROM DichVu WHERE MaDV = @Ma", DataProvider.TS("@Ma", ma)) > 0;
        }
    }
}
