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
using thuetruyen.Class;

namespace thuetruyen
{
    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();
        }
        DataTable tblHDT;


        private void timkiem_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ResetValues();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
          txtMaThue.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string sql;
            if ((txtMaThue.Text == "") && (mskNgayThue.Text == "  /  /") &&
               (txtMaNhanVien.Text == "") && (txtMaKhachHang.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm theo yêu cầu","Yêu cầu",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblThueSach WHERE 1=1";
            if (txtMaThue.Text != "")
                sql = sql + " AND MaThue Like N'%" + txtMaThue.Text + "%'";
            if (mskNgayThue.Text != "  /  /")
                sql = sql + " AND NgayThue like N'"+mskNgayThue.Text+ "'";
            if (txtMaNhanVien.Text != "")
                sql = sql + " AND MaNhanVien Like N'%" + txtMaNhanVien.Text + "%'";
            if (txtMaKhachHang.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txtMaKhachHang.Text + "%'";
            tblHDT = Functions.GetDataToTable(sql);
            if (tblHDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDT.Rows.Count + " bản ghi thỏa mãn điều kiện!!!",
"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            datagridTim.DataSource = tblHDT;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            datagridTim.Columns[0].HeaderText = "Mã Thuê";
            datagridTim.Columns[1].HeaderText = "Mã Khách Hàng";
            datagridTim.Columns[2].HeaderText = "Mã Nhân Viên";
            datagridTim.Columns[3].HeaderText = "Ngày Thuê";
            datagridTim.Columns[4].HeaderText = "Tiền Đặt Cọc";
            datagridTim.AllowUserToAddRows= false;
            datagridTim.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            datagridTim.DataSource = null;

        }
        private void datagridTim_DoubleClick(object sender, EventArgs e)
        {
            string mathue;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mathue = datagridTim.CurrentRow.Cells["MaThue"].Value.ToString();
                frmHoaDonThue frm = new frmHoaDonThue(); 
                frm.txtMaThue.Text = mathue;   
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)  
                Application.Exit();
        }
    }

 }
