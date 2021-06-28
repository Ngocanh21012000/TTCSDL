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
    public partial class FormLopHoc : Form
    {
        /*protected string connString = "Data Source=LAPTOP-LOVKU60P\\SQLEXPRESS;Initial Catalog=QUAN_LY_TRUNG_TAM_HOC_THEM;Integrated Security=True";*/
        protected SqlConnection conn;
        private SqlCommand cmd;
        public DataTable dt;
        public FormLopHoc()
        {
            InitializeComponent();
            this.Load += FormLopHoc_Load;
        }
        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            LoadcbMaKhoaHoc();
            LoadcbMHP();
            LoadcbMaGiaoVien();
            LoadcbMaMonHoc();
            ketNoi();
            hienThi();
            dongKetNoi();
        }
        private void ketNoi()
        {
            conn = new SqlConnection();
           /*conn.ConnectionString = connString;*/
            conn.ConnectionString = ConnectionString.connString;
            conn.Open();
        }
        private void hienThi()
        {
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM LOPHOC";
            SqlDataReader dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

            dataGridViewLopHoc.DataSource = dt;
            dataGridViewLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dongKetNoi()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void clickDuLieu(int rowIndex)
        {
            try
            {
                txtMaLopHoc.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["MaLopHoc"].Value.ToString();
                txtTenLopHoc.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["TenLopHoc"].Value.ToString();
                txtSoLuongHocSinh.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["SoLuongHocSinh"].Value.ToString();
                cbMaKhoaHoc.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["MaKhoaHoc"].Value.ToString();
                txtHocPhi1Buoi.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["HocPhi1Buoi"].Value.ToString();
                cbMaMHP.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["MaMHP"].Value.ToString();
                cbMaGiaoVien.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["MaGiaoVien"].Value.ToString();
                cbMaMonHoc.Text = dataGridViewLopHoc.Rows[rowIndex].Cells["MaMonHoc"].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ketNoi();
            /*cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO LOPHOC 
                    VALUES (@MaLopHoc,@TenLopHoc,@SoLuongHocSinh,@MaKhoaHoc,@HocPhi1Buoi,@MaMHP,@MaGiaoVien,@MaMonHoc)";
            cmd.Parameters.AddWithValue("@MaLopHoc", txtMaLopHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@TenLopHoc", txtTenLopHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@SoLuongHocSinh", int.Parse(txtSoLuongHocSinh.Text));
            cmd.Parameters.AddWithValue("@MaKhoaHoc", cbMaKhoaHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@HocPhi1Buoi", int.Parse(txtHocPhi1Buoi.Text));
            cmd.Parameters.AddWithValue("@MaMHP", cbMaMHP.Text.Trim());
            cmd.Parameters.AddWithValue("@MaGiaoVien", cbMaGiaoVien.Text.Trim());
            cmd.Parameters.AddWithValue("@MaMonHoc", cbMaMonHoc.Text.Trim());

            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Đã thêm dữ liệu");
                hienThi();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại. Hãy kiểm tra lại");
            }*/

            try
            {
                cmd = new SqlCommand("dbo.usp_LOPHOC_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaLopHoc", txtMaLopHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@TenLopHoc", txtTenLopHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@SoLuongHocSinh", int.Parse(txtSoLuongHocSinh.Text));
                cmd.Parameters.AddWithValue("@MaKhoaHoc", cbMaKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@HocPhi1Buoi", int.Parse(txtHocPhi1Buoi.Text));
                cmd.Parameters.AddWithValue("@MaMHP", cbMaMHP.Text.Trim());
                cmd.Parameters.AddWithValue("@MaGiaoVien", cbMaGiaoVien.Text.Trim());
                cmd.Parameters.AddWithValue("@MaMonHoc", cbMaMonHoc.Text.Trim());

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

        private void dataGridViewLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDuLieu(e.RowIndex);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ketNoi();
            cmd = new SqlCommand("dbo.usp_LOPHOC_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLopHoc", txtMaLopHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@TenLopHoc", txtTenLopHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@SoLuongHocSinh", int.Parse(txtSoLuongHocSinh.Text));
            cmd.Parameters.AddWithValue("@MaKhoaHoc", cbMaKhoaHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@HocPhi1Buoi", int.Parse(txtHocPhi1Buoi.Text));
            cmd.Parameters.AddWithValue("@MaMHP", cbMaMHP.Text.Trim());
            cmd.Parameters.AddWithValue("@MaGiaoVien", cbMaGiaoVien.Text.Trim());
            cmd.Parameters.AddWithValue("@MaMonHoc", cbMaMonHoc.Text.Trim());

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

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaLopHoc.Text = txtTenLopHoc.Text = txtSoLuongHocSinh.Text = txtHocPhi1Buoi.Text = cbMaGiaoVien.Text = cbMaKhoaHoc.Text = cbMaMHP.Text = cbMaMonHoc.Text = "";
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
                cmd.CommandText = "DELETE FROM LOPHOC WHERE MaLopHoc = @MaLopHoc";
                cmd.Parameters.AddWithValue("@MaLopHoc", txtMaLopHoc.Text.Trim());

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
        private void LoadcbMaKhoaHoc()
        {
            ketNoi();
            var cmd = new SqlCommand("SELECT * FROM KHOAHOC", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaKhoaHoc.DisplayMember = "MaKhoaHoc";
            cbMaKhoaHoc.DataSource = dt;
            dongKetNoi();
        }
        private void LoadcbMHP()
        {
            ketNoi();
            var cmd = new SqlCommand("SELECT * FROM MUCHOCPHI", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaMHP.DisplayMember = "MaMHP";
            cbMaMHP.DataSource = dt;
            dongKetNoi();
        }
        private void LoadcbMaGiaoVien()
        {
            ketNoi();
            var cmd = new SqlCommand("SELECT * FROM GIAOVIEN", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaGiaoVien.DisplayMember = "MaGiaoVien";
            cbMaGiaoVien.DataSource = dt;
            dongKetNoi();
        }
        private void LoadcbMaMonHoc()
        {
            ketNoi();
            var cmd = new SqlCommand("SELECT * FROM MONHOC", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaMonHoc.DisplayMember = "MaMonHoc";
            cbMaMonHoc.DataSource = dt;
            dongKetNoi();
        }

        private void btnTimKiemLopHoc_Click(object sender, EventArgs e)
        {
            ketNoi();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT * FROM LOPHOC WHERE MaLopHoc = @MaLopHoc";
                cmd.Parameters.AddWithValue("@MaLopHoc", txtTimKiem.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dataGridViewLopHoc.DataSource = dt;
                dataGridViewLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dongKetNoi();
            
        }


    }
}
