using System;
using System.Windows.Forms;
using EShopping.Data;

namespace EShopping
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();

            this.Load += FrmSanPham_Load;
            btnThem.Click += btnThem_Click;
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            try
            {
                string sql = @"
                    SELECT MaSanPham, TenSanPham,
                           DonGia, SoLuongTon, MaDanhMuc
                    FROM SanPham";

                dgvSanPham.DataSource = Db.Query(sql);
                dgvSanPham.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                dgvSanPham.ReadOnly = true;
                dgvSanPham.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmThemSanPham f = new FrmThemSanPham())
            {
                f.ShowDialog();
            }

            // Tự động tải lại sau khi đóng Form thêm
            TaiDanhSach();
        }

        private void FrmSanPham_Load_1(object sender, EventArgs e)
        {

        }
    }
}