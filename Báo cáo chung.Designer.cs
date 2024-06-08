namespace Báo_cáo_cửa_hàng.Báo_cáo
{
    partial class BaoCao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoƯaThíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoToolStripMenuItem1,
            this.báoCáoDoanhThuToolStripMenuItem,
            this.báoCáoƯaThíchToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(118, 38);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // báoCáoToolStripMenuItem1
            // 
            this.báoCáoToolStripMenuItem1.Name = "báoCáoToolStripMenuItem1";
            this.báoCáoToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.báoCáoToolStripMenuItem1.Text = "Báo cáo thuê sách";
            this.báoCáoToolStripMenuItem1.Click += new System.EventHandler(this.báoCáoToolStripMenuItem1_Click);
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            this.báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            this.báoCáoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            this.báoCáoDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuToolStripMenuItem_Click);
            // 
            // báoCáoƯaThíchToolStripMenuItem
            // 
            this.báoCáoƯaThíchToolStripMenuItem.Name = "báoCáoƯaThíchToolStripMenuItem";
            this.báoCáoƯaThíchToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.báoCáoƯaThíchToolStripMenuItem.Text = "Báo cáo ưa thích";
            this.báoCáoƯaThíchToolStripMenuItem.Click += new System.EventHandler(this.báoCáoƯaThíchToolStripMenuItem_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaoCao";
            this.Text = "Báo_cáo_chung";
            this.Load += new System.EventHandler(this.Báo_cáo_chung_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoƯaThíchToolStripMenuItem;
    }
}