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
    public partial class ThayDoiMatKhau : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public string tenNV;
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }
        private void ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            tbTenDN1.Focus();
        }


        private void tbTenDN1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenDN1.Text))
            {
                errorProvider1.SetError(tbTenDN1, "Ten dang nhap khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTenDN1, null);
            }
        }
        private void tbMatKhau1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau1.Text))
            {
                errorProvider1.SetError(tbMatKhau1, "Mat khau khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbMatKhau1, null);
            }
        }
        private void tbTenDN1_TextChanged(object sender, EventArgs e)
        {
            if ((tbTenDN1.Text.Length > 0) == true)
            {
                btnCapNhat.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }
        private void tbMatKhau1_TextChanged(object sender, EventArgs e)
        {
            if ((tbMatKhau1.Text.Length > 0) == true)
            {
                btnCapNhat.Enabled = true;

            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }

        private void tbNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if((tbNhapLaiMatKhau.Text.Length > 0) == true)
            {
                btnCapNhat.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }
        private void tbNhapLaiMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau1.Text))
            {
                errorProvider1.SetError(tbNhapLaiMatKhau, "Mat khau khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNhapLaiMatKhau, null);
            }
        }

        private void tbTenDN1_TextChanged_1(object sender, EventArgs e)
        {
            {
                if ((tbTenDN1.Text.Length > 0) == true)
                {
                    btnCapNhat.Enabled = true;
                }
                else
                {
                    btnCapNhat.Enabled = false;
                }
            }
        }

        private void tbMatKhau1_TextChanged_1(object sender, EventArgs e)
        {
            {
                if ((tbMatKhau1.Text.Length > 0) == true)
                {
                    btnCapNhat.Enabled = true;
                }
                else
                {
                    btnCapNhat.Enabled = false;
                }
            }
        }

        private void tbMatKhau1_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau1.Text))
            {
                errorProvider1.SetError(tbMatKhau1, "Mat khau khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbMatKhau1, null);
            }
        }

        private void tbTenDN1_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenDN1.Text))
            {
                errorProvider1.SetError(tbTenDN1, "Ten dang nhap khong duoc de trong");
            }
            else
            {
                errorProvider1.SetError(tbTenDN1, null);
            }
        }

        private void tbNhapLaiMatKhau_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau1.Text))
            {
                errorProvider1.SetError(tbNhapLaiMatKhau, "Mat khau khong duoc de trong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNhapLaiMatKhau, null);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string s = tbTenDN1.Text;
            string conectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            string sqlTim = "select * from tblNhanVien where sTaiKhoan ='" + s + "'";
          

            using (SqlConnection sqlConnection = new SqlConnection(conectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from tblNhanVien where sTaiKhoan = '" + s + "' ", sqlConnection))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dt = new DataTable("tblNhanvien"))
                        {

                            ad.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Tên đăng nhập không tồn tại", "Lỗi");
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Thay đổi mật khẩu thành công. Mời đăng nhập lại", "Thông báo");
                                DoiMK();
                                DangNhap f = new DangNhap();
                                f.Show();
                                this.Close();
                            }
                        }

                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var trangchu = new TrangChu();
            trangchu.StartPosition = FormStartPosition.Manual;
            trangchu.Location = this.Location;
            trangchu.TenNV1 = tenNV;
            trangchu.Show();
        }
        private void DoiMK()
        {
            string conectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection sqlConnection1 = new SqlConnection(conectionString))
            {
                using (SqlCommand command = sqlConnection1.CreateCommand())
                {
                    command.CommandText = "prDoiMK";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taikhoan", tbTenDN1.Text);
                    command.Parameters.AddWithValue("@matkhau", tbMatKhau1.Text);
                    sqlConnection1.Open();
                    command.ExecuteNonQuery();
                    //MessageBox.Show(i.ToString());
                    sqlConnection1.Close();


                }

            }
        }

    }




}
