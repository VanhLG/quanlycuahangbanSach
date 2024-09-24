namespace FormDangNhap
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtChiTiet = new System.Windows.Forms.DataGridView();
            this.sMaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblChiTietHDBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSachDataSet4 = new FormDangNhap.QLBanSachDataSet4();
            this.tblChiTietHDBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSachDataSet1 = new FormDangNhap.QLBanSachDataSet1();
            this.tblChiTietHDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSach2DataSet1 = new FormDangNhap.QLBanSach2DataSet1();
            this.tblChiTietHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanSach2DataSet = new FormDangNhap.QLBanSach2DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNV = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.tblChiTietHDTableAdapter = new FormDangNhap.QLBanSach2DataSetTableAdapters.tblChiTietHDTableAdapter();
            this.tblChiTietHDTableAdapter1 = new FormDangNhap.QLBanSach2DataSet1TableAdapters.tblChiTietHDTableAdapter();
            this.tblChiTietHDTableAdapter2 = new FormDangNhap.QLBanSachDataSet1TableAdapters.tblChiTietHDTableAdapter();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tblChiTietHDTableAdapter3 = new FormDangNhap.QLBanSachDataSet4TableAdapters.tblChiTietHDTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.nSl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSach2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSach2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtChiTiet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(22, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // dtChiTiet
            // 
            this.dtChiTiet.AutoGenerateColumns = false;
            this.dtChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSachDataGridViewTextBoxColumn,
            this.sTenSachDataGridViewTextBoxColumn,
            this.iSlDataGridViewTextBoxColumn,
            this.iTienDataGridViewTextBoxColumn,
            this.iThanhTien});
            this.dtChiTiet.DataSource = this.tblChiTietHDBindingSource3;
            this.dtChiTiet.Location = new System.Drawing.Point(0, 25);
            this.dtChiTiet.Name = "dtChiTiet";
            this.dtChiTiet.Size = new System.Drawing.Size(776, 150);
            this.dtChiTiet.TabIndex = 0;
            this.dtChiTiet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtChiTiet_CellEndEdit);
            // 
            // sMaSachDataGridViewTextBoxColumn
            // 
            this.sMaSachDataGridViewTextBoxColumn.DataPropertyName = "sMaSach";
            this.sMaSachDataGridViewTextBoxColumn.HeaderText = "Mã sách";
            this.sMaSachDataGridViewTextBoxColumn.Name = "sMaSachDataGridViewTextBoxColumn";
            this.sMaSachDataGridViewTextBoxColumn.Width = 130;
            // 
            // sTenSachDataGridViewTextBoxColumn
            // 
            this.sTenSachDataGridViewTextBoxColumn.DataPropertyName = "sTenSach";
            this.sTenSachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.sTenSachDataGridViewTextBoxColumn.Name = "sTenSachDataGridViewTextBoxColumn";
            // 
            // iSlDataGridViewTextBoxColumn
            // 
            this.iSlDataGridViewTextBoxColumn.DataPropertyName = "iSl";
            this.iSlDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.iSlDataGridViewTextBoxColumn.Name = "iSlDataGridViewTextBoxColumn";
            // 
            // iTienDataGridViewTextBoxColumn
            // 
            this.iTienDataGridViewTextBoxColumn.DataPropertyName = "iTien";
            this.iTienDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.iTienDataGridViewTextBoxColumn.Name = "iTienDataGridViewTextBoxColumn";
            // 
            // iThanhTien
            // 
            this.iThanhTien.HeaderText = "Thành tiền";
            this.iThanhTien.Name = "iThanhTien";
            this.iThanhTien.Width = 150;
            // 
            // tblChiTietHDBindingSource3
            // 
            this.tblChiTietHDBindingSource3.DataMember = "tblChiTietHD";
            this.tblChiTietHDBindingSource3.DataSource = this.qLBanSachDataSet4;
            // 
            // qLBanSachDataSet4
            // 
            this.qLBanSachDataSet4.DataSetName = "QLBanSachDataSet4";
            this.qLBanSachDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietHDBindingSource2
            // 
            this.tblChiTietHDBindingSource2.DataMember = "tblChiTietHD";
            this.tblChiTietHDBindingSource2.DataSource = this.qLBanSachDataSet1;
            // 
            // qLBanSachDataSet1
            // 
            this.qLBanSachDataSet1.DataSetName = "QLBanSachDataSet1";
            this.qLBanSachDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietHDBindingSource1
            // 
            this.tblChiTietHDBindingSource1.DataMember = "tblChiTietHD";
            this.tblChiTietHDBindingSource1.DataSource = this.qLBanSach2DataSet1;
            // 
            // qLBanSach2DataSet1
            // 
            this.qLBanSach2DataSet1.DataSetName = "QLBanSach2DataSet1";
            this.qLBanSach2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblChiTietHDBindingSource
            // 
            this.tblChiTietHDBindingSource.DataMember = "tblChiTietHD";
            this.tblChiTietHDBindingSource.DataSource = this.qLBanSach2DataSet;
            // 
            // qLBanSach2DataSet
            // 
            this.qLBanSach2DataSet.DataSetName = "QLBanSach2DataSet";
            this.qLBanSach2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "THANH TOÁN HÓA ĐƠN";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMaHD.Location = new System.Drawing.Point(28, 106);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(105, 20);
            this.lbMaHD.TabIndex = 3;
            this.lbMaHD.Text = "Mã hóa đơn : ";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTenHang.Location = new System.Drawing.Point(28, 148);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(86, 20);
            this.lbTenHang.TabIndex = 4;
            this.lbTenHang.Text = "Tên sách : ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTime.Location = new System.Drawing.Point(292, 106);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(106, 20);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Thời gian lập :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(292, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng : ";
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNV.Location = new System.Drawing.Point(534, 106);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(116, 20);
            this.lbNV.TabIndex = 7;
            this.lbNV.Text = "Nhân viên lập : ";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGia.Location = new System.Drawing.Point(534, 148);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(46, 20);
            this.lbGia.TabIndex = 8;
            this.lbGia.Text = "Giá : ";
            // 
            // cbTenHang
            // 
            this.cbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Location = new System.Drawing.Point(139, 142);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(121, 28);
            this.cbTenHang.TabIndex = 9;
            this.cbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbTenHang_SelectedIndexChanged);
            // 
            // cbTenKH
            // 
            this.cbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(348, 52);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(121, 28);
            this.cbTenKH.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(348, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(70, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thanh toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Khách hàng : ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(480, 412);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(84, 20);
            this.lbTongTien.TabIndex = 15;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // tblChiTietHDTableAdapter
            // 
            this.tblChiTietHDTableAdapter.ClearBeforeFill = true;
            // 
            // tblChiTietHDTableAdapter1
            // 
            this.tblChiTietHDTableAdapter1.ClearBeforeFill = true;
            // 
            // tblChiTietHDTableAdapter2
            // 
            this.tblChiTietHDTableAdapter2.ClearBeforeFill = true;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(139, 100);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 29);
            this.txtMaHD.TabIndex = 18;
            this.txtMaHD.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaHD_Validating);
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbGia.Location = new System.Drawing.Point(586, 144);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(112, 26);
            this.tbGia.TabIndex = 17;
            // 
            // tblChiTietHDTableAdapter3
            // 
            this.tblChiTietHDTableAdapter3.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(204, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "In hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nSl
            // 
            this.nSl.Location = new System.Drawing.Point(382, 147);
            this.nSl.Name = "nSl";
            this.nSl.Size = new System.Drawing.Size(100, 20);
            this.nSl.TabIndex = 20;
            this.nSl.TextChanged += new System.EventHandler(this.nSl_ValueChanged);
            this.nSl.Validating += new System.ComponentModel.CancelEventHandler(this.nSl_Validating);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nSl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTenKH);
            this.Controls.Add(this.cbTenHang);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTenHang);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSachDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSach2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanSach2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTongTien;
        private QLBanSach2DataSet qLBanSach2DataSet;
        private System.Windows.Forms.BindingSource tblChiTietHDBindingSource;
        private QLBanSach2DataSetTableAdapters.tblChiTietHDTableAdapter tblChiTietHDTableAdapter;
        private QLBanSach2DataSet1 qLBanSach2DataSet1;
        private System.Windows.Forms.BindingSource tblChiTietHDBindingSource1;
        private QLBanSach2DataSet1TableAdapters.tblChiTietHDTableAdapter tblChiTietHDTableAdapter1;
        private QLBanSachDataSet1 qLBanSachDataSet1;
        private System.Windows.Forms.BindingSource tblChiTietHDBindingSource2;
        private QLBanSachDataSet1TableAdapters.tblChiTietHDTableAdapter tblChiTietHDTableAdapter2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox tbGia;
        private QLBanSachDataSet4 qLBanSachDataSet4;
        private System.Windows.Forms.BindingSource tblChiTietHDBindingSource3;
        private QLBanSachDataSet4TableAdapters.tblChiTietHDTableAdapter tblChiTietHDTableAdapter3;
        private System.Windows.Forms.DataGridView dtChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iThanhTien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nSl;
    }
}