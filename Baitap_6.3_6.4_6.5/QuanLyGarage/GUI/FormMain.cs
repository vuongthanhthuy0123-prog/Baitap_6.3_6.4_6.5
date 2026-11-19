using System.Globalization;

namespace QuanLyGarage.GUI
{
    using QuanLyGarage.BUS;
    using QuanLyGarage.DAL;

    public partial class FormMain : Form
    {
        private readonly XeBUS xeBUS = new XeBUS();
        private readonly PhuTungBUS phuTungBUS = new PhuTungBUS();
        private readonly PhieuSuaChuaBUS phieuBUS = new PhieuSuaChuaBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
        private bool daKetNoi = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                string chuoi = DataProvider.ChuoiKetNoi;
                daKetNoi = true;
                lblKetNoi.Text = "Đã kết nối CSDL GarageDB trên server: " + DataProvider.TenServer;
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
                lblSoXe.Text = xeBUS.DemXe().ToString();
                lblChoThanhToan.Text = phieuBUS.DemChuaThanhToan().ToString();
                lblDoanhThu.Text = phieuBUS.DoanhThuThang(DateTime.Today.Month, DateTime.Today.Year).ToString("N0", vi) + " đ";
                lblSapHet.Text = phuTungBUS.DemSapHet().ToString();
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

        private void btnTiepNhan_Click(object sender, EventArgs e) { MoForm(new FormTiepNhan()); }
        private void btnLapPhieu_Click(object sender, EventArgs e) { MoForm(new FormLapPhieu()); }
        private void btnThanhToan_Click(object sender, EventArgs e) { MoForm(new FormThanhToan()); }
        private void btnPhuTung_Click(object sender, EventArgs e) { MoForm(new FormPhuTung()); }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
