using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FormKhachHang.Class;

namespace FormKhachHang
{
    public partial class Form1 : Form
    {
        private SqlConnection yourSqlConnection;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-FRLG1EC;Initial Catalog=BaiTapLon;Integrated Security=True;Encrypt=False";
            yourSqlConnection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            Load_Data();
            resetvalue();
            
        }
        DataTable tblKT;
        private void Load_Data()
        {
            string sql;
            sql = "SELECT MaKhach, TenKhach, GioiTinh, DiaChi, NgaySinh FROM tblKhachHang";
            tblKT = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblKT;
            dataGridView1.Columns[0].HeaderText = "Mã khách";
            dataGridView1.Columns[1].HeaderText = "Tên khách";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Ngày sinh";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void resetvalue()
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            chkNam.Checked = false;
            txtDiachi.Text = "";
            mskNgaysinh.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
            if (tblKT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            txtMakhach.Text = dataGridView1.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtTenkhach.Text = dataGridView1.CurrentRow.Cells["TenKhach"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                chkNam.Checked = true;
            else
                chkNam.Checked = false;
            txtDiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskNgaysinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetvalue();
            txtMakhach.Enabled = true;
            txtTenkhach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaKhach FROM tblKhachHang WHERE MaKhach=N'" + txtMakhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                txtMakhach.Text = "";
                return;
            }
            sql = "INSERT INTO tblKhachHang (MaKhach, TenKhach, NgaySinh, GioiTinh, DiaChi) VALUES (N'" + txtMakhach.Text.Trim() + "', N'" + txtTenkhach.Text.Trim() + "', '" + Class.Functions.ConvertDateTime(mskNgaysinh.Text) + "', N'" + gt + "', N'" + txtDiachi.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_Data();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                string sql, gt;
                if (tblKT.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMakhach.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenkhach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenkhach.Focus();
                    return;
                }
                if (txtDiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiachi.Focus();
                    return;
                }
                if (mskNgaysinh.Text == "  /  /")
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgaysinh.Focus();
                    return;
                }
                if (!Functions.IsDate(mskNgaysinh.Text))
                {
                    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgaysinh.Text = "";
                    mskNgaysinh.Focus();
                    return;
                }
                if (chkNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";
                sql = "UPDATE tblKhachHang SET  TenKhach=N'" + txtTenkhach.Text.Trim().ToString() + "', DiaChi=N'" + txtDiachi.Text.Trim().ToString() + "',Gioitinh=N'" + gt + "',Ngaysinh='" + Functions.ConvertDateTime(mskNgaysinh.Text) + "' WHERE Makhach=N'" + txtMakhach.Text + "'";
                Functions.RunSql(sql);
                Load_Data();
                resetvalue();
                btnBoqua.Enabled = false;
            }
            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhachHang WHERE Makhach=N'" + txtMakhach.Text + "'";
                Functions.RunSql(sql);
                Load_Data();
                resetvalue() ;  
            }

        }
      


        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            string sql = "";

            // Nếu TextBox tìm kiếm trống và không chọn gì trong ComboBox
            if (string.IsNullOrEmpty(txtTimkiem.Text.Trim()) && cboTimkiem.SelectedIndex == -1)
            {
                // Hiển thị toàn bộ danh sách khách hàng
                sql = "SELECT * FROM tblKhachHang";
            }
            else if (cboTimkiem.SelectedItem.ToString() == "Mã khách")
            {
                // Kiểm tra xem TextBox có trống không
                if (txtTimkiem.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTimkiem.Focus();
                    return;
                }
                // Tạo câu truy vấn SQL tìm kiếm theo mã khách
                sql = "SELECT * FROM tblKhachHang WHERE MaKhach=N'" + txtTimkiem.Text.Trim() + "'";
            }
            else if (cboTimkiem.SelectedItem.ToString() == "Tên khách")
            {
                // Nếu TextBox trống, hiển thị toàn bộ danh sách
                if (txtTimkiem.Text.Trim().Length == 0)
                {
                    sql = "SELECT * FROM tblKhachHang";
                }
                else
                {
                    // Tạo câu truy vấn SQL tìm kiếm theo tên khách
                    sql = "SELECT * FROM tblKhachHang WHERE TenKhach LIKE N'%" + txtTimkiem.Text.Trim() + "%'";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn kiểu tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sử dụng SqlCommand để thực thi câu lệnh SQL
            SqlCommand cmd = new SqlCommand(sql, yourSqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                yourSqlConnection.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = tblKT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                yourSqlConnection.Close();
            }
        }
    }
}


