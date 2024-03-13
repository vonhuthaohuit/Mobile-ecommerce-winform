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
    public partial class QuangCao : Form
    {
        public QuangCao()
        {
            InitializeComponent();
        }
        DBConnect_Quang db = new DBConnect_Quang();
        DataTable dt;
        void HienthiDSQC()
        {
            string chuoitruyvan = "Select * from QUANGCAO";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HienthiDSQC();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaQC.Text);
            newRow["MAQUANGCAO"] = txt_MaQC.Text;
            newRow["TENQUANGCAO"] = txt_TenQC.Text;
            newRow["HINHANH"] = txt_HinhAnh.Text;
            string chuoitruyvan = "Select * from QUANGCAO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaQC.Clear();
            txt_TenQC.Clear();
            txt_HinhAnh.Clear();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaQC.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select * from QUANGCAO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaQC.Text);
            if (dr != null)
                dr["MAQUANGCAO"] = txt_MaQC.Text;
                dr["TENQUANGCAO"] = txt_TenQC.Text;
                dr["HINHANH"] = txt_HinhAnh.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder();
            string chuoitruyvan = "Select * from QUANGCAO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            txt_MaQC.Clear();
            txt_TenQC.Clear();
            txt_HinhAnh.Clear();
        }

        private void btn_Luu_Click_1(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select * from QUANGCAO";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Lưu thành công");
            else
                MessageBox.Show("Lưu thất bại");
        }
    }
}
