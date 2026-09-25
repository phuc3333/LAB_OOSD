namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
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
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLuot
            // 
            this.cboLuot.FormattingEnabled = true;
            this.cboLuot.Location = new System.Drawing.Point(151, 1);
            this.cboLuot.Name = "cboLuot";
            this.cboLuot.Size = new System.Drawing.Size(121, 33);
            this.cboLuot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu lưu trú";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(415, 3);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 31);
            this.txtPhong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dịch vụ";
            // 
            // cboDV
            // 
            this.cboDV.FormattingEnabled = true;
            this.cboDV.Location = new System.Drawing.Point(708, 1);
            this.cboDV.Name = "cboDV";
            this.cboDV.Size = new System.Drawing.Size(121, 33);
            this.cboDV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhân viên";
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(150, 40);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(121, 33);
            this.cboNV.TabIndex = 6;
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(471, 45);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 31);
            this.dtNgay.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày sử dụng";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(150, 81);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(120, 31);
            this.numSL.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng";
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(538, 83);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(133, 35);
            this.btnGhi.TabIndex = 12;
            this.btnGhi.Text = "Ghi nhận";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(696, 81);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(133, 37);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(12, 139);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 82;
            this.dgvLichSu.RowTemplate.Height = 33;
            this.dgvLichSu.Size = new System.Drawing.Size(817, 343);
            this.dgvLichSu.TabIndex = 14;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 494);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLuot);
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}