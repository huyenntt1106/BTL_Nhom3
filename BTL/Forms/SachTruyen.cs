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
    public partial class frmSachTruyen : Form
    {
        public frmSachTruyen()
        {
            InitializeComponent();
        }

        private void frmSachTruyen_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
            txtMaSach.Enabled = false;
            Load_DataGridView();
            Class.Functions.FillCombo1("SELECT MaLoaiSach, TenLoaiSach FROM tblLoaiSach", cboMaLoaiSach, "MaLoaiSach", "TenLoaiSach");
            Class.Functions.FillCombo1("SELECT MaLinhVuc, TenLinhVuc FROM tblLinhVuc", cboMaLinhVuc, "MaLinhVuc", "TenLinhVuc");
            Class.Functions.FillCombo1("SELECT MaTacGia, TenTacGia FROM tblTacGia", cboMaTacGia, "MaTacGia", "TenTacGia");
            Class.Functions.FillCombo1("SELECT MaNXB, TenNXB FROM tblNXB", cboMaNhaXuatBan, "MaNXB", "TenNXB");
            Class.Functions.FillCombo1("SELECT MaNgonNgu, TenNgonNgu FROM tblNgonNgu", cboMaNgonNgu, "MaNgonNgu", "TenNgonNgu");
            cboMaLoaiSach.SelectedIndex = -1;
            cboMaLinhVuc.SelectedIndex = -1;
            cboMaTacGia.SelectedIndex = -1;
            cboMaNhaXuatBan.SelectedIndex = -1;
            cboMaNgonNgu.SelectedIndex = -1;
            ResetValues();
        }
        DataTable tblsachtryen;
        private void ResetValues()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboMaLoaiSach.Text = "";
            cboMaLinhVuc.Text = "";
            cboMaTacGia.Text = "";
            cboMaNhaXuatBan.Text = "";
            cboMaNgonNgu.Text = "";
            txtSoTrang.Text = "";
            txtGiaSach.Text = "";
            txtDonGiaThue.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            txtSoTrang.Enabled = true;
            txtDonGiaThue.Enabled = true;
            txtSoLuong.Enabled = true;
            txtAnh.Text = "";
            picAnh.Image = null;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblSachTruyen";
            tblsachtryen = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblsachtryen;
            DataGridView.Columns[0].HeaderText = "Mã Sách";
            DataGridView.Columns[1].HeaderText = "Tên Sách";
            DataGridView.Columns[2].HeaderText = "Mã Loại Sách";
            DataGridView.Columns[3].HeaderText = "Mã Lĩnh Vực";
            DataGridView.Columns[4].HeaderText = "Mã Tác Giả";
            DataGridView.Columns[5].HeaderText = "Mã NXB";
            DataGridView.Columns[6].HeaderText = "Mã Ngôn Ngữ";
            DataGridView.Columns[7].HeaderText = "Số Trang";
            DataGridView.Columns[8].HeaderText = "Giá Sách";
            DataGridView.Columns[9].HeaderText = "Đơn Giá Thuê";
            DataGridView.Columns[10].HeaderText = "Số lượng";
            DataGridView.Columns[11].HeaderText = "Ảnh";
            DataGridView.Columns[12].HeaderText = "Ghi Chú";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_DataGridViewSearch()
        {
            string sql;
            sql = "SELECT * FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            tblsachtryen = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblsachtryen;
            DataGridView.Columns[0].HeaderText = "Mã Sách";
            DataGridView.Columns[1].HeaderText = "Tên Sách";
            DataGridView.Columns[2].HeaderText = "Mã Loại Sách";
            DataGridView.Columns[3].HeaderText = "Mã Lĩnh Vực";
            DataGridView.Columns[4].HeaderText = "Mã Tác Giả";
            DataGridView.Columns[5].HeaderText = "Mã NXB";
            DataGridView.Columns[6].HeaderText = "Mã Ngôn Ngữ";
            DataGridView.Columns[7].HeaderText = "Số Trang";
            DataGridView.Columns[8].HeaderText = "Giá Sách";
            DataGridView.Columns[9].HeaderText = "Đơn Giá Thuê";
            DataGridView.Columns[10].HeaderText = "Số lượng";
            DataGridView.Columns[11].HeaderText = "Ảnh";
            DataGridView.Columns[12].HeaderText = "Ghi Chú";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }
            if (tblsachtryen.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSach.Text = DataGridView.CurrentRow.Cells["MaSach"].Value.ToString();
            txtTenSach.Text = DataGridView.CurrentRow.Cells["TenSach"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
            cboMaLoaiSach.Text = Class.Functions.GetFieldValues("SELECT TenLoaiSach FROM tblLoaiSach WHERE MaLoaiSach = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaLinhVuc"].Value.ToString();
            cboMaLinhVuc.Text = Class.Functions.GetFieldValues("SELECT TenLinhVuc FROM tblLinhVuc WHERE MaLinhVuc = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaTacGia"].Value.ToString();
            cboMaTacGia.Text = Class.Functions.GetFieldValues("SELECT TenTacGia FROM tblTacGia WHERE MaTacGia = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaNXB"].Value.ToString();
            cboMaNhaXuatBan.Text = Class.Functions.GetFieldValues("SELECT TenNXB FROM tblNXB WHERE MaNXB = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaNgonNgu"].Value.ToString();
            cboMaNgonNgu.Text = Class.Functions.GetFieldValues("SELECT TenNgonNgu FROM tblNgonNgu WHERE MaNgonNgu = N'" + ma + "'");
            txtSoTrang.Text = DataGridView.CurrentRow.Cells["SoTrang"].Value.ToString();
            txtGiaSach.Text = DataGridView.CurrentRow.Cells["GiaSach"].Value.ToString();
            txtDonGiaThue.Text = DataGridView.CurrentRow.Cells["DonGiaThue"].Value.ToString();
            txtSoLuong.Text = DataGridView.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtAnh.Text = Class.Functions.GetFieldValues("SELECT Anh FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'");
            //picAnh.Image = Image.FromFile(txtAnh.Text);
            txtGhiChu.Text = Class.Functions.GetFieldValues("SELECT GhiChu FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaSach.Enabled = true;
            txtMaSach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Mã Sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }
            if (cboMaLoaiSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLoaiSach.Focus();
                return;
            }
            if (cboMaLinhVuc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã lĩnh vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLinhVuc.Focus();
                return;
            }
            if (cboMaTacGia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTacGia.Focus();
                return;
            }
            if (cboMaNhaXuatBan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNhaXuatBan.Focus();
                return;
            }
            if (cboMaNgonNgu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ngôn ngữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNgonNgu.Focus();
                return;
            }
            if (txtSoTrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTrang.Focus();
                return;
            }
            if (txtGiaSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSach.Focus();
                return;
            }
            if (txtDonGiaThue.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaThue.Focus();
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            sql = "SELECT MaSach FROM tblSachTruyen WHERE MaSach=N'" + txtMaSach.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                txtMaSach.Text = "";
                return;
            }
            sql = "INSERT INTO tblSachTruyen(MaSach,TenSach,MaLoaiSach,MaLinhVuc,MaTacGia,MaNXB,MaNgonNgu,SoTrang,GiaSach,DonGiaThue,SoLuong,Anh,GhiChu) " + "VALUES(N'" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + cboMaLoaiSach.SelectedValue.ToString() + "',N'" + cboMaLinhVuc.SelectedValue.ToString() + "',N'" + cboMaTacGia.SelectedValue.ToString() + "',N'" + cboMaNhaXuatBan.SelectedValue.ToString() + "',N'" + cboMaNgonNgu.SelectedValue.ToString() + "',N'" + txtSoTrang.Text + "',N'" + txtGiaSach.Text + "',N'" + txtDonGiaThue.Text + "',N'" + txtSoLuong.Text + "',N'" + txtAnh.Text + "',N'" + txtGhiChu.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblsachtryen.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu ở bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }
            if (cboMaLoaiSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLoaiSach.Focus();
                return;
            }
            if (cboMaLinhVuc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã lĩnh vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaLinhVuc.Focus();
                return;
            }
            if (cboMaTacGia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTacGia.Focus();
                return;
            }
            if (cboMaNhaXuatBan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNhaXuatBan.Focus();
                return;
            }
            if (cboMaNgonNgu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ngôn ngữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNgonNgu.Focus();
                return;
            }
            if (txtSoTrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTrang.Focus();
                return;
            }
            if (txtGiaSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSach.Focus();
                return;
            }
            if (txtDonGiaThue.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaThue.Focus();
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGhiChu.Focus();
                return;
            }
            sql = "UPDATE tblSachTruyen SET  TenSach=N'" + txtTenSach.Text + "', MaLoaiSach=N'" + cboMaLoaiSach.SelectedValue.ToString() + "', MaLinhVuc=N'" + cboMaLinhVuc.SelectedValue.ToString() + "', MaTacGia=N'" + cboMaTacGia.SelectedValue.ToString() + "', MaNXB=N'" + cboMaNhaXuatBan.SelectedValue.ToString() + "', MaNgonNgu=N'" + cboMaNgonNgu.SelectedValue.ToString() + "', SoTrang=N'" + txtSoTrang.Text + "', GiaSach=N'" + txtGiaSach.Text + "', DonGiaThue=N'" + txtDonGiaThue.Text + "', SoLuong=N'" + txtSoLuong.Text + "', Anh=N'" + txtAnh.Text + "', GhiChu=N'" + txtGhiChu.Text + "' WHERE MaSach=N'" + txtMaSach.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblsachtryen.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu ở bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblSachTruyen WHERE MaSach=N'" + txtMaSach.Text + "'";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            Load_DataGridView();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSach.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaSach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã sách để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSach.Focus();
                return;
            }
            txtMaSach.Text = cboMaSach.Text;
            Load_Thongtin();
            Load_DataGridViewSearch();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            cboMaSach.SelectedIndex = -1;
        }
        private void Load_Thongtin()
        {
            string str;
            str = "SELECT TenSach FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtTenSach.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT TenLoaiSach FROM tblLoaiSach JOIN tblSachTruyen ON tblLoaiSach.MaLoaiSach=tblSachTruyen.MaLoaiSach  WHERE MaSach = N'" + txtMaSach.Text + "'";
            cboMaLoaiSach.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT TenLinhVuc FROM tblLinhVuc JOIN tblSachTruyen  ON tblLinhVuc.MaLinhVuc=tblSachTruyen.MaLinhVuc   WHERE MaSach = N'" + txtMaSach.Text + "'";
            cboMaLinhVuc.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT TenTacGia FROM tblTacGia JOIN tblSachTruyen ON tblTacGia.MaTacGia=tblSachTruyen.MaTacGia  WHERE MaSach = N'" + txtMaSach.Text + "'";
            cboMaTacGia.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT TenNXB FROM tblNXB JOIN tblSachTruyen ON tblNXB.MaNXB=tblSachTruyen.MaNXB  WHERE MaSach = N'" + txtMaSach.Text + "'";
            cboMaNhaXuatBan.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT TenNgonNgu FROM tblNgonNgu JOIN tblSachTruyen ON tblNgonNgu.MaNgonNgu=tblSachTruyen.MaNgonNgu  WHERE MaSach = N'" + txtMaSach.Text + "'";
            cboMaNgonNgu.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT SoTrang FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtSoTrang.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT GiaSach FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtGiaSach.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT DonGiaThue FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtDonGiaThue.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT SoLuong FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtSoLuong.Text = Class.Functions.GetFieldValues(str);

            str = "SELECT Anh FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtAnh.Text = Class.Functions.GetFieldValues(str);
            

            str = "SELECT GhiChu FROM tblSachTruyen WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtGhiChu.Text = Class.Functions.GetFieldValues(str);
        }

        private void cboMaSach_DropDown(object sender, EventArgs e)
        {
            Class.Functions.FillCombo1("SELECT MaSach FROM tblSachTruyen", cboMaSach, "MaSach", "MaSach");
            cboMaSach.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra trang chủ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
