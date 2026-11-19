namespace QuanLyDuAn.DTO
{
    public class CongViecDTO
    {
        public int MaTask { get; set; }
        public int MaDuAn { get; set; }
        public string TenDuAn { get; set; }
        public string TenTask { get; set; }
        public string MoTa { get; set; }
        public DateTime? HanNop { get; set; }
        public string DoUuTien { get; set; }
        public string TrangThai { get; set; }
        public string NguoiLam { get; set; }        // tên các thành viên được giao, cách nhau dấu phẩy

        // Trễ hạn: đã qua hạn nộp mà chưa Done
        public bool TreHan
        {
            get { return HanNop.HasValue && HanNop.Value < DateTime.Now && TrangThai != "Done"; }
        }

        public int SoNgayTre
        {
            get { return TreHan ? (int)Math.Ceiling((DateTime.Now - HanNop.Value).TotalDays) : 0; }
        }

        // Dòng hiển thị trên bảng Kanban
        public string TheKanban
        {
            get
            {
                string han = HanNop.HasValue ? HanNop.Value.ToString("dd/MM") : "--";
                return (TreHan ? "⚠ " : "") + "#" + MaTask + " " + TenTask + "  [" + DoUuTien + ", hạn " + han + "]";
            }
        }

        public override string ToString()
        {
            return TheKanban;
        }
    }
}
