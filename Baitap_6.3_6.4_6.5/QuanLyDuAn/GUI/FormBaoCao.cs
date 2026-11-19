namespace QuanLyDuAn.GUI
{
    using QuanLyDuAn.BUS;
    using QuanLyDuAn.DTO;

    public partial class FormBaoCao : Form
    {
        private readonly BaoCaoBUS bus = new BaoCaoBUS();
        private readonly DuAnBUS duAnBUS = new DuAnBUS();

        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            dgvTienDo.AutoGenerateColumns = false;
            colBieuDo.DefaultCellStyle.ForeColor = Color.SeaGreen;
            try
            {
                List<DuAnDTO> ds = new List<DuAnDTO>();
                ds.Add(new DuAnDTO { MaDuAn = 0, TenDuAn = "Tất cả dự án" });
                ds.AddRange(duAnBUS.TimKiem(""));
                cboDuAn.DisplayMember = "TenDuAn";
                cboDuAn.ValueMember = "MaDuAn";
                cboDuAn.DataSource = ds;
                TaiTatCa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiTatCa()
        {
            TaiTreHan();
            TaiTienDo();
        }

        // SqlDataReader -> ListView
        private void TaiTreHan()
        {
            lsvTreHan.Items.Clear();
            List<CongViecDTO> ds = bus.TaskTreHan();
            foreach (CongViecDTO cv in ds)
            {
                ListViewItem item = new ListViewItem(cv.MaTask.ToString());
                item.SubItems.Add(cv.TenTask);
                item.SubItems.Add(cv.TenDuAn);
                item.SubItems.Add(cv.HanNop.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(cv.SoNgayTre.ToString());
                item.SubItems.Add(cv.TrangThai);
                item.SubItems.Add(cv.NguoiLam);
                item.ForeColor = cv.SoNgayTre > 7 ? Color.Firebrick : Color.DarkOrange;
                lsvTreHan.Items.Add(item);
            }
            grpTreHan.Text = "Cảnh báo: " + ds.Count + " công việc đã quá hạn nộp mà chưa Done (SqlDataReader)";
        }

        private void TaiTienDo()
        {
            int maDuAn = cboDuAn.SelectedValue is int ? (int)cboDuAn.SelectedValue : 0;
            dgvTienDo.DataSource = bus.TienDoThanhVien(maDuAn);                 // GROUP BY
            lblTyLeDuAn.Text = "Tỷ lệ hoàn thành của " + cboDuAn.Text + ": " +
                               bus.TyLeHoanThanh(maDuAn).ToString("0.0") + "% công việc đã Done";   // ExecuteScalar
        }

        private void cboDuAn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { TaiTienDo(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try { TaiTatCa(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
