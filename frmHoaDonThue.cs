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
using COMExecl = Microsoft.Office.Interop.Excel;
using thuetruyen.Class;
using System.Diagnostics.Eventing.Reader;

namespace thuetruyen
{
    public partial class frmHoaDonThue : Form
    {
        DataTable tblCTTT;
        public frmHoaDonThue()
        {
            InitializeComponent();
        }

        private void frmHoaDonThue_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoaHoaDon.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaThue.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            mskNgaySinh.ReadOnly = true;
            txtGioiTinh.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            txtDonGiaThue.ReadOnly = true;
            txtTenTinhTrang.ReadOnly = true;
            txtDaTra.ReadOnly = true;
            // txtTongTien.ReadOnly=true;
            // txtTongTien.Text = "";
            Class.Functions.FillCombo("select MaKhach,TenKhach from tblKhachHang", cboMaKH, "MaKhach", "TenKhach");
            cboMaKH.SelectedIndex = -1;
            Class.Functions.FillCombo("select MaNhanVien,TenNhanVien from tblNhanVien", cboMaNV, "MaNhanVien", "TenNhanVien");
            cboMaNV.SelectedIndex = -1;
            Class.Functions.FillCombo("select MaSach,TenSach from tblSachTruyen", cboMaSach, "MaSach", "TenSach");
            cboMaSach.SelectedIndex = -1;
            Class.Functions.FillCombo("select MaTinhTrang,TenTinhTrang from tblTinhTrang", cboMaTinhTrang, "MaTinhTrang", "TenTinhTrang");
            cboMaTinhTrang.SelectedIndex = -1;
            Class.Functions.FillCombo("select MaThue from tblChiTietThueSach", cboMaThue, "MaThue", "MaThue");
            cboMaThue.SelectedIndex = -1;
            if (txtMaThue.Text != "")
            {
                Load_thongtinHD();
                btnXoaHoaDon.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            load_datagridviewchitiet();
        }
        private void load_datagridviewchitiet()
        {
            string sql;
            sql = "select a.MaSach,b.TenSach,a.MaTinhTrang,b.DonGiaThue,a.DaTra from tblChiTietThueSach as a,tblSachTruyen as b where a.MaThue=N'" + txtMaThue.Text + "' and a.MaSach=b.MaSach";
            tblCTTT = Class.Functions.GetDataToTable(sql);
            datagridThue.DataSource = tblCTTT;
            datagridThue.Columns[0].HeaderText = "Mã sách";
            datagridThue.Columns[1].HeaderText = "Tên sách";
            datagridThue.Columns[2].HeaderText = "Mã Tình Trạng";
            datagridThue.Columns[3].HeaderText = "Đơn Giá Thuê";
            datagridThue.Columns[4].HeaderText = "Đã Trả";
            datagridThue.AllowUserToAddRows = false;
            datagridThue.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_thongtinHD()
        {
            string str;
            str = "Select NgayThue from tblThueSach where MaThue=N'" + txtMaThue.Text + "'";
            mskNgayThue.Text = Class.Functions.ConvertDateTime(Functions.GetFieldValues(str));
            str = "select MaNhanVien from tblThueSach where MaThue=N'" + txtMaThue.Text + "'";
            cboMaNV.Text = Class.Functions.GetFieldValues(str);
            str = "select MaKhach from tblThueSach where MaThue=N'" + txtMaThue.Text + "'";
            cboMaKH.Text = Class.Functions.GetFieldValues(str);
            str = "select TienDatCoc from tblThueSach where MaThue=N'" + txtMaThue.Text + "'";
            txtTienCoc.Text = Functions.GetFieldValues(str);
            txtDaTra.Text = "0";
            //  str = "Select TongTien from tblThueSach where MaThue=N'" + txtMaThue.Text + "'";
            //   txtTongTien.Text=Class.Functions.GetFieldValues(str);
            //  lblTongTienChu.Text="Bằng chữ: "+Class.Functions.ChuyenSoSangChu(txtTongTien.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoaHoaDon.Enabled = false;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaThue.Text = Class.Functions.CreateKey("HDT");
            load_datagridviewchitiet();

        }
        private void ResetValues()
        {
            txtMaThue.Text = "";
            mskNgayThue.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            txtTienCoc.Text = "";
            //    txtTongTien.Text = "0";
            //   lblTongTienChu.Text = "Bằng chữ: ";
            cboMaSach.Text = "";
            cboMaTinhTrang.Text = "";
            //  txtThanhTien.Text = "";
            txtDaTra.Text = "0";
            //  txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            float sl, SLcon;
            sql = "Select MaThue from tblThueSach where MaThue=N'" + txtMaThue.Text + "'";
            if (!Class.Functions.CheckKey(sql))
            {

                if (cboMaNV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaNV.Focus(); return;
                }
                if (cboMaKH.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaKH.Focus(); return;
                }
                if (txtTienCoc.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tiền đặt cọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTienCoc.Focus(); return;
                }
                sql = "insert into tblThueSach(MaThue,NgayThue,MaNhanVien,MaKhach,TienDatCoc) values(N'" + txtMaThue.Text + "','" + Class.Functions.ConvertDateTime(mskNgayThue.Text) + "',N'" + cboMaNV.SelectedValue + "',N'" + cboMaKH.SelectedValue + "'," + txtTienCoc.Text + ")";
                Class.Functions.RunSql(sql);
            }
            if (cboMaSach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSach.Focus();
                return;
            }
            if (cboMaTinhTrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã tình trạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTinhTrang.Focus(); return;
            }
            /* if(txtThanhTien.Text=="")
             {
                 MessageBox.Show("Bạn phải nhập tình trạng đã trả","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtThanhTien .Focus(); return;
             } */
            /*  if(txtDaTra.Text=="")
              {
                  MessageBox.Show("Bạn phải nhập số lượng sách khách hàng thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  txtDaTra .Focus(); return;
              }*/
            sql = "Select MaSach from tblChiTietThueSach where MaSach=N'" + cboMaSach.SelectedValue + "' and MaThue=N'" + txtMaThue.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã có hãy nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalueSach();
                cboMaSach.Focus(); return;

            }
            sl = Convert.ToSingle(Class.Functions.GetFieldValues("Select SoLuong from tblSachTruyen where MaSach=N'" + cboMaSach.SelectedValue + "'"));
            if (1 > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SLcon = sl - 1;
            sql = "Update tblSachTruyen set SoLuong=" + SLcon + "where MaSach=N'" + cboMaSach.SelectedValue + "'";
            Functions.RunSql(sql);
            sql = "Insert into tblChiTietThueSach(MaThue,MaSach,MaTinhTrang,DaTra) values(N'" + txtMaThue.Text + "',N'" + cboMaSach.SelectedValue + "',N'" + cboMaTinhTrang.SelectedValue + "',N'" + txtDaTra.Text + "')";
            Functions.RunSql(sql);
            load_datagridviewchitiet();
            /*tong = Convert.ToSingle(Functions.GetFieldValues("select TongTien from tblThueSach where MaThue=N'" + txtMaThue.Text + "'"));
            Tongmoi=tong+Convert.ToSingle(txtThanhTien.Text);
            sql = "Update tblThueSach set TongTien=" + Tongmoi + "Where MaThue=N'" + txtMaThue.Text + "'";
            Functions.RunSql(sql);
            txtTongTien.Text=Tongmoi.ToString();
            lblTongTienChu.Text = "Bằng chữ: "+Functions.ChuyenSoSangChu(Tongmoi.ToString());*/
            resetvalueSach();
            btnXoaHoaDon.Enabled = true;
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
        }
        private void resetvalueSach()
        {
            cboMaSach.Text = "";
            cboMaTinhTrang.Text = "";
            txtDaTra.Text = "0";
            //  txtThanhTien.Text = "";

        }
        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
            {
                txtTenNV.Text = "";
            }
            str = "select TenNhanVien from tblNhanVien where MaNhanVien=N'" + cboMaNV.SelectedValue + "'";
            txtTenNV.Text = Class.Functions.GetFieldValues(str);

        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtGioiTinh.Text = "";
                mskNgaySinh.Text = "  /  /";
                txtDiaChi.Text = "";
            }
            str = "Select TenKhach from tblKhachHang where MaKhach=N'" + cboMaKH.SelectedValue + "'";
            txtTenKH.Text = Class.Functions.GetFieldValues(str);
            str = "Select GioiTinh from tblKhachHang where MaKhach=N'" + cboMaKH.SelectedValue + "'";
            txtGioiTinh.Text = Class.Functions.GetFieldValues(str);
            str = "select NgaySinh from tblKhachHang where MaKhach=N'" + cboMaKH.SelectedValue + "'";
            mskNgaySinh.Text = Class.Functions.GetFieldValues(str);
            str = "select DiaChi from tblKhachHang where MaKhach=N'" + cboMaKH.SelectedValue + "'";
            txtDiaChi.Text = Class.Functions.GetFieldValues(str);
        }

