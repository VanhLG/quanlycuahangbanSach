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
    public partial class FormKH : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        private DataTable tblDSKH = new DataTable("tblKhachHang");
        private DataView dataView_tblKhachHang = new DataView();
        public string tenNV;
        bool CheckKhoaChinh;
        string connectionstring = @"Data Source=DESKTOP-KMNS09Q;Initial Catalog=QLBanSach;Integrated Security=True";

        public FormKH()
        {
            InitializeComponent();
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = false;
            btnChinhSua.Enabled = false;
            btnXoaBo.Enabled = false;
            tbMaKH.Focus();
            LoadDataToGridView();
        }

        //Kiem tra ma khach hang khong duoc de trong
        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {
            if ((tbMaKH.Text.Length > 0) == true)
            {
                btnThemMoi.Enabled = true;
            }
            else
            {
                btnThemMoi.Enabled = false;
            }
            //Kiem tra khoa chinh
            foreach (DataRow row in tblDSKH.Rows)
            {
                if (row["sMaKH"].ToString() == tbMaKH.Text.ToString())
                {
                    tbMaKH.ReadOnly = true;
                    tbTenKH.Text = row["sTenKH"].ToString();
                    tbDiaChi.Text = row["sDiaChi"].ToString();
                    tbSDT.Text = row["sSDT"].ToString();

                    btnChinhSua.Enabled = true;
                    btnXoaBo.Enabled = true;
                }
            }
        }

        //Hien canh bao ma khach hang khong duoc de trong
        private void tbMaKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaKH.Text))
            {

                //e.Cancel = true;
                errorProvider.SetError(tbMaKH, "Mã khách hàng không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tbMaKH, null);
            }
        }

        //Hien canh bao ten khach hang khong duoc de trong
        private void TenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenKH.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tbTenKH, "Tên khách hàng không được để trống");
            }
            else
            {
                //e.Cancel=false;
                errorProvider.SetError(tbTenKH, null);
            }
        }

        //Kiem tra ho ten nhan vien khong duoc de trong
        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            if ((tbTenKH.Text.Length > 0) == true)
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
                errorProvider.SetError(tbSDT, "SDT không được để kí tự");
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
                errorProvider.SetError(tbSDT, "SDT khách hàng không được để trống");
            }
            else
            {
                errorProvider.SetError(tbSDT, null);
            }
        }

        //Load các thống tin trong cơ sở dữ liệu lên GridView
        private void LoadDataToGridView()
        {
            string querySelect = "Select * from tblKhachHang";
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
                        tblDSKH.Clear();
                        adapter.Fill(tblDSKH);
                        if (tblDSKH.Rows.Count > 0)
                        {
                            dataView_tblKhachHang = tblDSKH.DefaultView;
                            dgv_dskh.AutoGenerateColumns = false;
                            dgv_dskh.DataSource = dataView_tblKhachHang;
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
        private void dgv_dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaKH.ReadOnly = true;
            DataGridViewRow row = this.dgv_dskh.Rows[e.RowIndex];
            tbMaKH.Text = row.Cells[0].Value.ToString();
            tbTenKH.Text = row.Cells[1].Value.ToString();
            tbDiaChi.Text = row.Cells[2].Value.ToString();
            tbSDT.Text = row.Cells[3].Value.ToString();
        }

        //Sự kiện thêm mới khách hàng
        private void btThemMoi_Click(object sender, EventArgs e)
        {
            //phương thức kiểm tra sự tồn tại của khóa chính 
            //...
            foreach (DataRow row in tblDSKH.Rows)
            {
                if (tbMaKH.Text.ToString() == row["sMaKH"].ToString())
                {
                    CheckKhoaChinh = true;
                    MessageBox.Show("Khach hang da ton tai");
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
                                dataSet.Tables.Add(tblDSKH);

                                //Thêm bản ghi vào DataTable
                                DataRow newRow = tblDSKH.NewRow();
                                newRow["sMaKH"] = tbMaKH.Text;
                                newRow["sTenKH"] = tbTenKH.Text;
                                newRow["sDiaChi"] = tbDiaChi.Text;
                                newRow["sSDT"] = tbSDT.Text;

                                tblDSKH.Rows.Add(newRow);

                                //Thêm bản ghi thông qua insertComand
                                command.CommandText = "insert into tblKhachHang (sMaKH,sTenKH,sDiaChi,sSDT) " +
                                    "values (@MaKH,@TenKH,@DiaChi,@SDT)";
                                command.CommandType = CommandType.Text;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@MaKH", tbMaKH.Text);
                                command.Parameters.AddWithValue("@TenKH", tbTenKH.Text);
                                command.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
                                command.Parameters.AddWithValue("@SDT", tbSDT.Text);

                                adapter.InsertCommand = command;
                                adapter.Update(dataSet, "tblKhachHang");

                                MessageBox.Show("Them moi thanh cong");
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
            tbTenKH.Clear();
            tbMaKH.Clear();
            tbMaKH.ReadOnly = false;
            tbDiaChi.Clear();
            tbSDT.Clear();

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

                            dataSet.Tables.Add(tblDSKH);
                            int index = 0;
                            foreach (DataRow row in tblDSKH.Rows)
                            {
                                if (row["sMaKH"].ToString() == tbMaKH.Text.ToString())
                                {
                                    break;
                                }
                                else index++;
                            }

                            tblDSKH.Rows[index]["sTenKH"] = tbTenKH.Text;
                            tblDSKH.Rows[index]["sDiaChi"] = tbDiaChi.Text;
                            tblDSKH.Rows[index]["sSDT"] = tbSDT.Text;

                            //Chỉnh sửa bản ghi thông qua UpdateComand
                            command.CommandText = " update tblKhachHang set sTenKH=@TenKH,sDiaChi=@DiaChi,sSDT=@SDT " +
                                    " where sMaKH=@MaKH";
                            command.CommandType = CommandType.Text;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@MaKH", tbMaKH.Text);
                            command.Parameters.AddWithValue("@TenKH", tbTenKH.Text);
                            command.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
                            command.Parameters.AddWithValue("@SDT", tbSDT.Text);

                            adapter.UpdateCommand = command;
                            adapter.Update(dataSet, "tblKhachHang");

                            MessageBox.Show("Chỉnh sửa thành công");
                            dataSet.Tables.Clear();
                            LoadDataToGridView();

                        }
                    }
                }
            }
        }
        /*
        //Xử lí sự kiện xóa
        private void btnXoaBo_Click(object sender, EventArgs e)
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
                            dataSet.Tables.Add(tblDSKH);
                            int index = 0;
                            foreach (DataRow row in tblDSKH.Rows)
                            {
                                if (row["sMaKH"].ToString() == tbMaKH.Text.ToString())
                                {
                                    break;
                                }
                                else index++;
                            }

                            var deleteRow = tblDSKH.Rows[index];
                            deleteRow.Delete();

                            //Xóa bản ghi thông qua DeleteComand
                            command.CommandText = " delete from tblKhachHang where sMaKH=@MaKH ";
                            command.CommandType = CommandType.Text;
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@MaKH", tbMaKH.Text);

                            adapter.DeleteCommand = command;
                            adapter.Update(dataSet, "tblKhachHang");

                            MessageBox.Show("Xóa thành công");
                            dataSet.Tables.Clear();
                            LoadDataToGridView();

                        }
                    }
                }
            }
            Resert();
        }
        */

        private void btnXoaBo_Click(object sender, EventArgs e)
        {
            //Cách 2: Bắt lỗi ngoại lệ trực tiếp trong catch
            int index = dgv_dskh.CurrentRow.Index;
            string maKH = dataView_tblKhachHang[index]["sMaKH"].ToString();

            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Co muon xoa ma khach hang " + maKH + "  khong?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                if (dialog_delete == DialogResult.Yes)
                {
                    //Cách 1: kiểm tra thông qua ràng buộc giữa các bảng
                    //KiemTraRangBuoc_tblDIEM(maSV);

                    //thuc hien xoa
                    string deleteQuery = "Delete_tblKhachHang";
                    using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //lay danh sach KH vao DataTable
                            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblKhachHang", sqlConnection);
                            DataTable dt_tblKhachHang = new DataTable("tblKhachHang");
                            adapter.Fill(dt_tblKhachHang);

                            //add cac datatable vao dataset
                            DataSet ds = new DataSet();
                            ds.Tables.Add(dt_tblKhachHang);

                            //tim maNV can xoa
                            dt_tblKhachHang.PrimaryKey = new DataColumn[] { dt_tblKhachHang.Columns["sMaKH"] };
                            DataRow dataRow = dt_tblKhachHang.Rows.Find(maKH);
                            dataRow.Delete();

                            //xoa trong DB 
                            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                            {
                                sqlCommand.CommandText = deleteQuery;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.Parameters.AddWithValue("@makh", maKH);

                                adapter.DeleteCommand = sqlCommand;
                                adapter.Update(ds, "tblKhachHang");
                            }
                        }
                    }
                    LoadDataToGridView();
                }
                else
                {
                    return;
                }
            }
            /*
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
                string errorStr = ex.Message;/*
                if ((ex is SqlException)) //&& errorStr.Contains("40"))
                {
                    //MessageBox.Show("Đã có lỗi xảy ra ở sql server");
                    MessageBox.Show("Ràng buộc: Mã khách hàng " + maKH +
                            " có phát sinh hóa đơn, không xoá được!");
                }
                else*/
                if (errorStr.Contains("FK__tblHoaDon__sMaKH__4F7CD00D"))
                {
                    MessageBox.Show("Ràng buộc: Mã khách hàng " + maKH +
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
            if (String.IsNullOrEmpty(tbMaKH.Text) && String.IsNullOrEmpty(tbTenKH.Text) && String.IsNullOrEmpty(tbDiaChi.Text))
            {
                MessageBox.Show("Cần nhập ít nhất 1 thông tin để tìm kiếm", "Thông báo");
            }
            else
            {
                string filterMaKH = tbMaKH.Text;
                string filterTenKH = tbTenKH.Text;
                string filterDiaChi = tbDiaChi.Text;
                DataView dtv = new DataView(tblDSKH);

                if (String.IsNullOrEmpty(filterMaKH) && String.IsNullOrEmpty(filterTenKH))
                {
                    dtv.RowFilter = string.Format($"sDiaChi like '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterMaKH) && String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($" sTenKH like '%{filterTenKH}%'");
                }
                if (String.IsNullOrEmpty(filterTenKH) && String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($"sMaKH like '%{filterMaKH}%'");
                }
                if (String.IsNullOrEmpty(filterMaKH))
                {
                    dtv.RowFilter = string.Format($" sTenKH like '%{filterTenKH}%' and sDiaChi like '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($"sMaKH like '%{filterMaKH}%' and sTenKH like '%{filterTenKH}%'");
                }
                if (String.IsNullOrEmpty(filterTenKH))
                {
                    dtv.RowFilter = string.Format($"sMaKH like '%{filterMaKH}%' and sDiaChi like '%{filterDiaChi}%'");
                }
                dgv_dskh.DataSource = dtv;
            }
        }


        //Xử lí sự kiện thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
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
}
