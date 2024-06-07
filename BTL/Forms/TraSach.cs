using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using BTL.Class;
using System.Text.RegularExpressions;

namespace BTL
{
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }
        private void resetvalue()
        {
            txtMaKhach.Text = string.Empty;
            txtMaTra.Text = string.Empty;
            mskNgayThue.Text = string.Empty;
            mskNgayTra.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            cboMaNV.Text = string.Empty;
            checkbox1.Checked = false;
            cboMaViPham.Enabled = false;
            txtTienVP.Text = "";
            txtNgayThue.Text = "";

            txtMaKhach.Enabled = false;
            txtNgayThue.Enabled = false;
            mskNgayThue.Enabled = false;
            txtTienVP.Enabled = false;
            txtTongTien.Enabled = false;
            txtMaTra.Enabled = false;
        }

        DataTable tblTraSach;

        //Load_data2 là cho dgv 3
        private void Load_Data2()
        {
            tblTraSach = new DataTable();
            tblTraSach.Columns.Add("MaSach");
            tblTraSach.Columns.Add("TenSach");
            tblTraSach.Columns.Add("DonGiaThue");
            tblTraSach.Columns.Add("ThanhTien");
            dataGridView3.DataSource = tblTraSach;
            dataGridView3.Columns[0].HeaderText = "Mã sách";
            dataGridView3.Columns[1].HeaderText = "Tên sách";
            dataGridView3.Columns[2].HeaderText = "Đơn giá thuê";
            dataGridView3.Columns[3].HeaderText = "Thành tiền";
            dataGridView3.Columns[0].Width = 100;
            dataGridView3.Columns[1].Width = 150;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[3].Width = 150;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void TraSach_Load(object sender, EventArgs e)
        {
            resetvalue();
            btnThem.Enabled = true;
            //btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThoat.Enabled = true;
            btnTimkiem.Enabled = true;


            Functions.FillCombo("SELECT MaNhanVien FROM tblNhanVien", cboMaNV, "MaNhanVien"); cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaViPham FROM tblViPham", cboMaViPham, "MaViPham"); cboMaViPham.SelectedIndex = -1;
            Load_Data3();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra trang chủ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        DataTable tblThue;
        private void Load_Data1()
        {
            string sql = @"
                SELECT tblThueSach.MaKhach, tblThueSach.NgayThue, tblChiTietThueSach.MaSach, tblSachTruyen.TenSach, tblSachTruyen.DonGiaThue 
                FROM tblThueSach 
                INNER JOIN tblChiTietThueSach ON tblThueSach.MaThue = tblChiTietThueSach.MaThue 
                INNER JOIN tblSachTruyen ON tblChiTietThueSach.MaSach = tblSachTruyen.MaSach 
                WHERE tblChiTietThueSach.DaTra = 0 AND tblThueSach.MaThue = N'" + txtMaThue.Text + "'";

            tblThue = Class.Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblThue;
            dataGridView1.Columns[0].HeaderText = "Mã khách";
            dataGridView1.Columns[1].HeaderText = "Ngày thuê";
            dataGridView1.Columns[2].HeaderText = "Mã sách";
            dataGridView1.Columns[3].HeaderText = "Tên sách";
            dataGridView1.Columns[4].HeaderText = "Đơn giá";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            Load_Data2();
        }

        DataTable tblPhieu;
        private void Load_Data3()
        {
            string sql = @"select * from tblTraSach ";

            tblPhieu = Class.Functions.GetDataToTable(sql);

            dataGridView2.DataSource = tblPhieu;
            dataGridView2.Columns[0].HeaderText = "Mã trả";
            dataGridView2.Columns[1].HeaderText = "Mã thuê";
            dataGridView2.Columns[2].HeaderText = "Mã NV";
            dataGridView2.Columns[3].HeaderText = "Ngày trả";
            dataGridView2.Columns[4].HeaderText = "Tổng tiền";
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 150;
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtMaThue.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThue.Focus();
            }
            else
            {
                Load_Data1();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            btnThem.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            txtMaThue.Focus();
            txtMaTra.Text = Class.Functions.CreateKey("Tra");
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaThue.Text = string.Empty;
            
            btnLuu.Enabled = false;

            if (tblThue != null)
                tblThue.Clear();
            if (tblTraSach != null)
                tblTraSach.Clear();


        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                if (mskNgayTra.Text == "  /  /")
                {
                    MessageBox.Show("Bạn cần nhập ngày trả sách trước", "thongtbao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskNgayTra.Focus();
                    return;
                }
                else
                {
                    if (tblThue.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    txtMaKhach.Text = dataGridView1.CurrentRow.Cells["MaKhach"].Value.ToString();
                    mskNgayThue.Text = dataGridView1.CurrentRow.Cells["NgayThue"].FormattedValue.ToString();

                    DateTime borrowDate = DateTime.Parse(mskNgayThue.Text.ToString());
                    DateTime givingDate = DateTime.Parse(mskNgayTra.Text.ToString());
                    TimeSpan span = givingDate - borrowDate;
                    if (span.Days < 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại ngày trả lớn hơn ngày thuê sách!", "thongbao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mskNgayTra.Focus();
                        resetvalue();
                        return;
                    }
                    else
                    {
                        txtNgayThue.Text = (span.Days + 1).ToString();

                        string a = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
                        // Kiểm tra mã
                        bool ktra = tblTraSach.AsEnumerable().Any(row => row.Field<string>("MaSach") == a);

                        if (ktra)
                        {
                            MessageBox.Show("Sách đã được chọn rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {

                            double dongia = double.Parse(dataGridView1.CurrentRow.Cells["DonGiaThue"].Value.ToString());
                            double thanhtien = dongia * (span.Days + 1);
                            DataRow newRow = tblTraSach.NewRow();
                            newRow["MaSach"] = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
                            newRow["TenSach"] = dataGridView1.CurrentRow.Cells["TenSach"].Value.ToString();
                            newRow["DonGiaThue"] = dataGridView1.CurrentRow.Cells["DonGiaThue"].Value.ToString();
                            newRow["ThanhTien"] = thanhtien.ToString();
                            tblTraSach.Rows.Add(newRow);
                            TinhTong();
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Bạn cần vào chế độ thêm mới", "Thông báo");
                return;
            }
        }
        private void dataGridView3_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                if (tblTraSach.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa sách này khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowI = dataGridView3.CurrentRow.Index;
                        tblTraSach.Rows[rowI].Delete();
                        TinhTong();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần vào chế độ thêm mới", "Thông báo");
            }
        }
        private void TinhTong()
        {
            double total = 0;
            if (tblTraSach != null)
            {


                foreach (DataRow row in tblTraSach.Rows)
                {
                    total += Convert.ToDouble(row["ThanhTien"]);
                }
                double tienVP;
                if (double.TryParse(txtTienVP.Text, out tienVP))
                {
                    total += tienVP;
                }
            }
            txtTongTien.Text = total.ToString();
        }
        private void TienVP()
        {
            if (checkbox1.Checked && cboMaViPham.SelectedValue != null)
            {
                string maViPham = cboMaViPham.SelectedValue.ToString();
                string sql = $"SELECT TienPhat FROM tblViPham WHERE MaViPham = N'" + maViPham + "'";
                DataTable dt = Functions.GetDataToTable(sql);
                if (dt.Rows.Count > 0)
                {
                    txtTienVP.Text = dt.Rows[0]["TienPhat"].ToString();
                }
            }
            else
            {
                txtTienVP.Text = "0";
            }
        }
        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            cboMaViPham.Enabled = checkbox1.Checked;
            if (!checkbox1.Checked)
            {
                txtTienVP.Text = "0";
            }
            else
            {
                TienVP();
            }
            TinhTong();

        }
        private void cboMaViPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked)
            {
                TienVP();
            }
            TinhTong();

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            /*if (txtMaTra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTra.Focus();
                return;
            }*/
            if (mskNgayTra.Text == "  /  /")
            {
                MessageBox.Show("Bạn cần nhập ngày trả", "thongtbao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayTra.Focus();
                return;
            }
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            if (tblTraSach.Rows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn sách muốn trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (!Functions.IsDate(mskNgayTra.Text))
            {
                MessageBox.Show("Ngày trả không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayTra.Text = "";
                mskNgayTra.Focus();
                return;
            }
            string sql;
            sql = "SELECT MaTra FROM tblTraSach WHERE MaTra=N'" + txtMaTra.Text.Trim() + "'";
            /*if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã trả đã có, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTra.Focus();
                txtMaTra.Text = "";
                return;
            }*/
            sql = "INSERT INTO tblTraSach (MaTra, MaThue, MaNhanVien, NgayTra, TongTien) VALUES (N'" + txtMaTra.Text.Trim() + "', N'" + txtMaThue.Text.Trim() + "', N'" + cboMaNV.Text.Trim() + "','" + Class.Functions.ConvertDateTime(mskNgayTra.Text) + "', N'" + txtTongTien.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_Data3();
            // Lưu thông tin vào bảng tblChiTietTraSach
            foreach (DataRow row in tblTraSach.Rows)
            {
                string maSach = row["MaSach"].ToString();
                string thanhTien = row["ThanhTien"].ToString();
                string maViPham;

                if (checkbox1.Checked == false) maViPham = "VP00";
                else maViPham = cboMaViPham.SelectedValue != null ? cboMaViPham.SelectedValue.ToString() : "NULL";

                sql = $"INSERT INTO tblChiTietTraSach (MaTra, MaSach, MaViPham, ThanhTien) VALUES (N'{txtMaTra.Text.Trim()}', N'{maSach}', {(maViPham != "NULL" ? $"N'{maViPham}'" : "NULL")}, N'{thanhTien}')";
                Functions.RunSql(sql);

                sql = $"UPDATE tblChiTietThueSach SET DaTra = 1 WHERE MaThue = N'{txtMaThue.Text.Trim()}' AND MaSach = N'{maSach}'";
                Functions.RunSql(sql);
            }
            resetvalue();
            btnThem.Enabled = true;
            //btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThoat.Enabled = true;
            btnTimkiem.Enabled = true;
            txtMaThue.Text = string.Empty;
            tblThue.Clear();
            tblTraSach.Clear();
        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Không thể chọn khi ở chế độ thêm mới", "tb", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                if (tblPhieu.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    btnXoa.Enabled = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblPhieu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa phiếu trả sách không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string maTra = dataGridView2.CurrentRow.Cells["MaTra"].Value.ToString();
                string maThue = dataGridView2.CurrentRow.Cells["MaThue"].Value.ToString();

                // update DaTra
                sql = "SELECT MaSach FROM tblChiTietTraSach WHERE MaTra = N'" + maTra + "'";
                DataTable dtMaSach = Class.Functions.GetDataToTable(sql);

                foreach (DataRow row in dtMaSach.Rows)
                {
                    string maSach = row["MaSach"].ToString();
                    sql = "UPDATE tblChiTietThueSach SET DaTra = 0 WHERE MaThue = N'" + maThue + "' AND MaSach = N'" + maSach + "'";
                    Class.Functions.RunSql(sql);
                }
                //xoá DetailTraSach
                sql = "DELETE FROM tblChiTietTraSach WHERE MaTra = N'" + maTra + "'";
                Class.Functions.RunSql(sql);
                // Xóa TraSach
                sql = "DELETE FROM tblTraSach WHERE MaTra = N'" + maTra + "'";
                Class.Functions.RunSql(sql);
                Load_Data3();
                Load_Data1();
                resetvalue();
            }
        }
    }
}
