namespace FormDangNhap
{
    partial class ThayDoiMatKhau
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhau1 = new System.Windows.Forms.TextBox();
            this.tbTenDN1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(129, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // tbNhapLaiMatKhau
            // 
            this.tbNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbNhapLaiMatKhau.Location = new System.Drawing.Point(356, 171);
            this.tbNhapLaiMatKhau.Name = "tbNhapLaiMatKhau";
            this.tbNhapLaiMatKhau.PasswordChar = '*';
            this.tbNhapLaiMatKhau.Size = new System.Drawing.Size(226, 29);
            this.tbNhapLaiMatKhau.TabIndex = 20;
            this.tbNhapLaiMatKhau.TextChanged += new System.EventHandler(this.tbNhapLaiMatKhau_TextChanged);
            this.tbNhapLaiMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.tbNhapLaiMatKhau_Validating_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(421, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Hủy bỏ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCapNhat.Location = new System.Drawing.Point(133, 267);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(161, 39);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(129, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên đăng nhập ";
            // 
            // tbMatKhau1
            // 
            this.tbMatKhau1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbMatKhau1.Location = new System.Drawing.Point(356, 122);
            this.tbMatKhau1.Name = "tbMatKhau1";
            this.tbMatKhau1.PasswordChar = '*';
            this.tbMatKhau1.Size = new System.Drawing.Size(226, 29);
            this.tbMatKhau1.TabIndex = 15;
            this.tbMatKhau1.TextChanged += new System.EventHandler(this.tbMatKhau1_TextChanged_1);
            this.tbMatKhau1.Validating += new System.ComponentModel.CancelEventHandler(this.tbMatKhau1_Validating_1);
            // 
            // tbTenDN1
            // 
            this.tbTenDN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTenDN1.Location = new System.Drawing.Point(356, 72);
            this.tbTenDN1.Name = "tbTenDN1";
            this.tbTenDN1.Size = new System.Drawing.Size(226, 29);
            this.tbTenDN1.TabIndex = 14;
            this.tbTenDN1.TextChanged += new System.EventHandler(this.tbTenDN1_TextChanged_1);
            this.tbTenDN1.Validating += new System.ComponentModel.CancelEventHandler(this.tbTenDN1_Validating_1);
            // 
            // ThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNhapLaiMatKhau);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatKhau1);
            this.Controls.Add(this.tbTenDN1);
            this.Name = "ThayDoiMatKhau";
            this.Text = "Thay Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.ThayDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNhapLaiMatKhau;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatKhau1;
        private System.Windows.Forms.TextBox tbTenDN1;
    }
}