namespace QuanLyDuAn.GUI
{
    using QuanLyDuAn.BUS;
    using QuanLyDuAn.DAL;

    public partial class FormMain : Form
    {
        private readonly BaoCaoBUS baoCaoBUS = new BaoCaoBUS();
        private bool daKetNoi = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                string chuoi = DataProvider.ChuoiKetNoi;     // thử kết nối ngay khi mở
                daKetNoi = true;
                lblKetNoi.Text = "Đã kết nối CSDL ProjectTaskDB trên server: " + DataProvider.TenServer;
            }
            catch (Exception ex)
            {
                lblKetNoi.Text = "Chưa kết nối được CSDL";
                MessageBox.Show(ex.Message, "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CapNhatSoLieu();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            CapNhatSoLieu();
        }

        private void CapNhatSoLieu()
        {
            if (!daKetNoi) return;
            try
            {
                lblSoDuAn.Text = baoCaoBUS.DemDuAn().ToString();
                lblSoTask.Text = baoCaoBUS.DemTask().ToString();
                lblTreHan.Text = baoCaoBUS.DemTreHan().ToString();
                lblTyLe.Text = baoCaoBUS.TyLeHoanThanh(0).ToString("0.0") + " %";
            }
            catch (Exception ex)
            {
                lblKetNoi.Text = "Lỗi đọc dữ liệu: " + ex.Message;
            }
        }

        private void MoForm(Form f)
        {
            if (!daKetNoi)
            {
                MessageBox.Show("Chưa kết nối được CSDL. Hãy chạy file Database\\ScriptDB.sql rồi mở lại chương trình.",
                    "Chưa có CSDL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (f) { f.ShowDialog(this); }
        }

        private void btnCongViec_Click(object sender, EventArgs e) { MoForm(new FormCongViec()); }
        private void btnDuAn_Click(object sender, EventArgs e) { MoForm(new FormDuAn()); }
        private void btnThanhVien_Click(object sender, EventArgs e) { MoForm(new FormThanhVien()); }
        private void btnBaoCao_Click(object sender, EventArgs e) { MoForm(new FormBaoCao()); }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
