using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Báo_cáo_cửa_hàng.Báo_cáo
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void Báo_cáo_chung_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BaoCaoThueSach a= new BaoCaoThueSach();
            a.Show();
        }

        private void báoCáoƯaThíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoUaThich a=new BaoCaoUaThich();
            a.Show();
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu a=new BaoCaoDoanhThu();
            a.Show();
        }
    }
}
