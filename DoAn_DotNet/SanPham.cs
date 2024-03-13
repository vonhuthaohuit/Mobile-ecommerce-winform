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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBConnect_Quang db = new DBConnect_Quang();
        DataTable dt;
        void HienthiDSSP()
        {
            string chuoitruyvan = "Select * from SANPHAM";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HienthiDSSP();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select * from SANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaSP.Text);
            newRow["MASANPHAM"] = txt_MaSP.Text;
            string chuoitruyvan = "Select * from SANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Đã thêm");
            else
                MessageBox.Show("Chưa thêm");
            txt_MaSP.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaSP.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select * from SANPHAM";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
