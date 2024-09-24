namespace FormDangNhap
{
    partial class FormNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTenCV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLuongCB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHSL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoaBo = new System.Windows.Forms.Button();
            this.btnTìmKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.sMaNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQueQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLuongCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fHSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTaiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMatKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSachDataSet = new FormDangNhap.QLBanSachDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.tblNhanVienTableAdapter = new FormDangNhap.QLBanSachDataSetTableAdapters.tblNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(285, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(104, 40);
            this.tbMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(85, 20);
            this.tbMaNV.TabIndex = 2;
            this.tbMaNV.TextChanged += new System.EventHandler(this.tbMaNV_TextChanged);
            this.tbMaNV.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaNV_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nhân viên";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(290, 40);
            this.tbTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(280, 20);
            this.tbTenNV.TabIndex = 2;
            this.tbTenNV.TextChanged += new System.EventHandler(this.TenNV_TextChanged);
            this.tbTenNV.Validating += new System.ComponentModel.CancelEventHandler(this.TenNV_Validating);
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(81, 89);
            this.rb_nam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(47, 17);
            this.rb_nam.TabIndex = 3;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(128, 89);
            this.rb_nu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(39, 17);
            this.rb_nu.TabIndex = 3;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày sinh";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(660, 41);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(116, 20);
            this.dtNgaySinh.TabIndex = 4;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(242, 88);
            this.tbQueQuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(222, 20);
            this.tbQueQuan.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điện thoại";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(554, 89);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(222, 20);
            this.tbSDT.TabIndex = 2;
            this.tbSDT.TextChanged += new System.EventHandler(this.tbSDT_TextChanged);
            this.tbSDT.Validating += new System.ComponentModel.CancelEventHandler(this.tbSDT_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên công việc ";
            // 
            // tbTenCV
            // 
            this.tbTenCV.Location = new System.Drawing.Point(111, 139);
            this.tbTenCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTenCV.Name = "tbTenCV";
            this.tbTenCV.Size = new System.Drawing.Size(134, 20);
            this.tbTenCV.TabIndex = 2;
            this.tbTenCV.Validating += new System.ComponentModel.CancelEventHandler(this.tbTenCV_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lương cơ bản ";
            // 
            // tbLuongCB
            // 
            this.tbLuongCB.Location = new System.Drawing.Point(350, 139);
            this.tbLuongCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLuongCB.Name = "tbLuongCB";
            this.tbLuongCB.Size = new System.Drawing.Size(95, 20);
            this.tbLuongCB.TabIndex = 2;
            this.tbLuongCB.TextChanged += new System.EventHandler(this.tbLuongCB_TextChanged);
            this.tbLuongCB.Validating += new System.ComponentModel.CancelEventHandler(this.tbLuongCB_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hệ số lương";
            // 
            // tbHSL
            // 
            this.tbHSL.Location = new System.Drawing.Point(544, 139);
            this.tbHSL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHSL.Name = "tbHSL";
            this.tbHSL.Size = new System.Drawing.Size(49, 20);
            this.tbHSL.TabIndex = 2;
            this.tbHSL.Validating += new System.ComponentModel.CancelEventHandler(this.tbHSL_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(634, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Phụ cấp";
            // 
            // tbPC
            // 
            this.tbPC.Location = new System.Drawing.Point(681, 139);
            this.tbPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPC.Name = "tbPC";
            this.tbPC.Size = new System.Drawing.Size(95, 20);
            this.tbPC.TabIndex = 2;
            this.tbPC.TextChanged += new System.EventHandler(this.tbPC_TextChanged);
            this.tbPC.Validating += new System.ComponentModel.CancelEventHandler(this.tbPC_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tài khoản ";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(92, 194);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(280, 20);
            this.tbTaiKhoan.TabIndex = 2;
            this.tbTaiKhoan.Validating += new System.ComponentModel.CancelEventHandler(this.tbTaiKhoan_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(495, 194);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(134, 20);
            this.tbMatKhau.TabIndex = 2;
            this.tbMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.tbMatKhau_Validating);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.Location = new System.Drawing.Point(104, 232);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(84, 37);
            this.btnThemMoi.TabIndex = 5;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatLai.Location = new System.Drawing.Point(201, 232);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(84, 37);
            this.btnDatLai.TabIndex = 5;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnChinhSua.Location = new System.Drawing.Point(296, 232);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(84, 37);
            this.btnChinhSua.TabIndex = 5;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoaBo
            // 
            this.btnXoaBo.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaBo.Location = new System.Drawing.Point(393, 232);
            this.btnXoaBo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaBo.Name = "btnXoaBo";
            this.btnXoaBo.Size = new System.Drawing.Size(84, 37);
            this.btnXoaBo.TabIndex = 5;
            this.btnXoaBo.Text = "Xóa bỏ";
            this.btnXoaBo.UseVisualStyleBackColor = false;
            this.btnXoaBo.Click += new System.EventHandler(this.btnXoaBo_Click);
            // 
            // btnTìmKiem
            // 
            this.btnTìmKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTìmKiem.Location = new System.Drawing.Point(493, 232);
            this.btnTìmKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTìmKiem.Name = "btnTìmKiem";
            this.btnTìmKiem.Size = new System.Drawing.Size(84, 37);
            this.btnTìmKiem.TabIndex = 5;
            this.btnTìmKiem.Text = "Tìm kiếm";
            this.btnTìmKiem.UseVisualStyleBackColor = false;
            this.btnTìmKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(592, 232);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.AutoGenerateColumns = false;
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNVDataGridViewTextBoxColumn,
            this.sTenNVDataGridViewTextBoxColumn,
            this.dNgaysinhDataGridViewTextBoxColumn,
            this.sGioiTinhDataGridViewTextBoxColumn,
            this.sQueQuanDataGridViewTextBoxColumn,
            this.sSDTDataGridViewTextBoxColumn,
            this.iLuongCBDataGridViewTextBoxColumn,
            this.fHSLDataGridViewTextBoxColumn,
            this.iPCDataGridViewTextBoxColumn,
            this.sTenCVDataGridViewTextBoxColumn,
            this.sTaiKhoanDataGridViewTextBoxColumn,
            this.sMatKhauDataGridViewTextBoxColumn});
            this.dgv_dsnv.DataSource = this.tblNhanVienBindingSource;
            this.dgv_dsnv.Location = new System.Drawing.Point(38, 308);
            this.dgv_dsnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(737, 196);
            this.dgv_dsnv.TabIndex = 6;
            this.dgv_dsnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnv_CellClick);
            // 
            // sMaNVDataGridViewTextBoxColumn
            // 
            this.sMaNVDataGridViewTextBoxColumn.DataPropertyName = "sMaNV";
            this.sMaNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.sMaNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sMaNVDataGridViewTextBoxColumn.Name = "sMaNVDataGridViewTextBoxColumn";
            this.sMaNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTenNVDataGridViewTextBoxColumn
            // 
            this.sTenNVDataGridViewTextBoxColumn.DataPropertyName = "sTenNV";
            this.sTenNVDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.sTenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTenNVDataGridViewTextBoxColumn.Name = "sTenNVDataGridViewTextBoxColumn";
            this.sTenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // dNgaysinhDataGridViewTextBoxColumn
            // 
            this.dNgaysinhDataGridViewTextBoxColumn.DataPropertyName = "dNgaysinh";
            this.dNgaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.dNgaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dNgaysinhDataGridViewTextBoxColumn.Name = "dNgaysinhDataGridViewTextBoxColumn";
            this.dNgaysinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // sGioiTinhDataGridViewTextBoxColumn
            // 
            this.sGioiTinhDataGridViewTextBoxColumn.DataPropertyName = "sGioiTinh";
            this.sGioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.sGioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sGioiTinhDataGridViewTextBoxColumn.Name = "sGioiTinhDataGridViewTextBoxColumn";
            this.sGioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // sQueQuanDataGridViewTextBoxColumn
            // 
            this.sQueQuanDataGridViewTextBoxColumn.DataPropertyName = "sQueQuan";
            this.sQueQuanDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.sQueQuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sQueQuanDataGridViewTextBoxColumn.Name = "sQueQuanDataGridViewTextBoxColumn";
            this.sQueQuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // sSDTDataGridViewTextBoxColumn
            // 
            this.sSDTDataGridViewTextBoxColumn.DataPropertyName = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sSDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSDTDataGridViewTextBoxColumn.Name = "sSDTDataGridViewTextBoxColumn";
            this.sSDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // iLuongCBDataGridViewTextBoxColumn
            // 
            this.iLuongCBDataGridViewTextBoxColumn.DataPropertyName = "iLuongCB";
            this.iLuongCBDataGridViewTextBoxColumn.HeaderText = "Lương cơ bản";
            this.iLuongCBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iLuongCBDataGridViewTextBoxColumn.Name = "iLuongCBDataGridViewTextBoxColumn";
            this.iLuongCBDataGridViewTextBoxColumn.Width = 125;
            // 
            // fHSLDataGridViewTextBoxColumn
            // 
            this.fHSLDataGridViewTextBoxColumn.DataPropertyName = "fHSL";
            this.fHSLDataGridViewTextBoxColumn.HeaderText = "Hệ số lương";
            this.fHSLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fHSLDataGridViewTextBoxColumn.Name = "fHSLDataGridViewTextBoxColumn";
            this.fHSLDataGridViewTextBoxColumn.Width = 125;
            // 
            // iPCDataGridViewTextBoxColumn
            // 
            this.iPCDataGridViewTextBoxColumn.DataPropertyName = "iPC";
            this.iPCDataGridViewTextBoxColumn.HeaderText = "Phụ cấp";
            this.iPCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iPCDataGridViewTextBoxColumn.Name = "iPCDataGridViewTextBoxColumn";
            this.iPCDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTenCVDataGridViewTextBoxColumn
            // 
            this.sTenCVDataGridViewTextBoxColumn.DataPropertyName = "sTenCV";
            this.sTenCVDataGridViewTextBoxColumn.HeaderText = "Tên công việc";
            this.sTenCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTenCVDataGridViewTextBoxColumn.Name = "sTenCVDataGridViewTextBoxColumn";
            this.sTenCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTaiKhoanDataGridViewTextBoxColumn
            // 
            this.sTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "sTaiKhoan";
            this.sTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            this.sTaiKhoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTaiKhoanDataGridViewTextBoxColumn.Name = "sTaiKhoanDataGridViewTextBoxColumn";
            this.sTaiKhoanDataGridViewTextBoxColumn.Width = 125;
            // 
            // sMatKhauDataGridViewTextBoxColumn
            // 
            this.sMatKhauDataGridViewTextBoxColumn.DataPropertyName = "sMatKhau";
            this.sMatKhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.sMatKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sMatKhauDataGridViewTextBoxColumn.Name = "sMatKhauDataGridViewTextBoxColumn";
            this.sMatKhauDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            this.tblNhanVienBindingSource.DataSource = this.qLBanSachDataSet;
            // 
            // qLBanSachDataSet
            // 
            this.qLBanSachDataSet.DataSetName = "QLBanSachDataSet";
            this.qLBanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 292);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Danh sách nhân viên";
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.dgv_dsnv);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTìmKiem);
            this.Controls.Add(this.btnXoaBo);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbHSL);
            this.Controls.Add(this.tbPC);
            this.Controls.Add(this.tbLuongCB);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTenCV);
            this.Controls.Add(this.tbQueQuan);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNV";
            this.Text = "FormNV";
            this.Load += new System.EventHandler(this.FormNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTenCV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLuongCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbHSL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoaBo;
        private System.Windows.Forms.Button btnTìmKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgv_dsnv;
        private System.Windows.Forms.Label label14;
        private QLBanSachDataSet qLBanSachDataSet;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private QLBanSachDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQueQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLuongCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHSLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTaiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMatKhauDataGridViewTextBoxColumn;
    }
}