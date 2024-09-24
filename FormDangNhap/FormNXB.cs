using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class FormNXB : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
        private DataTable tb = new DataTable();
        public string tenNV;
        public FormNXB()
        {
            InitializeComponent();
        }

        private void FormNXB_Load(object sender, EventArgs e)
        {
            txbMaNXB.Focus();
            btnThem.Enabled = false;
            loadDataToGridView_dgvDSNXB();
        }

        private void txbMaNXB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaNXB.Text))
            {
                errorProvider.SetError(txbMaNXB, "Mã nhà xuất bản không được để trống!");
            }
            else
            {
                errorProvider.SetError(txbMaNXB, null);
            }
        }

        private void txbMaNXB_TextChanged(object sender, EventArgs e)
        {
            if ((txbMaNXB.Text.Length > 0) == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txbTenNXB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTenNXB.Text))
            {
                errorProvider.SetError(txbTenNXB, "Tên nhà xuất bản không được để trống!");
            }
            else
            {
                errorProvider.SetError(txbTenNXB, null);
            }
        }

        private void txbTenNXB_TextChanged(object sender, EventArgs e)
        {
            if ((txbTenNXB.Text.Length > 0) == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private bool IsNumber(string str)
        {
            foreach (Char ch in str)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private void txbSDT_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(txbSDT.Text))
            {
                btnThem.Enabled = false;
                errorProvider.SetError(txbSDT, "Số điện thoại không được chứa ký tự!");
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void loadDataToGridView_dgvDSNXB()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblNXB", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tb);
                        dgvDSNXB.DataSource = tb;
                    }
                }
            }
        }

        private void dgvDSNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaNXB.ReadOnly = true;
            DataGridViewRow row = this.dgvDSNXB.Rows[e.RowIndex];
            txbMaNXB.Text = row.Cells[0].Value.ToString();
            txbTenNXB.Text = row.Cells[1].Value.ToString();
            txbDiaChi.Text = row.Cells[2].Value.ToString();
            txbSDT.Text = row.Cells[3].Value.ToString();
        }

        private void Reset()
        {
            txbMaNXB.ReadOnly = false;
            txbMaNXB.Text = "";
            txbTenNXB.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
        }

        public bool KTTin_NXB()
        {
            if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbDiaChi.Focus();
                return false;
            }

            if (txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbSDT.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTTin_NXB())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "Insert_tblNXB";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@maNXB", txbMaNXB.Text);
                            cmd.Parameters.AddWithValue("@tenNXB", txbTenNXB.Text);
                            cmd.Parameters.AddWithValue("@diaChi", txbDiaChi.Text);
                            cmd.Parameters.AddWithValue("@sdt", txbSDT.Text);

                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            tb.Clear();
                            loadDataToGridView_dgvDSNXB();
                            Reset();
                            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Đã tồn tại mã nhà xuất bản " + txbMaNXB.Text);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaNXB.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà xuất bản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (KTTin_NXB())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "Update_tblNXB";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maNXB", txbMaNXB.Text);
                            cmd.Parameters.AddWithValue("@tenNXB", txbTenNXB.Text);
                            cmd.Parameters.AddWithValue("@diaChi", txbDiaChi.Text);
                            cmd.Parameters.AddWithValue("@sdt", txbSDT.Text);
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            tb.Clear();
                            loadDataToGridView_dgvDSNXB();
                            Reset();
                            MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbMaNXB.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã nhà xuất bản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbMaNXB.Focus();//để nhắc lại uể muốn xoá
                }
                else
                {
                    SqlConnection cnn = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
                    cmd.CommandText = "Delete_tblNXB";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNXB", txbMaNXB.Text);
                    cmd.Connection = cnn;
                    cnn.Open();
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                    Reset();
                    tb.Clear();
                    loadDataToGridView_dgvDSNXB();
                    MessageBox.Show("Đã xoá thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa nhà xuất bản có mã " + txbMaNXB.Text + " do có ràng buộc liên quan! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
                var trangchu = new TrangChu();
                trangchu.StartPosition = FormStartPosition.Manual;
                trangchu.Location = this.Location;
                trangchu.TenNV1 = tenNV;
                trangchu.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbMaNXB.Text) && String.IsNullOrEmpty(txbTenNXB.Text) && String.IsNullOrEmpty(txbDiaChi.Text))
            {
                MessageBox.Show("Cần nhập ít nhất 1 thông tin để tìm kiếm", "Thông báo");
            }
            else
            {
                string filterMaNXB = txbMaNXB.Text;
                string filterTenNXB = txbTenNXB.Text;
                string filterDiaChi = txbDiaChi.Text;

                DataView dtv = new DataView(tb);

                if (String.IsNullOrEmpty(filterMaNXB) && String.IsNullOrEmpty(filterTenNXB))
                {
                    dtv.RowFilter = string.Format($"sDiaChi LIKE '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterMaNXB) && String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($"sTenNXB LIKE '%{filterTenNXB}%'");
                }
                if (String.IsNullOrEmpty(filterDiaChi) && String.IsNullOrEmpty(filterTenNXB))
                {
                    dtv.RowFilter = string.Format($"sMaNXB LIKE '%{filterMaNXB}%'");
                }
                if (String.IsNullOrEmpty(filterMaNXB))
                {
                    dtv.RowFilter = string.Format($" sTenNXB like '%{filterTenNXB}%' and sDiaChi like '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterTenNXB))
                {
                    dtv.RowFilter = string.Format($" sMaNXB like '%{filterMaNXB}%' and sDiaChi like '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($" sMaNXB like '%{filterMaNXB}%' and sTenNXB like '%{filterTenNXB}%'");
                }
                dgvDSNXB.DataSource = dtv;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            tb.Clear();
            loadDataToGridView_dgvDSNXB();
        }

       
    }
}
