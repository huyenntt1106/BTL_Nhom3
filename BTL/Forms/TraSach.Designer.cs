namespace BTL
{
    partial class frmTraSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTienVP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgayThue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskNgayTra = new System.Windows.Forms.MaskedTextBox();
            this.mskNgayThue = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboMaViPham = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Phiếu Trả Sách";
            // 
            // txtMaThue
            // 
            this.txtMaThue.Location = new System.Drawing.Point(101, 51);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(192, 26);
            this.txtMaThue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã thuê:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(537, 181);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã khách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã trả:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày thuê:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTienVP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNgayThue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskNgayTra);
            this.groupBox1.Controls.Add(this.mskNgayThue);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cboMaViPham);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtMaTra);
            this.groupBox1.Controls.Add(this.txtMaKhach);
            this.groupBox1.Controls.Add(this.checkbox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(125, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 369);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HÓA ĐƠN";
            // 
            // txtTienVP
            // 
            this.txtTienVP.Location = new System.Drawing.Point(769, 94);
            this.txtTienVP.Name = "txtTienVP";
            this.txtTienVP.Size = new System.Drawing.Size(100, 26);
            this.txtTienVP.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tiền vi phạm:";
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Location = new System.Drawing.Point(541, 72);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Size = new System.Drawing.Size(100, 26);
            this.txtNgayThue.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Số ngày thuê:";
            // 
            // mskNgayTra
            // 
            this.mskNgayTra.Location = new System.Drawing.Point(299, 71);
            this.mskNgayTra.Mask = "00/00/0000";
            this.mskNgayTra.Name = "mskNgayTra";
            this.mskNgayTra.Size = new System.Drawing.Size(100, 26);
            this.mskNgayTra.TabIndex = 38;
            this.mskNgayTra.ValidatingType = typeof(System.DateTime);
            // 
            // mskNgayThue
            // 
            this.mskNgayThue.Location = new System.Drawing.Point(97, 69);
            this.mskNgayThue.Mask = "00/00/0000";
            this.mskNgayThue.Name = "mskNgayThue";
            this.mskNgayThue.Size = new System.Drawing.Size(100, 26);
            this.mskNgayThue.TabIndex = 37;
            this.mskNgayThue.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(58, 146);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(828, 177);
            this.dataGridView3.TabIndex = 26;
            this.dataGridView3.Click += new System.EventHandler(this.dataGridView3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 20);
            this.label18.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 20);
            this.label19.TabIndex = 25;
            this.label19.Text = "Các sách muốn trả";
            // 
            // cboMaViPham
            // 
            this.cboMaViPham.FormattingEnabled = true;
            this.cboMaViPham.Location = new System.Drawing.Point(769, 46);
            this.cboMaViPham.Name = "cboMaViPham";
            this.cboMaViPham.Size = new System.Drawing.Size(100, 28);
            this.cboMaViPham.TabIndex = 35;
            this.cboMaViPham.SelectedIndexChanged += new System.EventHandler(this.cboMaViPham_SelectedIndexChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(541, 27);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(100, 28);
            this.cboMaNV.TabIndex = 34;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(711, 329);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(175, 26);
            this.txtTongTien.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(626, 332);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Tổng tiền:";
            // 
            // txtMaTra
            // 
            this.txtMaTra.Location = new System.Drawing.Point(299, 28);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.Size = new System.Drawing.Size(100, 26);
            this.txtMaTra.TabIndex = 20;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(97, 28);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(103, 26);
            this.txtMaKhach.TabIndex = 17;
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Location = new System.Drawing.Point(674, 15);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(93, 24);
            this.checkbox1.TabIndex = 15;
            this.checkbox1.Text = "Vi phạm";
            this.checkbox1.UseVisualStyleBackColor = true;
            this.checkbox1.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(670, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mã vi phạm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày trả:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(174, 665);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(512, 665);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(868, 664);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 666);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(685, 664);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(81, 30);
            this.btnBoQua.TabIndex = 20;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(604, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(532, 181);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(600, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 20);
            this.label17.TabIndex = 22;
            this.label17.Text = "Phiếu trả sách:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(312, 48);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(91, 32);
            this.btnTimkiem.TabIndex = 23;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 718);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaThue);
            this.Controls.Add(this.label1);
            this.Name = "frmTraSach";
            this.Text = "TraSach";
            this.Load += new System.EventHandler(this.TraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboMaViPham;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.MaskedTextBox mskNgayTra;
        private System.Windows.Forms.MaskedTextBox mskNgayThue;
        private System.Windows.Forms.TextBox txtNgayThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienVP;
    }
}