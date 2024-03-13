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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DBConnect_Quang db = new DBConnect_Quang();
        DataTable dt;
        void HienthiDSSP()
        {
            string chuoitruyvan = "Select * from CHITIETSANPHAM";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienthiDSSP();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select * from CHITIETSANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaChiTietSP.Text);
            newRow["MACHITIETSANPHAM"] = txt_MaChiTietSP.Text;
            newRow["MASANPHAM"] = txt_MaSP.Text;
            newRow["TENSANPHAM"] = txt_TenSP.Text;
            newRow["GIA"] = txt_GiaSP.Text;
            newRow["MAUSAC"] = txt_mausac.Text;
            newRow["MOTASANPHAM"] = txt_mota.Text;
            newRow["HINHANH"] = txt_mota.Text;
            string chuoitruyvan = "Select * from CHITIETSANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaChiTietSP.Clear();
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_GiaSP.Clear();
            txt_mausac.Clear();
            txt_mota.Clear();
            txt_HinhAnh.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaChiTietSP.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select MACHITIETSANPHAM, MASANPHAM, TENSANPHAM, GIA, MAUSAC, MOTASANPHAM from CHITIETSANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaChiTietSP.Text);
            if (dr != null)
            dr["MACHITIETSANPHAM"] = txt_MaChiTietSP.Text;
            dr["MASANPHAM"] = txt_MaSP.Text;
            dr["TENSANPHAM"] = txt_TenSP.Text;
            dr["GIA"] = txt_GiaSP.Text;
            dr["MAUSAC"] = txt_mausac.Text;
            dr["MOTASANPHAM"] = txt_mota.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder();
            string chuoitruyvan = "Select MACHITIETSANPHAM, MASANPHAM, TENSANPHAM, GIA, MAUSAC, MOTASANPHAM from CHITIETSANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaChiTietSP.Clear();
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_GiaSP.Clear();
            txt_mausac.Clear();
            txt_mota.Clear();
        }
    }
}
