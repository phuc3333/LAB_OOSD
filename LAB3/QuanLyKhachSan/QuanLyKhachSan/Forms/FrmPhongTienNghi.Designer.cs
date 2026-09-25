namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvPhong);
            this.tabPage1.Controls.Add(this.btnThemPhong);
            this.tabPage1.Controls.Add(this.numGia);
            this.tabPage1.Controls.Add(this.numMax);
            this.tabPage1.Controls.Add(this.cboKhu);
            this.tabPage1.Controls.Add(this.txtPhong);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đơn giá/ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số người tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Khu vực";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(13, 108);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 82;
            this.dgvPhong.RowTemplate.Height = 33;
            this.dgvPhong.Size = new System.Drawing.Size(748, 303);
            this.dgvPhong.TabIndex = 15;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(657, 43);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(104, 46);
            this.btnThemPhong.TabIndex = 14;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(165, 40);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(120, 31);
            this.numGia.TabIndex = 13;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(641, 6);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 31);
            this.numMax.TabIndex = 12;
            // 
            // cboKhu
            // 
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(343, 3);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(121, 33);
            this.cboKhu.TabIndex = 11;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(98, 3);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 31);
            this.txtPhong.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTN);
            this.tabPage2.Controls.Add(this.btnThemTN);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtTinhTrang);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.numSTT);
            this.tabPage2.Controls.Add(this.cboLoai);
            this.tabPage2.Controls.Add(this.txtMaTN);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiện nghi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTN
            // 
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(13, 87);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 82;
            this.dgvTN.RowTemplate.Height = 33;
            this.dgvTN.Size = new System.Drawing.Size(748, 303);
            this.dgvTN.TabIndex = 28;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(661, 43);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(86, 36);
            this.btnThemTN.TabIndex = 27;
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(123, 40);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(100, 31);
            this.txtTinhTrang.TabIndex = 25;
            this.txtTinhTrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số thứ tự";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Loại tiện nghi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(648, 6);
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(120, 31);
            this.numSTT.TabIndex = 21;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(376, 3);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 33);
            this.cboLoai.TabIndex = 20;
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(82, 3);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(100, 31);
            this.txtMaTN.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvLD);
            this.tabPage3.Controls.Add(this.btnLapDat);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtGhiChu);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cboNV);
            this.tabPage3.Controls.Add(this.txtTTLD);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dtNgay);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cboPhong);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cboTN);
            this.tabPage3.Controls.Add(this.txtSoLD);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(775, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phiếu lắp đặt / Luân chuyển";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvLD
            // 
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Location = new System.Drawing.Point(9, 125);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.RowHeadersWidth = 82;
            this.dgvLD.RowTemplate.Height = 33;
            this.dgvLD.Size = new System.Drawing.Size(759, 262);
            this.dgvLD.TabIndex = 40;
            // 
            // btnLapDat
            // 
            this.btnLapDat.Location = new System.Drawing.Point(616, 83);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(135, 36);
            this.btnLapDat.TabIndex = 39;
            this.btnLapDat.Text = "Lập phiếu";
            this.btnLapDat.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(419, 80);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 31);
            this.txtGhiChu.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Nhân viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(536, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Tình trạng";
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(144, 78);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(121, 33);
            this.cboNV.TabIndex = 34;
            // 
            // txtTTLD
            // 
            this.txtTTLD.Location = new System.Drawing.Point(651, 46);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(100, 31);
            this.txtTTLD.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ngày lắp đặt";
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(144, 41);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(361, 31);
            this.dtNgay.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Chọn phòng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(651, 6);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(121, 33);
            this.cboPhong.TabIndex = 28;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Thiết bị tiện nghi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mã";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cboTN
            // 
            this.cboTN.FormattingEnabled = true;
            this.cboTN.Location = new System.Drawing.Point(374, 3);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(121, 33);
            this.cboTN.TabIndex = 25;
            this.cboTN.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSoLD
            // 
            this.txtSoLD.Location = new System.Drawing.Point(67, 3);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(100, 31);
            this.txtSoLD.TabIndex = 24;
            this.txtSoLD.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPhongTienNghi";
            this.Text = "FrmPhongTienNghi";
            this.Load += new System.EventHandler(this.FrmPhongTienNghi_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.Button btnLapDat;
    }
}