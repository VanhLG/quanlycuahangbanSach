using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FormDangNhap
{
    public partial class TrangChu : Form
    {
        public string TenNV1;
        public string tenDangNhap;

        public TrangChu()
        {
            InitializeComponent();
        }


        private void ThayDoiMK_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau form3 = new ThayDoiMatKhau();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = this.Location;
            form3.tenNV = TenNV1;
            form3.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string LoadCV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Select sTenCV from tblNhanVien where sTaiKhoan ='" + TenNV1 + "'", connection))
                {
                    tenDangNhap = (string)cmd.ExecuteScalar();
                }
                return tenDangNhap;
            }
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadCV() == "CEO")
            {
                var formNV = new FormNV();
                formNV.StartPosition = FormStartPosition.Manual;
                formNV.Location = this.Location;
                formNV.tenNV = TenNV1;
                formNV.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập. Vui lòng đăng ký với Admin");
            }    
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formKH = new FormKH();
            formKH.StartPosition = FormStartPosition.Manual;
            formKH.Location = this.Location;
            formKH.tenNV = TenNV1;
            formKH.Show();
            this.Hide();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            lbTenNV.Text =  $"Xin chào, {TenNV1}!";
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSach = new FormSach();
            formSach.StartPosition = FormStartPosition.Manual;
            formSach.Location = this.Location;
            formSach.tenNV = TenNV1;
            formSach.Show();
            this.Hide();
        }

        private void quảnLýNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNXB = new FormNXB();
            formNXB.StartPosition = FormStartPosition.Manual;
            formNXB.Location = this.Location;
            formNXB.tenNV = TenNV1;
            formNXB.Show();
            this.Hide();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.TenNV = TenNV1;
            f.Show();
            this.Hide();
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêTheoLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = this.Location;
            form4.tenNV = TenNV1;
            form4.ShowDialog();
            this.Hide();
        }

        private void thốngKêTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTKNgay = new FormThongKeNgayLap();
            formTKNgay.StartPosition = FormStartPosition.Manual;
            formTKNgay.Location = this.Location;
            formTKNgay.tenNV = TenNV1;
            formTKNgay.Show();
            this.Hide();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.tenNV = TenNV1;
            form1.Show();
            this.Hide();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new HuongDanSuDung();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.tenNV = TenNV1;
            form1.Show();
            this.Hide();
        }
    }
}
