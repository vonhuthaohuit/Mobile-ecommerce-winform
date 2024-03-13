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
    public partial class frmThemNV : Form
    {
        ConnectDB_Vuong db = new ConnectDB_Vuong();
        DataTable dt;

        SqlDataAdapter da_nhanvien;
        DataSet ds_nhanvien;

        public frmThemNV()
        {
            InitializeComponent();

            string query = "Select * from NHANVIEN";
            da_nhanvien = new SqlDataAdapter(query, db.ConStr);
            ds_nhanvien = new DataSet();
            da_nhanvien.Fill(ds_nhanvien, "NHANVIEN");
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            LoadCboChonMaPerson();
            HienThiDanhSachNhanVien();

            dataGridView1.CellClick += dataGridView1_CellClick;
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

        private void HienThiDanhSachNhanVien()
        {
            string query = "SELECT NHANVIEN.MANHANVIEN, PERSON.MAPERSON, PERSON.TEN, NHANVIEN.CHUCVU, PERSON.GIOITINH, PERSON.SODIENTHOAI, PERSON.DIACHI, PERSON.EMAIL " +
            "FROM NHANVIEN " +
            "INNER JOIN PERSON ON NHANVIEN.MAPERSON = PERSON.MAPERSON";


            SqlDataAdapter da = new SqlDataAdapter(query, db.ConStr);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            HienThiThongTinNhanVien(0);
        }

        private void HienThiThongTinNhanVien(int rowIndex)
        {

            if (dt != null && dt.Rows.Count > 0 && rowIndex >= 0 && rowIndex < dt.Rows.Count)
            {
                // Tiếp tục truy cập và hiển thị thông tin
                DataRow row = dt.Rows[rowIndex];
                txt_MaNV.Text = row["MANHANVIEN"].ToString();
                cbo_ChonMaPerson.Text = row["MAPERSON"].ToString();
                txt_ChucVu.Text = row["CHUCVU"].ToString();
                // Các thông tin khác tương tự...
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(db.ConStr))
            {
                conn.Open();
                string selectedMaPerson = cbo_ChonMaPerson.SelectedItem.ToString();

                SqlCommand nhanVienCmd = new SqlCommand("INSERT INTO NHANVIEN (MANHANVIEN, MAPERSON, CHUCVU) " +
                    "VALUES (@MaNV, @MaPerson, @ChucVu);", conn);
                nhanVienCmd.Parameters.AddWithValue("@MaNV", txt_MaNV.Text);
                nhanVienCmd.Parameters.AddWithValue("@MaPerson", selectedMaPerson);
                nhanVienCmd.Parameters.AddWithValue("@ChucVu", txt_ChucVu.Text);
                nhanVienCmd.ExecuteNonQuery();

                conn.Close();

                HienThiDanhSachNhanVien();
                MessageBox.Show("Thêm nhân viên mới thành công!");
            }
            txt_MaNV.Clear();
            cbo_ChonMaPerson.SelectedIndex = 0;
            txt_ChucVu.Clear();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            frmThemTTCN f = new frmThemTTCN();
            f.Show();
            this.Hide();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(db.ConStr))
                {
                    connection.Open();
                    string deleteCommandText = "DELETE FROM NHANVIEN WHERE MANHANVIEN = @MaNV";
                    SqlCommand deleteCommand = new SqlCommand(deleteCommandText, connection);
                    deleteCommand.Parameters.AddWithValue("@MaNV", txt_MaNV.Text);

                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            HienThiDanhSachNhanVien();
                            MessageBox.Show("Xóa nhân viên thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                    }
                }
            }
            txt_MaNV.Clear();
            cbo_ChonMaPerson.SelectedIndex = 0;
            txt_ChucVu.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MaNV.Text = row.Cells["MANHANVIEN"].Value.ToString();
                cbo_ChonMaPerson.Text = row.Cells["MAPERSON"].Value.ToString();
                txt_ChucVu.Text = row.Cells["CHUCVU"].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(db.ConStr))
            {
                connection.Open();

                string updateCommandText = "UPDATE NHANVIEN SET MAPERSON = @MaPerson, CHUCVU = @ChucVu WHERE MANHANVIEN = @MaNV";
                SqlCommand updateCommand = new SqlCommand(updateCommandText, connection);
                updateCommand.Parameters.AddWithValue("@MaNV", txt_MaNV.Text);
                updateCommand.Parameters.AddWithValue("@MaPerson", cbo_ChonMaPerson.SelectedItem.ToString());
                updateCommand.Parameters.AddWithValue("@ChucVu", txt_ChucVu.Text);

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        HienThiDanhSachNhanVien();
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
