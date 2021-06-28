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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (tbuser.Text.Trim() == null || tbuser.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbuser.Focus();
            }
            else
            {
                var dt = ConnectionString.StoreFillDS("DN", System.Data.CommandType.StoredProcedure, "" + tbuser.Text + "", "" + tb_matkhau.Text + "");
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);      

                    var ktra_phanquyen = ConnectionString.DataTable_Sql("SELECT PhanQuyen from DANGNHAP where TenDangnhap  ='" + tbuser.Text.Trim() + "' and MatKhau  ='" + tb_matkhau.Text + "'");
                    Form1.phanquyen = ktra_phanquyen.Rows[0][0].ToString().Trim();

                    Form1 _FormMain = new Form1();
                    this.Hide();
                    _FormMain.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbuser.Text = "";
                    tb_matkhau.Text = "";
                    tbuser.Focus();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbuser.Focus();
        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tb_matkhau.Focus();
            }
        }

    

        private void tb_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login.Focus();
            }
        }
    }
}
