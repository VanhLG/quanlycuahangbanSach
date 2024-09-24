namespace FormDangNhap
{
    partial class FormKH
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
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoaBo = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_dskh = new System.Windows.Forms.DataGridView();
            this.sMaKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSachDataSet = new FormDangNhap.QLBanSachDataSet();
            this.tblKhachHangTableAdapter = new FormDangNhap.QLBanSachDataSetTableAdapters.tblKhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(233, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(115, 52);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(101, 20);
            this.tbMaKH.TabIndex = 2;
            this.tbMaKH.TextChanged += new System.EventHandler(this.tbMaKH_TextChanged);
            this.tbMaKH.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaKH_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(344, 50);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(353, 20);
            this.tbTenKH.TabIndex = 4;
            this.tbTenKH.TextChanged += new System.EventHandler(this.tbTenKH_TextChanged);
            this.tbTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.TenKH_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(76, 104);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(264, 20);
            this.tbDiaChi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(462, 104);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(235, 20);
            this.tbSDT.TabIndex = 4;
            this.tbSDT.Validating += new System.ComponentModel.CancelEventHandler(this.tbSDT_Validating);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(124, 156);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(79, 41);
            this.btnThemMoi.TabIndex = 5;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Location = new System.Drawing.Point(208, 156);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(79, 41);
            this.btnDatLai.TabIndex = 5;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(291, 156);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(79, 41);
            this.btnChinhSua.TabIndex = 5;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoaBo
            // 
            this.btnXoaBo.Location = new System.Drawing.Point(374, 156);
            this.btnXoaBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaBo.Name = "btnXoaBo";
            this.btnXoaBo.Size = new System.Drawing.Size(79, 41);
            this.btnXoaBo.TabIndex = 5;
            this.btnXoaBo.Text = "Xóa bỏ";
            this.btnXoaBo.UseVisualStyleBackColor = true;
            this.btnXoaBo.Click += new System.EventHandler(this.btnXoaBo_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(458, 156);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(79, 41);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(541, 156);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Danh sách khách hàng";
            // 
            // dgv_dskh
            // 
            this.dgv_dskh.AutoGenerateColumns = false;
            this.dgv_dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dskh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKHDataGridViewTextBoxColumn,
            this.sTenKHDataGridViewTextBoxColumn,
            this.sDiaChiDataGridViewTextBoxColumn,
            this.sSDTDataGridViewTextBoxColumn});
            this.dgv_dskh.DataSource = this.tblKhachHangBindingSource;
            this.dgv_dskh.Location = new System.Drawing.Point(39, 245);
            this.dgv_dskh.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_dskh.Name = "dgv_dskh";
            this.dgv_dskh.RowHeadersWidth = 51;
            this.dgv_dskh.RowTemplate.Height = 24;
            this.dgv_dskh.Size = new System.Drawing.Size(657, 228);
            this.dgv_dskh.TabIndex = 6;
            this.dgv_dskh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dskh_CellClick);
            // 
            // sMaKHDataGridViewTextBoxColumn
            // 
            this.sMaKHDataGridViewTextBoxColumn.DataPropertyName = "sMaKH";
            this.sMaKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.sMaKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sMaKHDataGridViewTextBoxColumn.Name = "sMaKHDataGridViewTextBoxColumn";
            this.sMaKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTenKHDataGridViewTextBoxColumn
            // 
            this.sTenKHDataGridViewTextBoxColumn.DataPropertyName = "sTenKH";
            this.sTenKHDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.sTenKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTenKHDataGridViewTextBoxColumn.Name = "sTenKHDataGridViewTextBoxColumn";
            this.sTenKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDiaChiDataGridViewTextBoxColumn
            // 
            this.sDiaChiDataGridViewTextBoxColumn.DataPropertyName = "sDiaChi";
            this.sDiaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.sDiaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDiaChiDataGridViewTextBoxColumn.Name = "sDiaChiDataGridViewTextBoxColumn";
            this.sDiaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sSDTDataGridViewTextBoxColumn
            // 
            this.sSDTDataGridViewTextBoxColumn.DataPropertyName = "sSDT";
            this.sSDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sSDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSDTDataGridViewTextBoxColumn.Name = "sSDTDataGridViewTextBoxColumn";
            this.sSDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblKhachHangBindingSource
            // 
            this.tblKhachHangBindingSource.DataMember = "tblKhachHang";
            this.tblKhachHangBindingSource.DataSource = this.qLBanSachDataSet;
            // 
            // qLBanSachDataSet
            // 
            this.qLBanSachDataSet.DataSetName = "QLBanSachDataSet";
            this.qLBanSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKhachHangTableAdapter
            // 
            this.tblKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // FormKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 483);
            this.Controls.Add(this.dgv_dskh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoaBo);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKH";
            this.Text = "FormKH";
            this.Load += new System.EventHandler(this.FormKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dskh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoaBo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_dskh;
        private QLBanSachDataSet qLBanSachDataSet;
        private System.Windows.Forms.BindingSource tblKhachHangBindingSource;
        private QLBanSachDataSetTableAdapters.tblKhachHangTableAdapter tblKhachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDTDataGridViewTextBoxColumn;
    }
}