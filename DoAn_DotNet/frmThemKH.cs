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
    public partial class frmThemKH : Form
    {
        ConnectDB_Vuong db = new ConnectDB_Vuong();
        DataTable dt;

        SqlDataAdapter da_khachhang;
        DataSet ds_khachhang;
        public frmThemKH()
        {
            InitializeComponent();

            string query = "SELECT * FROM KHACHHANG";
            da_khachhang = new SqlDataAdapter(query, db.ConStr);
            ds_khachhang = new DataSet();
            da_khachhang.Fill(ds_khachhang, "KHACHHANG");
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            frmThemTTCN f = new frmThemTTCN();
            f.Show();
            this.Close();
        }

        private void LoadCboChonMaPerson()
        {
            using (var conn = new SqlConnection(db.ConStr))
            {
                conn.Open();

                // Xóa các mục cũ khỏi ComboBox
                cbo_ChonMaPerson.Items.Clear();

                // Truy vấn cơ sở dữ liệu để lấy danh sách mã person
                string query = "SELECT MAPERSON FROM PERSON";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string maPerson = reader["MAPERSON"].ToString();
                    cbo_ChonMaPerson.Items.Add(maPerson);
                }

                reader.Close();
                conn.Close();

                cbo_ChonMaPerson.SelectedIndex = 0;
            }
        }

        private void HienThiDanhSachKhachHang()
        {
            string query = "SELECT KHACHHANG.MAKHACHHANG, PERSON.MAPERSON, PERSON.TEN, PERSON.GIOITINH, PERSON.SODIENTHOAI, PERSON.DIACHI, PERSON.EMAIL " +
                "FROM KHACHHANG " +
                "INNER JOIN PERSON ON KHACHHANG.MAPERSON = PERSON.MAPERSON";

            SqlDataAdapter da = new SqlDataAdapter(query, db.ConStr);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            HienThiThongTinKhachHang(0);
        }

        private void HienThiThongTinKhachHang(int rowIndex)
        {

            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                txt_MaKH.Text = row.Cells[0].Value.ToString();
                cbo_ChonMaPerson.Text = row.Cells[1].Value.ToString();
            }
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            LoadCboChonMaPerson();
            HienThiDanhSachKhachHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(db.ConStr))
            {
                conn.Open();
                string selectedMaPerson = cbo_ChonMaPerson.SelectedItem.ToString();

                SqlCommand nhanVienCmd = new SqlCommand("INSERT INTO KHACHHANG (MAKHACHHANG, MAPERSON) " +
                    "VALUES (@MaKH, @MaPerson);", conn);
                nhanVienCmd.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
                nhanVienCmd.Parameters.AddWithValue("@MaPerson", selectedMaPerson);
                nhanVienCmd.ExecuteNonQuery();

                conn.Close();

                HienThiDanhSachKhachHang();
                MessageBox.Show("Thêm khách hàng mới thành công!");
            }
            txt_MaKH.Clear();
            cbo_ChonMaPerson.SelectedIndex = 0;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(db.ConStr))
                {
                    connection.Open();
                    string deleteCommandText = "DELETE FROM KHACHHANG WHERE MAKHACHHANG = @MaKH";
                    SqlCommand deleteCommand = new SqlCommand(deleteCommandText, connection);
                    deleteCommand.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);

                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            HienThiDanhSachKhachHang();
                            MessageBox.Show("Xóa khách hàng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
                    }
                }
            }
            txt_MaKH.Clear();
            cbo_ChonMaPerson.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MaKH.Text = row.Cells["MAKHACHHANG"].Value.ToString();
                cbo_ChonMaPerson.Text = row.Cells["MAPERSON"].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(db.ConStr))
            {
                connection.Open();

                string updateCommandText = "UPDATE KHACHHANG SET MAPERSON = @MaPerson WHERE MAKHACHHANG = @MaKH";
                SqlCommand updateCommand = new SqlCommand(updateCommandText, connection);
                updateCommand.Parameters.AddWithValue("@MaKH", txt_MaKH.Text);
                updateCommand.Parameters.AddWithValue("@MaPerson", cbo_ChonMaPerson.SelectedItem.ToString());

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        HienThiDanhSachKhachHang();
                        MessageBox.Show("Sửa thông tin thành công thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin để sửa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa thông tin: " + ex.Message);
                }
            }
        }


    }
}
