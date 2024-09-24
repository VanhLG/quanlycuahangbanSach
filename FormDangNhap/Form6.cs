using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class Form6 : Form

    {
        
        public string soHD;
        public string TenNV;
        public string tenDangNhap;
        public string maNV;
        String dt = DateTime.Now.ToString("dd/MM/yyyy");
        DateTime ngayLap = DateTime.Now;
        private DataTable tblCTHD = new DataTable("tblChiTietHD");
        double TongTien = 0;
        int soLuong = 0;
        ErrorProvider errorProvider = new ErrorProvider();
        public Form6()
        {
            InitializeComponent();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lbNV.Text = $"Nhân viên lập: {LoadTen()}";
            lbTime.Text = $"Thời gian lập: {dt}";
            hienKH();
            hienTenHang();
            hienGia();
            LoadDataToGridView1();

        }
     

        private DataTable layTenKH()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblKhachHang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tblKH");
                        ad.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienKH()
        {
            DataTable dt = layTenKH();
            DataView dataView = new DataView(dt);
            dataView.Sort = "sTenKH";
            cbTenKH.DataSource = dt;
            cbTenKH.DisplayMember = "sTenKH";
            cbTenKH.ValueMember = "sMaKH";
        }

        private DataTable layTenHang()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection cnn1 = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd1 = new SqlCommand("Select * from tblSach", cnn1))
                {
                    cmd1.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd1))
                    {
                        DataTable tb1 = new DataTable("tblSach");
                        ad.Fill(tb1);
                        return tb1;
                    }
                }
            }
        }
        private void hienTenHang()
        {
            DataTable dt1 = layTenHang();
            DataView dataView = new DataView(dt1);
            dataView.Sort = "sMaSach";
            cbTenHang.DataSource = dt1;
            cbTenHang.DisplayMember = "sTenSach";
            cbTenHang.ValueMember = "sMaSach";
        }

        private DataTable layGia()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection cnn1 = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd1 = new SqlCommand("Select * from tblSach where sTenSach = '" + cbTenHang.Text + "' ", cnn1))
                {
                    cmd1.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd1))
                    {
                        DataTable tb1 = new DataTable("tblSach");
                        ad.Fill(tb1);
                        return tb1;
                    }
                }
            }
        }
        private void hienGia()
        {
            DataTable dt1 = layGia();
            DataView dataView = new DataView(dt1);
            dataView.Sort = "sMaSach";
            
        }


        private void LoadDataToGridView1()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            tbGia.ReadOnly=true;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblChiTietHD where sMaHD='"+txtMaHD.Text+"'", connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        tblCTHD.Clear();
                        ad.Fill(tblCTHD);
                        dtChiTiet.DataSource = tblCTHD;

                    }
                }
            }
        }
        private object LoadTen()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Select sTenNV from tblNhanVien where sTaiKhoan='" + TenNV + "'", connection))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenNV);
                    tenDangNhap = (string)cmd.ExecuteScalar();
                }
                return tenDangNhap;
            }
        }
        private int LoadSL()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Select iSL from tblSach where sMaSach='" + cbTenHang.SelectedValue + "'", connection))
                {
                    cmd.Parameters.AddWithValue("@Soluong", nSl);
                    soLuong = (int)cmd.ExecuteScalar();
                }
                return soLuong;
            }
        }
        private object LoadMaNV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from tblNhanVien where sTaiKhoan='" + TenNV + "'", connection))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", TenNV);
                    maNV = (string)cmd.ExecuteScalar();
                }
                return maNV;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo kết nối đến cơ sở dữ liệu
            string connectionString = ConfigurationManager.ConnectionStrings["QLBanSach"].ConnectionString;
            string checkExistQuery = "SELECT COUNT(*) FROM tblHoaDon WHERE sMaHD = @MaHD";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();
                using (SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, connection))
                {
                    checkExistCommand.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    int count = (int)checkExistCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        // Thêm dữ liệu vào bảng Hóa đơn
                        using (SqlCommand command = new SqlCommand("INSERT INTO tblHoaDon (sMaHD, sMaNV, sMaKH, dNgayLap) VALUES (@MaHD, @MaNV, @MaKH, @NgayLap)", connection))
                        {
                            // Truyền giá trị vào tham số
                            command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                            command.Parameters.AddWithValue("@MaNV", LoadMaNV());
                            command.Parameters.AddWithValue("@MaKH", cbTenKH.SelectedValue);
                            command.Parameters.AddWithValue("@NgayLap", ngayLap);

                            // Thực thi lệnh
                            command.ExecuteNonQuery();
                        }
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(tblCTHD);
                                    //Thêm bản ghi vào DataTable
                                    DataRow newRow = tblCTHD.NewRow();
                                    newRow["sMaHD"] = txtMaHD.Text;
                                    newRow["sMaSach"] = cbTenHang.SelectedValue;
                                    newRow["sTenSach"] = cbTenHang.Text;
                                    newRow["iSl"] = nSl.Text;
                                    newRow["iTien"] = tbGia.Text;

                                    tblCTHD.Rows.Add(newRow);

                                    //Thêm bản ghi thông qua insertComand
                                    command.CommandText = "INSERT INTO tblChiTietHD(sMaHD, sMaSach, sTenSach, iSl, iTien) VALUES(@MaHD, @MaSach, @TenSach, @Sl, @Tien)";
                                    command.CommandType = CommandType.Text;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                                    command.Parameters.AddWithValue("@MaSach", cbTenHang.SelectedValue);
                                    command.Parameters.AddWithValue("@TenSach", cbTenHang.Text);
                                    command.Parameters.AddWithValue("@Sl", nSl.Text);
                                    command.Parameters.AddWithValue("@Tien", tbGia.Text);

                                    adapter.InsertCommand = command;
                                    adapter.Update(dataSet, "tblChiTietHD");
                                    dataSet.Tables.Clear();
                                    LoadDataToGridView1();

                                }
                            }
                        }
                    }
                    else
                    {
                        // Thêm dữ liệu vào bảng Chi tiết hóa đơn
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {

                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(tblCTHD);
                                    //Thêm bản ghi vào DataTable
                                    DataRow newRow = tblCTHD.NewRow();
                                    newRow["sMaHD"] = txtMaHD.Text;
                                    newRow["sMaSach"] = cbTenHang.SelectedValue;
                                    newRow["sTenSach"] = cbTenHang.Text;
                                    newRow["iSl"] = nSl.Text;
                                    newRow["iTien"] = tbGia.Text;

                                    tblCTHD.Rows.Add(newRow);

                                    //Thêm bản ghi thông qua insertComand
                                    command.CommandText = "INSERT INTO tblChiTietHD(sMaHD, sMaSach, sTenSach, iSl, iTien) VALUES(@MaHD, @MaSach, @TenSach, @Sl, @Tien)";
                                    command.CommandType = CommandType.Text;
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                                    command.Parameters.AddWithValue("@MaSach", cbTenHang.SelectedValue);
                                    command.Parameters.AddWithValue("@TenSach", cbTenHang.Text);
                                    command.Parameters.AddWithValue("@Sl", nSl.Text);
                                    command.Parameters.AddWithValue("@Tien", tbGia.Text);

                                    adapter.InsertCommand = command;
                                    adapter.Update(dataSet, "tblChiTietHD");
                                    dataSet.Tables.Clear();
                                    LoadDataToGridView1();
                                    
                                }
                            }
                        }
                    }
                }
            }
            soHD = txtMaHD.Text;
        }
        private void cbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item  = (DataRowView)cbTenHang.SelectedItem;
            tbGia.Text = item["iGia"].ToString();
        }

        private void dtChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double giaSanPham = double.Parse(dtChiTiet.Rows[e.RowIndex].Cells[3].Value.ToString());
                int soLuongSanPham = int.Parse(dtChiTiet.Rows[e.RowIndex].Cells[2].Value.ToString());
                double tongTienSanPham = giaSanPham * soLuongSanPham;
                dtChiTiet.Rows[e.RowIndex].Cells[4].Value = tongTienSanPham.ToString("N0");
                TongTien = 0;
                foreach (DataGridViewRow row in dtChiTiet.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        double thanhtien = double.Parse(row.Cells[4].Value.ToString());
                        TongTien += thanhtien;
                    }
                }

                lbTongTien.Text = $"Tổng tiền: {TongTien.ToString("N0")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void nSl1_Validating(object sender, CancelEventArgs e)
        {
           
                if (nSl != null && int.Parse(nSl.Text) > LoadSL())
                {
                    MessageBox.Show("Số lượng sách không được lớn hơn số sách trong kho");
                }
           
        }
        
        private void txtMaHD_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(txtMaHD, "Tên khách hàng không được để trống");
            }
            else
            {
                //e.Cancel=false;
                errorProvider.SetError(txtMaHD, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khách hàng đã thanh toán hóa đơn thành công!");
            this.Close();
            var trangchu = new TrangChu();
            trangchu.StartPosition = FormStartPosition.Manual;
            trangchu.Location = this.Location;
            trangchu.TenNV1 = TenNV;
            trangchu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            var form5 = new Form5();
            form5.StartPosition = FormStartPosition.Manual;
            form5.Location = this.Location;
            form5.tenNV2 = TenNV;
            form5.sohd = soHD;
            form5.Show();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            var trangchu = new TrangChu();
            trangchu.StartPosition = FormStartPosition.Manual;
            trangchu.Location = this.Location;
            trangchu.TenNV1 = TenNV;
            trangchu.Show();
        }

        private void tbGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void nSl_ValueChanged(object sender, EventArgs e)
        {

        }
        private void nSl_Validating(object sender, CancelEventArgs e)
        {

            if (nSl != null && int.Parse(nSl.Text) > 34)
            {
                MessageBox.Show("Số lượng sách không được lớn hơn số sách trong kho");
            }

        }
    }
}


        
    

