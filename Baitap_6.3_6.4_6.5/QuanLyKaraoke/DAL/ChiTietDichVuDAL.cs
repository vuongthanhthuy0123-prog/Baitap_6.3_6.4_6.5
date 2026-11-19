using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyKaraoke.DAL
{
    // DỊCH VỤ CỦA PHÒNG THEO MÔ HÌNH NGẮT KẾT NỐI:
    // SqlDataAdapter nạp ChiTietDichVu của hóa đơn vào DataTable -> thêm / sửa / xóa trên DataTable
    // -> SqlCommandBuilder + adapter.Update() ghi lại vào SQL Server.
    public class ChiTietDichVuDAL
    {
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;

        public DataTable NapDichVuCuaHoaDon(int maHD)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlCommand cmd = new SqlCommand("SELECT MaHD, MaDV, SoLuong, DonGia FROM ChiTietDichVu WHERE MaHD = @MaHD", conn);
            cmd.Parameters.Add(DataProvider.TS("@MaHD", maHD));

            adapter = new SqlDataAdapter(cmd);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            builder = new SqlCommandBuilder(adapter);
            builder.ConflictOption = ConflictOption.OverwriteChanges;

            DataTable dt = new DataTable("ChiTietDichVu");
            adapter.Fill(dt);
            return dt;
        }

        public int Luu(DataTable dt)
        {
            if (adapter == null) throw new InvalidOperationException("Chưa nạp danh sách dịch vụ.");
            return adapter.Update(dt);
        }
    }
}
