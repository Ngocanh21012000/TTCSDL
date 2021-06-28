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
    public partial class FormGiaoVien : Form
    {
        public FormGiaoVien()
        {
            InitializeComponent();
        }
        ConnectionString conn = new ConnectionString();
      
        private void btn_nhap_Click(object sender, EventArgs e)
        {
            clearall();


            if (btn_nhap.Text == "Nhập mới")
            {

                btn_nhap.Text = "Huỷ Nhập";
                btn_sua.Enabled = false;

                btn_luu.Enabled = true;
            }
            else
            {

                btn_luu.Enabled = false;
                btn_nhap.Text = "Nhập mới";
                btn_sua.Enabled = true;


            }




        }
        public bool kiemtradulieugiaovien()
        {
            if (txtMaGiaoVien.Text == "" || txtTenGiaoVien.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "" || txtMMTT.Text == "" || txtMMH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else
            {
                if (conn.kiemtatrungkhoagiaovien(txtMaGiaoVien.Text))
                {
                    MessageBox.Show(" Mã giáo viên này đã tồn tại !");
                    return false;
                }
                return true;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (btn_sua.Enabled == false)
            {

                bool kt;
                //=====================
                if (kiemtradulieugiaovien() == false)
                {

                    return;
                }
                else
                {
                    string _magv, _htgv, _nsgv, _dcgv, _dtgv, _tdgv, _mmhgv, _mmttgv;
                    int _gtgv;
                    _magv = txtMaGiaoVien.Text;
                    _htgv = txtTenGiaoVien.Text;
                    _dcgv = txtDiaChi.Text;
                    _dtgv = txtSoDienThoai.Text;
                    _mmhgv = txtMMH.Text;
                    _mmttgv = txtMMTT.Text;
                    if (rdNam.Checked)
                        _gtgv = 1;
                    else
                        _gtgv = 0;
                    _nsgv = dateTimePicker1.Value.ToShortDateString();

                    kt = conn.luugiaovien(_magv, _htgv, _nsgv, _dcgv, _dtgv, _mmhgv, _mmttgv, _gtgv);
                    if (kt == false)
                    {
                        MessageBox.Show("Ban Chua Them Duoc!");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = conn.giaovien();
                        dgvGiaoVien.DataSource = ds.Tables[0];
                        MessageBox.Show("Ban Them Thanh Cong !");
                        clearall();
                        btn_luu.Enabled = false;
                        btn_sua.Enabled = true;
                        btn_nhap.Text = "Nhập mới";


                    }
                }
            }
            else
            {
                bool kt;
                //=====================               
                string _magv, _htgv, _nsgv, _dcgv, _dtgv, _mmhgv, _mmttgv;
                int _gtgv;
                _magv = txtMaGiaoVien.Text;
                _htgv = txtTenGiaoVien.Text;
                _dcgv = txtDiaChi.Text;
                
                _dtgv = txtSoDienThoai.Text;
                _mmhgv = txtMMH.Text;
                _mmttgv = txtMMTT.Text;
                if (rdNam.Checked)
                    _gtgv = 1;
                else
                    _gtgv = 0;
                _nsgv = dateTimePicker1.Value.ToShortDateString();
                _magv = dgvGiaoVien.CurrentCell.Value.ToString();
                kt = conn.suathongtingiaovien(_magv, _htgv, _nsgv, _dcgv, _dtgv, _mmhgv, _mmttgv, _gtgv);
                if (kt == false)
                {
                    MessageBox.Show("Ban Chua sua Duoc!");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = conn.giaovien();
                    dgvGiaoVien.DataSource = ds.Tables[0];
                    MessageBox.Show("Ban da sua Thanh Cong !");
                    //ClearAll();
                    btn_luu.Enabled = false;
                    btn_sua.Enabled = true;
                    btn_nhap.Enabled = true;

                    btn_sua.Text = "Sửa";
                }

            }
        }
        
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            txtMaGiaoVien.Focus();
            load_GiaoVien();
            
        }
        private void load_GiaoVien()
        {
            string kv = "SELECT MaGiaoVien,TenGiaoVien,NgaySinh,GioiTinh,SDT,DiaChi,MaMonHoc,MaMTT FROM GIAOVIEN ";
            var dt_kv = ConnectionString.DataTable_Sql(kv);
            if (dt_kv.Rows.Count > 0)
            {
                dgvGiaoVien.DataSource = dt_kv;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào!");
            }
        }
        private void Xoa_txt()
        {
            txtMaGiaoVien.ResetText();
            txtTenGiaoVien.ResetText();
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();
            dateTimePicker1.ResetText();
            txtMMH.ResetText();
            txtMMTT.ResetText();
        }
        void clearall()
        {
            txtMaGiaoVien.Clear();
            txtTenGiaoVien.Clear();
            txtDiaChi.Clear();
            txtMMTT.Clear();
            txtMMH.Clear();
            txtMaGiaoVien.Focus();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           
        }

     
        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrEmpty(txtSoDienThoai.Text) &&
                 !int.TryParse(txtSoDienThoai.Text, out i)
              )
            {
                MessageBox.Show("Vui lòng nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.ResetText();
            }
        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txtMaGiaoVien.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
                txtTenGiaoVien.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["TenNhanVien"].Value.ToString();
                
                dateTimePicker1.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                txtSoDienThoai.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtMMH.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["MaMonHoc"].Value.ToString();
                txtMMTT.Text = dgvGiaoVien.Rows[e.RowIndex].Cells["MaMTT"].Value.ToString();

            }
            catch
            {

            }
        }

        private void txtGiaoVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenGiaoVien.Focus();

            }
        }

        private void txtTenGiaoVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dateTimePicker1.Focus();

            }
        }
        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSoDienThoai.Focus();

            }
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Focus();

            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMMH.Focus();

            }
        }

        private void txtMMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMMTT.Focus();

            }
        }

        private void txtMMTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "GiaoVien";
            if (rdmagv.Checked == true)
            {
                string ma = "MaGiaoVien";
                bool kt;
                kt = conn.timkiemall(str, ma, txttkgv.Text);
                if (kt == false)
                {
                    MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                    return;
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = conn.gettimkiemAll(str, ma, txttkgv.Text);
                    dgvGiaoVien.DataSource = ds.Tables[0];
                }
            }
            else
            {
                if (rdtengv.Checked == true)
                {
                    string ma = "TenGiaoVien";
                    bool kt;
                    kt = conn.timkiemall(str, ma, txttkgv.Text);
                    if (kt == false)
                    {
                        MessageBox.Show("Dữ liệu bạn cần không tìm thấy !");
                        return;
                    }
                    else
                    {
                        DataSet ds = new DataSet();
                        ds = conn.gettimkiemAll(str, ma, txttkgv.Text);
                        dgvGiaoVien.DataSource = ds.Tables[0];
                    }
                }

                else
                {
                    MessageBox.Show("Hay chon cach tim kiem");
                }


            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
