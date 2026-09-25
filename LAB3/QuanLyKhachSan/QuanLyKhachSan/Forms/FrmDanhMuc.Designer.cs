namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabQuyDinh = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabQuyDinh.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQuyDinh
            // 
            this.tabQuyDinh.Controls.Add(this.tabPage1);
            this.tabQuyDinh.Controls.Add(this.tabPage2);
            this.tabQuyDinh.Controls.Add(this.tabPage3);
            this.tabQuyDinh.Controls.Add(this.tabPage4);
            this.tabQuyDinh.Controls.Add(this.tabPage5);
            this.tabQuyDinh.Location = new System.Drawing.Point(12, 12);
            this.tabQuyDinh.Name = "tabQuyDinh";
            this.tabQuyDinh.SelectedIndex = 0;
            this.tabQuyDinh.Size = new System.Drawing.Size(776, 444);
            this.tabQuyDinh.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvKhu);
            this.tabPage1.Controls.Add(this.btnThemKhu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.txtKhuTen);
            this.tabPage1.Controls.Add(this.txtKhuMa);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khu vực";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvKhu
            // 
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Location = new System.Drawing.Point(6, 88);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.RowHeadersWidth = 82;
            this.dgvKhu.RowTemplate.Height = 33;
            this.dgvKhu.Size = new System.Drawing.Size(748, 303);
            this.dgvKhu.TabIndex = 7;
            this.dgvKhu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhu_CellContentClick);
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(668, 1);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(86, 36);
            this.btnThemKhu.TabIndex = 6;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn vị/Vai trò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(562, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 2;
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(275, 3);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(100, 31);
            this.txtKhuTen.TabIndex = 1;
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(85, 6);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(100, 31);
            this.txtKhuMa.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvNV);
            this.tabPage2.Controls.Add(this.txtNVSDT);
            this.tabPage2.Controls.Add(this.btnThemNV);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtNVVaiTro);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtNVTen);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNVMa);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(9, 115);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 82;
            this.dgvNV.RowTemplate.Height = 33;
            this.dgvNV.Size = new System.Drawing.Size(748, 282);
            this.dgvNV.TabIndex = 12;
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(396, 10);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(100, 31);
            this.txtNVSDT.TabIndex = 11;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(582, 13);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(86, 36);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "SDT";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(396, 53);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(100, 31);
            this.txtNVVaiTro.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vai trò";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(99, 53);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(100, 31);
            this.txtNVTen.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(99, 7);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(100, 31);
            this.txtNVMa.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvLoaiTN);
            this.tabPage3.Controls.Add(this.txtLoaiMa);
            this.tabPage3.Controls.Add(this.btnThemLoaiTN);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtLoaiTen);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(760, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Loại tiện nghi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Location = new System.Drawing.Point(0, 105);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.RowHeadersWidth = 82;
            this.dgvLoaiTN.RowTemplate.Height = 33;
            this.dgvLoaiTN.Size = new System.Drawing.Size(748, 282);
            this.dgvLoaiTN.TabIndex = 17;
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(110, 9);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(100, 31);
            this.txtLoaiMa.TabIndex = 16;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(296, 12);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(86, 36);
            this.btnThemLoaiTN.TabIndex = 15;
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã";
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(110, 52);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(100, 31);
            this.txtLoaiTen.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Loại tên";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDV);
            this.tabPage4.Controls.Add(this.btnThemDV);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.numDVGia);
            this.tabPage4.Controls.Add(this.txtDVDVT);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtDVMa);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtDVTen);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(760, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dịch vụ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(-44, 132);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 82;
            this.dgvDV.RowTemplate.Height = 33;
            this.dgvDV.Size = new System.Drawing.Size(804, 282);
            this.dgvDV.TabIndex = 26;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(627, 35);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(86, 36);
            this.btnThemDV.TabIndex = 25;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Giá";
            // 
            // numDVGia
            // 
            this.numDVGia.Location = new System.Drawing.Point(403, 47);
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(120, 31);
            this.numDVGia.TabIndex = 23;
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(403, 3);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(100, 31);
            this.txtDVDVT.TabIndex = 22;
            this.txtDVDVT.TextChanged += new System.EventHandler(this.txtDVDVT_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Đơn vị tính";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(143, 3);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(100, 31);
            this.txtDVMa.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã";
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(143, 46);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(100, 31);
            this.txtDVTen.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tên dinh vụ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvQD);
            this.tabPage5.Controls.Add(this.btnThemQD);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.numQDTien);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.cboQDLoai);
            this.tabPage5.Controls.Add(this.txtQDMa);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.txtQDMucDo);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(760, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Quy định đền bù";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvQD
            // 
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Location = new System.Drawing.Point(3, 105);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.RowHeadersWidth = 82;
            this.dgvQD.RowTemplate.Height = 33;
            this.dgvQD.Size = new System.Drawing.Size(748, 282);
            this.dgvQD.TabIndex = 30;
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(617, 7);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(86, 36);
            this.btnThemQD.TabIndex = 29;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "Tiền";
            // 
            // numQDTien
            // 
            this.numQDTien.Location = new System.Drawing.Point(401, 53);
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(120, 31);
            this.numQDTien.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(306, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Loại";
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(400, 7);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(121, 33);
            this.cboQDLoai.TabIndex = 25;
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(137, 7);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(100, 31);
            this.txtQDMa.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Mã";
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(137, 50);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(100, 31);
            this.txtQDMucDo.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Mức độ";
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 464);
            this.Controls.Add(this.tabQuyDinh);
            this.Name = "FrmDanhMuc";
            this.Text = "FrmDanhMuc";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load_1);
            this.tabQuyDinh.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuyDinh;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvQD;
    }
}