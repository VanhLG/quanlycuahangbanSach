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
    public partial class FormSach : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
        private DataTable dt = new DataTable();
        public string tenNV;
        public int soluong;
        public FormSach()
        {
            InitializeComponent();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            txbMaSach.Focus();
            //btnThem.Enabled = false;
            loadDataComboBox_MaNXB();
            loadDataToGridView_dgvDSSach();
        }

        /*private void txbMaSach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaSach.Text))
            {
                errorProvider.SetError(txbMaSach, "Mã sách không được để trống!");
            }
            else
            {
                errorProvider.SetError(txbMaSach, null);
            }
        }

        private void txbMaSach_TextChanged(object sender, EventArgs e)
        {
            if ((txbMaSach.Text.Length > 0) == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txbTenSach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTenSach.Text))
            {
                errorProvider.SetError(txbTenSach, "Tên sách không được để trống!");
            }
            else
            {
                errorProvider.SetError(txbTenSach, null);
            }
        }
        private void txbTenSach_TextChanged(object sender, EventArgs e)
        {
            if ((txbTenSach.Text.Length > 0) == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }*/
        private void loadDataComboBox_MaNXB()
        {
            string querySelect = "SELECT * FROM tblNXB";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = querySelect;
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tblNXB = new DataTable())
                        {
                            adapter.Fill(tblNXB);
                            if (tblNXB.Rows.Count > 0)
                            {
                                foreach (DataRow row in tblNXB.Rows)
                                {
                                    cbMaNXB.Items.Add(row["sMaNXB"]);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại bản ghi nào!");
                            }
                        }
                    }
                }
            }

        }

        private void loadDataToGridView_dgvDSSach()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblSach", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        dgvDSSach.DataSource = dt;
                    }
                }
            }
        }

        private void dgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDSSach.Rows[e.RowIndex];
            txbMaSach.Text = row.Cells[0].Value.ToString();
            txbTenSach.Text = row.Cells[1].Value.ToString();
            cbMaNXB.Text = row.Cells[2].Value.ToString();
            txbTacGia.Text = row.Cells[3].Value.ToString();
            txbTheLoai.Text = row.Cells[4].Value.ToString();
            txbGia.Text = row.Cells[5].Value.ToString();
        }

        private void Reset()
        {
            txbMaSach.ReadOnly = false;
            txbMaSach.Text = "";
            txbTenSach.Text = "";
            cbMaNXB.Text = "";
            txbTacGia.Text = "";
            txbTheLoai.Text = "";
            txbGia.Text = "";
        }

        public bool KTTin_Sach()
        {
            if (cbMaNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaNXB.Focus();
                return false;
            }

            if (txbTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTheLoai.Focus();
                return false;
            }

            if (txbTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTacGia.Focus();
                return false;
            }

            if (txbGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbGia.Focus();
                return false;
            }
            else if(int.Parse(txbGia.Text) == 0)
            {
                MessageBox.Show("Giá sách phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbGia.Focus();
                return false;
            }    
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTTin_Sach())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "Insert_tblSach";
                            cmd.CommandType = CommandType.StoredProcedure; 
                            cmd.Parameters.AddWithValue("@maSach", txbMaSach.Text);
                            cmd.Parameters.AddWithValue("@tenSach", txbTenSach.Text);
                            cmd.Parameters.AddWithValue("@maNXB", cbMaNXB.Text);
                            cmd.Parameters.AddWithValue("@tacGia", txbTacGia.Text);
                            cmd.Parameters.AddWithValue("@theLoai", txbTheLoai.Text);
                            cmd.Parameters.AddWithValue("@gia", txbGia.Text);

                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            dt.Clear();
                            loadDataToGridView_dgvDSSach();
                            Reset();
                            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch 
                {
                    MessageBox.Show("Đã tồn tại mã sách " + txbMaSach.Text);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txbMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaSach.Focus();
            }
            else if (KTTin_Sach())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "Update_tblSach";
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@maSach", txbMaSach.Text);
                            cmd.Parameters.AddWithValue("@tenSach", txbTenSach.Text);
                            cmd.Parameters.AddWithValue("@maNXB", cbMaNXB.Text);
                            cmd.Parameters.AddWithValue("@tacGia", txbTacGia.Text);
                            cmd.Parameters.AddWithValue("@theLoai", txbTheLoai.Text);
                            cmd.Parameters.AddWithValue("@gia", txbGia.Text);
                            cmd.Connection = con;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            dt.Clear();
                            loadDataToGridView_dgvDSSach();
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
                if (txbMaSach.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập mã sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbMaSach.Focus();//để nhắc lại uể muốn xoá
                }
                else
                {
                    SqlConnection cnn = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;

                    cmd.CommandText = "Delete_tblSach";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maSach", txbMaSach.Text);


                    cmd.Connection = cnn;
                    cnn.Open();
                    DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                    Reset();
                    dt.Clear();
                    loadDataToGridView_dgvDSSach();
                    MessageBox.Show("Đã xoá thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa sách có mã " + txbMaSach.Text + " do có ràng buộc liên quan! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbMaSach.Text) && String.IsNullOrEmpty(txbTenSach.Text) && String.IsNullOrEmpty(cbMaNXB.Text))
            {
                MessageBox.Show("Cần nhập ít nhất 1 thông tin để tìm kiếm", "Thông báo");
            }
            else
            {
                string filterMaSach = txbMaSach.Text;
                string filterTenSach = txbTenSach.Text;
                string filterMaNXB = cbMaNXB.Text;

                DataView dtv = new DataView(dt);

                if (String.IsNullOrEmpty(filterMaSach) && String.IsNullOrEmpty(filterTenSach))
                {
                    dtv.RowFilter = string.Format($"sMaNXB LIKE '%{filterMaNXB}%'");
                }
                if (String.IsNullOrEmpty(filterMaSach) && String.IsNullOrEmpty(filterMaNXB))
                {
                    dtv.RowFilter = string.Format($"sTenSach LIKE '%{filterTenSach}%'");
                }
                if (String.IsNullOrEmpty(filterMaNXB) && String.IsNullOrEmpty(filterTenSach))
                {
                    dtv.RowFilter = string.Format($"sMaSach LIKE '%{filterMaSach}%'");
                }
                if (String.IsNullOrEmpty(filterMaSach))
                {
                    dtv.RowFilter = string.Format($" sTenSach like '%{filterTenSach}%' and sMaNXB like '%{filterMaNXB}%'");
                }
                if (String.IsNullOrEmpty(filterTenSach))
                {
                    dtv.RowFilter = string.Format($" sMaSach like '%{filterMaSach}%' and sMaNXB like '%{filterMaNXB}%'");
                }
                if (String.IsNullOrEmpty(filterMaNXB))
                {
                    dtv.RowFilter = string.Format($" sMaSach like '%{filterMaSach}%' and sTenSach like '%{filterTenSach}%'");
                }
                dgvDSSach.DataSource = dtv;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            dt.Clear();
            loadDataToGridView_dgvDSSach();
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

        private void txbMaSach_Click(object sender, EventArgs e)
        {
            if(txbMaSach.Text==null)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu", "Lỗi");
            }    
        }

        private void txbGia_Click(object sender, EventArgs e)
        {
            if(int.Parse(txbGia.Text)==0)
            {
                MessageBox.Show("Giá phải lớn hơn 0");
            }    
        }
    }
}
