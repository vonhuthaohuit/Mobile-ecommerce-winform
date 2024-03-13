namespace DoAn_DotNet
{
    partial class Form2
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_GiaSP = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_MaChiTietSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mausac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.MACHITIETSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAUSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTASANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(861, 191);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(132, 59);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(611, 191);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 59);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(365, 191);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(116, 59);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_GiaSP
            // 
            this.txt_GiaSP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaSP.Location = new System.Drawing.Point(563, 129);
            this.txt_GiaSP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_GiaSP.Name = "txt_GiaSP";
            this.txt_GiaSP.Size = new System.Drawing.Size(158, 24);
            this.txt_GiaSP.TabIndex = 20;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSP.Location = new System.Drawing.Point(252, 125);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(229, 27);
            this.txt_MaSP.TabIndex = 19;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.Location = new System.Drawing.Point(625, 69);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(223, 24);
            this.txt_TenSP.TabIndex = 18;
            // 
            // txt_MaChiTietSP
            // 
            this.txt_MaChiTietSP.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaChiTietSP.Location = new System.Drawing.Point(254, 72);
            this.txt_MaChiTietSP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MaChiTietSP.Name = "txt_MaChiTietSP";
            this.txt_MaChiTietSP.Size = new System.Drawing.Size(227, 24);
            this.txt_MaChiTietSP.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã chi tiết sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACHITIETSANPHAM,
            this.MASANPHAM,
            this.TENSANPHAM,
            this.GIA,
            this.MAUSAC,
            this.MOTASANPHAM,
            this.HINHANH});
            this.dataGridView1.Location = new System.Drawing.Point(230, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(994, 226);
            this.dataGridView1.TabIndex = 21;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(614, 512);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(116, 59);
            this.btn_Luu.TabIndex = 27;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(875, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Màu sắc";
            // 
            // txt_mausac
            // 
            this.txt_mausac.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mausac.Location = new System.Drawing.Point(992, 67);
            this.txt_mausac.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_mausac.Name = "txt_mausac";
            this.txt_mausac.Size = new System.Drawing.Size(223, 24);
            this.txt_mausac.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(760, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mô Tả";
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(820, 133);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(395, 24);
            this.txt_mota.TabIndex = 18;
            // 
            // MACHITIETSANPHAM
            // 
            this.MACHITIETSANPHAM.DataPropertyName = "MACHITIETSANPHAM";
            this.MACHITIETSANPHAM.HeaderText = "Mã Chi Tiết Sản Phẩm";
            this.MACHITIETSANPHAM.Name = "MACHITIETSANPHAM";
            this.MACHITIETSANPHAM.Width = 150;
            // 
            // MASANPHAM
            // 
            this.MASANPHAM.DataPropertyName = "MASANPHAM";
            this.MASANPHAM.HeaderText = "MÃ SẢN PHẨM";
            this.MASANPHAM.Name = "MASANPHAM";
            this.MASANPHAM.Width = 150;
            // 
            // TENSANPHAM
            // 
            this.TENSANPHAM.DataPropertyName = "TENSANPHAM";
            this.TENSANPHAM.HeaderText = "TÊN SẢN PHẨM";
            this.TENSANPHAM.Name = "TENSANPHAM";
            this.TENSANPHAM.Width = 250;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "GIÁ";
            this.GIA.Name = "GIA";
            this.GIA.Width = 200;
            // 
            // MAUSAC
            // 
            this.MAUSAC.DataPropertyName = "MAUSAC";
            this.MAUSAC.HeaderText = "MÀU SẮC";
            this.MAUSAC.Name = "MAUSAC";
            // 
            // MOTASANPHAM
            // 
            this.MOTASANPHAM.DataPropertyName = "MOTASANPHAM";
            this.MOTASANPHAM.HeaderText = "MÔ TẢ";
            this.MOTASANPHAM.Name = "MOTASANPHAM";
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Hình Ảnh";
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hình Ảnh";
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Location = new System.Drawing.Point(252, 158);
            this.txt_HinhAnh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(229, 27);
            this.txt_HinhAnh.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 710);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_GiaSP);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_mausac);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_MaChiTietSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_GiaSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_MaChiTietSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mausac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHITIETSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAUSAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTASANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_HinhAnh;
    }
}