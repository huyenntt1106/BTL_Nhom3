using Báo_cáo_cửa_hàng.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Báo_cáo_cửa_hàng
{
    public partial class BaoCaoUaThich : Form
    {
        public BaoCaoUaThich()
        {
            InitializeComponent();
        }

        private void BaoCaoUaThich_Load(object sender, EventArgs e)
        {
            btnIn.Enabled = false;
            btnLamMoi.Enabled = false;
            load_data1("select b.TenSach, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a " +
                "inner join tblSachtruyen as b on a.MaSach=b.MaSach group by b.TenSach order by count(a.MaSach) desc ");
            load_data2("select c.TenLoaiSach, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a " +
                "inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblLoaiSach as c on b.MaLoaiSach=c.MaLoaiSach " +
                "group by c.TenLoaiSach order by count(a.MaSach) desc ");
            load_data3("select c.TenTacGia, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a " +
                "inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblTacGia as c on b.MaTacGia=c.MaTacGia " +
                "group by c.TenTacGia order by count(a.MaSach) desc ");
        }
        DataTable tblSachThue, tblTheLoai, tblTacGia;
        private void load_data1(string sql)
        {
            tblSachThue = Functions.GetDataToTable(sql);
            DataGridView1.DataSource = tblSachThue;
            DataGridView1.Columns[0].HeaderText = "Tên sách";
            DataGridView1.Columns[1].HeaderText = "Số lần được thuê";
            DataGridView1.Columns[0].Width = 100;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void load_data2(string sql)
        {
            tblTheLoai = Functions.GetDataToTable(sql);
            DataGridView2.DataSource = tblTheLoai;
            DataGridView2.Columns[0].HeaderText = "Tên thể loại";
            DataGridView2.Columns[1].HeaderText = "Số lần được thuê";
            DataGridView2.Columns[0].Width = 100;
            DataGridView2.Columns[1].Width = 80;
            DataGridView2.AllowUserToAddRows = false;
            DataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void load_data3(string sql)
        {
            tblTacGia = Functions.GetDataToTable(sql);
            DataGridView3.DataSource = tblTacGia;
            DataGridView3.Columns[0].HeaderText = "Tên tác giả";
            DataGridView3.Columns[1].HeaderText = "Số lần sách được thuê";
            DataGridView3.Columns[0].Width = 100;
            DataGridView3.Columns[1].Width = 80;
            DataGridView3.AllowUserToAddRows = false;
            DataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
        }    
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql1, sql2, sql3;

            sql1 = "select b.TenSach, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblThueSach as c on a.MaThue=c.MaThue where 1=1 ";
            sql2 = "select c.TenLoaiSach, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblLoaiSach as c on b.MaLoaiSach=c.MaLoaiSach inner join tblThueSach as d on d.MaThue=a.MaThue where 1=1 ";
            sql3 = "select c.TenTacGia, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblTacGia as c on b.MaTacGia=c.MaTacGia inner join tblThueSach as d on d.MaThue=a.MaThue where 1=1 ";

            if (mskTuNgay.Text == "  /  /" || mskDenNgay.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                mskDenNgay.Text = "";
                mskDenNgay.Focus();
                return;
            }
            sql1 += " and (c.NgayThue between '" + Functions.ConvertDate(mskTuNgay.Text) + "' and '" + Functions.ConvertDate(mskDenNgay.Text) + "') group by b.TenSach order by count(a.MaSach) desc";
            Class.Functions.RunSql(sql1);
            load_data1(sql1);


            sql2 += "and (d.NgayThue between '" + Functions.ConvertDate(mskTuNgay.Text) + "' and '" + Functions.ConvertDate(mskDenNgay.Text) + "') group by c.TenLoaiSach order by count(a.MaSach) desc";
            Class.Functions.RunSql(sql2);
            load_data2(sql2);


            sql3 += "and (d.NgayThue between  '" + Functions.ConvertDate(mskTuNgay.Text) + "' and '" + Functions.ConvertDate(mskDenNgay.Text) + "') group by c.TenTacGia order by count(a.MaSach) desc";
            Class.Functions.RunSql(sql3);
            load_data3(sql3);

            mskDenNgay.Enabled = false;
            mskTuNgay.Enabled = false;
            btnIn.Enabled = true;
            btnLamMoi.Enabled = true;
            btnHienThi.Enabled = false;


            if (tblSachThue.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetValues();
                return;
            }
            if (tblTheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetValues();
                return;
            }
            if (tblTacGia.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetValues();
                return;
            }
            
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
            mskTuNgay.Enabled = true;
            mskDenNgay.Enabled = true;
            btnIn.Enabled = false;
            btnLamMoi.Enabled = true;
            btnHienThi.Enabled = true;
            load_data1("select b.TenSach, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a " +
                "inner join tblSachtruyen as b on a.MaSach=b.MaSach group by b.TenSach order by count(a.MaSach) desc");
            load_data2("select c.TenLoaiSach, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a " +
                "inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblLoaiSach as c on b.MaLoaiSach=c.MaLoaiSach " +
                "group by c.TenLoaiSach order by count(a.MaSach) desc");
            load_data3("select c.TenTacGia, count(a.MaSach) as N'Số lần được thuê' from tblChiTietThueSach as a " +
                "inner join tblSachtruyen as b on a.MaSach=b.MaSach inner join tblTacGia as c on b.MaTacGia=c.MaTacGia " +
                "group by c.TenTacGia order by count(a.MaSach) desc");
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
            exRange.Range["C1:D1:E1:F1"].Font.Size = 14;
            exRange.Range["C1:D1:E1:F1"].Font.Name = "Times new roman";
            exRange.Range["C1:D1:E1:F1"].Font.Bold = true;
            exRange.Range["C1:D1:E1:F1"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C1:D1:E1:F1"].MergeCells = true;
            exRange.Range["C1:D1:E1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C1:D1:E1:F1"].Value = "DANH SÁCH ƯA THÍCH";

            exRange.Range["A3:I3"].Font.Bold = true;
            exRange.Range["A3:I3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C3:C3"].ColumnWidth = 15;
            exRange.Range["A3:A3"].Value = "STT";
            exRange.Range["B3:B3"].Value = "Tên sách";
            exRange.Range["C3:C3"].Value = "Số lần được thuê";
            for (hang = 0; hang < tblSachThue.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 4] = hang + 1;
                for (cot = 0; cot < tblSachThue.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 4] = tblSachThue.Rows[hang][cot].ToString();
                }
            }
            exRange.Range["F3:F3"].ColumnWidth = 15;
            exRange.Range["E3:E3"].Value = "Tên thể loại";
            exRange.Range["F3:F3"].Value = "Số lần thuê";
            for (hang = 0; hang < tblTheLoai.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 4] = hang + 1;
                for (cot = 0; cot < tblTheLoai.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 5][hang + 4] = tblTheLoai.Rows[hang][cot].ToString();
                }
            }
            exRange.Range["I3:I3"].ColumnWidth = 15;
            exRange.Range["H3:H3"].Value = "Tên tác giả";
            exRange.Range["I3:I3"].Value = "Số lần thuê";
            for (hang = 0; hang < tblTheLoai.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tblTacGia.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 8][hang + 4] = tblTacGia.Rows[hang][cot].ToString();
                }
            }

            exApp.Visible = true;
        }
        private void ResetValues()
        {
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
        }

    }
}
