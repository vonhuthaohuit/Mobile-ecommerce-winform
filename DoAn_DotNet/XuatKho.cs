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
    public partial class XuatKho : Form
    {
        public XuatKho()
        {
            InitializeComponent();
        }
        DBConnect_Khai db = new DBConnect_Khai();
        DataTable dt;
        void HienthiDSXuatKho()
        {
            string chuoitruyvan = "Select * from XUATKHO";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }
        void hienThiDSMaSP_cbo()
        {
            DBConnect_Khai db = new DBConnect_Khai();
            string chuoitruyvan = "Select * from NHAPKHO";
            DataTable dt = db.getDaTable(chuoitruyvan);

            cbo_MaSP.DataSource = dt;
            cbo_MaSP.DisplayMember = "MASANPHAM";
            cbo_MaSP.ValueMember = "MASANPHAM";
        }
        void hienThiDSMaKho_cbo()
        {
            DBConnect_Khai db = new DBConnect_Khai();
            string chuoitruyvan = "Select * from NHAPKHO";
            DataTable dt = db.getDaTable(chuoitruyvan);

            cbo_MaKho.DataSource = dt;
            cbo_MaKho.DisplayMember = "MAKHO";
            cbo_MaKho.ValueMember = "MAKHO";
        }
        void Databingding(DataTable pDT)
        {
            txt_MaXuatKho.DataBindings.Clear();
            cbo_MaKho.DataBindings.Clear();
            cbo_MaSP.DataBindings.Clear();
            txt_DonGia.DataBindings.Clear();
            numUD_SoLuong.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            txt_MaXuatKho.DataBindings.Add("Text", pDT, "MAXUATKHO");
            cbo_MaKho.DataBindings.Add("Text", pDT, "MAKHO");
            cbo_MaSP.DataBindings.Add("Text", pDT, "MASANPHAM");
            txt_DonGia.DataBindings.Add("Text", pDT, "DONGIA");
            numUD_SoLuong.DataBindings.Add("Text", pDT, "SOLUONG");
            dateTimePicker1.DataBindings.Add("Text", pDT, "NGAYXUAT");
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            HienthiDSXuatKho();
            hienThiDSMaSP_cbo();
            Databingding(dt);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select * from XUATKHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaXuatKho.Text);
            newRow["MAXUATKHO"] = txt_MaXuatKho.Text;
            newRow["MASANPHAM"] = cbo_MaSP.Text;
            newRow["MAKHO"] = cbo_MaKho.Text;
            newRow["SOLUONG"] = numUD_SoLuong.Text;
            newRow["DONGIA"] = txt_DonGia.Text;
            newRow["NGAYXUAT"] = dateTimePicker1.Text;
            string chuoitruyvan = "Select * from XUATKHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
            txt_MaXuatKho.Clear();
            txt_DonGia.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaXuatKho.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select * from XUATKHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Chưa xóa");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaXuatKho.Text);
            if (dr != null)
                dr["MASANPHAM"] = cbo_MaSP.Text;
                dr["MAKHO"] = cbo_MaKho.Text;
                dr["SOLUONG"] = numUD_SoLuong.Text;
                dr["DONGIA"] = txt_DonGia.Text;
                dr["NGAYXUAT"] = dateTimePicker1.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder();
            string chuoitruyvan = "Select * from XUATKHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã sửa");
            else
                MessageBox.Show("Chưa sửa");
            txt_MaXuatKho.Clear();
            txt_DonGia.Clear();
        }

        private void cbo_MaKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
