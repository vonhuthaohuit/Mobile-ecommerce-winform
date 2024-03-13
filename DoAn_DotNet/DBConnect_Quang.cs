using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_DotNet
{
    class DBConnect_Quang
    {

        private readonly string chuoiketnoi = 

        SqlConnection conn;
        public DBConnect_Quang()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public DBConnect_Quang(string chuoikn)
        {
            conn = new SqlConnection(chuoikn);
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public int getNonQuery(string chuoiTruyVan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoiTruyVan, conn);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public int getScalar(string chuoiTruyVan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoiTruyVan, conn);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public DataTable getDaTable(string chuoitruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int upDateDataTable(DataTable dtnew, string chuoitruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dtnew);
            return kq;
        }
    }
}
