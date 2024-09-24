using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class FormNV : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        private DataTable tblDSNV = new DataTable("tblNhanVien");
        private DataView dataView_tblNhanVien = new DataView();

        private bool CheckKhoaChinh;
        private bool GioiTinh;
        public string tenNV;
        string connectionstring = @"Data Source=DESKTOP-KMNS09Q;Initial Catalog=QLBanSach;Integrated Security=True";
        public FormNV()
        {
            InitializeComponent();
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoaBo.Enabled = false;
            tbMaNV.Focus();
            LoadDataToGridView();

        }

        //Kiem tra ma nhan vien khong duoc de trong
        private void tbMaNV_TextChanged(object sender, EventArgs e)
        {
            if ((tbMaNV.Text.Length > 0) == true)
            {
                btnThemMoi.Enabled = true;
            }
            else
            {
                btnThemMoi.Enabled = false;
            }
            //Kiem tra khoa chinh
            foreach (DataRow row in tblDSNV.Rows)
            {
                if (row["sMaNV"].ToString() == tbMaNV.Text.ToString())
                {
                    tbMaNV.ReadOnly = true;
                    tbTenNV.Text = row["sTenNV"].ToString();
                    dtNgaySinh.Value = (DateTime)row["dNgaySinh"];
                    if ((string)row["sGioiTinh"] == "Nam")
                    {
                        rb_nam.Checked = true;
                    }
                    else
                    {
                        rb_nu.Checked = true;
                    }
                    tbQueQuan.Text = row["sQueQuan"].ToString();
                    tbSDT.Text = row["sSDT"].ToString();
                    tbTenCV.Text = row["sTenCV"].ToString();
                    tbTaiKhoan.Text = row["sTaiKhoan"].ToString();
                    tbMatKhau.Text = row["sMatKhau"].ToString();
                    tbLuongCB.Text = row["iLuongCB"].ToString();
                    tbHSL.Text = row["fHSL"].ToString();
                    tbPC.Text = row["iPC"].ToString();

                    btnChinhSua.Enabled = true;
                    btnXoaBo.Enabled = true;

                }
            }
        }

        //Hien canh bao ma nhan vien khong duoc de trong
        private void tbMaNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaNV.Text))
            {

                //e.Cancel = true;
                errorProvider.SetError(tbMaNV, "Mã nhân viên không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tbMaNV, null);
            }
        }

        //Hien canh bao ten nhan vien khong duoc de trong
        private void TenNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenNV.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tbTenNV, "Tên nhân viên không được để trống");
            }
            else
            {
                //e.Cancel=false;
                errorProvider.SetError(tbTenNV, null);
            }
        }

        //Kiem tra ho ten nhan vien khong duoc de trong thi moi hien nut them moi
        private void TenNV_TextChanged(object sender, EventArgs e)
        {
            if ((tbTenNV.Text.Length > 0) == true)
            {
                btnThemMoi.Enabled = true;
            }
            else
            {
                btnThemMoi.Enabled = false;
            }
        }

        //Ham kiem tra xem ki tu vua nhap co phai la kieu so khong
        private bool IsNumber(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        //Kiem tra SDT ko duoc chua ki tu
        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(tbSDT.Text) == false)
            {
                btnThemMoi.Enabled = false;
                errorProvider.SetError(tbSDT, "Số điện thoại không được để kí tự");
            }
            else
            {
                btnThemMoi.Enabled = true;
                errorProvider.SetError(tbSDT, null);
            }
        }

        //Ham kiem tra SDT ko duoc de trong
        private void tbSDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSDT.Text) == true)
            {
                errorProvider.SetError(tbSDT, "SDT nhân viên không được để trống");
            }
            else
            {
                errorProvider.SetError(tbSDT, null);
            }
        }

        //Kiem tra Luong co ban ko duoc chua ki tu
        private void tbLuongCB_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(tbLuongCB.Text) == false)
            {
                btnThemMoi.Enabled = false;
                errorProvider.SetError(tbLuongCB, "Lương cơ bán không được để kí tự");
            }
            else
            {
                btnThemMoi.Enabled = true;
                errorProvider.SetError(tbSDT, null);
            }
        }

        //Ham kiem tra Luong co ban ko duoc de trong
        private void tbLuongCB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLuongCB.Text) == true)
            {
                errorProvider.SetError(tbLuongCB, "Lương cơ bản không được để trống");
            }
            else
            {
                errorProvider.SetError(tbSDT, null);
            }
        }

        //Ham kiem tra HSL ko duoc de trong
        private void tbHSL_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbHSL.Text) == true)
            {
                errorProvider.SetError(tbHSL, "Hệ số lương không được để trống");
            }
            else
            {
                errorProvider.SetError(tbHSL, null);
            }
        }

        //Kiem tra phu cap ko duoc chua ki tu
        private void tbPC_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(tbPC.Text) == false)
            {
                btnThemMoi.Enabled = false;
                errorProvider.SetError(tbPC, "Phụ cấp không được để kí tự");
            }
            else
            {
                btnThemMoi.Enabled = true;
                errorProvider.SetError(tbPC, null);
            }
        }

        //Ham kiem tra phu cap ko duoc de trong
        private void tbPC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPC.Text) == true)
            {
                errorProvider.SetError(tbPC, "Phụ cấp không được để trống");
            }
            else
            {
                errorProvider.SetError(tbPC, null);
            }
        }

        //Hien canh bao tai khoan khong duoc de trong
        private void tbTenCV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenCV.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tbTenCV, "Tên công việc không được để trống");
            }
            else
            {
                //e.Cancel=false;
                errorProvider.SetError(tbTenCV, null);
            }
        }

        //Hien canh bao tai khoan khong duoc de trong
        private void tbTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTaiKhoan.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tbTaiKhoan, "Tài khoản không được để trống");
            }
            else
            {
                //e.Cancel=false;
                errorProvider.SetError(tbTaiKhoan, null);
            }
        }

        //Hien canh bao mat khau khong duoc de trong
        private void tbMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tbMatKhau, "Mật khẩu không được để trống");
            }
            else
            {
                //e.Cancel=false;
                errorProvider.SetError(tbMatKhau, null);
            }
        }

        //Load các thống tin trong cơ sở dữ liệu lên GridView
        private void LoadDataToGridView()
        {
            string querySelect = "Select * from tblNhanVien";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = querySelect;
                    command.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = command;
                        tblDSNV.Clear();
                        adapter.Fill(tblDSNV);
                        if (tblDSNV.Rows.Count > 0)
                        {
                            dataView_tblNhanVien = tblDSNV.DefaultView;
                            dgv_dsnv.AutoGenerateColumns = false;
                            dgv_dsnv.DataSource = dataView_tblNhanVien;
                        }
                        else
                        {
                            MessageBox.Show("Khong ton tai ban ghi nao");
                        }

                    }
                }
            }
        }

        //Sự kiện xử lý hiện thông tin tương ứng khi click chuột vào trong Cell của GridView
        private void dgv_dsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaNV.ReadOnly = true;
            DataGridViewRow row = this.dgv_dsnv.Rows[e.RowIndex];
            tbMaNV.Text = row.Cells[0].Value.ToString();
            tbTenNV.Text = row.Cells[1].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value);
            bool gioiTinh;
            if (Boolean.TryParse(row.Cells[3].Value.ToString(), out gioiTinh))
            {
                if (gioiTinh == true)
                {
                    rb_nam.Checked = true;
                }
                else
                {
                    rb_nu.Checked = true;
                }
            }
            tbQueQuan.Text = row.Cells[4].Value.ToString();
            tbSDT.Text = row.Cells[5].Value.ToString();
            tbLuongCB.Text = row.Cells[6].Value.ToString();
            tbHSL.Text = row.Cells[7].Value.ToString();
            tbPC.Text = row.Cells[8].Value.ToString();
            tbTenCV.Text = row.Cells[9].Value.ToString();
            tbTaiKhoan.Text = row.Cells[10].Value.ToString();
            tbMatKhau.Text = row.Cells[11].Value.ToString();
        }

        //Sự kiện thêm mới nhân viên
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if (rb_nam.Checked == true)
            {
                GioiTinh = true;
            }
            else if (rb_nu.Checked == true)
            {
                GioiTinh = false;
            }
            //phương thức kiểm tra sự tồn tại của khóa chính 
            //...
            foreach (DataRow row in tblDSNV.Rows)
            {
                if (tbMaNV.Text.ToString() == row["sMaNV"].ToString())
                {
                    CheckKhoaChinh = true;
                    MessageBox.Show("Nhan vien da ton tai");
                    break;
                }
                else
                {
                    CheckKhoaChinh = false;
                }
            }

            //Thêm dữ liệu mới vào CSDL theo pp ngắt kết nối
            if (CheckKhoaChinh == false)
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.ConnectionString = connectionstring;
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {

                            using (DataSet dataSet = new DataSet())
                            {
                                dataSet.Tables.Add(tblDSNV);

                                //Thêm bản ghi vào DataTable
                                DataRow newRow = tblDSNV.NewRow();
                                newRow["sMaNV"] = tbMaNV.Text;
                                newRow["sTenNV"] = tbTenNV.Text;
                                newRow["dNgaySinh"] = dtNgaySinh.Value.ToString("yyyy/MM/dd");
                                newRow["sGioiTinh"] = GioiTinh;
                                newRow["sQueQuan"] = tbQueQuan.Text;
                                newRow["sSDT"] = tbSDT.Text;
                                newRow["iLuongCB"] = tbLuongCB.Text;
                                newRow["fHSL"] = tbHSL.Text;
                                newRow["iPC"] = tbPC.Text;
                                newRow["sTenCV"] = tbTenCV.Text;
                                newRow["sTaiKhoan"] = tbTaiKhoan.Text;
                                newRow["sMatKhau"] = tbMatKhau.Text;

                                tblDSNV.Rows.Add(newRow);

                                //Thêm bản ghi thông qua insertComand
                                command.CommandText = "insert into tblNhanVien (sMaNV,sTenNV,dNgaySinh,sGioiTinh,sQueQuan,sSDT,iLuongCB,fHSL,iPC,sTenCV,sTaiKhoan,sMatKhau) " +
                                    "values (@MaNV,@TenNV,@NgaySinh,@GioiTinh,@QueQuan,@SDT,@LuongCB,@HSL,@PC,@TenCV,@TaiKhoan,@MatKhau)";
                                command.CommandType = CommandType.Text;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                                command.Parameters.AddWithValue("@TenNV", tbTenNV.Text);
                                command.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.ToString("yyyy/MM/dd"));
                                if (rb_nam.Checked == true)
                                {
                                    command.Parameters.AddWithValue("@GioiTinh", "Nam");
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@GioiTinh", "Nữ");
                                }
                                command.Parameters.AddWithValue("@QueQuan", tbQueQuan.Text);
                                command.Parameters.AddWithValue("@SDT", tbSDT.Text);
                                command.Parameters.AddWithValue("@LuongCB", tbLuongCB.Text);
                                command.Parameters.AddWithValue("@HSL", tbHSL.Text);
                                command.Parameters.AddWithValue("@PC", tbPC.Text);
                                command.Parameters.AddWithValue("@TenCV", tbTenCV.Text);
                                command.Parameters.AddWithValue("@TaiKhoan", tbTaiKhoan.Text);
                                command.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);

                                adapter.InsertCommand = command;
                                adapter.Update(dataSet, "tblNhanVien");

                                MessageBox.Show("Them moi thanh cong");
                                dataSet.Tables.Clear();
                                LoadDataToGridView();

                            }
                        }
                    }
                }
            }
        }

        //Hàm đưa tất cả dữ liệu về ban đầu
        public void Resert()
        {
            tbTenNV.Clear();
            tbMaNV.Clear();
            tbMaNV.ReadOnly = false;
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            tbQueQuan.Clear();
            tbSDT.Clear();
            tbLuongCB.Clear();
            tbHSL.Clear();
            tbPC.Clear();
            tbTenCV.Clear();
            tbTaiKhoan.Clear();
            tbMatKhau.Clear();

            btnChinhSua.Enabled = false;
            btnXoaBo.Enabled = false;
            btnThemMoi.Enabled = false;
        }

        //Xử lý sự kiện cho nút đặt lại
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            Resert();
        }

        //Xử lý sự kiện chỉnh sửa
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.ConnectionString = connectionstring;
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {

                        using (DataSet dataSet = new DataSet())
                        {

                            dataSet.Tables.Add(tblDSNV);
                            int index = 0;
                            foreach (DataRow row in tblDSNV.Rows)
                            {
                                if (row["sMaNV"].ToString() == tbMaNV.Text.ToString())
                                {
                                    break;
                                }
                                else index++;
                            }

                            tblDSNV.Rows[index]["sTenNV"] = tbTenNV.Text;
                            tblDSNV.Rows[index]["dNgaySinh"] = dtNgaySinh.Value.ToString("yyyy/MM/dd");
                            tblDSNV.Rows[index]["sGioiTinh"] = GioiTinh;
                            tblDSNV.Rows[index]["sQueQuan"] = tbQueQuan.Text;
                            tblDSNV.Rows[index]["sSDT"] = tbSDT.Text;
                            tblDSNV.Rows[index]["iLuongCB"] = tbLuongCB.Text;
                            tblDSNV.Rows[index]["fHSL"] = tbHSL.Text;
                            tblDSNV.Rows[index]["iPC"] = tbPC.Text;
                            tblDSNV.Rows[index]["sTenCV"] = tbTenCV.Text;
                            tblDSNV.Rows[index]["sTaiKhoan"] = tbTaiKhoan.Text;
                            tblDSNV.Rows[index]["sMatKhau"] = tbMatKhau.Text;
                            //Chỉnh sửa bản ghi thông qua UpdateComand
                            command.CommandText = "update tblNhanVien set sTenNV=@TenNV,dNgaySinh=@NgaySinh,sGioiTinh=@GioiTinh,sQueQuan=@QueQuan,sSDT=@SDT,iLuongCB=@LuongCB,fHSL=@HSL,iPC=@PC,sTenCV=@TenCV,sTaiKhoan=@TaiKhoan,sMatKhau=@MatKhau" +
                                    " where sMaNV=@MaNV";
                            command.CommandType = CommandType.Text;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                            command.Parameters.AddWithValue("@TenNV", tbTenNV.Text);
                            command.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value.ToString("yyyy/MM/dd"));
                            if (rb_nam.Checked == true)
                            {
                                command.Parameters.AddWithValue("@GioiTinh", "Nam");
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@GioiTinh", "Nữ");
                            }
                            command.Parameters.AddWithValue("@QueQuan", tbQueQuan.Text);
                            command.Parameters.AddWithValue("@SDT", tbSDT.Text);
                            command.Parameters.AddWithValue("@LuongCB", tbLuongCB.Text);
                            command.Parameters.AddWithValue("@HSL", tbHSL.Text);
                            command.Parameters.AddWithValue("@PC", tbPC.Text);
                            command.Parameters.AddWithValue("@TenCV", tbTenCV.Text);
                            command.Parameters.AddWithValue("@TaiKhoan", tbTaiKhoan.Text);
                            command.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);

                            adapter.UpdateCommand = command;
                            adapter.Update(dataSet, "tblNhanVien");

                            MessageBox.Show("Chỉnh sửa thành công");
                            dataSet.Tables.Clear();
                            LoadDataToGridView();

                        }
                    }
                }
            }
        }

        private void btnXoaBo_Click(object sender, EventArgs e)
        {
            //Cách 2: Bắt lỗi ngoại lệ trực tiếp trong catch
            int index = dgv_dsnv.CurrentRow.Index;
            string maNV = dataView_tblNhanVien[index]["sMaNV"].ToString();

            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Co muon xoa ma nhan vien " + maNV + "  khong?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                if (dialog_delete == DialogResult.Yes)
                {
                    //Cách 1: kiểm tra thông qua ràng buộc giữa các bảng
                    //KiemTraRangBuoc_tblHoaDon(maNV);

                    //thuc hien xoa
                    string deleteQuery = "Delete_tblNhanVien";
                    using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //lay danh sach nhan vien vao DataTable
                            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblNhanVien", sqlConnection);
                            DataTable dt_tblNhanVien = new DataTable("tblNhanVien");
                            adapter.Fill(dt_tblNhanVien);

                            //add cac datatable vao dataset
                            DataSet ds = new DataSet();
                            ds.Tables.Add(dt_tblNhanVien);

                            //tim maNV can xoa
                            dt_tblNhanVien.PrimaryKey = new DataColumn[] { dt_tblNhanVien.Columns["sMaNV"] };
                            DataRow dataRow = dt_tblNhanVien.Rows.Find(maNV);
                            dataRow.Delete();

                            //xoa trong DB 
                            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                            {
                                sqlCommand.CommandText = deleteQuery;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.Parameters.AddWithValue("@maNV", maNV);

                                adapter.DeleteCommand = sqlCommand;
                                adapter.Update(ds, "tblNhanVien");
                            }
                        }
                    }
                    LoadDataToGridView();
                }
                else
                {
                    return;
                }
            }/*
            catch (SqlException sql)
            {
                string errorSql = sql.Message;
                if (errorSql.Contains("40"))
                {
                    MessageBox.Show("Sql server bị ngắt kết nối");
                }
            }*/
            catch (Exception ex)
            {
                string errorStr = ex.Message;
                /*if ((ex is SqlException) && errorStr.Contains("40"))
                {
                    MessageBox.Show("Đã có lỗi xảy ra ở sql server");
                }
                else*/
                    if (errorStr.Contains("FK__tblHoaDon__sMaNV__4E88ABD4"))
                {
                    MessageBox.Show("Ràng buộc: Mã nhân viên " + maNV +
                            " có phát sinh hóa đơn, không xoá được!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbMaNV.Text) && String.IsNullOrEmpty(tbTenNV.Text) && String.IsNullOrEmpty(tbQueQuan.Text))
            {
                MessageBox.Show("Cần nhập ít nhất 1 thông tin để tìm kiếm", "Thông báo");
            }
            else
            {
                string filterMaNV = tbMaNV.Text;
                string filterTenNV = tbTenNV.Text;
                string filterQueQuan = tbQueQuan.Text;
                DataView dtv = new DataView(tblDSNV);

                if (String.IsNullOrEmpty(filterMaNV) && String.IsNullOrEmpty(filterTenNV))
                {
                    dtv.RowFilter = string.Format($"sQueQuan like '%{filterQueQuan}%'");
                }
                if (String.IsNullOrEmpty(filterMaNV) && String.IsNullOrEmpty(filterQueQuan))
                {
                    dtv.RowFilter = string.Format($" sTenNV like '%{filterTenNV}%'");
                }
                if (String.IsNullOrEmpty(filterTenNV) && String.IsNullOrEmpty(filterQueQuan))
                {
                    dtv.RowFilter = string.Format($"sMaNV like '%{filterMaNV}%'");
                }
                if (String.IsNullOrEmpty(filterMaNV))
                {
                    dtv.RowFilter = string.Format($" sTenNV like '%{filterTenNV}%' and sQueQuan like '%{filterQueQuan}%'");
                }
                if (String.IsNullOrEmpty(filterQueQuan))
                {
                    dtv.RowFilter = string.Format($"sMaNV like '%{filterMaNV}%' and sTenNV like '%{filterTenNV}%'");
                }
                if (String.IsNullOrEmpty(filterTenNV))
                {
                    dtv.RowFilter = string.Format($"sMaNV like '%{filterMaNV}%' and sQueQuan like '%{filterQueQuan}%'");
                }
                dgv_dsnv.DataSource = dtv;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                var trangchu = new TrangChu();
                trangchu.StartPosition = FormStartPosition.Manual;
                trangchu.Location = this.Location;
                trangchu.TenNV1 = tenNV;
                trangchu.Show();
            }
        }
    }
}
