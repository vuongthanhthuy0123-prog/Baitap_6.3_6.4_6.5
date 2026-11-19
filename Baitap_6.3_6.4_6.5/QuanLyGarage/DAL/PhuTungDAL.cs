using System.Data;

namespace QuanLyGarage.DAL
{
    using QuanLyGarage.DTO;

    public class PhuTungDAL
    {
        public List<PhuTungDTO> TimKiem(string tuKhoa)
        {
            DataTable dt = DataProvider.ExecuteQuery(
                "SELECT MaPhuTung, TenPhuTung, DonGia, SoLuongTon FROM PhuTung WHERE TenPhuTung LIKE @TuKhoa ORDER BY TenPhuTung",
                DataProvider.TS("@TuKhoa", "%" + tuKhoa + "%"));
            List<PhuTungDTO> ds = new List<PhuTungDTO>();
            foreach (DataRow r in dt.Rows)
            {
                ds.Add(new PhuTungDTO
                {
                    MaPhuTung = Convert.ToInt32(r["MaPhuTung"]),
                    TenPhuTung = r["TenPhuTung"].ToString(),
                    DonGia = Convert.ToDecimal(r["DonGia"]),
                    SoLuongTon = Convert.ToInt32(r["SoLuongTon"])
                });
            }
            return ds;
        }

        public bool Them(PhuTungDTO pt)
        {
            return DataProvider.ExecuteNonQuery("INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES (@Ten, @DonGia, @Ton)",
                DataProvider.TS("@Ten", pt.TenPhuTung), DataProvider.TS("@DonGia", pt.DonGia), DataProvider.TS("@Ton", pt.SoLuongTon)) > 0;
        }

        public bool Sua(PhuTungDTO pt)
        {
            return DataProvider.ExecuteNonQuery("UPDATE PhuTung SET TenPhuTung = @Ten, DonGia = @DonGia, SoLuongTon = @Ton WHERE MaPhuTung = @Ma",
                DataProvider.TS("@Ma", pt.MaPhuTung), DataProvider.TS("@Ten", pt.TenPhuTung),
                DataProvider.TS("@DonGia", pt.DonGia), DataProvider.TS("@Ton", pt.SoLuongTon)) > 0;
        }

        public bool Xoa(int ma)
        {
            return DataProvider.ExecuteNonQuery("DELETE FROM PhuTung WHERE MaPhuTung = @Ma", DataProvider.TS("@Ma", ma)) > 0;
        }

        public int DemSapHet(int nguong)
        {
            return Convert.ToInt32(DataProvider.ExecuteScalar("SELECT COUNT(*) FROM PhuTung WHERE SoLuongTon < @Nguong",
                DataProvider.TS("@Nguong", nguong)));
        }
    }
}
