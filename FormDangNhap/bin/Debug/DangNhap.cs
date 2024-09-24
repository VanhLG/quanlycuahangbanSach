using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormDangNhap
{
    public partial class DangNhap : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public DangNhap()
        {

            InitializeComponent();
            

        }

        private void tbTenDN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenDN.Text))
            {
                errorProvider.SetError(tbTenDN, "Ten dang nhap khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbTenDN, null);
            }
        }

        private void tbMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau.Text))
            {
                errorProvider.SetError(tbMatKhau, "Mat khau khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbMatKhau, null);
            }
        }

        private void tbTenDN_TextChanged(object sender, EventArgs e)
        {
            if ((tbTenDN.Text.Length > 0) == true)
            {
                btnDangNhap.Enabled = true;
            }
            else
            {
                btnDangNhap.Enabled = false;
            }
        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {
            if ((tbMatKhau.Text.Length > 0) == true)
            {
                btnDangNhap.Enabled = true;

            }
            else
            {
                btnDangNhap.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDangNhap.Enabled = false;
            tbTenDN.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string s = tbTenDN.Text;
            string conectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;

           

            string sqlTim = "select * from tblNhanVien where sTaiKhoan ='" + s + "'";
            string x = tbMatKhau.Text;
            string sqlTim1 = "select * from tblNhanVien where sMatKhau ='" + x + "'";

            using (SqlConnection sqlConnection = new SqlConnection(conectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from tblNhanVien where sTaiKhoan = '" + s + "'  and  sMatKhau ='" + x + "'", sqlConnection))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dt = new DataTable("tblNhanvien"))
                        {
                            ad.Fill(dt);
                            if (dt.Rows.Count == 0) {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Lỗi");
                                this.Show();
                            }
                            else
                            {
                                TrangChu trangChu = new TrangChu();
                                trangChu.TenNV1 = tbTenDN.Text;
                                trangChu.Show();
                                this.Hide();

                            }
                        }

                    }
                }
            }
 }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
 
