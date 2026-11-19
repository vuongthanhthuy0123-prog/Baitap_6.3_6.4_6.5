namespace QuanLyDuAn.DTO
{
    // Tỷ lệ hoàn thành công việc của 1 thành viên
    public class TienDoThanhVienDTO
    {
        public string HoTen { get; set; }
        public int TongTask { get; set; }
        public int SoDone { get; set; }

        public int SoChuaXong
        {
            get { return TongTask - SoDone; }
        }

        public double TyLe
        {
            get { return TongTask == 0 ? 0 : Math.Round(100.0 * SoDone / TongTask, 1); }
        }

        public string BieuDo
        {
            get { return new string('█', (int)Math.Round(TyLe / 10)) + new string('░', 10 - (int)Math.Round(TyLe / 10)); }
        }
    }
}
