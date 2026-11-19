namespace QuanLyDuAn.BUS
{
    using QuanLyDuAn.DAL;
    using QuanLyDuAn.DTO;

    public class BaoCaoBUS
    {
        private readonly BaoCaoDAL dal = new BaoCaoDAL();

        public List<CongViecDTO> TaskTreHan() { return dal.TaskTreHan(); }
        public int DemTreHan() { return dal.DemTreHan(); }
        public int DemDuAn() { return dal.DemDuAn(); }
        public int DemTask() { return dal.DemTask(); }
        public double TyLeHoanThanh(int maDuAn) { return dal.TyLeHoanThanh(maDuAn); }
        public List<TienDoThanhVienDTO> TienDoThanhVien(int maDuAn) { return dal.TienDoThanhVien(maDuAn); }
    }
}
