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
using FormNhanVien.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FormNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            Functions.FillCombo("SELECT MaCa FROM tblCaLam", cboMaca, "MaCa"); 
            cboMaca.SelectedIndex = -1;
            Load_Data();
            resetvalue();
        }
        DataTable tblKT;
        private void Load_Data()
        {
            string sql;
            sql = "SELECT MaNhanVien, TenNhanVien, MaCa, LuongThang, DiaChi, DienThoai, NamSinh, GioiTinh from tblNhanVien; ";
            tblKT = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblKT;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Mã ca";
            dataGridView1.Columns[3].HeaderText = "Lương tháng";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[5].HeaderText = "Điện thoại";
            dataGridView1.Columns[6].HeaderText = "Năm sinh";
            dataGridView1.Columns[7].HeaderText = "Giới tính";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void resetvalue()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            cboMaca.Text = "";
            txtLuongthang.Text = "";
            mskDienthoai.Text = "";
            chkNam.Checked = false;
            txtDiachi.Text = "";
            mskNamsinh.Text = "";
           //txtAnh.Text = "";
            //picAnh.Image = null;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (cboMaca.SelectedIndex == -1) 
            {
                MessageBox.Show("Bạn phải chọn mã ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaca.Focus();
                return;
            }
                if (txtLuongthang.Text.Trim().Length == 0)
            {
                 MessageBox.Show("Bạn phải nhập tền lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtLuongthang.Focus();
                 return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNamsinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNamsinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNamsinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNamsinh.Text = "";
                mskNamsinh.Focus();
                return;
            }
            if (chkNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNhanVien FROM tblNhanVien WHERE MaNhanVien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(MaNhanVien, TenNhanVien, MaCa, NamSinh, GioiTinh, DiaChi, DienThoai, LuongThang) VALUES (N'" + txtManhanvien.Text.Trim() + "', N'" + txtTennhanvien.Text.Trim() + "', N'" + cboMaca.Text.Trim() + "','" + Class.Functions.ConvertDateTime(mskNamsinh.Text) + "',N'" + gt + "', N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "', N'" + txtLuongthang.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_Data();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetvalue();
            txtManhanvien.Enabled = true;
            txtTennhanvien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
                Functions.RunSql(sql);
                Load_Data();
                resetvalue();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (tblKT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txtTennhanvien.Text = dataGridView1.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            cboMaca.Text = dataGridView1.CurrentRow.Cells["MaCa"].Value.ToString();
            txtLuongthang.Text = dataGridView1.CurrentRow.Cells["LuongThang"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                chkNam.Checked = true;
            else
                chkNam.Checked = false;
            txtDiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskNamsinh.Text = dataGridView1.CurrentRow.Cells["NamSinh"].Value.ToString();
            mskDienthoai.Text = dataGridView1.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-FRLG1EC;Initial Catalog=BaiTapLon;Integrated Security=True;Encrypt=False";
            string sql = "";

            SqlConnection yourSqlConnection = new SqlConnection(connectionString);

            // Nếu TextBox tìm kiếm trống và không chọn gì trong ComboBox
            if (string.IsNullOrEmpty(txtTimkiem.Text.Trim()) && cboTimkiem.SelectedIndex == -1)
            {
                // Hiển thị toàn bộ danh sách khách hàng
                sql = "SELECT * FROM tblNhanVien";
            }
            else if (cboTimkiem.SelectedItem.ToString() == "Mã nhân viên")
            {
                // Kiểm tra xem TextBox có trống không
                if (txtTimkiem.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTimkiem.Focus();
                    return;
                }
                // Tạo câu truy vấn SQL tìm kiếm theo mã khách
                sql = "SELECT * FROM tblNhanVien WHERE MaNhanVien=N'" + txtTimkiem.Text.Trim() + "'";
            }
            else if (cboTimkiem.SelectedItem.ToString() == "Tên nhân viên")
            {
                // Nếu TextBox trống, hiển thị toàn bộ danh sách
                if (txtTimkiem.Text.Trim().Length == 0)
                {
                    sql = "SELECT * FROM tblNhanVien";
                }
                else
                {
                    // Tạo câu truy vấn SQL tìm kiếm theo tên khách
                    sql = "SELECT * FROM tblNhanVien WHERE TenNhanVien LIKE N'%" + txtTimkiem.Text.Trim() + "%'";
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
                    MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            {
                string sql, gt;
                if (tblKT.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtManhanvien.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTennhanvien.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTennhanvien.Focus();
                    return;
                }
                if (txtLuongthang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLuongthang.Focus();
                    return;
                }
                if (txtDiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiachi.Focus();
                    return;
                }
                if (cboMaca.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải chọn mã ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaca.Focus();
                    return;
                }
                if (mskNamsinh.Text == "  /  /")
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNamsinh.Focus();
                    return;
                }
                if (!Functions.IsDate(mskNamsinh.Text))
                {
                    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNamsinh.Text = "";
                    mskNamsinh.Focus();
                    return;
                }
                if (chkNam.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";
                sql = "UPDATE tblNhanVien SET  TenNhanVien=N'" + txtTennhanvien.Text.Trim().ToString() + "', DiaChi=N'" + txtDiachi.Text.Trim().ToString() + "',Gioitinh=N'" + gt + "',Namsinh='" + Functions.ConvertDateTime(mskNamsinh.Text) + "' WHERE MaNhanVien=N'" + txtManhanvien.Text + "'";
                Functions.RunSql(sql);
                Load_Data();
                resetvalue();
                btnBoqua.Enabled = false;
            }
        }
    }
}
