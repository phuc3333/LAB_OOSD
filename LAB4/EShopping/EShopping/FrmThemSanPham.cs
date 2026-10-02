using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EShopping.Data;

namespace EShopping
{
    public partial class FrmThemSanPham : Form
    {
        public FrmThemSanPham()
        {
            InitializeComponent();

            this.Load += FrmThemSanPham_Load;
            btnLuu.Click += btnLuu_Click;

        }

        // Tải danh mục vào ComboBox
        private void FrmThemSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc";

                cboDanhMuc.DataSource = Db.Query(sql);
                cboDanhMuc.DisplayMember = "TenDanhMuc";
                cboDanhMuc.ValueMember = "MaDanhMuc";
                cboDanhMuc.DropDownStyle =
                    ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh mục: " + ex.Message);
            }
        }

        // Lưu sản phẩm vào SQL Server
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();
            decimal donGia;
            int soLuong;

            if (tenSP == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!");
                txtTenSP.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out donGia)
                || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out soLuong)
                || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                txtSoLuong.Focus();
                return;
            }

            if (cboDanhMuc.SelectedValue == null
                || cboDanhMuc.SelectedValue is DataRowView)
            {
                MessageBox.Show("Vui lòng chọn danh mục!");
                return;
            }

            try
            {
                string sql = @"
                    INSERT INTO SanPham
                        (TenSanPham, DonGia, SoLuongTon, MaDanhMuc)
                    VALUES
                        (@Ten, @Gia, @SoLuong, @MaDanhMuc)";

                SqlParameter[] ps =
                {
                    new SqlParameter(
                        "@Ten", SqlDbType.NVarChar, 150)
                    {
                        Value = tenSP
                    },

                    new SqlParameter("@Gia", SqlDbType.Decimal)
                    {
                        Precision = 18,
                        Scale = 2,
                        Value = donGia
                    },

                    new SqlParameter("@SoLuong", SqlDbType.Int)
                    {
                        Value = soLuong
                    },

                    new SqlParameter("@MaDanhMuc", SqlDbType.Int)
                    {
                        Value = Convert.ToInt32(
                            cboDanhMuc.SelectedValue)
                    }
                };

                int ketQua = Db.Execute(sql, ps);

                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thêm được sản phẩm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}