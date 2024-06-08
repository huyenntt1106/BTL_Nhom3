namespace Báo_cáo_cửa_hàng.Báo_cáo
{
    partial class BaoCaoDoanhThu
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
            this.mskNgay = new System.Windows.Forms.MaskedTextBox();
            this.rdoTheoKhoang = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTenSach = new System.Windows.Forms.ComboBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskNgay
            // 
            this.mskNgay.Location = new System.Drawing.Point(854, 141);
            this.mskNgay.Mask = "00/00/0000";
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(267, 31);
            this.mskNgay.TabIndex = 54;
            this.mskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // rdoTheoKhoang
            // 
            this.rdoTheoKhoang.AutoSize = true;
            this.rdoTheoKhoang.Location = new System.Drawing.Point(577, 201);
            this.rdoTheoKhoang.Name = "rdoTheoKhoang";
            this.rdoTheoKhoang.Size = new System.Drawing.Size(169, 29);
            this.rdoTheoKhoang.TabIndex = 53;
            this.rdoTheoKhoang.TabStop = true;
            this.rdoTheoKhoang.Text = "Theo khoảng";
            this.rdoTheoKhoang.UseVisualStyleBackColor = true;
            this.rdoTheoKhoang.Click += new System.EventHandler(this.rdoTheoKhoang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskDenNgay);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.mskTuNgay);
            this.groupBox2.Location = new System.Drawing.Point(775, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 71);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // mskDenNgay
            // 
            this.mskDenNgay.Location = new System.Drawing.Point(418, 30);
            this.mskDenNgay.Mask = "00/00/0000";
            this.mskDenNgay.Name = "mskDenNgay";
            this.mskDenNgay.Size = new System.Drawing.Size(267, 31);
            this.mskDenNgay.TabIndex = 3;
            this.mskDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "đến";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Từ";
            // 
            // mskTuNgay
            // 
            this.mskTuNgay.Location = new System.Drawing.Point(77, 30);
            this.mskTuNgay.Mask = "00/00/0000";
            this.mskTuNgay.Name = "mskTuNgay";
            this.mskTuNgay.Size = new System.Drawing.Size(267, 31);
            this.mskTuNgay.TabIndex = 0;
            this.mskTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.Location = new System.Drawing.Point(579, 143);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(145, 29);
            this.rdoTheoNgay.TabIndex = 51;
            this.rdoTheoNgay.TabStop = true;
            this.rdoTheoNgay.Text = "Theo ngày";
            this.rdoTheoNgay.UseVisualStyleBackColor = true;
            this.rdoTheoNgay.Click += new System.EventHandler(this.rdoTheoNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 51);
            this.label1.TabIndex = 50;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Tên sách";
            // 
            // cboTenSach
            // 
            this.cboTenSach.FormattingEnabled = true;
            this.cboTenSach.Location = new System.Drawing.Point(261, 175);
            this.cboTenSach.Name = "cboTenSach";
            this.cboTenSach.Size = new System.Drawing.Size(297, 33);
            this.cboTenSach.TabIndex = 56;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(420, 275);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 82;
            this.DataGridView1.RowTemplate.Height = 33;
            this.DataGridView1.Size = new System.Drawing.Size(671, 382);
            this.DataGridView1.TabIndex = 55;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(302, 695);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(288, 31);
            this.txtDoanhThu.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Doanh thu";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1015, 771);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(158, 64);
            this.btnIn.TabIndex = 64;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(740, 771);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(158, 64);
            this.btnHienThi.TabIndex = 63;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(465, 771);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(158, 64);
            this.btnLamMoi.TabIndex = 62;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 904);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboTenSach);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.mskNgay);
            this.Controls.Add(this.rdoTheoKhoang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rdoTheoNgay);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "Báo Cáo Doanh Thu";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskNgay;
        private System.Windows.Forms.RadioButton rdoTheoKhoang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskDenNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTuNgay;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTenSach;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnLamMoi;
    }
}