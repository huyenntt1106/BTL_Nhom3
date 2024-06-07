namespace BTL.Forms
{
    partial class frmTimKiemThue
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
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.datagridTim = new System.Windows.Forms.DataGridView();
            this.mskNgayThue = new System.Windows.Forms.MaskedTextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.lblMaThue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(603, 80);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(237, 26);
            this.txtMaKhachHang.TabIndex = 41;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(190, 187);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(237, 26);
            this.txtMaNhanVien.TabIndex = 40;
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(190, 80);
            this.txtMaThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(237, 26);
            this.txtMaThue.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 46);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tìm Kiếm Hoá Đơn Thuê Sách Truyện";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(801, 510);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(153, 29);
            this.btnDong.TabIndex = 37;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(478, 510);
            this.btnTimlai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(165, 29);
            this.btnTimlai.TabIndex = 36;
            this.btnTimlai.Text = "Tìm Lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(126, 510);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(178, 29);
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // datagridTim
            // 
            this.datagridTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTim.Location = new System.Drawing.Point(26, 234);
            this.datagridTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridTim.Name = "datagridTim";
            this.datagridTim.RowHeadersWidth = 51;
            this.datagridTim.RowTemplate.Height = 24;
            this.datagridTim.Size = new System.Drawing.Size(969, 228);
            this.datagridTim.TabIndex = 34;
            this.datagridTim.DoubleClick += new System.EventHandler(this.datagridTim_DoubleClick);
            // 
            // mskNgayThue
            // 
            this.mskNgayThue.Location = new System.Drawing.Point(190, 135);
            this.mskNgayThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgayThue.Mask = "00/00/0000";
            this.mskNgayThue.Name = "mskNgayThue";
            this.mskNgayThue.Size = new System.Drawing.Size(237, 26);
            this.mskNgayThue.TabIndex = 33;
            this.mskNgayThue.ValidatingType = typeof(System.DateTime);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(22, 195);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(148, 20);
            this.lblMaNV.TabIndex = 32;
            this.lblMaNV.Text = "Mã Nhân Viên Tạo :";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(475, 87);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(131, 20);
            this.lblMaKH.TabIndex = 31;
            this.lblMaKH.Text = "Mã Khách Hàng :";
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.AutoSize = true;
            this.lblTienDatCoc.Location = new System.Drawing.Point(475, 139);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(109, 20);
            this.lblTienDatCoc.TabIndex = 30;
            this.lblTienDatCoc.Text = "Tiền Đặt Cọc :";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Location = new System.Drawing.Point(603, 131);
            this.txtTienDatCoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(237, 26);
            this.txtTienDatCoc.TabIndex = 29;
            this.txtTienDatCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienDatCoc_KeyPress);
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Location = new System.Drawing.Point(22, 143);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(97, 20);
            this.lblNgayThue.TabIndex = 28;
            this.lblNgayThue.Text = " Ngày Thuê :";
            // 
            // lblMaThue
            // 
            this.lblMaThue.AutoSize = true;
            this.lblMaThue.Location = new System.Drawing.Point(22, 90);
            this.lblMaThue.Name = "lblMaThue";
            this.lblMaThue.Size = new System.Drawing.Size(79, 20);
            this.lblMaThue.TabIndex = 27;
            this.lblMaThue.Text = "Mã Thuê :";
            // 
            // frmTimKiemThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 570);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.datagridTim);
            this.Controls.Add(this.mskNgayThue);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblTienDatCoc);
            this.Controls.Add(this.txtTienDatCoc);
            this.Controls.Add(this.lblNgayThue);
            this.Controls.Add(this.lblMaThue);
            this.Name = "frmTimKiemThue";
            this.Text = "TimKiemThue";
            this.Load += new System.EventHandler(this.frmTimKiemThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView datagridTim;
        private System.Windows.Forms.MaskedTextBox mskNgayThue;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.Label lblMaThue;
    }
}