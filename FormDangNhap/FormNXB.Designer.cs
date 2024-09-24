namespace FormDangNhap
{
    partial class FormNXB
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTenNXB = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbMaNXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSNXB = new System.Windows.Forms.DataGridView();
            this.sMaNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNXBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSachDataSet = new FormDangNhap.QLBanSachDataSet();
            this.tblNXBTableAdapter = new FormDangNhap.QLBanSachDataSetTableAdapters.tblNXBTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNXBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(253, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txbTenNXB);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.txbSDT);
            this.groupBox1.Controls.Add(this.txbMaNXB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(710, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhà Xuất Bản";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(590, 122);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 31);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(480, 122);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(82, 31);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(369, 122);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 31);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(259, 122);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(146, 122);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 31);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 122);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbTenNXB
            // 
            this.txbTenNXB.Location = new System.Drawing.Point(119, 76);
            this.txbTenNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenNXB.Name = "txbTenNXB";
            this.txbTenNXB.Size = new System.Drawing.Size(206, 20);
            this.txbTenNXB.TabIndex = 1;
            this.txbTenNXB.TextChanged += new System.EventHandler(this.txbTenNXB_TextChanged);
            this.txbTenNXB.Validating += new System.ComponentModel.CancelEventHandler(this.txbTenNXB_Validating);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(467, 29);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(206, 20);
            this.txbDiaChi.TabIndex = 1;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(467, 76);
            this.txbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(206, 20);
            this.txbSDT.TabIndex = 1;
            this.txbSDT.TextChanged += new System.EventHandler(this.txbSDT_TextChanged);
            // 
            // txbMaNXB
            // 
            this.txbMaNXB.Location = new System.Drawing.Point(119, 29);
            this.txbMaNXB.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaNXB.Name = "txbMaNXB";
            this.txbMaNXB.Size = new System.Drawing.Size(206, 20);
            this.txbMaNXB.TabIndex = 1;
            this.txbMaNXB.TextChanged += new System.EventHandler(this.txbMaNXB_TextChanged);
            this.txbMaNXB.Validating += new System.ComponentModel.CancelEventHandler(this.txbMaNXB_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà xuất bản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSNXB);
            this.groupBox2.Location = new System.Drawing.Point(10, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(709, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Nhà Xuất Bản";
            // 
            // dgvDSNXB
            // 
            this.dgvDSNXB.AutoGenerateColumns = false;
            this.dgvDSNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNXBDataGridViewTextBoxColumn,
            this.sTenNXBDataGridViewTextBoxColumn,
            this.sDiaChiDataGridViewTextBoxColumn,
            this.sSDTDataGridViewTextBoxColumn});
            this.dgvDSNXB.DataSource = this.tblNXBBindingSource;
            this.dgvDSNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNXB.Location = new System.Drawing.Point(2, 15);
            this.dgvDSNXB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSNXB.Name = "dgvDSNXB";
            this.dgvDSNXB.RowHeadersWidth = 51;
            this.dgvDSNXB.RowTemplate.Height = 24;
            this.dgvDSNXB.Size = new System.Drawing.Size(705, 193);
            this.dgvDSNXB.TabIndex = 0;
            this.dgvDSNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNXB_CellClick);
            // 
            // sMaNXBDataGridViewTextBoxColumn
            // 
            this.sMaNXBDataGridViewTextBoxColumn.DataPropertyName = "sMaNXB";
            this.sMaNXBDataGridViewTextBoxColumn.HeaderText = "Mã nhà xuất bản";
            this.sMaNXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sMaNXBDataGridViewTextBoxColumn.Name = "sMaNXBDataGridViewTextBoxColumn";
            this.sMaNXBDataGridViewTextBoxColumn.Width = 150;
            // 
            // sTenNXBDataGridViewTextBoxColumn
            // 
            this.sTenNXBDataGridViewTextBoxColumn.DataPropertyName = "sTenNXB";
            this.sTenNXBDataGridViewTextBoxColumn.HeaderText = "Tên nhà xuất bản";
            this.sTenNXBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTenNXBDataGridViewTextBoxColumn.Name = "sTenNXBDataGridViewTextBoxColumn";
            this.sTenNXBDataGridViewTextBoxColumn.Width = 150;
            // 
            // sDiaChiDataGridViewTextBoxColumn
            // 
            this.sDiaChiDataGridViewTextBoxColumn.DataPropertyName = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.sDiaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDiaChiDataGridViewTextBoxColumn.Name = "sDiaChiDataGridViewTextBoxColumn";
            this.sDiaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // sSDTDataGridViewTextBoxColumn
            // 
            this.sSDTDataGridViewTextBoxColumn.DataPropertyName = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sSDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSDTDataGridViewTextBoxColumn.Name = "sSDTDataGridViewTextBoxColumn";
            this.sSDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblNXBBindingSource
            // 
            this.tblNXBBindingSource.DataMember = "tblNXB";
            this.tblNXBBindingSource.DataSource = this.qLBanSachDataSet;
            // 
            // qLBanSachDataSet
            // 
            this.qLBanSachDataSet.DataSetName = "QLBanSachDataSet";
            this.qLBanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNXBTableAdapter
            // 
            this.tblNXBTableAdapter.ClearBeforeFill = true;
            // 
            // FormNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNXB";
            this.Text = "FormNXB";
            this.Load += new System.EventHandler(this.FormNXB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNXBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTenNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSNXB;
        private QLBanSachDataSet qLBanSachDataSet;
        private System.Windows.Forms.BindingSource tblNXBBindingSource;
        private QLBanSachDataSetTableAdapters.tblNXBTableAdapter tblNXBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
    }
}