        private void cboMaSach_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSach.Text == "")
            {
                txtTenSach.Text = "";
                txtDonGiaThue.Text = "";
            }
            str = "Select TenSach from tblSachTruyen where MaSach=N'" + cboMaSach.SelectedValue + "'";
            txtTenSach.Text = Class.Functions.GetFieldValues(str);
            str = "Select DonGiaThue from tblSachTruyen where MaSach=N'" + cboMaSach.SelectedValue + "'";
            txtDonGiaThue.Text = Class.Functions.GetFieldValues(str);
        }

        private void cboMaTinhTrang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaTinhTrang.Text == "")
            {
                txtTenTinhTrang.Text = "";
            }
            str = "select TenTinhTrang from tblTinhTrang where MaTinhTrang=N'" + cboMaTinhTrang.SelectedValue + "'";
            txtTenTinhTrang.Text = Class.Functions.GetFieldValues(str);

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cboMaThue.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaThue.Focus();
                return;
            }
            txtMaThue.Text = cboMaThue.Text;
            Load_thongtinHD();
            load_datagridviewchitiet();
            btnXoaHoaDon.Enabled = true;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = true;
            cboMaThue.SelectedIndex = -1;
        }

        private void cboMaThue_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("select MaThue from tblThueSach ", cboMaThue, "MaThue", "MaThue");
            cboMaThue.SelectedIndex = -1;
        }

        private void frmHoaDonThue_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btnĐóng_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn đóng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            COMExecl.Application exApp = new COMExecl.Application();
            COMExecl.Workbook exBook;
            COMExecl.Worksheet exSheet;
            COMExecl.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinSach;
            exBook = exApp.Workbooks.Add(COMExecl.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Bookstore BAV";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc-Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Hotline:0233222299";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN THUÊ";
            sql = "SELECT a.MaThue,a.NgayThue,a.TienDatCoc,b.TenNhanVien,c.TenKhach,c.NgaySinh,c.DiaChi from tblThueSach a ,tblNhanVien b,tblKhachHang c where a.MaThue=N'" + txtMaThue.Text + "'and c.MaKhach=a.MaKhach and a.MaNhanVien=b.MaNhanVien";
            tblThongtinHD = Class.Functions.GetDataToTable(sql);
            exRange.Range["B6:C10"].Font.Size = 12;
            exRange.Range["B6:C6"].Value = "Mã hóa đơn thuê:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B8:B8"].Value = "Ngày sinh:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][5].ToString();
            exRange.Range["B9:B9"].Value = "Địa chỉ:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][6].ToString();
            exRange.Range["B10:B10"].Value = "Tiền đặt cọc";
            exRange.Range["C10:C10"].MergeCells = true;
            exRange.Range["C10:C10"].Value = tblThongtinHD.Rows[0][2].ToString();
            sql = "SELECT b.TenSach, b.DonGiaThue, c.TenTinhTrang from tblChiTietThueSach AS a , tblSachTruyen AS b,tblTinhTrang as c WHERE a.MaThue = N'" +
                  txtMaThue.Text + "' AND a.MaSach = b.MaSach and a.MaTinhTrang=c.MaTinhTrang";
            tblThongtinSach = Functions.GetDataToTable(sql);
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sách";
            exRange.Range["C11:C11"].Value = "Đơn giá thuê";
            exRange.Range["D11:D11"].Value = "Tình trạng";
            //   exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinSach.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinSach.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinSach.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinSach.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange = exSheet.Cells[4][hang + 17]; // ô D1
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0]["NgayThue"]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên lập hóa đơn";
            exRange.Range["A5:C5"].MergeCells = true;
            exRange.Range["A5:C5"].Font.Italic = true;
            exRange.Range["A5:C5"].HorizontalAlignment = COMExecl.XlHAlign.xlHAlignCenter;
            exRange.Range["A5:C5"].Value = tblThongtinHD.Rows[0]["TenNhanVien"];
            exSheet.Name = "Hóa đơn thuê";
            exApp.Visible = true;
        }

        private void datagridThue_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double SoLuongxoa, sl, slcon;
            if (tblCTTT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng sach
                MaHangxoa = datagridThue.CurrentRow.Cells["MaSach"].Value.ToString();
                SoLuongxoa = 1;
                sql = "DELETE tblChiTietThueSach WHERE MaThue=N'" + txtMaThue.Text + "' AND MaSach = N'" + MaHangxoa + "'";
                Functions.RunSql(sql);
                // Cập nhật lại số lượng cho sach
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSachTruyen WHERE MaSach = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tblSachTruyen SET SoLuong =" + slcon + " WHERE MaSach= N'" + MaHangxoa + "'";
                Functions.RunSql(sql);
                load_datagridviewchitiet();
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaSach FROM tblChiTietThueSach WHERE MaThue = N'" + txtMaThue.Text + "'";
                DataTable tblSach = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblSach.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSachTruyen WHERE MaSach = N'" + tblSach.Rows[hang][0].ToString() + "'"));
                    slxoa = 1;
                    slcon = sl + slxoa;
                    sql = "UPDATE tblSachTruyen SET SoLuong =" + slcon + " WHERE MaSach= N'" + tblSach.Rows[hang][0].ToString() + "'";
                    Functions.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChiTietThueSach WHERE MaThue=N'" + txtMaThue.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE tblThueSach WHERE MaThue=N'" + txtMaThue.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                load_datagridviewchitiet();
                btnXoaHoaDon.Enabled = false;
                btnInHoaDon.Enabled = false;
            }
        }
    }

}