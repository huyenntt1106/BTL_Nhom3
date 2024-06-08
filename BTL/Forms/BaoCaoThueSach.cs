using BTL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTL.Forms
{
    public partial class frmBaoCaoThueSach : Form
    {
        public frmBaoCaoThueSach()
        {
            InitializeComponent();
        }

        private void frmBaoCaoThueSach_Load(object sender, EventArgs e)
        {
            mskDenNgay.Enabled = false;
            mskTuNgay.Enabled = false;
            mskNgay.Enabled = false;
            rdoTheoNgay.Visible = true;
            rdoTheoKhoang.Visible = true;
            btnIn.Enabled = false;
            btnLamMoi.Enabled = true;

            Class.Functions.FillCombo1("select MaTra from tblChiTietTraSach", cboMaTra, "MaTra", "MaTra");
            cboMaTra.SelectedValue = -1;
            Class.Functions.FillCombo1("select MaSach, TenSach from tblSachTruyen", cboTenSach, "MaSach", "TenSach");
            cboTenSach.SelectedValue = -1;
            Class.Functions.FillCombo1("select MaKhach, TenKhach from tblKhachHang", cboTenKhach, "MaKhach", "TenKhach");
            cboTenKhach.SelectedValue = -1;
            Class.Functions.FillCombo1("select MaNhanVien, TenNhanVien from tblNhanVien", cboTenNhanVien, "MaNhanVien", "TenNhanVien");
            cboTenNhanVien.SelectedValue = -1;

            string sql = "select a.MaTra, c.MaSach,c.TenSach, c.DonGiaThue,a.NgayTra, e.NgayThue, g.TienPhat, a.TongTien,d.TenNhanVien, f.TenKhach from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra " +
                "inner join tblSachTruyen as c on c.MaSach=b.MaSach " +
                "inner join tblNhanVien as d on d.MaNhanVien=a.MaNhanVien " +
                "inner join tblThueSach as e on a.MaThue= e.MaThue " +
                "inner join tblKhachHang as f on f.MaKhach=e.MaKhach " +
                "inner join tblViPham as g on g.MaViPham=b.MaViPham";
            load_data1(sql);

            string sql1 = "select c.MaKhach, c.TenKhach, count(b.MaSach) from tblThueSach as a inner join tblChiTietThueSach as b on a.MaThue=b.MaThue" +
                " inner join tblKhachHang as c on c.MaKhach=a.MaKhach group by c.MaKhach, c.TenKhach";
            load_data2(sql1);
        }
        DataTable tblBC1, tblBC2;
        private void load_data1(string sql)
        {
            tblBC1 = Class.Functions.GetDataToTable(sql);
            DataGridView1.DataSource = tblBC1;
            DataGridView1.Columns[0].HeaderText = "Mã trả";
            DataGridView1.Columns[1].HeaderText = "Mã sách";
            DataGridView1.Columns[2].HeaderText = "Tên sách";
            DataGridView1.Columns[3].HeaderText = "Đơn giá thuê";
            DataGridView1.Columns[4].HeaderText = "Ngày trả";
            DataGridView1.Columns[5].HeaderText = "Ngày thuê";
            DataGridView1.Columns[6].HeaderText = "Tiền phạt";
            DataGridView1.Columns[7].HeaderText = "Tổng tiền";
            DataGridView1.Columns[8].HeaderText = "Tên nhân viên";
            DataGridView1.Columns[9].HeaderText = "Tên khách";
            DataGridView1.Columns[0].Width = 80;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 100;
            DataGridView1.Columns[3].Width = 80;
            DataGridView1.Columns[4].Width = 100;
            DataGridView1.Columns[5].Width = 100;
            DataGridView1.Columns[6].Width = 100;
            DataGridView1.Columns[7].Width = 100;
            DataGridView1.Columns[8].Width = 100;
            DataGridView1.Columns[9].Width = 100;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql1, sql2;
            if (tblBC1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetValues();
                return;
            }
            if (cboMaTra.Text == "" && cboTenSach.Text == "" && cboTenKhach.Text == "" &&
                cboTenNhanVien.Text == "" && mskNgay.Text == "  /  /" && mskTuNgay.Text == "  /  /" && mskDenNgay.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql1 = "select a.MaTra, c.MaSach,c.TenSach, c.DonGiaThue,a.NgayTra, e.NgayThue, g.TienPhat, a.TongTien,d.TenNhanVien, f.TenKhach from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra " +
                "inner join tblSachTruyen as c on c.MaSach=b.MaSach " +
                "inner join tblNhanVien as d on d.MaNhanVien=a.MaNhanVien " +
                "inner join tblThueSach as e on a.MaThue= e.MaThue " +
                "inner join tblKhachHang as f on f.MaKhach=e.MaKhach " +
                "inner join tblViPham as g on g.MaViPham=b.MaViPham where 1=1";
            sql2 = "from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra " +
                "inner join tblSachTruyen as c on c.MaSach=b.MaSach " +
                "inner join tblNhanVien as d on d.MaNhanVien=a.MaNhanVien " +
                "inner join tblThueSach as e on a.MaThue= e.MaThue " +
                "inner join tblKhachHang as f on f.MaKhach=e.MaKhach " +
                "inner join tblViPham as g on g.MaViPham=b.MaViPham " +
                "inner join tblChiTietThueSach as h on h.MaThue=e.MaThue where 1=1";

            if (cboMaTra.SelectedValue != null)
            {
                sql1 += " and a.MaTra=N'" + cboMaTra.SelectedValue + "'";
                sql2 += " and a.MaTra=N'" + cboMaTra.SelectedValue + "'";
            }
            if (cboTenSach.SelectedValue != null)
            {
                sql1 += " and c.MaSach=N'" + cboTenSach.SelectedValue + "'";
                sql2 += " and c.MaSach=N'" + cboTenSach.SelectedValue + "'";
            }
            if (cboTenNhanVien.SelectedValue != null)
            {
                sql1 += " and d.MaNhanVien =N'" + cboTenNhanVien.SelectedValue + "'";
                sql2 += " and d.MaNhanVien =N'" + cboTenNhanVien.SelectedValue + "'";
            }
            if (cboTenKhach.SelectedValue != null)
            {
                sql1 += " and f.MaKhach =N'" + cboTenKhach.SelectedValue + "'";
                sql2 += " and f.MaKhach =N'" + cboTenKhach.SelectedValue + "'";
            }
            if (mskNgay.Text != "  /  /")
            {
                if (!Functions.IsDate(mskNgay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskNgay.Focus();
                    mskNgay.Text = "";
                    return;
                }
                sql1 += "and a.NgayTra= N'" + Functions.ConvertDateTime(mskNgay.Text) + "'";
                sql2 += "and a.NgayTra= N'" + Functions.ConvertDateTime(mskNgay.Text) + "'";

            }
            if (mskTuNgay.Text != "  /  /")
            {
                if (mskDenNgay.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập đến ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskDenNgay.Focus();
                    return;
                }
            }
            if (mskDenNgay.Text != "  /  /")
            {
                if (mskTuNgay.Text == "  /  /")
                {

                    MessageBox.Show("Hãy nhập từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTuNgay.Focus();
                    return;
                }
            }
            if (mskTuNgay.Text != "  /  /" && mskDenNgay.Text != "  /  /")
            {
                if (!Functions.IsDate(mskTuNgay.Text))
                {
                    MessageBox.Show("Bạn phải nhập lại thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskTuNgay.Text = "";
                    mskTuNgay.Focus();
                    return;
                }
                if (!Functions.IsDate(mskDenNgay.Text))
                {
                    MessageBox.Show("Bạn phải nhập lại thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskDenNgay.Text = "";
                    mskDenNgay.Focus();
                    return;
                }

                if (DateTime.ParseExact(mskTuNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql1 += "and (a.NgayTra between '" + Functions.ConvertDateTime(mskTuNgay.Text) + "' and '" + Functions.ConvertDateTime(mskDenNgay.Text) + "')";
                sql2 += "and (a.NgayTra between '" + Functions.ConvertDateTime(mskTuNgay.Text) + "' and '" + Functions.ConvertDateTime(mskDenNgay.Text) + "')";
            }
            load_data1(sql1);

            load_data2("select f.MaKhach, f.TenKhach, count(h.MaSach) as N'Số sách thuê' " + sql2 + " group by f.MaKhach, f.TenKhach");

            cboMaTra.Enabled = false;
            cboTenSach.Enabled = false;
            cboTenKhach.Enabled = false;
            cboTenNhanVien.Enabled = false;
            mskDenNgay.Enabled = false;
            mskNgay.Enabled = false;
            mskTuNgay.Enabled = false;
            rdoTheoKhoang.Enabled = false;
            rdoTheoNgay.Enabled = false;
            btnIn.Enabled = true;
            btnLamMoi.Enabled = true;
            btnHienThi.Enabled = false;
        }

        private void rdoTheoNgay_Click(object sender, EventArgs e)
        {
            mskNgay.Enabled = true;
            mskTuNgay.Enabled = false;
            mskDenNgay.Enabled = false;
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
        }

        private void rdoTheoKhoang_Click(object sender, EventArgs e)
        {
            mskNgay.Text = "";
            mskTuNgay.Enabled = true;
            mskDenNgay.Enabled = true;
            mskNgay.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaTra.Text = "";
            cboTenSach.Text = "";
            cboTenKhach.Text = "";
            cboTenNhanVien.Text = "";
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
            mskNgay.Text = "";
            cboTenSach.Enabled = true;
            cboTenKhach.Enabled = true;
            cboTenNhanVien.Enabled = true;
            cboMaTra.Enabled = true;
            btnIn.Enabled = false;
            btnLamMoi.Enabled = true;
            btnHienThi.Enabled = true;
            rdoTheoNgay.Checked = false;
            rdoTheoKhoang.Checked = false;
            rdoTheoNgay.Enabled = true;
            rdoTheoKhoang.Enabled = true;
            string sql = "select a.MaTra, c.MaSach,c.TenSach, c.DonGiaThue,a.NgayTra, e.NgayThue, g.TienPhat, a.TongTien,d.TenNhanVien, f.TenKhach from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra " +
                "inner join tblSachTruyen as c on c.MaSach=b.MaSach " +
                "inner join tblNhanVien as d on d.MaNhanVien=a.MaNhanVien " +
                "inner join tblThueSach as e on a.MaThue= e.MaThue " +
                "inner join tblKhachHang as f on f.MaKhach=e.MaKhach " +
                "inner join tblViPham as g on g.MaViPham=b.MaViPham";
            load_data1(sql);

            string sql1 = "select c.MaKhach, c.TenKhach, count(b.MaSach) from tblThueSach as a inner join tblChiTietThueSach as b on a.MaThue=b.MaThue" +
               " inner join tblKhachHang as c on c.MaKhach=a.MaKhach group by c.MaKhach, c.TenKhach";
            load_data2(sql1);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["D1:E1:F1:G1"].Font.Size = 14;
            exRange.Range["D1:E1:F1:G1"].Font.Name = "Times new roman";
            exRange.Range["D1:E1:F1:G1"].Font.Bold = true;
            exRange.Range["D1:E1:F1:G1"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["D1:E1:F1:G1"].MergeCells = true;
            exRange.Range["D1:E1:F1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:E1:F1:G1"].Value = "BÁO CÁO THUÊ SÁCH";

            exRange.Range["A3:I3"].Font.Bold = true;
            exRange.Range["A3:I3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C3:C3"].ColumnWidth = 15;
            exRange.Range["A3:A3"].Value = "STT";
            exRange.Range["B3:B3"].Value = "Mã sách";
            exRange.Range["C3:C3"].Value = "Tên sách";
            exRange.Range["D3:D3"].Value = "Đơn giá thuê";
            exRange.Range["E3:E3"].Value = "Ngày trả";
            exRange.Range["F3:F3"].Value = "Ngày thuê";
            exRange.Range["G3:G3"].Value = "Tiền phạt";
            exRange.Range["H3:H3"].Value = "Tổng tiền";
            exRange.Range["I3:I3"].Value = "Tên nhân viên";
            exRange.Range["K3:K3"].Value = "Tên khách";

            for (hang = 0; hang < tblBC1.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 4] = hang + 1;
                for (cot = 0; cot < tblBC1.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 1][hang + 4] = tblBC1.Rows[hang][cot].ToString();
                }
            }

            exRange.Range["L3:L3"].Value = "Mã khách";
            exRange.Range["M3:M3"].Value = "Tên khách hàng";
            exRange.Range["N3:N3"].Value = "Số lần thuê";
            for (hang = 0; hang < tblBC2.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 4] = hang + 1;
                for (cot = 0; cot < tblBC2.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 12][hang + 4] = tblBC2.Rows[hang][cot].ToString();
                }
            }
            exApp.Visible = true;
        }

        private void load_data2(string sql)
        {
            tblBC2 = Functions.GetDataToTable(sql);
            DataGridView2.DataSource = tblBC2;
            DataGridView2.Columns[0].HeaderText = "Mã khách";
            DataGridView2.Columns[1].HeaderText = "Tên khách";
            DataGridView2.Columns[2].HeaderText = "Số sách thuê";
            DataGridView2.Columns[0].Width = 80;
            DataGridView2.Columns[1].Width = 100;
            DataGridView2.Columns[2].Width = 80;
            DataGridView2.AllowUserToAddRows = false;
            DataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            cboTenSach.Text = "";
            cboTenKhach.Text = "";
            cboTenNhanVien.Text = "";
            mskNgay.Text = "";
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
        }


    }

}
