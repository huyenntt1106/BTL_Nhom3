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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
        }
        private void hóaĐơnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach a = new frmTraSach();
            a.Show();
        }
        private void sáchTruyệnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSachTruyen a = new frmSachTruyen();
            a.Show();
            
        }
        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang a = new frmKhachHang();
            a.Show();
        }
        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien a = new frmNhanVien();
            a.Show();
        }
        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThu a=new frmBaoCaoDoanhThu();
            a.Show();
        }

        private void báoCáoưuthichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoUaThich b = new frmBaoCaoUaThich();
            b.Show();
        }
        private void báoCáoThuêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoThueSach a= new frmBaoCaoThueSach();
            a.Show();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void hóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThueSach a=new frmThueSach();
            a.Show();
        }
        private void tìmHóaĐơnThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemThue a = new frmTimKiemThue();
            a.Show();
        }
    }
}
