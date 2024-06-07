namespace BTL.Forms
{
    partial class frmKhachHang
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
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.AutoCompleteCustomSource.AddRange(new string[] {
            "Mã khách",
            "Tên khách"});
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Items.AddRange(new object[] {
            "",
            "Mã khách",
            "Tên khách"});
            this.cboTimkiem.Location = new System.Drawing.Point(254, 559);
            this.cboTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(136, 28);
            this.cboTimkiem.TabIndex = 46;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimkiem.Location = new System.Drawing.Point(645, 553);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(87, 35);
            this.btnTimkiem.TabIndex = 45;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(422, 557);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(204, 26);
            this.txtTimkiem.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tìm theo:";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDong.Location = new System.Drawing.Point(669, 479);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(87, 35);
            this.btnDong.TabIndex = 42;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBoqua.Location = new System.Drawing.Point(557, 479);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(87, 35);
            this.btnBoqua.TabIndex = 41;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(439, 479);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 35);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSua.Location = new System.Drawing.Point(318, 479);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 35);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(206, 479);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 35);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(90, 479);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 35);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 196);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // mskNgaysinh
            // 
            this.mskNgaysinh.Location = new System.Drawing.Point(629, 160);
            this.mskNgaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskNgaysinh.Mask = "00/00/0000";
            this.mskNgaysinh.Name = "mskNgaysinh";
            this.mskNgaysinh.Size = new System.Drawing.Size(112, 26);
            this.mskNgaysinh.TabIndex = 35;
            this.mskNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(629, 105);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(112, 26);
            this.txtDiachi.TabIndex = 34;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(202, 203);
            this.chkNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(68, 24);
            this.chkNam.TabIndex = 33;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(202, 139);
            this.txtTenkhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(112, 26);
            this.txtTenkhach.TabIndex = 32;
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(202, 76);
            this.txtMakhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(112, 26);
            this.txtMakhach.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên khách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 609);
            this.Controls.Add(this.cboTimkiem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskNgaysinh);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskNgaysinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}