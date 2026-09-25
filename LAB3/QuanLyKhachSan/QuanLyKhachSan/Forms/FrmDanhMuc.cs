using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        readonly DanhMucService s = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            Tai();
        }

        void Tai()
        {
            // Nạp dữ liệu lên DataGridViews
            dgvKhu.DataSource = s.LayKhuVuc();
            dgvNV.DataSource = s.LayNhanVien();
            dgvLoaiTN.DataSource = s.LayLoaiTienNghi();
            dgvDV.DataSource = s.LayDichVu();
            dgvQD.DataSource = s.LayQuyDinhDenBu();

            // Cấu hình ComboBox Loại tiện nghi trong Tab Quy định đền bù
            cboQDLoai.DataSource = s.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            H(s.ThemKhu(txtKhuMa.Text.Trim(), txtKhuTen.Text.Trim()));
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            H(s.ThemNhanVien(txtNVMa.Text.Trim(), txtNVTen.Text.Trim(), txtNVVaiTro.Text.Trim(), txtNVSDT.Text.Trim()));
        }

        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            H(s.ThemLoaiTN(txtLoaiMa.Text.Trim(), txtLoaiTen.Text.Trim()));
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            H(s.ThemDichVu(txtDVMa.Text.Trim(), txtDVTen.Text.Trim(), txtDVDVT.Text.Trim(), numDVGia.Value));
        }

        private void btnThemQD_Click(object sender, EventArgs e)
        {
            H(s.ThemQuyDinh(
                txtQDMa.Text.Trim(),
                cboQDLoai.SelectedValue == null ? "" : cboQDLoai.SelectedValue.ToString(),
                txtQDMucDo.Text.Trim(),
                numQDTien.Value
            ));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDanhMuc_Load_1(object sender, EventArgs e)
        {
            Tai();
        }

        private void txtDVDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}