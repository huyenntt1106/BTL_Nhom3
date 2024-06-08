namespace BTL.Forms
{
    partial class frmThueSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDaTra = new System.Windows.Forms.Label();
            this.txtDaTra = new System.Windows.Forms.TextBox();
            this.cboMaTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTenTinhTrang = new System.Windows.Forms.Label();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnĐóng = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboMaThue = new System.Windows.Forms.ComboBox();
            this.datagridThue = new System.Windows.Forms.DataGridView();
            this.txtTenTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMaTT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMaS = new System.Windows.Forms.Label();
            this.lblMaThue = new System.Windows.Forms.Label();
            this.txtDonGiaThue = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnTim = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.mskNgayThue = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDaTra
            // 
            this.lblDaTra.AutoSize = true;
            this.lblDaTra.Location = new System.Drawing.Point(721, 84);
            this.lblDaTra.Name = "lblDaTra";
            this.lblDaTra.Size = new System.Drawing.Size(65, 20);
            this.lblDaTra.TabIndex = 41;
            this.lblDaTra.Text = "Đã Trả :";
            // 
            // txtDaTra
            // 
            this.txtDaTra.Location = new System.Drawing.Point(804, 81);
            this.txtDaTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDaTra.Name = "txtDaTra";
            this.txtDaTra.Size = new System.Drawing.Size(270, 26);
            this.txtDaTra.TabIndex = 39;
            // 
            // cboMaTinhTrang
            // 
            this.cboMaTinhTrang.FormattingEnabled = true;
            this.cboMaTinhTrang.Location = new System.Drawing.Point(128, 120);
            this.cboMaTinhTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaTinhTrang.Name = "cboMaTinhTrang";
            this.cboMaTinhTrang.Size = new System.Drawing.Size(229, 28);
            this.cboMaTinhTrang.TabIndex = 28;
            this.cboMaTinhTrang.TextChanged += new System.EventHandler(this.cboMaTinhTrang_TextChanged);
            // 
            // lblTenTinhTrang
            // 
            this.lblTenTinhTrang.AutoSize = true;
            this.lblTenTinhTrang.Location = new System.Drawing.Point(3, 181);
            this.lblTenTinhTrang.Name = "lblTenTinhTrang";
            this.lblTenTinhTrang.Size = new System.Drawing.Size(123, 20);
            this.lblTenTinhTrang.TabIndex = 27;
            this.lblTenTinhTrang.Text = "Tên Tình Trạng :";
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(501, 496);
            this.btnXoaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(129, 29);
            this.btnXoaHoaDon.TabIndex = 20;
            this.btnXoaHoaDon.Text = "Xóa Hóa Đơn";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnĐóng
            // 
            this.btnĐóng.Location = new System.Drawing.Point(946, 496);
            this.btnĐóng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnĐóng.Name = "btnĐóng";
            this.btnĐóng.Size = new System.Drawing.Size(166, 29);
            this.btnĐóng.TabIndex = 19;
            this.btnĐóng.Text = "Đóng";
            this.btnĐóng.UseVisualStyleBackColor = true;
            this.btnĐóng.Click += new System.EventHandler(this.btnĐóng_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(706, 496);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(159, 29);
            this.btnInHoaDon.TabIndex = 18;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(273, 496);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 29);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 496);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 29);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm Mới Hóa Đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMaThue
            // 
            this.cboMaThue.FormattingEnabled = true;
            this.cboMaThue.Location = new System.Drawing.Point(398, 884);
            this.cboMaThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaThue.Name = "cboMaThue";
            this.cboMaThue.Size = new System.Drawing.Size(330, 28);
            this.cboMaThue.TabIndex = 28;
            this.cboMaThue.DropDown += new System.EventHandler(this.cboMaThue_DropDown);
            // 
            // datagridThue
            // 
            this.datagridThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridThue.Location = new System.Drawing.Point(7, 248);
            this.datagridThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridThue.Name = "datagridThue";
            this.datagridThue.RowHeadersWidth = 51;
            this.datagridThue.RowTemplate.Height = 24;
            this.datagridThue.Size = new System.Drawing.Size(1214, 199);
            this.datagridThue.TabIndex = 12;
            this.datagridThue.DoubleClick += new System.EventHandler(this.datagridThue_DoubleClick);
            // 
            // txtTenTinhTrang
            // 
            this.txtTenTinhTrang.Location = new System.Drawing.Point(128, 175);
            this.txtTenTinhTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTinhTrang.Name = "txtTenTinhTrang";
            this.txtTenTinhTrang.Size = new System.Drawing.Size(229, 26);
            this.txtTenTinhTrang.TabIndex = 8;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(128, 65);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(229, 26);
            this.txtTenSach.TabIndex = 7;
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(128, 22);
            this.cboMaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(229, 28);
            this.cboMaSach.TabIndex = 6;
            this.cboMaSach.TextChanged += new System.EventHandler(this.cboMaSach_TextChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(670, 32);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(116, 20);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Đơn Giá Thuê :";
            // 
            // lblMaTT
            // 
            this.lblMaTT.AutoSize = true;
            this.lblMaTT.Location = new System.Drawing.Point(3, 124);
            this.lblMaTT.Name = "lblMaTT";
            this.lblMaTT.Size = new System.Drawing.Size(118, 20);
            this.lblMaTT.TabIndex = 2;
            this.lblMaTT.Text = "Mã Tình Trạng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên Sách :";
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Location = new System.Drawing.Point(18, 22);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(80, 20);
            this.lblMaS.TabIndex = 0;
            this.lblMaS.Text = "Mã Sách :";
            // 
            // lblMaThue
            // 
            this.lblMaThue.AutoSize = true;
            this.lblMaThue.Location = new System.Drawing.Point(-239, 867);
            this.lblMaThue.Name = "lblMaThue";
            this.lblMaThue.Size = new System.Drawing.Size(75, 20);
            this.lblMaThue.TabIndex = 27;
            this.lblMaThue.Text = "Mã Thuê:";
            // 
            // txtDonGiaThue
            // 
            this.txtDonGiaThue.Location = new System.Drawing.Point(804, 25);
            this.txtDonGiaThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGiaThue.Name = "txtDonGiaThue";
            this.txtDonGiaThue.Size = new System.Drawing.Size(270, 26);
            this.txtDonGiaThue.TabIndex = 9;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(745, 883);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(84, 29);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblDaTra);
            this.grpThongTin.Controls.Add(this.txtDaTra);
            this.grpThongTin.Controls.Add(this.cboMaTinhTrang);
            this.grpThongTin.Controls.Add(this.lblTenTinhTrang);
            this.grpThongTin.Controls.Add(this.btnXoaHoaDon);
            this.grpThongTin.Controls.Add(this.btnĐóng);
            this.grpThongTin.Controls.Add(this.btnInHoaDon);
            this.grpThongTin.Controls.Add(this.btnLuu);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.datagridThue);
            this.grpThongTin.Controls.Add(this.txtDonGiaThue);
            this.grpThongTin.Controls.Add(this.txtTenTinhTrang);
            this.grpThongTin.Controls.Add(this.txtTenSach);
            this.grpThongTin.Controls.Add(this.cboMaSach);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.lblMaTT);
            this.grpThongTin.Controls.Add(this.label11);
            this.grpThongTin.Controls.Add(this.lblMaS);
            this.grpThongTin.Location = new System.Drawing.Point(39, 325);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpThongTin.Size = new System.Drawing.Size(1331, 532);
            this.grpThongTin.TabIndex = 25;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Sách Thuê";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtTienCoc);
            this.groupBox1.Controls.Add(this.lblTienCoc);
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.mskNgaySinh);
            this.groupBox1.Controls.Add(this.mskNgayThue);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaThue);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Controls.Add(this.lblMaKH);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Location = new System.Drawing.Point(39, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1331, 232);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(1101, 134);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(75, 20);
            this.lblGioiTinh.TabIndex = 20;
            this.lblGioiTinh.Text = "Giới Tính:";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(1179, 130);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(106, 26);
            this.txtGioiTinh.TabIndex = 19;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(957, 130);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(106, 26);
            this.txtTienCoc.TabIndex = 18;
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Location = new System.Drawing.Point(857, 134);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(109, 20);
            this.lblTienCoc.TabIndex = 17;
            this.lblTienCoc.Text = "Tiền Đặt Cọc :";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(738, 26);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(547, 28);
            this.cboMaKH.TabIndex = 16;
            this.cboMaKH.TextChanged += new System.EventHandler(this.cboMaKH_TextChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(153, 130);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(339, 28);
            this.cboMaNV.TabIndex = 15;
            this.cboMaNV.TextChanged += new System.EventHandler(this.cboMaNV_TextChanged);
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(738, 130);
            this.mskNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(103, 26);
            this.mskNgaySinh.TabIndex = 14;
            this.mskNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // mskNgayThue
            // 
            this.mskNgayThue.Location = new System.Drawing.Point(153, 82);
            this.mskNgayThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgayThue.Mask = "00/00/0000";
            this.mskNgayThue.Name = "mskNgayThue";
            this.mskNgayThue.Size = new System.Drawing.Size(339, 26);
            this.mskNgayThue.TabIndex = 13;
            this.mskNgayThue.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(738, 179);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(547, 26);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(153, 179);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(339, 26);
            this.txtTenNV.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(738, 82);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(547, 26);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(153, 26);
            this.txtMaThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(339, 26);
            this.txtMaThue.TabIndex = 9;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(600, 186);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(68, 20);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa Chỉ :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(600, 138);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(89, 20);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày Sinh :";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(594, 90);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(136, 20);
            this.lblTenKH.TabIndex = 5;
            this.lblTenKH.Text = "Tên Khách Hàng :";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(600, 34);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(131, 20);
            this.lblMaKH.TabIndex = 4;
            this.lblMaKH.Text = "Mã Khách Hàng :";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(18, 186);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(122, 20);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Tên Nhân Viên :";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(24, 138);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(117, 20);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã Nhân Viên :";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(24, 90);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(93, 20);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "Ngày Thuê :";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(24, 34);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(79, 20);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã Thuê :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hóa Đơn Thuê Sách Truyện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 887);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã Thuê:";
            // 
            // frmThueSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 938);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaThue);
            this.Controls.Add(this.lblMaThue);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmThueSach";
            this.Text = "ThueSach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThueSach_FormClosing);
            this.Load += new System.EventHandler(this.frmThueSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaTra;
        private System.Windows.Forms.TextBox txtDaTra;
        private System.Windows.Forms.ComboBox cboMaTinhTrang;
        private System.Windows.Forms.Label lblTenTinhTrang;
        private System.Windows.Forms.Button btnXoaHoaDon;
        public System.Windows.Forms.Button btnĐóng;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMaThue;
        private System.Windows.Forms.DataGridView datagridThue;
        private System.Windows.Forms.TextBox txtTenTinhTrang;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblMaTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMaS;
        private System.Windows.Forms.Label lblMaThue;
        private System.Windows.Forms.TextBox txtDonGiaThue;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.MaskedTextBox mskNgayThue;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenKH;
        public System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}