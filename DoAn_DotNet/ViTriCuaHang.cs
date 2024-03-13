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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DBConnect_Quang db = new DBConnect_Quang();
        DataTable dt;
        void HienthiDSCUAHANG()
        {
            string chuoitruyvan = "Select * from VITRICUAHANG";
            dt = db.getDaTable(chuoitruyvan);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HienthiDSCUAHANG();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dataGridView1.DataSource;
            string chuoitruyvan = "Select * from VITRICUAHANG";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Lưu thành công");
            else
                MessageBox.Show("Lưu thất bại");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.Rows.Add(txt_MaVT.Text);
            newRow["MAVITRICUAHANG"] = txt_MaVT.Text;
            newRow["TENVITRICUAHANG"] = txt_TenVT.Text;
            newRow["DIACHICUAHANG"] = txt_DiaChi.Text;
            string chuoitruyvan = "Select * from VITRICUAHANG";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaVT.Clear();
            txt_TenVT.Clear();
            txt_DiaChi.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaVT.Text);
            if (dr != null)
                dr.Delete();
            string chuoitruyvan = "Select * from VITRICUAHANG";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows.Find(txt_MaVT.Text);
            if (dr != null)
                dr["MAVITRICUAHANG"] = txt_MaVT.Text;
                dr["TENVITRICUAHANG"] = txt_TenVT.Text;
                dr["DIACHICUAHANG"] = txt_DiaChi.Text;
            SqlCommandBuilder cb = new SqlCommandBuilder();
            string chuoitruyvan = "Select * from VITRICUAHANG";
            int k = db.upDateDataTable(dt, chuoitruyvan);
            if (k != 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            txt_MaVT.Clear();
            txt_TenVT.Clear();
            txt_DiaChi.Clear();
        }

    }
}
