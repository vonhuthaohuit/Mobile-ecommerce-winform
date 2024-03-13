using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_DotNet
{
    class ConnectDB_Hao
    {
        private readonly string conStr = 

        public SqlConnection con;

        public ConnectDB_Hao()
        {
            con = new SqlConnection(conStr);
        }
        public ConnectDB_Hao(string conStr)
        {
            con = new SqlConnection(conStr);
        }

        public void OpenDB()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void CloseDB()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public int getExecuteNonQuery(string query)
        {
            OpenDB();
            SqlCommand cmd = new SqlCommand(query, con);

            int kq = cmd.ExecuteNonQuery();

            return kq;
        }
        public object getExecuteScalar(string query)
        {
            OpenDB();
            SqlCommand cmd = new SqlCommand(query, con);

            object kq = cmd.ExecuteScalar();

            return kq;
        }
        bool checkMaDonHang(string maDonHang)
        {
            int check = 0;
            ConnectDB_Hao db = new ConnectDB_Hao();

            db.OpenDB();

            string query = "SELECT COUNT(*) FROM DONHANG WHERE MADONHANG = '" + maDonHang + "'";
            check = (int)getExecuteScalar(query);


            db.CloseDB();

            if (check != 0)
                return true;
            return false;
        }
        public bool insertDonHang(string maDonHang, string maKhachHang, string ngayDat, string trangThai)
        {
            if (!checkMaDonHang(maDonHang))
            {
                OpenDB();
                string query = "INSERT INTO DONHANG(MADONHANG, MAKHACHHANG, NGAYDATHANG, TRANGTHAI) VALUES('" + maDonHang + "', '" + maKhachHang + "', '" + ngayDat + "', N'" + trangThai + "')";

                int kq = getExecuteNonQuery(query);


                CloseDB();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteDonHang(string maDonHang)
        {
            if (checkMaDonHang(maDonHang))
            {
                OpenDB();
                string query = "DELETE DONHANG WHERE MADONHANG = '" + maDonHang + "'";

                int kq = getExecuteNonQuery(query);

                CloseDB();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateDonHang(string maDonHang, string maKhachHang, string ngayDat, string trangThai)
        {
            if (checkMaDonHang(maDonHang))
            {
                OpenDB();
                string query = "UPDATE DONHANG SET MADONHANG = '" + maDonHang + "', MAKHACHHANG = '" + maKhachHang + "', NGAYDATHANG = '" + ngayDat + "', TRANGTHAI = N'" + trangThai + "' WHERE MADONHANG = '" + maDonHang + "'";

                int kq = getExecuteNonQuery(query);

                CloseDB();
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getDataTable(string query)
        {
            SqlDataAdapter dataAdap = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            dataAdap.Fill(ds);
            return ds.Tables[0];
        }
        public int updateDataTable(DataTable dt, string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
        bool checkMaChiTietDonHang(string maChiTietDonHang)
        {
            int check = 0;
            ConnectDB_Hao db = new ConnectDB_Hao();

            db.OpenDB();

            string query = "SELECT COUNT(*) FROM CHITIETDONHANG WHERE MACHITIETDONHANG = '" + maChiTietDonHang + "'";
            check = (int)getExecuteScalar(query);


            db.CloseDB();

            if (check != 0)
                return true;
            return false;
        }
        bool checkTonTaiChiTietDonHang(string maChiTietDonHang, string maDonHang, string maSanPham)
        {
            int check = 0;
            ConnectDB_Hao db = new ConnectDB_Hao();

            db.OpenDB();

            string query = "SELECT COUNT(*) FROM CHITIETDONHANG WHERE MACHITIETDONHANG = '"+ maChiTietDonHang +"' AND MADONHANG = '"+ maDonHang +"' AND MASANPHAM ='" + maSanPham + "'";

            check = (int)getExecuteScalar(query);

            db.CloseDB();

            if (check != 0)
                return true;
            return false;
        }
        public bool insertChiTietDonHang(string maChiTietDonHang, string maDonHang, string maSanPham, int soLuong, int kiemTraTrangThai)
        {
           if(!checkTonTaiChiTietDonHang(maChiTietDonHang, maDonHang, maSanPham))
           {
                OpenDB();
                string query = "INSERT INTO CHITIETDONHANG (MACHITIETDONHANG, MADONHANG, MASANPHAM, SOLUONG, KIEMTRATHANHTOAN) VALUES ('" + maChiTietDonHang + "', '" + maDonHang + "', '" + maSanPham + "', " + soLuong + ", " + kiemTraTrangThai + ")";

                int kq = getExecuteNonQuery(query);


                CloseDB();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteChiTietDonHang(string maChiTietDonHang)
        {
            if (checkMaChiTietDonHang(maChiTietDonHang))
            {
                OpenDB();
                string query = "DELETE CHITIETDONHANG WHERE MACHITIETDONHANG = '" + maChiTietDonHang + "'";

                int kq = getExecuteNonQuery(query);

                CloseDB();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateChiTietDonHang(string maChiTietDonHang, string maDonHang, string maSanPham, int soLuong, int kiemTraTrangThai)
        {
            if (checkMaChiTietDonHang(maChiTietDonHang) )
            {
                OpenDB();
                string query = "UPDATE CHITIETDONHANG SET MACHITIETDONHANG = '"+ maChiTietDonHang +"' ,MADONHANG '" + maDonHang +"', MASANPHAM = '" +maSanPham+"',SOLUONG = "+ soLuong +", KIEMTRATRANGTHAI = "+ kiemTraTrangThai+" ";

                int kq = getExecuteNonQuery(query);

                CloseDB();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
