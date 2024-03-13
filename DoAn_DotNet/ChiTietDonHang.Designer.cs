namespace DoAn_DotNet
{
    partial class ChiTietDonHang
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_ChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUD_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbo_KiemTraThanhToan = new System.Windows.Forms.ComboBox();
            this.cbo_SanPham = new System.Windows.Forms.ComboBox();
            this.cbo_DonHang = new System.Windows.Forms.ComboBox();
            this.txt_MaChiTietDonHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LuuCSDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietDonHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(535, 69);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chi Tiết Đơn Hàng";
            // 
            // dgv_ChiTietDonHang
            // 
            this.dgv_ChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietDonHang.Location = new System.Drawing.Point(146, 386);
            this.dgv_ChiTietDonHang.Name = "dgv_ChiTietDonHang";
            this.dgv_ChiTietDonHang.RowTemplate.Height = 24;
            this.dgv_ChiTietDonHang.Size = new System.Drawing.Size(879, 310);
            this.dgv_ChiTietDonHang.TabIndex = 9;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(783, 336);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(111, 32);
            this.btn_Thoat.TabIndex = 17;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(635, 336);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 32);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(467, 336);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 32);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(297, 336);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 32);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUD_SoLuong);
            this.groupBox1.Controls.Add(this.cbo_KiemTraThanhToan);
            this.groupBox1.Controls.Add(this.cbo_SanPham);
            this.groupBox1.Controls.Add(this.cbo_DonHang);
            this.groupBox1.Controls.Add(this.txt_MaChiTietDonHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(146, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 237);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Đơn Hàng";
            // 
            // numUD_SoLuong
            // 
            this.numUD_SoLuong.Location = new System.Drawing.Point(619, 38);
            this.numUD_SoLuong.Name = "numUD_SoLuong";
            this.numUD_SoLuong.Size = new System.Drawing.Size(120, 22);
            this.numUD_SoLuong.TabIndex = 29;
            // 
            // cbo_KiemTraThanhToan
            // 
            this.cbo_KiemTraThanhToan.FormattingEnabled = true;
            this.cbo_KiemTraThanhToan.Location = new System.Drawing.Point(656, 105);
            this.cbo_KiemTraThanhToan.Name = "cbo_KiemTraThanhToan";
            this.cbo_KiemTraThanhToan.Size = new System.Drawing.Size(152, 24);
            this.cbo_KiemTraThanhToan.TabIndex = 28;
            // 
            // cbo_SanPham
            // 
            this.cbo_SanPham.FormattingEnabled = true;
            this.cbo_SanPham.Location = new System.Drawing.Point(177, 171);
            this.cbo_SanPham.Name = "cbo_SanPham";
            this.cbo_SanPham.Size = new System.Drawing.Size(204, 24);
            this.cbo_SanPham.TabIndex = 27;
            // 
            // cbo_DonHang
            // 
            this.cbo_DonHang.FormattingEnabled = true;
            this.cbo_DonHang.Location = new System.Drawing.Point(177, 105);
            this.cbo_DonHang.Name = "cbo_DonHang";
            this.cbo_DonHang.Size = new System.Drawing.Size(204, 24);
            this.cbo_DonHang.TabIndex = 26;
            // 
            // txt_MaChiTietDonHang
            // 
            this.txt_MaChiTietDonHang.Location = new System.Drawing.Point(177, 40);
            this.txt_MaChiTietDonHang.Name = "txt_MaChiTietDonHang";
            this.txt_MaChiTietDonHang.Size = new System.Drawing.Size(204, 22);
            this.txt_MaChiTietDonHang.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kiểm Tra Thanh Toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Đơn Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Chi Tiết Đơn Hàng";
            // 
            // btn_LuuCSDL
            // 
            this.btn_LuuCSDL.Location = new System.Drawing.Point(539, 702);
            this.btn_LuuCSDL.Name = "btn_LuuCSDL";
            this.btn_LuuCSDL.Size = new System.Drawing.Size(78, 35);
            this.btn_LuuCSDL.TabIndex = 21;
            this.btn_LuuCSDL.Text = "Lưu";
            this.btn_LuuCSDL.UseVisualStyleBackColor = true;
            this.btn_LuuCSDL.Click += new System.EventHandler(this.btn_LuuCSDL_Click);
            // 
            // ChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 766);
            this.Controls.Add(this.btn_LuuCSDL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_ChiTietDonHang);
            this.Controls.Add(this.label4);
            this.Name = "ChiTietDonHang";
            this.Text = "ChiTietDonHang";
            this.Load += new System.EventHandler(this.ChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietDonHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_ChiTietDonHang;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUD_SoLuong;
        private System.Windows.Forms.ComboBox cbo_KiemTraThanhToan;
        private System.Windows.Forms.ComboBox cbo_SanPham;
        private System.Windows.Forms.ComboBox cbo_DonHang;
        private System.Windows.Forms.TextBox txt_MaChiTietDonHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LuuCSDL;
    }
}