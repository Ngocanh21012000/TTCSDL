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
    public partial class FormKhoaHoc : Form
    {
        protected SqlConnection conn;
        private SqlCommand cmd;
        public DataTable dt;
        public FormKhoaHoc()
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
            cmd.CommandText = "SELECT * FROM KHOAHOC";
            SqlDataReader dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

            dataGridViewKhoaHoc.DataSource = dt;
            dataGridViewKhoaHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dongKetNoi()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ketNoi();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO KHOAHOC 
                        VALUES (@MaKhoaHoc,@TenKhoaHoc)";
                cmd.Parameters.AddWithValue("@MaKhoaHoc", txtMaKhoaHoc.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKhoaHoc", txtTenKhoaHoc.Text.Trim());

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
        }

        private void FormKhoaHoc_Load(object sender, EventArgs e)
        {
            ketNoi();
            hienThi();
            dongKetNoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ketNoi();
            cmd = new SqlCommand("dbo.usp_KhoaHoc_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKhoaHoc", txtMaKhoaHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@TenKhoaHoc", txtTenKhoaHoc.Text.Trim());

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
        private void clickDuLieu(int rowIndex)
        {
            try
            {
                txtMaKhoaHoc.Text = dataGridViewKhoaHoc.Rows[rowIndex].Cells["MaKhoaHoc"].Value.ToString();
                txtTenKhoaHoc.Text = dataGridViewKhoaHoc.Rows[rowIndex].Cells["TenKhoaHoc"].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridViewKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDuLieu(e.RowIndex);
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
                cmd.CommandText = "DELETE FROM KHOAHOC WHERE MaKhoaHoc = @MaKhoaHoc";
                cmd.Parameters.AddWithValue("@MaKhoaHoc", txtMaKhoaHoc.Text.Trim());

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


            /*ketNoi();
            cmd = new SqlCommand("dbo.usp_KHoaHoc_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKhoaHoc", txtMaKhoaHoc.Text.Trim());
            cmd.Parameters.AddWithValue("@TenKhoaHoc", txtTenKhoaHoc.Text.Trim());

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show("Xóa dữ liệu thất bại. Hãy kiểm tra lại");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                }
            }

            hienThi();
            dongKetNoi();*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
