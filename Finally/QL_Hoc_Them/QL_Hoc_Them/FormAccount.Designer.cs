
namespace QL_Hoc_Them
{
    partial class FormAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.TenDangNhap = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.PhanQuyen = new System.Windows.Forms.Label();
            this.rdNhanVien = new System.Windows.Forms.RadioButton();
            this.rdGiaoVien = new System.Windows.Forms.RadioButton();
            this.PQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN QUYỀN ĐĂNG NHẬP";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.AutoSize = true;
            this.TenDangNhap.Location = new System.Drawing.Point(16, 83);
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Size = new System.Drawing.Size(87, 13);
            this.TenDangNhap.TabIndex = 1;
            this.TenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Location = new System.Drawing.Point(44, 125);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(59, 13);
            this.MatKhau.TabIndex = 2;
            this.MatKhau.Text = "Mật Khẩu :";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(149, 83);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(182, 20);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(146, 125);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(185, 20);
            this.txtMatKhau.TabIndex = 4;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.AutoSize = true;
            this.PhanQuyen.Location = new System.Drawing.Point(31, 181);
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.Size = new System.Drawing.Size(72, 13);
            this.PhanQuyen.TabIndex = 5;
            this.PhanQuyen.Text = "Phân Quyền :";
            // 
            // rdNhanVien
            // 
            this.rdNhanVien.AutoSize = true;
            this.rdNhanVien.Location = new System.Drawing.Point(131, 177);
            this.rdNhanVien.Name = "rdNhanVien";
            this.rdNhanVien.Size = new System.Drawing.Size(92, 17);
            this.rdNhanVien.TabIndex = 6;
            this.rdNhanVien.TabStop = true;
            this.rdNhanVien.Text = "Nhân Viên KT";
            this.rdNhanVien.UseVisualStyleBackColor = true;
            this.rdNhanVien.CheckedChanged += new System.EventHandler(this.rdNhanVien_CheckedChanged);
            // 
            // rdGiaoVien
            // 
            this.rdGiaoVien.AutoSize = true;
            this.rdGiaoVien.Location = new System.Drawing.Point(310, 179);
            this.rdGiaoVien.Name = "rdGiaoVien";
            this.rdGiaoVien.Size = new System.Drawing.Size(71, 17);
            this.rdGiaoVien.TabIndex = 7;
            this.rdGiaoVien.TabStop = true;
            this.rdGiaoVien.Text = "Giáo Viên";
            this.rdGiaoVien.UseVisualStyleBackColor = true;
            // 
            // PQ
            // 
            this.PQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PQ.Location = new System.Drawing.Point(171, 246);
            this.PQ.Name = "PQ";
            this.PQ.Size = new System.Drawing.Size(160, 38);
            this.PQ.TabIndex = 8;
            this.PQ.Text = "Phân Quyền";
            this.PQ.UseVisualStyleBackColor = false;
            this.PQ.Click += new System.EventHandler(this.PQ_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 334);
            this.Controls.Add(this.PQ);
            this.Controls.Add(this.rdGiaoVien);
            this.Controls.Add(this.rdNhanVien);
            this.Controls.Add(this.PhanQuyen);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "FormAccount";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TenDangNhap;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label PhanQuyen;
        private System.Windows.Forms.RadioButton rdNhanVien;
        private System.Windows.Forms.RadioButton rdGiaoVien;
        private System.Windows.Forms.Button PQ;
    }
}