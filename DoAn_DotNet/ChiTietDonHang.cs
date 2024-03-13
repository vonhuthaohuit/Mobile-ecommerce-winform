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
    public partial class ChiTietDonHang : Form
    {
        DataTable dt;
        ConnectDB_Hao db = new ConnectDB_Hao();
        SqlConnection conStr;
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public ChiTietDonHang()
        {
            conStr = new SqlConnection(@"Data Source=A204PC31;Initial Catalog=QUAN_LY_CUA_HANG_BAN_DIEN_THOAI;Persist Security Info=True;User ID=SA;Password=123");
            string query = "SELECT * FROM CHITIETDONHANG";
            da = new SqlDataAdapter(query, conStr);
            ds = new DataSet();
            da.Fill(ds, "CHITIETDONHANG");
            DataColumn[] keyColumns = new DataColumn[3];
            keyColumns[0] = ds.Tables["CHITIETDONHANG"].Columns["MACHITIETDONHANG"];
            keyColumns[1] = ds.Tables["CHITIETDONHANG"].Columns["MADONHANG"];
            keyColumns[2] = ds.Tables["CHITIETDONHANG"].Columns["MASANPHAM"];

            // Thiết lập mảng cột làm khóa chính
            ds.Tables["CHITIETDONHANG"].PrimaryKey = keyColumns;
            InitializeComponent();
        }
        void dataBingDing(DataTable pDT)
        {
            txt_MaChiTietDonHang.DataBindings.Clear();
            cbo_DonHang.DataBindings.Clear();
            cbo_SanPham.DataBindings.Clear();
            cbo_KiemTraThanhToan.DataBindings.Clear();
            numUD_SoLuong.DataBindings.Clear();


            txt_MaChiTietDonHang.DataBindings.Add("Text", pDT, "MACHITIETDONHANG");
            cbo_DonHang.DataBindings.Add("Text", pDT, "MADONHANG");
            cbo_SanPham.DataBindings.Add("Text", pDT, "MASANPHAM");
            Binding binding = new Binding("Text", pDT, "KIEMTRATHANHTOAN");

            // Sử dụng sự kiện Format để định dạng giá trị
            binding.Format += (sender, e) =>
            {
                if (e.Value is bool)
                {
                    bool isPaid = (bool)e.Value;
                    e.Value = isPaid ? "Đã Thanh Toán" : "Chưa Thanh Toán";
                }
            };

            cbo_KiemTraThanhToan.DataBindings.Add(binding);
            numUD_SoLuong.DataBindings.Add("Text", pDT, "SOLUONG");
        }
        void load_ChiTietDonHang()
        {
            dgv_ChiTietDonHang.DataSource = db.getDataTable("SELECT * FROM CHITIETDONHANG");
            dgv_ChiTietDonHang.DataSource = ds.Tables[0];
            dataBingDing(ds.Tables[0]);
            
            
        }
        void load_DonHang()
        {
            ConnectDB_Hao connect = new ConnectDB_Hao();
            string query = @"SELECT * FROM DONHANG";
            DataTable dt = connect.getDataTable(query);

            cbo_DonHang.DataSource = dt;
            cbo_DonHang.DisplayMember = "MADONHANG";
            cbo_DonHang.ValueMember = "MADONHANG";
        }
        void load_SanPham()
        {
            ConnectDB_Hao connect = new ConnectDB_Hao();
            string query = @"SELECT * FROM SANPHAM";
            DataTable dt = connect.getDataTable(query);

            cbo_SanPham.DataSource = dt;
            cbo_SanPham.DisplayMember = "MASANPHAM";
            cbo_SanPham.ValueMember = "MASANPHAM";
        }
        void load_KiemTraThanhToan()
        {
            string[] kiemTraThanhToans = { "Đã Thanh Toán", "Chưa Thanh Toán" };
            foreach (var item in kiemTraThanhToans)
            {
                cbo_KiemTraThanhToan.Items.Add(item);
            }
        }
        private void ChiTietDonHang_Load(object sender, EventArgs e)
        {
            load_ChiTietDonHang();
            load_DonHang();
            load_SanPham();
            load_KiemTraThanhToan();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int kiemTraTrangThai = 0;
            if (Convert.ToInt32(numUD_SoLuong.Value.ToString()) > 0)
            {
                ConnectDB_Hao db = new ConnectDB_Hao();
                if (cbo_KiemTraThanhToan.SelectedItem.ToString() == "Đã Thanh Toán")
                {
                    kiemTraTrangThai = 1;
                    if (db.insertChiTietDonHang(txt_MaChiTietDonHang.Text, cbo_DonHang.SelectedValue.ToString(), cbo_SanPham.SelectedValue.ToString(), Convert.ToInt32(numUD_SoLuong.Value.ToString()), kiemTraTrangThai))
                    {
                        load_ChiTietDonHang();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công");
                    }
                }
                else
                {
                    kiemTraTrangThai = 0;
                    if (db.insertChiTietDonHang(txt_MaChiTietDonHang.Text, cbo_DonHang.SelectedValue.ToString(), cbo_SanPham.SelectedValue.ToString(), Convert.ToInt32(numUD_SoLuong.ToString()), kiemTraTrangThai))
                    {
                        load_ChiTietDonHang();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Số Lượng Phải > 0 !!!");
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ConnectDB_Hao db = new ConnectDB_Hao();
            if (db.deleteChiTietDonHang(txt_MaChiTietDonHang.Text))
            {
                MessageBox.Show("Xóa Thành Công");
                load_ChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int kiemTraTrangThai = 0;
            ConnectDB_Hao db = new ConnectDB_Hao();
            if (cbo_KiemTraThanhToan.SelectedItem.ToString() == "Đã Thanh Toán")
            {
                kiemTraTrangThai = 1;
                if (db.updateChiTietDonHang(txt_MaChiTietDonHang.Text, cbo_DonHang.SelectedValue.ToString(), cbo_SanPham.SelectedValue.ToString(), Convert.ToInt32(numUD_SoLuong.ToString()), kiemTraTrangThai))
                {
                    MessageBox.Show("Sửa Thành Công");
                    load_ChiTietDonHang();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công");
                }
            }
            else
            {
                kiemTraTrangThai = 0;
                if (db.updateChiTietDonHang(txt_MaChiTietDonHang.Text, cbo_DonHang.SelectedValue.ToString(), cbo_SanPham.SelectedValue.ToString(), Convert.ToInt32(numUD_SoLuong.ToString()), kiemTraTrangThai))
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LuuCSDL_Click(object sender, EventArgs e)
        {
            dt = (DataTable)dgv_ChiTietDonHang.DataSource;

            string query = "SELECT * FROM CHITIETDONHANG";
            int k = db.updateDataTable(dt, query);
            if (k != 0)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại!");
        }

    }
}
