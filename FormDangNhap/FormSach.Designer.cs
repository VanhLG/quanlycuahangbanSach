namespace FormDangNhap
{
    partial class FormSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.txbTacGia = new System.Windows.Forms.TextBox();
            this.txbTheLoai = new System.Windows.Forms.TextBox();
            this.txbMaSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.sMaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSachDataSet = new FormDangNhap.QLBanSachDataSet();
            this.tblSachTableAdapter = new FormDangNhap.QLBanSachDataSetTableAdapters.tblSachTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(207, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbMaNXB);
            this.groupBox1.Controls.Add(this.txbTenSach);
            this.groupBox1.Controls.Add(this.txbTacGia);
            this.groupBox1.Controls.Add(this.txbTheLoai);
            this.groupBox1.Controls.Add(this.txbMaSach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(558, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // txbGia
            // 
            this.txbGia.Location = new System.Drawing.Point(357, 131);
            this.txbGia.Margin = new System.Windows.Forms.Padding(2);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(171, 20);
            this.txbGia.TabIndex = 5;
            this.txbGia.Click += new System.EventHandler(this.txbGia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(192, 186);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 24);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(458, 186);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 24);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(369, 186);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 24);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(280, 186);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(68, 24);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(106, 186);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 24);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 186);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 24);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Location = new System.Drawing.Point(68, 135);
            this.cbMaNXB.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(171, 21);
            this.cbMaNXB.TabIndex = 2;
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(68, 80);
            this.txbTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(171, 20);
            this.txbTenSach.TabIndex = 1;
            //this.txbTenSach.TextChanged += new System.EventHandler(this.txbTenSach_TextChanged);
            //this.txbTenSach.Validating += new System.ComponentModel.CancelEventHandler(this.txbTenSach_Validating);
            // 
            // txbTacGia
            // 
            this.txbTacGia.Location = new System.Drawing.Point(357, 82);
            this.txbTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txbTacGia.Name = "txbTacGia";
            this.txbTacGia.Size = new System.Drawing.Size(171, 20);
            this.txbTacGia.TabIndex = 1;
            // 
            // txbTheLoai
            // 
            this.txbTheLoai.Location = new System.Drawing.Point(357, 26);
            this.txbTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbTheLoai.Name = "txbTheLoai";
            this.txbTheLoai.Size = new System.Drawing.Size(171, 20);
            this.txbTheLoai.TabIndex = 1;
            // 
            // txbMaSach
            // 
            this.txbMaSach.Location = new System.Drawing.Point(69, 24);
            this.txbMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.Size = new System.Drawing.Size(171, 20);
            this.txbMaSach.TabIndex = 1;
            this.txbMaSach.Click += new System.EventHandler(this.txbMaSach_Click);
            //this.txbMaSach.TextChanged += new System.EventHandler(this.txbMaSach_TextChanged);
            //this.txbMaSach.Validating += new System.ComponentModel.CancelEventHandler(this.txbMaSach_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tác giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thế loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSach);
            this.groupBox2.Location = new System.Drawing.Point(10, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(557, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Sách";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.AutoGenerateColumns = false;
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSachDataGridViewTextBoxColumn,
            this.sTenSachDataGridViewTextBoxColumn,
            this.sMaNXBDataGridViewTextBoxColumn,
            this.sTacGiaDataGridViewTextBoxColumn,
            this.sTheLoaiDataGridViewTextBoxColumn,
            this.Gia});
            this.dgvDSSach.DataSource = this.tblSachBindingSource;
            this.dgvDSSach.Location = new System.Drawing.Point(22, 18);
            this.dgvDSSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.RowHeadersWidth = 51;
            this.dgvDSSach.RowTemplate.Height = 24;
            this.dgvDSSach.Size = new System.Drawing.Size(503, 205);
            this.dgvDSSach.TabIndex = 0;
            this.dgvDSSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSach_CellClick);
            // 
            // sMaSachDataGridViewTextBoxColumn
            // 
            this.sMaSachDataGridViewTextBoxColumn.DataPropertyName = "sMaSach";
            this.sMaSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.sMaSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sMaSachDataGridViewTextBoxColumn.Name = "sMaSachDataGridViewTextBoxColumn";
            this.sMaSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTenSachDataGridViewTextBoxColumn
            // 
            this.sTenSachDataGridViewTextBoxColumn.DataPropertyName = "sTenSach";
            this.sTenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.sTenSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTenSachDataGridViewTextBoxColumn.Name = "sTenSachDataGridViewTextBoxColumn";
            this.sTenSachDataGridViewTextBoxColumn.Width = 125;
            // 
            // sMaNXBDataGridViewTextBoxColumn
            // 
            this.sMaNXBDataGridViewTextBoxColumn.DataPropertyName = "sMaNXB";
            this.sMaNXBDataGridViewTextBoxColumn.HeaderText = "Mã NXB";
            this.sMaNXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sMaNXBDataGridViewTextBoxColumn.Name = "sMaNXBDataGridViewTextBoxColumn";
            this.sMaNXBDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTacGiaDataGridViewTextBoxColumn
            // 
            this.sTacGiaDataGridViewTextBoxColumn.DataPropertyName = "sTacGia";
            this.sTacGiaDataGridViewTextBoxColumn.HeaderText = "Tác giả";
            this.sTacGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTacGiaDataGridViewTextBoxColumn.Name = "sTacGiaDataGridViewTextBoxColumn";
            this.sTacGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTheLoaiDataGridViewTextBoxColumn
            // 
            this.sTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "sTheLoai";
            this.sTheLoaiDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            this.sTheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTheLoaiDataGridViewTextBoxColumn.Name = "sTheLoaiDataGridViewTextBoxColumn";
            this.sTheLoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "iGia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            this.Gia.Width = 150;
            // 
            // tblSachBindingSource
            // 
            this.tblSachBindingSource.DataMember = "tblSach";
            this.tblSachBindingSource.DataSource = this.qLBanSachDataSet;
            // 
            // qLBanSachDataSet
            // 
            this.qLBanSachDataSet.DataSetName = "QLBanSachDataSet";
            this.qLBanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSachTableAdapter
            // 
            this.tblSachTableAdapter.ClearBeforeFill = true;
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private QLBanSachDataSet qLBanSachDataSet;
        private System.Windows.Forms.BindingSource tblSachBindingSource;
        private QLBanSachDataSetTableAdapters.tblSachTableAdapter tblSachTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}