using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Hoc_Them
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }
        private void xoatxt()
        {
            txtMatKhau.ResetText();
            txtTenDangNhap.ResetText();
        }
        private void PQ_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                var ktra_ID = ConnectionString.DataTable_Sql("SELECT * FROM DANGNHAP WHERE TenDangNhap='" + txtTenDangNhap.Text.Trim() + "'");
                if (ktra_ID.Rows.Count > 0)
                {

                    MessageBox.Show("Trùng tên đăng nhập, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtTenDangNhap.ResetText();
                    txtMatKhau.ResetText();
                    txtTenDangNhap.Focus();
                }
                else
                {
                    int iUserRole = 0;
                    if (rdNhanVien.Checked == true)
                    {
                        iUserRole = 1;
                    }
                    else if (rdGiaoVien.Checked == true)
                    {
                        iUserRole = 2;
                    }
                    
                    else
                    {
                        MessageBox.Show("Chưa chọn phân quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    string insert = "insert into DANGNHAP(TenDangNhap, MatKhau, PhanQuyen) VALUES(";
                    insert += "N'" + txtTenDangNhap.Text + "',N'" + txtMatKhau.Text + "', '" + iUserRole + "')";
                    ConnectionString.ExecuteSQL(insert);
                    MessageBox.Show("Phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoatxt();
                    rdNhanVien.Checked = false;
                    rdGiaoVien.Checked = false;
                   
                }

            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void rdNhanVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
