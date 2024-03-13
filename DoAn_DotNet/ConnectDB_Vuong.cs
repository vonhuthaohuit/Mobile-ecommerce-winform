using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_DotNet
{
    class ConnectDB_Vuong
    {
        private readonly string ConStr = 


        SqlConnection conn;

        public ConnectDB_Vuong()
        {
            conn = new SqlConnection(ConStr);
        }

        public DataTable getDataTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public int updateDataTable(DataTable dt, string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return kq;
        }
    }
}
