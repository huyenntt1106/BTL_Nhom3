namespace thuetruyen
{
    partial class timkiem
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
            this.lblMaThue = new System.Windows.Forms.Label();
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.mskNgayThue = new System.Windows.Forms.MaskedTextBox();
            this.datagridTim = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaThue
            // 
            this.lblMaThue.AutoSize = true;
            this.lblMaThue.Location = new System.Drawing.Point(43, 68);
            this.lblMaThue.Name = "lblMaThue";
            this.lblMaThue.Size = new System.Drawing.Size(66, 16);
            this.lblMaThue.TabIndex = 0;
            this.lblMaThue.Text = "Mã Thuê :";
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Location = new System.Drawing.Point(43, 110);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(83, 16);
            this.lblNgayThue.TabIndex = 1;
            this.lblNgayThue.Text = " Ngày Thuê :";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(445, 66);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(108, 16);
            this.lblMaKH.TabIndex = 13;
            this.lblMaKH.Text = "Mã Khách Hàng :";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(43, 152);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(125, 16);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã Nhân Viên Tạo :";
            // 
            // mskNgayThue
            // 
            this.mskNgayThue.Location = new System.Drawing.Point(192, 104);
            this.mskNgayThue.Mask = "00/00/0000";
            this.mskNgayThue.Name = "mskNgayThue";
            this.mskNgayThue.Size = new System.Drawing.Size(211, 22);
            this.mskNgayThue.TabIndex = 18;
            this.mskNgayThue.ValidatingType = typeof(System.DateTime);
            // 
            // datagridTim
            // 
            this.datagridTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTim.Location = new System.Drawing.Point(46, 183);
            this.datagridTim.Name = "datagridTim";
            this.datagridTim.RowHeadersWidth = 51;
            this.datagridTim.RowTemplate.Height = 24;
            this.datagridTim.Size = new System.Drawing.Size(861, 182);
            this.datagridTim.TabIndex = 19;
            this.datagridTim.DoubleClick += new System.EventHandler(this.datagridTim_DoubleClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(135, 404);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 23);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(448, 404);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(147, 23);
            this.btnTimlai.TabIndex = 21;
            this.btnTimlai.Text = "Tìm Lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(735, 404);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(136, 23);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tìm Kiếm Hoá Đơn Thuê Sách Truyện";
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(192, 60);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(211, 22);
            this.txtMaThue.TabIndex = 24;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(192, 146);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(211, 22);
            this.txtMaNhanVien.TabIndex = 25;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(559, 60);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(211, 22);
            this.txtMaKhachHang.TabIndex = 26;
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
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
            this.Controls.Add(this.lblNgayThue);
            this.Controls.Add(this.lblMaThue);
            this.Name = "timkiem";
            this.Text = "Tìm Hóa Đơn Thuê";
            this.Load += new System.EventHandler(this.timkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaThue;
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.MaskedTextBox mskNgayThue;
        private System.Windows.Forms.DataGridView datagridTim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaKhachHang;
    }
}