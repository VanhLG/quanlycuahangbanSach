using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Form4 : Form
    {
        public string tenNV;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(@"D:\BÀI TẬP ĐẠI HỌC 2021 - 2025\BÀI TẬP LẬP TRÌNH [104]\MÔN CƠ SỞ [72]\[2022-2023] KÌ 2 [18]\BÀI TẬP LẬP TRÌNH HƯỚNG SỰ KIỆN [4]\FormDangNhap\FormDangNhap\CrystalReport2.rpt");
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            var trangchu = new TrangChu();
            trangchu.StartPosition = FormStartPosition.Manual;
            trangchu.Location = this.Location;
            trangchu.TenNV1 = tenNV;
            trangchu.Show();
        }
    }
}
