using BTL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                // Kiểm tra tính hợp lệ của dữ liệu
                if (txtEmail.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (txtTenDN.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDN.Focus();
                    return;
                }

                if (txtMatKhau.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    return;
                }

                if (txtMatKhau1.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau1.Focus();
                    return;
                }

                if (txtMatKhau.Text != txtMatKhau1.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau1.Text = "";
                    txtMatKhau1.Focus();
                    return;
                }

                // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                string sqlCheckExist = "SELECT COUNT(*) FROM tblTaiKhoan WHERE TaiKhoan = N'" + txtTenDN.Text + "'";
                int count = Convert.ToInt32(Functions.GetFieldValues(sqlCheckExist));
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDN.Text = "";
                    txtTenDN.Focus();
                    return;
                }

                // Thêm thông tin tài khoản vào database
                string sqlInsert = "INSERT INTO tblTaiKhoan (Email, TaiKhoan, Pass) VALUES " +
                                   "(N'" + txtEmail.Text + "', N'" + txtTenDN.Text + "', N'" + txtMatKhau.Text + "')";
                Functions.RunSql(sqlInsert);
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTenDN.Text = ""; 
                txtEmail.Text="";
                txtMatKhau.Text = "";
                txtMatKhau1.Text = "";
                this.Close();
            }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
