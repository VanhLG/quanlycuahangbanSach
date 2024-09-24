using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class HuongDanSuDung : Form
    {
        public string tenNV;
        public HuongDanSuDung()
        {
            InitializeComponent();
        }

        private void HuongDanSuDung_Load(object sender, EventArgs e)
        {

        }

        private void HuongDanSuDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            var trangchu = new TrangChu();
            trangchu.StartPosition = FormStartPosition.Manual;
            trangchu.Location = this.Location;
            trangchu.TenNV1 = tenNV;
            trangchu.Show();
        }
    }
}
