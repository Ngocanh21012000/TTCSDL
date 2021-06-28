
namespace QL_Hoc_Them
{
    partial class FormLogin
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
            this.Login = new System.Windows.Forms.Button();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(156, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.AutoSize = true;
            this.TenDangNhap.Location = new System.Drawing.Point(31, 100);
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Size = new System.Drawing.Size(81, 13);
            this.TenDangNhap.TabIndex = 1;
            this.TenDangNhap.Text = "TenDangNhap:";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Location = new System.Drawing.Point(56, 146);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(56, 13);
            this.MatKhau.TabIndex = 2;
            this.MatKhau.Text = "MatKhau :";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Login.Location = new System.Drawing.Point(137, 208);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(131, 33);
            this.Login.TabIndex = 3;
            this.Login.Text = "Đăng Nhập";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(151, 100);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(171, 20);
            this.tbuser.TabIndex = 4;
            this.tbuser.TextChanged += new System.EventHandler(this.tbuser_TextChanged);
            this.tbuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbuser_KeyPress);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(151, 146);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(171, 20);
            this.tb_matkhau.TabIndex = 5;
            this.tb_matkhau.TextChanged += new System.EventHandler(this.tb_matkhau_TextChanged);
            this.tb_matkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_matkhau_KeyPress);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 286);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TenDangNhap);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TenDangNhap;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tb_matkhau;
    }
}