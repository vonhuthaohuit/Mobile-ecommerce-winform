using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_DotNet
{
    public partial class DonHang : Form
    {
        DataTable dt;
        ConnectDB_Hao db = new ConnectDB_Hao();
        SqlConnection conStr;
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public DonHang()
        {
            conStr = new SqlConnection(@"Data Source=A204PC31;Initial Catalog=QUAN_LY_CUA_HANG_BAN_DIEN_THOAI;Persist Security Info=True;User ID=SA;Password=123");
            string query = "SELECT * FROM DONHANG";
            da = new SqlDataAdapter(query, conStr);
            ds = new DataSet();
            da.Fill(ds, "DONHANG");
            key[0] = ds.Tables["DONHANG"].Columns[0];
            ds.Tables["DONHANG"].PrimaryKey = key;
            InitializeComponent();
        }
        void dataBingDing(DataTable pDT)
        {
            txt_MaDonHang.DataBindings.Clear();
            cbo_KhachHang.DataBindings.Clear();
            dTP_NgayDat.DataBindings.Clear();
            cbo_TrangThai.DataBindings.Clear();

            txt_MaDonHang.DataBindings.Add("Text", pDT, "MADONHANG");
            cbo_KhachHang.DataBindings.Add("Text", pDT, "MAKHACHHANG");
            dTP_NgayDat.DataBindings.Add("Text", pDT, "NGAYDATHANG");
            cbo_TrangThai.DataBindings.Add("Text", pDT, "TRANGTHAI");
        }
        void load_CboTrangThai()
        {
            string[] trangThais = { "Chờ xử lý", "Đã Thanh Toán", "Đang Giao Hàng", "Giao Thành Công" };
            foreach (string item in trangThais)
            {
                cbo_TrangThai.Items.Add(item);
            }
            cbo_TrangThai.SelectedIndex = 0;
        }
        void load_DGVDonHang()
        {
            dgv_DonHang.DataSource = db.getDataTable("SELECT * FROM DONHANG");
            dgv_DonHang.DataSource = ds.Tables[0];
            dataBingDing(ds.Tables[0]);

        }
        void load_CboKhachHang()
        {
            ConnectDB_Hao connect = new ConnectDB_Hao();
            string query = @"SELECT * FROM KHACHHANG INNER JOIN PERSON ON KHACHHANG.MAPERSON = PERSON.MAPERSON";
            DataTable dt = connect.getDataTable(query);

            cbo_KhachHang.DataSource = dt;
            cbo_KhachHang.DisplayMember = "TEN";
            cbo_KhachHang.ValueMember = "MAKHACHHANG";
        }
        private void DonHang_Load(object sender, EventArgs e)
        {
            load_CboTrangThai();
            load_CboKhachHang();
            load_DGVDonHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ConnectDB_Hao db = new ConnectDB_Hao();
            string ngayDat = string.Format("{0:yyyy-MM-dd}", dTP_NgayDat.Value);
            if (db.insertDonHang(txt_MaDonHang.Text, cbo_KhachHang.SelectedValue.ToString(), ngayDat, cbo_TrangThai.SelectedItem.ToString()))
            {
                MessageBox.Show("Thêm Thành Công");
                load_DGVDonHang();
            }
            else
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ConnectDB_Hao db = new ConnectDB_Hao();
            if (db.deleteDonHang(txt_MaDonHang.Text))
            {
                MessageBox.Show("Xóa Thành Công");
                load_DGVDonHang();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ConnectDB_Hao db = new ConnectDB_Hao();
            string ngayDat = string.Format("{0:yyyy-MM-dd}", dTP_NgayDat.Value);
            if (db.updateDonHang(txt_MaDonHang.Text, cbo_KhachHang.SelectedValue.ToString(), ngayDat, cbo_TrangThai.SelectedItem.ToString()))
            {
                MessageBox.Show("Sửa Thành Công");
                load_DGVDonHang();
            }
            else
            {
                MessageBox.Show("Sửa Không Thành Công");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_LuuCSDL_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dgv_DonHang.DataSource;

            string query = "SELECT * FROM DONHANG";
            int k = db.updateDataTable(dt, query);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại!");
        }
    }
}
