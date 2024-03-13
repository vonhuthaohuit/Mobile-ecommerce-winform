namespace DoAn_DotNet
{
    partial class QuangCao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TenQC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.txt_MaQC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.MAQUANGCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENQUANGCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(592, 121);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(121, 55);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(379, 121);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(121, 55);
            this.btn_Xoa.TabIndex = 40;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(192, 121);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(121, 55);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAQUANGCAO,
            this.TENQUANGCAO,
            this.HINHANH});
            this.dataGridView1.Location = new System.Drawing.Point(283, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // txt_TenQC
            // 
            this.txt_TenQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenQC.Location = new System.Drawing.Point(629, 12);
            this.txt_TenQC.Name = "txt_TenQC";
            this.txt_TenQC.Size = new System.Drawing.Size(227, 23);
            this.txt_TenQC.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tên Quảng Cáo";
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Location = new System.Drawing.Point(229, 65);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(326, 23);
            this.txt_HinhAnh.TabIndex = 35;
            // 
            // txt_MaQC
            // 
            this.txt_MaQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaQC.Location = new System.Drawing.Point(229, 12);
            this.txt_MaQC.Name = "txt_MaQC";
            this.txt_MaQC.Size = new System.Drawing.Size(242, 23);
            this.txt_MaQC.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hình Ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã Quảng Cáo";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(794, 121);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(121, 55);
            this.btn_Luu.TabIndex = 42;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click_1);
            // 
            // MAQUANGCAO
            // 
            this.MAQUANGCAO.DataPropertyName = "MAQUANGCAO";
            this.MAQUANGCAO.HeaderText = "MÃ QUẢNG CÁO";
            this.MAQUANGCAO.Name = "MAQUANGCAO";
            this.MAQUANGCAO.Width = 150;
            // 
            // TENQUANGCAO
            // 
            this.TENQUANGCAO.DataPropertyName = "TENQUANGCAO";
            this.TENQUANGCAO.HeaderText = "Tên Quảng Cáo";
            this.TENQUANGCAO.Name = "TENQUANGCAO";
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Hình Ảnh";
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 373);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TenQC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.txt_MaQC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_TenQC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HinhAnh;
        private System.Windows.Forms.TextBox txt_MaQC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQUANGCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENQUANGCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANH;
    }
}