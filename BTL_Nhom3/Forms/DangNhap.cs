using BTL.Class;
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

namespace BTL.Forms
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            txtTenDN.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            DangKy a = new DangKy();
            a.Show();
        }
        DataTable TK;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == null)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatKhau.Text == null)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "SELECT Pass FROM tblTaiKhoan WHERE TaiKhoan = N'" + txtTenDN.Text +"'";
            

            DataTable table = Functions.GetDataToTable(sql);

            if (table.Rows.Count > 0)
            {
                string passFromDB = table.Rows[0]["Pass"].ToString();

                // Kiểm tra mật khẩu
                if (passFromDB.Equals(txtMatKhau.Text))
                {
                    txtTenDN.Text = null;
                    txtMatKhau.Text = null;
                    TrangChu a= new TrangChu();
                    a.Show();
                }
                else
                {
                    // Đăng nhập không thành công
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Text = null;
                    txtMatKhau.Focus();
                }
            }
            else
            {
                // Tên đăng nhập không tồn tại
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDN.Text = null;
                txtTenDN.Focus();
            }
        }
        
    }
}
