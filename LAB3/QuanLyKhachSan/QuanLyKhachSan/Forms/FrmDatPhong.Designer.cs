namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnThemKhach);
            this.tabPage1.Controls.Add(this.dgvKhach);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSDT);
            this.tabPage1.Controls.Add(this.txtTenKH);
            this.tabPage1.Controls.Add(this.txtCMND);
            this.tabPage1.Controls.Add(this.txtQT);
            this.tabPage1.Controls.Add(this.txtMaKH);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(639, 43);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(122, 41);
            this.btnThemKhach.TabIndex = 11;
            this.btnThemKhach.Text = "Thêm";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            // 
            // dgvKhach
            // 
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(0, 97);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 82;
            this.dgvKhach.RowTemplate.Height = 33;
            this.dgvKhach.Size = new System.Drawing.Size(785, 424);
            this.dgvKhach.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quốc tịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(354, 46);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 31);
            this.txtSDT.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(354, 3);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 31);
            this.txtTenKH.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(648, 6);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 31);
            this.txtCMND.TabIndex = 2;
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(106, 40);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(100, 31);
            this.txtQT.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(54, 3);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 31);
            this.txtMaKH.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThemPhong);
            this.tabPage2.Controls.Add(this.btnBoPhong);
            this.tabPage2.Controls.Add(this.btnLapPhieu);
            this.tabPage2.Controls.Add(this.dgvPhieu);
            this.tabPage2.Controls.Add(this.dgvChon);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.numSoNguoi);
            this.tabPage2.Controls.Add(this.dgvPhong);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.numCoc);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dtTra);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dtNhan);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtLap);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cboNV);
            this.tabPage2.Controls.Add(this.cboKenh);
            this.tabPage2.Controls.Add(this.cboKhach);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSoPhieu);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đặt phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(423, 163);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(106, 57);
            this.btnThemPhong.TabIndex = 30;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(423, 226);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(106, 55);
            this.btnBoPhong.TabIndex = 29;
            this.btnBoPhong.Text = "Bỏ";
            this.btnBoPhong.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(659, 333);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(152, 54);
            this.btnLapPhieu.TabIndex = 28;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(-8, 393);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.RowHeadersWidth = 82;
            this.dgvPhieu.RowTemplate.Height = 33;
            this.dgvPhieu.Size = new System.Drawing.Size(950, 193);
            this.dgvPhieu.TabIndex = 27;
            // 
            // dgvChon
            // 
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Location = new System.Drawing.Point(535, 163);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.RowHeadersWidth = 82;
            this.dgvChon.RowTemplate.Height = 33;
            this.dgvChon.Size = new System.Drawing.Size(405, 164);
            this.dgvChon.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(277, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Số người";
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(411, 126);
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(94, 31);
            this.numSoNguoi.TabIndex = 24;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(0, 163);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 82;
            this.dgvPhong.RowTemplate.Height = 33;
            this.dgvPhong.Size = new System.Drawing.Size(417, 164);
            this.dgvPhong.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tiền cọc";
            // 
            // numCoc
            // 
            this.numCoc.Location = new System.Drawing.Point(140, 126);
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(94, 31);
            this.numCoc.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(609, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày trả";
            // 
            // dtTra
            // 
            this.dtTra.Location = new System.Drawing.Point(730, 80);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(200, 31);
            this.dtTra.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Ngày nhận";
            // 
            // dtNhan
            // 
            this.dtNhan.Location = new System.Drawing.Point(140, 79);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(200, 31);
            this.dtNhan.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày lập";
            // 
            // dtLap
            // 
            this.dtLap.Location = new System.Drawing.Point(365, 43);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(200, 31);
            this.dtLap.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kênh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Khách hàng";
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(768, 3);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(121, 33);
            this.cboNV.TabIndex = 11;
            // 
            // cboKenh
            // 
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(74, 40);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(121, 33);
            this.cboKenh.TabIndex = 10;
            // 
            // cboKhach
            // 
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(365, 3);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(121, 33);
            this.cboKhach.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(63, 3);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 31);
            this.txtSoPhieu.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnNhanPhong);
            this.tabPage3.Controls.Add(this.dgvNguoi);
            this.tabPage3.Controls.Add(this.btnThemNguoi);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtNguoiPhong);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtNguoiQT);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtNguoiCMND);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtNguoiTen);
            this.tabPage3.Controls.Add(this.dgvCT);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtPhieuChon);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(787, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhận phòng/Người lưu trú";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 36;
            this.button1.Text = "NoShow";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(540, 480);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(119, 41);
            this.btnNhanPhong.TabIndex = 35;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoi.Location = new System.Drawing.Point(7, 251);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.RowHeadersWidth = 82;
            this.dgvNguoi.RowTemplate.Height = 33;
            this.dgvNguoi.Size = new System.Drawing.Size(776, 220);
            this.dgvNguoi.TabIndex = 34;
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(691, 204);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(82, 41);
            this.btnThemNguoi.TabIndex = 33;
            this.btnThemNguoi.Text = "Thêm";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 25);
            this.label19.TabIndex = 32;
            this.label19.Text = "Phòng";
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(83, 161);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(100, 31);
            this.txtNguoiPhong.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(279, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 25);
            this.label18.TabIndex = 30;
            this.label18.Text = "Tên";
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(83, 202);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(100, 31);
            this.txtNguoiQT.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(580, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "CMND";
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(673, 167);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(100, 31);
            this.txtNguoiCMND.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "CMND";
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(384, 164);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(100, 31);
            this.txtNguoiTen.TabIndex = 25;
            // 
            // dgvCT
            // 
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(8, 40);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 82;
            this.dgvCT.RowTemplate.Height = 33;
            this.dgvCT.Size = new System.Drawing.Size(776, 115);
            this.dgvCT.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 25);
            this.label15.TabIndex = 10;
            this.label15.Text = "Số";
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.Location = new System.Drawing.Point(63, 3);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.Size = new System.Drawing.Size(100, 31);
            this.txtPhieuChon.TabIndex = 9;
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDatPhong";
            this.Text = "FrmDatPhong";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.DataGridView dgvNguoi;
        private System.Windows.Forms.Button btnThemNguoi;
    }
}