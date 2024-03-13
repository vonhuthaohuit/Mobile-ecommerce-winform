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
    public partial class frmThemTTCN : Form
    {
        ConnectDB_Vuong db = new ConnectDB_Vuong();
        DataTable dt;

        SqlDataAdapter da_Person;
        DataSet ds_Person;
        DataColumn[] key = new DataColumn[1];

        public frmThemTTCN()
        {
            InitializeComponent();
            txt_MaPerson.Focus();

            string query = "SELECT * FROM PERSON";
            da_Person = new SqlDataAdapter(query, db.ConStr);
            ds_Person = new DataSet();

            da_Person.Fill(ds_Person, "PERSON");

            if (ds_Person.Tables.Contains("PERSON"))
            {
                key[0] = ds_Person.Tables["PERSON"].Columns["MAPERSON"];
                ds_Person.Tables["PERSON"].PrimaryKey = key;
            }
            else
            {
                MessageBox.Show("Table 'PERSON' not found in the dataset.");
            }

        }

        void HienThiPerson()
        {
            string query = "SELECT MAPERSON, TEN, SODIENTHOAI, EMAIL, DIACHI, GIOITINH FROM PERSON";
            dt = db.getDataTable(query);
            dataGridView1.DataSource = dt;

            dataGridView1.DataSource = ds_Person.Tables[0];
            Databingding(ds_Person.Tables[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gioiTinh = { "Nam", "Nữ" };
            cbo_GioiTinh.Items.AddRange(gioiTinh);
            cbo_GioiTinh.SelectedIndex = 0;

            HienThiPerson();
        }

        private void Databingding(DataTable pDT)
        {
            txt_MaPerson.DataBindings.Clear();
            txt_Ten.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            txt_DiaChi.DataBindings.Clear();
            cbo_GioiTinh.DataBindings.Clear();

            txt_MaPerson.DataBindings.Add("Text", pDT, "MAPERSON");
            txt_Ten.DataBindings.Add("Text", pDT, "TEN");
            txt_SDT.DataBindings.Add("Text", pDT, "SODIENTHOAI");
            txt_Email.DataBindings.Add("Text", pDT, "EMAIL");
            txt_DiaChi.DataBindings.Add("Text", pDT, "DIACHI");
            cbo_GioiTinh.DataBindings.Add("Text", pDT, "GIOITINH");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (ds_Person != null)
            {
                DataRow dr = ds_Person.Tables["PERSON"].Rows.Find(txt_MaPerson.Text);
                if (dr != null)
                {
                    MessageBox.Show("Mã người dùng đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow newRow = ds_Person.Tables[0].NewRow();
                    newRow["MAPERSON"] = txt_MaPerson.Text;
                    newRow["TEN"] = txt_Ten.Text;
                    newRow["SODIENTHOAI"] = txt_SDT.Text;
                    newRow["EMAIL"] = txt_Email.Text;
                    newRow["DIACHI"] = txt_DiaChi.Text;
                    newRow["GIOITINH"] = cbo_GioiTinh.SelectedItem.ToString();

                    ds_Person.Tables["PERSON"].Rows.Add(newRow);

                    SqlCommandBuilder cb = new SqlCommandBuilder(da_Person);

                    da_Person.Update(ds_Person, "PERSON");

                    HienThiPerson();
                    MessageBox.Show("Đã thêm thông tin cá nhân mới thành công.");
                }
            }
            cbo_GioiTinh.SelectedIndex = 0;
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaPerson.Text))
            {
                MessageBox.Show("Vui lòng nhập mã người dùng để xóa.");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin người này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(db.ConStr))
                {
                    connection.Open();
                    string deleteCommandText = "DELETE FROM PERSON WHERE MAPERSON = @MaPerson";
                    SqlCommand deleteCommand = new SqlCommand(deleteCommandText, connection);
                    deleteCommand.Parameters.AddWithValue("@MaPerson", txt_MaPerson.Text);

                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            HienThiPerson();
                            MessageBox.Show("Xóa thông tin người dùng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hãy xóa mã người dùng ở bên bảng nhân viên hoặc khách hàng trước!! \nHãy thử lại!! \nChi tiết lỗi: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            frmThemNV f = new frmThemNV();
            f.Show();
            this.Hide();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH f = new frmThemKH();
            f.Show();
            this.Hide();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(db.ConStr))
            {
                connection.Open();

                string updateCommandText = "UPDATE PERSON SET TEN = @Ten, SODIENTHOAI = @SDT, EMAIL = @Email, DIACHI = @DiaChi, GIOITINH = @GioiTinh WHERE MAPERSON = @MaPerson";
                SqlCommand updateCommand = new SqlCommand(updateCommandText, connection);
                updateCommand.Parameters.AddWithValue("@MaPerson", txt_MaPerson.Text);
                updateCommand.Parameters.AddWithValue("@Ten", txt_Ten.Text);
                updateCommand.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                updateCommand.Parameters.AddWithValue("@Email", txt_Email.Text);
                updateCommand.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                updateCommand.Parameters.AddWithValue("@GioiTinh", cbo_GioiTinh.SelectedItem.ToString());

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        HienThiPerson();
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

        private void btn_QuanLyTK_Click(object sender, EventArgs e)
        {
            frmQLTK f = new frmQLTK();
            f.Show();
            this.Hide();
        }

    }
}
