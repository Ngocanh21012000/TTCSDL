using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Hoc_Them
{
    public partial class FormHocSinh : Form
    {
        protected SqlConnection conn;
        private SqlCommand cmd;
        public DataTable dt;
        public FormHocSinh()
        {
            InitializeComponent();
        }
        private void ketNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConnectionString.connString;
            conn.Open();
        }
        private void hienThi()
        {
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM HOCSINH";
            SqlDataReader dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

            dataGridViewHocSinh.DataSource = dt;
            dataGridViewHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dongKetNoi()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaHocSinh.Text = txtTenHocSinh.Text = dtpNgaySinh.Text = cbGioiTinh.Text = txtDiaChi.Text = txtSDT.Text = "";
        }

        private void FormHocSinh_Load(object sender, EventArgs e)
        {
            ketNoi();
            hienThi();
            dongKetNoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ketNoi();
            try
            {
                cmd = new SqlCommand("dbo.pro_themHocSinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text.Trim());
                cmd.Parameters.AddWithValue("@TenHocSinh", txtTenHocSinh.Text.Trim());
                string NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại. Hãy kiểm tra lại");
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu thất bại. Hãy kiểm tra lại");
            }

            hienThi();
            dongKetNoi();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            ketNoi();
            cmd = new SqlCommand("dbo.pro_updateHocSinh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text.Trim());
            cmd.Parameters.AddWithValue("@TenHocSinh", txtTenHocSinh.Text.Trim());
            string NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text.Trim());
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại. Hãy kiểm tra lại");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                }
            }

            hienThi();
            dongKetNoi();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketNoi();
            DialogResult dlg = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("pro_xoaHocSinh", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text.Trim());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Xóa dữ liệu thất bại. Hãy kiểm tra lại");
                        }
                        else
                        {
                            MessageBox.Show("Đã xóa dữ liệu");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa dữ liệu thất bại. Hãy kiểm tra lại");
                }
            }
            hienThi();
            dongKetNoi();
        }
        private void clickDuLieu(int rowIndex)
        {
            try
            {
                txtMaHocSinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["MaHocSinh"].Value.ToString();
                txtTenHocSinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["TenHocSinh"].Value.ToString();
                dtpNgaySinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["NgaySinh"].Value.ToString();
                cbGioiTinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["SDT"].Value.ToString();
            }
            catch
            {

            }
        }
        private void dataGridViewHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDuLieu(e.RowIndex);
        }

        private void dataGridViewHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
