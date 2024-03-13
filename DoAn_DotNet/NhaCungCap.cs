using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn_DotNet
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        DBConnect_Khai db = new DBConnect_Khai();
        DataTable dt;
        void HienthiDSNCC()
        {
            string chuoitruyvan = "Select * from NHACUNGCAP";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }
        void Databingding(DataTable pDT)
        {
            txt_MaNCC.DataBindings.Clear();
            txt_TenNCC.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_MaNCC.DataBindings.Add("Text", pDT, "MANCC");
            txt_TenNCC.DataBindings.Add("Text", pDT, "TENNCC");
            txt_DiaChi.DataBindings.Add("Text", pDT, "DIACHI");
            txt_SDT.DataBindings.Add("Text", pDT, "SODIENTHOAI");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienthiDSNCC();
            Databingding(dt);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select * from NHACUNGCAP";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaNCC.Text);
            newRow["MANCC"] = txt_MaNCC.Text;
            newRow["TENNCC"] = txt_TenNCC.Text;
            newRow["DIACHI"] = txt_DiaChi.Text;
            newRow["SODIENTHOAI"] = txt_SDT.Text;
            string chuoitruyvan = "Select * from NHACUNGCAP";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaNCC.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select * from NHACUNGCAP";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Chưa xóa");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaNCC.Text);
            if (dr != null)
                dr["TENNCC"] = txt_TenNCC.Text;
                dr["DIACHI"] = txt_DiaChi.Text;
                dr["SODIENTHOAI"] = txt_SDT.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder();
            string chuoitruyvan = "Select * from NHACUNGCAP";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã sửa");
            else
                MessageBox.Show("Chưa sửa");
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_DiaChi.Clear();
            txt_SDT.Clear();
        }

    }
}
