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
    public partial class FormBuoiHoc : Form
    {
        protected SqlConnection conn;
        private SqlCommand cmd;
        public DataTable dt;
        public FormBuoiHoc()
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
            cmd.CommandText = "SELECT * FROM BUOIHOC";
            SqlDataReader dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

            dataGridViewBuoiHoc.DataSource = dt;
            dataGridViewBuoiHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void hienThiHocSinh()
        {
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaHocSinh, TenHocSinh, NgaySinh, GioiTinh, SDT FROM HOCSINH";
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

        private void FormBuoiHoc_Load(object sender, EventArgs e)
        {
            LoadcbMaLopHoc();
            LoadcbMaBuoiHoc();
            ketNoi();
            hienThi();
            hienThiHocSinh();
            dongKetNoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ketNoi();
            string NgayHoc = dtpNgayHoc.Value.ToString("yyyy-MM-dd");
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO BUOIHOC 
                        VALUES (@MaBuoiHoc,@NgayHoc,@ThoiGian,@MaLopHoc)";
                cmd.Parameters.AddWithValue("@MaBuoiHoc", txtMaBuoiHoc.Text.Trim());

                cmd.Parameters.AddWithValue("@NgayHoc", NgayHoc);
                cmd.Parameters.AddWithValue("@ThoiGian", int.Parse(txtThoiGian.Text));
                cmd.Parameters.AddWithValue("@MaLopHoc", cbMaLopHoc.Text.Trim());

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Đã thêm dữ liệu");
                    hienThi();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại. Hãy kiểm tra lại");
                }
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu thất bại. Hãy kiểm tra lại");
            }
            
            hienThi();
            dongKetNoi();
            LoadcbMaBuoiHoc();
            cbMaBuoiHoc.Text = txtMaBuoiHoc.Text; 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ketNoi();
            cmd = new SqlCommand("dbo.usp_BuoiHoc_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBuoiHoc", txtMaBuoiHoc.Text.Trim());
            string NgayHoc = dtpNgayHoc.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@NgayHoc", NgayHoc);
            cmd.Parameters.AddWithValue("@ThoiGian", int.Parse(txtThoiGian.Text));
            cmd.Parameters.AddWithValue("@MaLopHoc", cbMaLopHoc.Text.Trim());

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
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM BUOIHOC WHERE MaBuoiHoc = @MaBuoiHoc";
                cmd.Parameters.AddWithValue("@MaBuoiHoc", txtMaBuoiHoc.Text.Trim());

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    hienThi();
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu thất bại. Hãy kiểm tra lại");
                }
            }
            dongKetNoi();
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaBuoiHoc.Text = dtpNgayHoc.Text = txtThoiGian.Text = cbMaLopHoc.Text = "";
        }

        private void clickDuLieu(int rowIndex)
        {
            try
            {
                txtMaBuoiHoc.Text = dataGridViewBuoiHoc.Rows[rowIndex].Cells["MaBuoiHoc"].Value.ToString();
                dtpNgayHoc.Text = dataGridViewBuoiHoc.Rows[rowIndex].Cells["NgayHoc"].Value.ToString();
                txtThoiGian.Text = dataGridViewBuoiHoc.Rows[rowIndex].Cells["ThoiGian"].Value.ToString();
                cbMaLopHoc.Text = dataGridViewBuoiHoc.Rows[rowIndex].Cells["MaLopHoc"].Value.ToString();
                cbMaBuoiHoc.Text = dataGridViewBuoiHoc.Rows[rowIndex].Cells["MaBuoiHoc"].Value.ToString();
            }
            catch
            {

            }
        }
        private void dataGridViewBuoiHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDuLieu(e.RowIndex);
        }
        private void clickDuLieuHocSinh(int rowIndex)
        {
            try
            {
                txtMaHocSinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["MaHocSinh"].Value.ToString();
                txtTenHocSinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["TenHocSinh"].Value.ToString();
                /*dtpNgaySinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["NgaySinh"].Value.ToString();
                cbGioiTinh.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dataGridViewHocSinh.Rows[rowIndex].Cells["SDT"].Value.ToString();*/
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TichVang FROM DIEMDANH WHERE MaBuoiHoc = @MaBuoiHoc AND MaHocSinh = @MaHocSinh";
                cmd.Parameters.AddWithValue("@MaBuoiHoc", cbMaBuoiHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text.Trim());

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    checkVang.Checked = true;
                    MessageBox.Show("Đã ghi danh");

                }
                else
                {
                    checkVang.Checked = false;
                    MessageBox.Show("Điểm danh thất bại. Hãy kiểm tra lại");
                }
            }
            catch
            {

            }
        }
        private void dataGridViewHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDuLieuHocSinh(e.RowIndex);
        }

        private void LoadcbMaLopHoc()
        {
            ketNoi();
            var cmd = new SqlCommand("SELECT * FROM LOPHOC", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaLopHoc.DisplayMember = "MaLopHoc";
            cbMaLopHoc.DataSource = dt;
            dongKetNoi();
        }
        private void LoadcbMaBuoiHoc()
        {
            ketNoi();
            var cmd = new SqlCommand("SELECT * FROM BUOIHOC", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaBuoiHoc.DisplayMember = "MaBuoiHoc";
            cbMaBuoiHoc.DataSource = dt;
            dongKetNoi();
        }

        private void checkVang_CheckedChanged(object sender, EventArgs e)
        {
            ketNoi();
            try
            {
                if(checkVang.Checked == false)
                {
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO DIEMDANH 
                        VALUES (@MaBuoiHoc,@MaHocSinh,@TichVang)";
                cmd.Parameters.AddWithValue("@MaBuoiHoc", cbMaBuoiHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@MaHocSinh", txtMaHocSinh.Text.Trim());
                cmd.Parameters.AddWithValue("@TichVang", 1);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Đã ghi danh");
                }
                else
                {
                    MessageBox.Show("Điểm danh thất bại. Hãy kiểm tra lại");
                }

                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Điểm danh thất bại. Hãy kiểm tra lại");
            }

            dongKetNoi();
        }
    }
}
