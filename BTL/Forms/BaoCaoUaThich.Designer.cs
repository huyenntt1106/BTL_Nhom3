namespace BTL.Forms
{
    partial class frmBaoCaoUaThich
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskDenNgay);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.mskTuNgay);
            this.groupBox2.Location = new System.Drawing.Point(264, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(548, 57);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // mskDenNgay
            // 
            this.mskDenNgay.Location = new System.Drawing.Point(310, 24);
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
            this.label9.Location = new System.Drawing.Point(262, 26);
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
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(684, 589);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 51);
            this.btnIn.TabIndex = 69;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(478, 589);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(118, 51);
            this.btnHienThi.TabIndex = 68;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(271, 589);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(118, 51);
            this.btnLamMoi.TabIndex = 67;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // DataGridView3
            // 
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView3.Location = new System.Drawing.Point(798, 159);
            this.DataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.RowHeadersWidth = 82;
            this.DataGridView3.RowTemplate.Height = 33;
            this.DataGridView3.Size = new System.Drawing.Size(350, 387);
            this.DataGridView3.TabIndex = 66;
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(403, 159);
            this.DataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersWidth = 82;
            this.DataGridView2.RowTemplate.Height = 33;
            this.DataGridView2.Size = new System.Drawing.Size(350, 387);
            this.DataGridView2.TabIndex = 65;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(18, 159);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 82;
            this.DataGridView1.RowTemplate.Height = 33;
            this.DataGridView1.Size = new System.Drawing.Size(350, 387);
            this.DataGridView1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 62;
            this.label1.Text = "BÁO CÁO ƯA THÍCH\r\n";
            // 
            // frmBaoCaoUaThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.DataGridView3);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoUaThich";
            this.Text = "BaoCaoUaThich";
            this.Load += new System.EventHandler(this.frmBaoCaoUaThich_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskDenNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTuNgay;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView DataGridView3;
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label1;
    }
}