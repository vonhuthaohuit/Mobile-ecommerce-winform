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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        DBConnect_Khai db = new DBConnect_Khai();
        DataTable dt;
        void HienthiDSKho()
        {
            string chuoitruyvan = "Select MAKHO, TENKHO, DIACHIKHO, SODIENTHOAIKHO from KHO";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }
        void Databingding(DataTable pDT)
        {
            txt_MaKho.DataBindings.Clear();
            txt_TenKho.DataBindings.Clear();
            txt_DiaChiKho.DataBindings.Clear();
            txt_SDTKho.DataBindings.Clear();
            txt_MaKho.DataBindings.Add("Text", pDT, "MAKHO");
            txt_TenKho.DataBindings.Add("Text", pDT, "TENKHO");
            txt_DiaChiKho.DataBindings.Add("Text", pDT, "DIACHIKHO");
            txt_SDTKho.DataBindings.Add("Text", pDT, "SODIENTHOAIKHO");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            HienthiDSKho();
            Databingding(dt); 
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select MAKHO, TENKHO, DIACHIKHO, SODIENTHOAIKHO from KHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaKho.Text);
            newRow["MAKHO"] = txt_MaKho.Text;
            newRow["TENKHO"] = txt_TenKho.Text;
            newRow["DIACHIKHO"] = txt_DiaChiKho.Text;
            newRow["SODIENTHOAIKHO"] = txt_SDTKho.Text;
            string chuoitruyvan = "Select MAKHO, TENKHO, DIACHIKHO, SODIENTHOAIKHO from KHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
            txt_MaKho.Clear();
            txt_TenKho.Clear();
            txt_DiaChiKho.Clear();
            txt_SDTKho.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaKho.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select MAKHO, TENKHO, DIACHIKHO, SODIENTHOAIKHO from KHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã xóa");
            else
                MessageBox.Show("Chưa xóa");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaKho.Text);
            if (dr != null)
                dr["TENKHO"] = txt_TenKho.Text;
                dr["DIACHIKHO"] = txt_DiaChiKho.Text;
                dr["SODIENTHOAIKHO"] = txt_SDTKho.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder();
            string chuoitruyvan = "Select MAKHO, TENKHO, DIACHIKHO, SODIENTHOAIKHO from KHO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã sửa");
            else
                MessageBox.Show("Chưa sửa");
            txt_MaKho.Clear();
            txt_TenKho.Clear();
            txt_DiaChiKho.Clear();
            txt_SDTKho.Clear();
        }
    }
}
