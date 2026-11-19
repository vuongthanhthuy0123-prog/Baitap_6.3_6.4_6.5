namespace QuanLyDuAn.DTO
{
    public class DuAnDTO
    {
        public int MaDuAn { get; set; }
        public string TenDuAn { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
        public int SoTask { get; set; }
        public int SoTaskDone { get; set; }

        public string TienDo
        {
            get { return SoTaskDone + "/" + SoTask + " task"; }
        }
    }
}
