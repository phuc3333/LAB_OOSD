namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTu
            // 
            this.dtTu.Location = new System.Drawing.Point(109, 12);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(200, 31);
            this.dtTu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dtDen
            // 
            this.dtDen.Location = new System.Drawing.Point(471, 12);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(200, 31);
            this.dtDen.TabIndex = 2;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(746, 4);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(126, 54);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Location = new System.Drawing.Point(12, 64);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 82;
            this.dgvTongHop.RowTemplate.Height = 33;
            this.dgvTongHop.Size = new System.Drawing.Size(860, 196);
            this.dgvTongHop.TabIndex = 5;
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(12, 266);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 82;
            this.dgvDV.RowTemplate.Height = 33;
            this.dgvDV.Size = new System.Drawing.Size(860, 195);
            this.dgvDV.TabIndex = 6;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(734, 467);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 48);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 527);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTu);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnDong;
    }
}