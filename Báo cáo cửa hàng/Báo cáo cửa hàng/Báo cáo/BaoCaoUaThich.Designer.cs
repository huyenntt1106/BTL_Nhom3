namespace Báo_cáo_cửa_hàng
{
    partial class BaoCaoUaThich
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskDenNgay);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.mskTuNgay);
            this.groupBox2.Location = new System.Drawing.Point(397, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 71);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // mskDenNgay
            // 
            this.mskDenNgay.Location = new System.Drawing.Point(413, 30);
            this.mskDenNgay.Mask = "00/00/0000";
            this.mskDenNgay.Name = "mskDenNgay";
            this.mskDenNgay.Size = new System.Drawing.Size(267, 31);
            this.mskDenNgay.TabIndex = 3;
            this.mskDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 33);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 51);
            this.label1.TabIndex = 50;
            this.label1.Text = "BÁO CÁO ƯA THÍCH\r\n";
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(69, 243);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 82;
            this.DataGridView1.RowTemplate.Height = 33;
            this.DataGridView1.Size = new System.Drawing.Size(467, 484);
            this.DataGridView1.TabIndex = 56;
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(583, 243);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersWidth = 82;
            this.DataGridView2.RowTemplate.Height = 33;
            this.DataGridView2.Size = new System.Drawing.Size(467, 484);
            this.DataGridView2.TabIndex = 57;
            // 
            // DataGridView3
            // 
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView3.Location = new System.Drawing.Point(1109, 243);
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.RowHeadersWidth = 82;
            this.DataGridView3.RowTemplate.Height = 33;
            this.DataGridView3.Size = new System.Drawing.Size(467, 484);
            this.DataGridView3.TabIndex = 58;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(957, 780);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(158, 64);
            this.btnIn.TabIndex = 61;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(682, 780);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(158, 64);
            this.btnHienThi.TabIndex = 60;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(407, 780);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(158, 64);
            this.btnLamMoi.TabIndex = 59;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // BaoCaoUaThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 924);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.DataGridView3);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoUaThich";
            this.Text = "Báo Cáo Ưa Thích Độc Giả";
            this.Load += new System.EventHandler(this.BaoCaoUaThich_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskDenNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.DataGridView DataGridView3;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

