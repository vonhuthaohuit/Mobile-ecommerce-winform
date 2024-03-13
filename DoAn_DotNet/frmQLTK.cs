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
    public partial class frmQLTK : Form
    {
        ConnectDB_Vuong db = new ConnectDB_Vuong();
        DataTable dt;

        SqlDataAdapter da_TaiKhoan;
        DataSet ds_TaiKhoan;
        DataColumn[] key = new DataColumn[1];
        public frmQLTK()
        {
            InitializeComponent();
            string query = "SELECT TENTAIKHOAN, MATKHAU FROM TAIKHOAN";
            da_TaiKhoan = new SqlDataAdapter(query, db.ConStr);
            ds_TaiKhoan = new DataSet();
            da_TaiKhoan.Fill(ds_TaiKhoan, "TAIKHOAN");

            key[0] = ds_TaiKhoan.Tables["TAIKHOAN"].Columns["TENTAIKHOAN"];
            ds_TaiKhoan.Tables["TAIKHOAN"].PrimaryKey = key;
        }
        void HienThiTK()
        {
            string query = "SELECT * FROM TAIKHOAN";
            dt = db.getDataTable(query);
            dataGridView1.DataSource = dt;
        }

        private void Databingding(DataTable pDT)
        {
            txt_TenTK.DataBindings.Clear();
            txt_MatKhau.DataBindings.Clear();

            txt_TenTK.DataBindings.Add("Text", pDT, "TENTAIKHOAN");
            txt_MatKhau.DataBindings.Add("Text", pDT, "MATKHAU");
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            HienThiTK();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (ds_TaiKhoan != null)
            {
                DataRow dr = ds_TaiKhoan.Tables["TAIKHOAN"].Rows.Find(txt_TenTK.Text);
                if (dr != null)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow newRow = ds_TaiKhoan.Tables[0].NewRow();
                    newRow["TENTAIKHOAN"] = txt_TenTK.Text;
                    newRow["MATKHAU"] = txt_MatKhau.Text;

                    ds_TaiKhoan.Tables["TAIKHOAN"].Rows.Add(newRow);

                    SqlCommandBuilder cb = new SqlCommandBuilder(da_TaiKhoan);

                    da_TaiKhoan.Update(ds_TaiKhoan, "TAIKHOAN");

                    HienThiTK();
                    MessageBox.Show("Đã thêm tài khoản mới thành công.");
                }
            }
            txt_TenTK.Clear();
            txt_MatKhau.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenTK.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(db.ConStr))
                {
                    connection.Open();
                    string deleteCommandText = "DELETE FROM TAIKHOAN WHERE TENTAIKHOAN = @TenTaiKhoan";
                    SqlCommand deleteCommand = new SqlCommand(deleteCommandText, connection);
                    deleteCommand.Parameters.AddWithValue("@TenTaiKhoan", txt_TenTK.Text);

                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            HienThiTK();
                            MessageBox.Show("Xóa tài khoản thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message);
                    }
                }
            }
            txt_TenTK.Clear();
            txt_MatKhau.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng đã nhấn vào một dòng hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_TenTK.Text = row.Cells["TENTAIKHOAN"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MATKHAU"].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenTK.Text) || string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu để sửa.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(db.ConStr))
            {
                connection.Open();

                string updateCommandText = "UPDATE TAIKHOAN SET MATKHAU = @MatKhau WHERE TENTAIKHOAN = @TenTaiKhoan";
                SqlCommand updateCommand = new SqlCommand(updateCommandText, connection);
                updateCommand.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text);
                updateCommand.Parameters.AddWithValue("@TenTaiKhoan", txt_TenTK.Text);

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        HienThiTK();
                        MessageBox.Show("Sửa tài khoản thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản để sửa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa tài khoản: " + ex.Message);
                }
            }

            txt_TenTK.Clear();
            txt_MatKhau.Clear();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            frmThemTTCN f = new frmThemTTCN();
            f.Show();
            this.Hide();
        }


    }
}
