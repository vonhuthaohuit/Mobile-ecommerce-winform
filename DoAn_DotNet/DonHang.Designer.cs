namespace DoAn_DotNet
{
    partial class DonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaDonHang = new System.Windows.Forms.TextBox();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.cbo_KhachHang = new System.Windows.Forms.ComboBox();
            this.dTP_NgayDat = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dgv_DonHang = new System.Windows.Forms.DataGridView();
            this.btn_LuuCSDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã khách hàng:";
            // 
            // txt_MaDonHang
            // 
            this.txt_MaDonHang.Location = new System.Drawing.Point(272, 111);
            this.txt_MaDonHang.Name = "txt_MaDonHang";
            this.txt_MaDonHang.Size = new System.Drawing.Size(200, 22);
            this.txt_MaDonHang.TabIndex = 6;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Location = new System.Drawing.Point(272, 262);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(200, 24);
            this.cbo_TrangThai.TabIndex = 7;
            // 
            // cbo_KhachHang
            // 
            this.cbo_KhachHang.FormattingEnabled = true;
            this.cbo_KhachHang.Location = new System.Drawing.Point(624, 114);
            this.cbo_KhachHang.Name = "cbo_KhachHang";
            this.cbo_KhachHang.Size = new System.Drawing.Size(200, 24);
            this.cbo_KhachHang.TabIndex = 8;
            // 
            // dTP_NgayDat
            // 
            this.dTP_NgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_NgayDat.Location = new System.Drawing.Point(272, 193);
            this.dTP_NgayDat.Name = "dTP_NgayDat";
            this.dTP_NgayDat.Size = new System.Drawing.Size(200, 22);
            this.dTP_NgayDat.TabIndex = 9;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(295, 321);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 32);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(465, 321);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 32);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(633, 321);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(111, 32);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(781, 321);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(111, 32);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dgv_DonHang
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DonHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DonHang.Location = new System.Drawing.Point(174, 390);
            this.dgv_DonHang.Name = "dgv_DonHang";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DonHang.RowTemplate.Height = 24;
            this.dgv_DonHang.Size = new System.Drawing.Size(872, 281);
            this.dgv_DonHang.TabIndex = 14;
            this.dgv_DonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DonHang_CellContentClick);
            // 
            // btn_LuuCSDL
            // 
            this.btn_LuuCSDL.Location = new System.Drawing.Point(543, 688);
            this.btn_LuuCSDL.Name = "btn_LuuCSDL";
            this.btn_LuuCSDL.Size = new System.Drawing.Size(75, 23);
            this.btn_LuuCSDL.TabIndex = 15;
            this.btn_LuuCSDL.Text = "Lưu";
            this.btn_LuuCSDL.UseVisualStyleBackColor = true;
            this.btn_LuuCSDL.Click += new System.EventHandler(this.btn_LuuCSDL_Click);
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 769);
            this.Controls.Add(this.btn_LuuCSDL);
            this.Controls.Add(this.dgv_DonHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dTP_NgayDat);
            this.Controls.Add(this.cbo_KhachHang);
            this.Controls.Add(this.cbo_TrangThai);
            this.Controls.Add(this.txt_MaDonHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DonHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaDonHang;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.ComboBox cbo_KhachHang;
        private System.Windows.Forms.DateTimePicker dTP_NgayDat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridView dgv_DonHang;
        private System.Windows.Forms.Button btn_LuuCSDL;
    }
}

