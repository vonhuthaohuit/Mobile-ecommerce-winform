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
    public partial class ThanhToanDonHang : Form
    {
        DataTable dt;
        ConnectDB_Hao db = new ConnectDB_Hao();
        SqlConnection conStr;
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];
        public ThanhToanDonHang()
        {
            conStr = new SqlConnection(@"Data Source=A204PC31;Initial Catalog=QUAN_LY_CUA_HANG_BAN_DIEN_THOAI;Persist Security Info=True;User ID=SA;Password=123");
            string query = "SELECT * FROM THANHTOANDONHANG";
            da = new SqlDataAdapter(query, conStr);
            ds = new DataSet();
            da.Fill(ds, "THANHTOANDONHANG");
            key[0] = ds.Tables["THANHTOANDONHANG"].Columns[0];
            ds.Tables["THANHTOANDONHANG"].PrimaryKey = key;
            InitializeComponent();
        }

        void dataBingDing(DataTable pDT)
        {
            txt_MaThanhToanDonHang.DataBindings.Clear();
            cbo_DonHang.DataBindings.Clear();

            txt_MaThanhToanDonHang.DataBindings.Add("Text", pDT, "MATHANHTOANDONHANG");
            cbo_DonHang.DataBindings.Add("Text", pDT, "MADONHANG");
        }
        void load_DGVThanhToanDonHang()
        {
            dgv_ThanhToanDonHang.DataSource = db.getDataTable("SELECT * FROM THANHTOANDONHANG");
            dgv_ThanhToanDonHang.DataSource = ds.Tables[0];
            dataBingDing(ds.Tables[0]);
        }
        void load_CboDonHang()
        {
            ConnectDB_Hao connect = new ConnectDB_Hao();
            string query = @"SELECT * FROM THANHTOANDONHANG";
            DataTable dt = connect.getDataTable(query);

            cbo_DonHang.DataSource = dt;
            cbo_DonHang.DisplayMember = "MADONHANG";
            cbo_DonHang.ValueMember = "MADONHANG";
        }
        private void ThanhToanDonHang_Load(object sender, EventArgs e)
        {
            load_CboDonHang();
            load_DGVThanhToanDonHang();
        }
    }
}
