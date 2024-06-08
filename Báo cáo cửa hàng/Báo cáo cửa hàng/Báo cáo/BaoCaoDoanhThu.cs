using Báo_cáo_cửa_hàng.Class;
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


namespace Báo_cáo_cửa_hàng.Báo_cáo
{
    public partial class BaoCaoDoanhThu : Form
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            txtDoanhThu.Text = "";
            mskDenNgay.Enabled = false;
            mskTuNgay.Enabled = false;
            mskNgay.Enabled = false;

            Class.Functions.FillCombo("select MaSach, TenSach from tblSachTruyen", cboTenSach, "MaSach", "TenSach");
            cboTenSach.SelectedValue = -1;

            string sql = "select a.NgayTra, c.TenSach, a.TongTien from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra inner join tblSachTruyen as c on c.MaSach=b.MaSach";
            load_data(sql);
        }
        DataTable tblDT;
        private void load_data(string sql)
        {
            tblDT = Class.Functions.GetDataToTable(sql);
            DataGridView1.DataSource = tblDT;
            DataGridView1.Columns[0].HeaderText = "Ngày trả";
            DataGridView1.Columns[1].HeaderText = "Tên sách";
            DataGridView1.Columns[2].HeaderText = "Tổng tiền";
            DataGridView1.Columns[0].Width = 80;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 100;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql="" ;
            string sql1 = "" ;
            double dt;
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetValues();
                return;
            }
            if (cboTenSach.Text == "" && mskNgay.Text == "  /  /" && mskTuNgay.Text == "  /  /" && mskDenNgay.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "select a.NgayTra, c.TenSach, a.TongTien from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra inner join tblSachTruyen as c on c.MaSach=b.MaSach where 1=1 ";
            sql1 = "from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra inner join tblSachTruyen as c on c.MaSach=b.MaSach where 1=1 ";
            if (cboTenSach.SelectedValue != null)
            {
                sql += " and c.MaSach=N'" + cboTenSach.SelectedValue + "'";
                sql1 += " and c.MaSach=N'" + cboTenSach.SelectedValue + "'";
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
                sql += " and a.NgayTra= N'" + Functions.ConvertDate(mskNgay.Text) + "'";
                sql1 += " and a.NgayTra= N'" + Functions.ConvertDate(mskNgay.Text) + "'";
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
                sql += " and (a.NgayTra between '" + Functions.ConvertDate(mskTuNgay.Text) + "' and '" + Functions.ConvertDate(mskDenNgay.Text) + "')";
                sql1 += " and (a.NgayTra between '" + Functions.ConvertDate(mskTuNgay.Text) + "' and '" + Functions.ConvertDate(mskDenNgay.Text) + "')";
            }
            dt = Convert.ToDouble(Functions.GetFieldValues("select sum(a.TongTien) " + sql1));
            txtDoanhThu.Text = dt.ToString();

            load_data(sql);
            cboTenSach.Enabled = false;
            mskDenNgay.Enabled = false;
            mskNgay.Enabled = false;
            mskTuNgay.Enabled = false;
            rdoTheoKhoang.Enabled = false;
            rdoTheoNgay.Enabled = false;
            btnIn.Enabled = true;
            btnLamMoi.Enabled = true;
            btnHienThi.Enabled = false;
        }
        private void ResetValues()
        {
            cboTenSach.Text = "";
            mskNgay.Text = "";
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboTenSach.Text = "";
            txtDoanhThu.Text = "";
            mskTuNgay.Text = "";
            mskDenNgay.Text = "";
            mskNgay.Text = "";
            cboTenSach.Enabled = true;
            btnIn.Enabled = false;
            btnLamMoi.Enabled = true;
            btnHienThi.Enabled = true;
            rdoTheoNgay.Checked = false;
            rdoTheoKhoang.Checked = false;
            rdoTheoNgay.Enabled = true;
            rdoTheoKhoang.Enabled = true;
            string sql = "select a.NgayTra, c.TenSach, a.TongTien from tblTraSach as a " +
                "inner join tblChiTietTraSach as b on a.MaTra=b.MaTra inner join tblSachTruyen as c on c.MaSach=b.MaSach";
            load_data(sql);
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
            exRange.Range["D1:E1:F1:G1"].Value = "BÁO CÁO DOANH THU";

            exRange.Range["A3:I3"].Font.Bold = true;
            exRange.Range["A3:I3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B3:B3"].ColumnWidth = 15;
            exRange.Range["A3:A3"].Value = "Ngày trả";
            exRange.Range["B3:B3"].Value = "Tên sách";
            exRange.Range["C3:C3"].Value = "Tổng tiền";

            exRange.Range["E4:E4"].Value = "Doanh Thu:";
            exRange.Range["F4:F4"].Value = txtDoanhThu.Text;

            for (hang = 0; hang < tblDT.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 4] = hang + 1;
                for (cot = 0; cot < tblDT.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 1][hang + 4] = tblDT.Rows[hang][cot].ToString();
                }
            }
            exApp.Visible = true;

        }
    }
}
