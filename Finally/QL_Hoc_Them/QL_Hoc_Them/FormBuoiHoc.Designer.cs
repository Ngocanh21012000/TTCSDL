namespace QL_Hoc_Them
{
    partial class FormBuoiHoc
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBuoiHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaLopHoc = new System.Windows.Forms.ComboBox();
            this.dtpNgayHoc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBuoiHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMaBuoiHoc = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkVang = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHocSinh = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuoiHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewBuoiHoc);
            this.groupBox2.Location = new System.Drawing.Point(6, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 311);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách buổi học";
            // 
            // dataGridViewBuoiHoc
            // 
            this.dataGridViewBuoiHoc.AllowUserToAddRows = false;
            this.dataGridViewBuoiHoc.AllowUserToDeleteRows = false;
            this.dataGridViewBuoiHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuoiHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuoiHoc.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewBuoiHoc.Name = "dataGridViewBuoiHoc";
            this.dataGridViewBuoiHoc.ReadOnly = true;
            this.dataGridViewBuoiHoc.RowHeadersWidth = 51;
            this.dataGridViewBuoiHoc.RowTemplate.Height = 24;
            this.dataGridViewBuoiHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuoiHoc.Size = new System.Drawing.Size(468, 290);
            this.dataGridViewBuoiHoc.TabIndex = 0;
            this.dataGridViewBuoiHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuoiHoc_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnNhapMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbMaLopHoc);
            this.groupBox1.Controls.Add(this.dtpNgayHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtThoiGian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaBuoiHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 575);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin buổi học";
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(334, 48);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(93, 27);
            this.btnNhapMoi.TabIndex = 19;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(334, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 29);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(334, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 29);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(334, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 29);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbMaLopHoc
            // 
            this.cbMaLopHoc.FormattingEnabled = true;
            this.cbMaLopHoc.Location = new System.Drawing.Point(154, 160);
            this.cbMaLopHoc.Name = "cbMaLopHoc";
            this.cbMaLopHoc.Size = new System.Drawing.Size(121, 24);
            this.cbMaLopHoc.TabIndex = 15;
            // 
            // dtpNgayHoc
            // 
            this.dtpNgayHoc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHoc.Location = new System.Drawing.Point(155, 87);
            this.dtpNgayHoc.Name = "dtpNgayHoc";
            this.dtpNgayHoc.Size = new System.Drawing.Size(120, 22);
            this.dtpNgayHoc.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày học";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(154, 124);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(121, 22);
            this.txtThoiGian.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian";
            // 
            // txtMaBuoiHoc
            // 
            this.txtMaBuoiHoc.Location = new System.Drawing.Point(155, 51);
            this.txtMaBuoiHoc.Name = "txtMaBuoiHoc";
            this.txtMaBuoiHoc.Size = new System.Drawing.Size(120, 22);
            this.txtMaBuoiHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã buổi học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CẬP NHẬT THÔNG TIN BUỔI HỌC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMaBuoiHoc);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.checkVang);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtTenHocSinh);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMaHocSinh);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(504, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 575);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Điểm danh";
            // 
            // cbMaBuoiHoc
            // 
            this.cbMaBuoiHoc.FormattingEnabled = true;
            this.cbMaBuoiHoc.Location = new System.Drawing.Point(145, 47);
            this.cbMaBuoiHoc.Name = "cbMaBuoiHoc";
            this.cbMaBuoiHoc.Size = new System.Drawing.Size(120, 24);
            this.cbMaBuoiHoc.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Mã buổi học";
            // 
            // checkVang
            // 
            this.checkVang.AutoSize = true;
            this.checkVang.Location = new System.Drawing.Point(404, 231);
            this.checkVang.Name = "checkVang";
            this.checkVang.Size = new System.Drawing.Size(63, 21);
            this.checkVang.TabIndex = 29;
            this.checkVang.Text = "Vắng";
            this.checkVang.UseVisualStyleBackColor = true;
            this.checkVang.CheckedChanged += new System.EventHandler(this.checkVang_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tích vắng:";
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Enabled = false;
            this.txtTenHocSinh.Location = new System.Drawing.Point(145, 119);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(136, 22);
            this.txtTenHocSinh.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tên học sinh";
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(145, 84);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(136, 22);
            this.txtMaHocSinh.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã học sinh";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewHocSinh);
            this.groupBox4.Location = new System.Drawing.Point(6, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 308);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách học sinh";
            // 
            // dataGridViewHocSinh
            // 
            this.dataGridViewHocSinh.AllowUserToAddRows = false;
            this.dataGridViewHocSinh.AllowUserToDeleteRows = false;
            this.dataGridViewHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHocSinh.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewHocSinh.Name = "dataGridViewHocSinh";
            this.dataGridViewHocSinh.ReadOnly = true;
            this.dataGridViewHocSinh.RowHeadersWidth = 51;
            this.dataGridViewHocSinh.RowTemplate.Height = 24;
            this.dataGridViewHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHocSinh.Size = new System.Drawing.Size(472, 287);
            this.dataGridViewHocSinh.TabIndex = 0;
            this.dataGridViewHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHocSinh_CellClick);
            // 
            // FormBuoiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 616);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormBuoiHoc";
            this.Text = "FormBuoiHoc";
            this.Load += new System.EventHandler(this.FormBuoiHoc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuoiHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewBuoiHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMaLopHoc;
        private System.Windows.Forms.DateTimePicker dtpNgayHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBuoiHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewHocSinh;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaBuoiHoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkVang;
        private System.Windows.Forms.Label label12;
    }
}