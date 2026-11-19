using System.Globalization;

namespace QuanLyKaraoke.GUI
{
    using QuanLyKaraoke.BUS;
    using QuanLyKaraoke.DTO;

    public partial class FormBaoCao : Form
    {
        private readonly HoaDonBUS bus = new HoaDonBUS();
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
        private bool daTai = false;

        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            foreach (DataGridViewColumn c in new DataGridViewColumn[] { colTienPhong, colTienDV, colTongCong })
                c.DefaultCellStyle.FormatProvider = vi;
            dtpNgay.Value = DateTime.Today;
            TaiBaoCao();
            daTai = true;
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            if (daTai) TaiBaoCao();
        }

        private void TaiBaoCao()
        {
            try
            {
                DateTime ngay = dtpNgay.Value.Date;
                // ExecuteScalar
                lblDoanhThuNgay.Text = "Doanh thu ngày " + ngay.ToString("dd/MM") + ": " + bus.DoanhThuNgay(ngay).ToString("N0", vi) + " đ";
                lblDoanhThuThang.Text = "Doanh thu tháng " + ngay.ToString("MM/yyyy") + ": " +
                                        bus.DoanhThuThang(ngay.Month, ngay.Year).ToString("N0", vi) + " đ";

                List<HoaDonDTO> ds = bus.HoaDonDaThanhToan(ngay);
                dgvHoaDon.DataSource = ds;
                grpHoaDon.Text = "Hóa đơn đã thanh toán ngày " + ngay.ToString("dd/MM/yyyy") + " (" + ds.Count + " hóa đơn)";

                // SqlDataReader
                lsvTop.Items.Clear();
                foreach (TopDichVuDTO t in bus.TopDichVu())
                {
                    ListViewItem item = new ListViewItem(t.TenDV);
                    item.SubItems.Add(t.SoLuong.ToString());
                    item.SubItems.Add(t.DoanhThu.ToString("N0", vi));
                    lsvTop.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
