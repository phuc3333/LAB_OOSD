using System;
using System.Globalization;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện ngày
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nạp dữ liệu tổng hợp và dịch vụ
            dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}