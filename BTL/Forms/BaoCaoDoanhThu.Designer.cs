namespace BTL.Forms
{
    partial class frmBaoCaoDoanhThu
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTenSach = new System.Windows.Forms.ComboBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskNgay = new System.Windows.Forms.MaskedTextBox();
            this.mskDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.rdoTheoKhoang = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(694, 607);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 51);
            this.btnIn.TabIndex = 77;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(488, 607);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(118, 51);
            this.btnHienThi.TabIndex = 76;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(282, 607);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(118, 51);
            this.btnLamMoi.TabIndex = 75;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(159, 546);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(217, 26);
            this.txtDoanhThu.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Doanh thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Tên sách";
            // 
            // cboTenSach
            // 
            this.cboTenSach.FormattingEnabled = true;
            this.cboTenSach.Location = new System.Drawing.Point(129, 130);
            this.cboTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenSach.Name = "cboTenSach";
            this.cboTenSach.Size = new System.Drawing.Size(224, 28);
            this.cboTenSach.TabIndex = 71;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(248, 210);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 82;
            this.DataGridView1.RowTemplate.Height = 33;
            this.DataGridView1.Size = new System.Drawing.Size(503, 306);
            this.DataGridView1.TabIndex = 70;
            // 
            // mskNgay
            // 
            this.mskNgay.Location = new System.Drawing.Point(573, 103);
            this.mskNgay.Margin = new System.Windows.Forms.Padding(2);
            this.mskNgay.Mask = "00/00/0000";
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(201, 26);
            this.mskNgay.TabIndex = 69;
            this.mskNgay.ValidatingType = typeof(System.DateTime);
            // 
            // mskDenNgay
            // 
            this.mskDenNgay.Location = new System.Drawing.Point(314, 24);
            this.mskDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.mskDenNgay.Mask = "00/00/0000";
            this.mskDenNgay.Name = "mskDenNgay";
            this.mskDenNgay.Size = new System.Drawing.Size(201, 26);
            this.mskDenNgay.TabIndex = 3;
            this.mskDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "đến";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Từ";
            // 
            // mskTuNgay
            // 
            this.mskTuNgay.Location = new System.Drawing.Point(58, 24);
            this.mskTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.mskTuNgay.Mask = "00/00/0000";
            this.mskTuNgay.Name = "mskTuNgay";
            this.mskTuNgay.Size = new System.Drawing.Size(201, 26);
            this.mskTuNgay.TabIndex = 0;
            this.mskTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // rdoTheoKhoang
            // 
            this.rdoTheoKhoang.AutoSize = true;
            this.rdoTheoKhoang.Location = new System.Drawing.Point(366, 151);
            this.rdoTheoKhoang.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTheoKhoang.Name = "rdoTheoKhoang";
            this.rdoTheoKhoang.Size = new System.Drawing.Size(127, 24);
            this.rdoTheoKhoang.TabIndex = 68;
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
            this.groupBox2.Location = new System.Drawing.Point(514, 122);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(548, 57);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.Location = new System.Drawing.Point(367, 104);
            this.rdoTheoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(108, 24);
            this.rdoTheoNgay.TabIndex = 66;
            this.rdoTheoNgay.TabStop = true;
            this.rdoTheoNgay.Text = "Theo ngày";
            this.rdoTheoNgay.UseVisualStyleBackColor = true;
            this.rdoTheoNgay.Click += new System.EventHandler(this.rdoTheoNgay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 38);
            this.label1.TabIndex = 65;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 682);
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
            this.Name = "frmBaoCaoDoanhThu";
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTenSach;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.MaskedTextBox mskNgay;
        private System.Windows.Forms.MaskedTextBox mskDenNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTuNgay;
        private System.Windows.Forms.RadioButton rdoTheoKhoang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
        private System.Windows.Forms.Label label1;
    }
}