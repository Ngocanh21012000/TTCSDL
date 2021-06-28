using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_Hoc_Them
{


    class ConnectionString
    {

        public static string connString;
        public static SqlConnection conn = new SqlConnection();

        static ConnectionString()
        {
            connString = "Data Source=NGUYEN;Initial Catalog=QUAN_LY_TRUNG_TAM_HOC_THEM;Integrated Security=True";
            conn = new SqlConnection(connString);
            if (conn.State == ConnectionState.Open)
            {
                conn.Open();
            }
            else if (conn.State == ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public static void open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Dispose();
            }
        }
        public static DataTable DataTable_Sql(string sql)
        {
            //try
            //{
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlDataAdapter dap = new SqlDataAdapter(sql, conn))
                {
                    using (DataSet ds = new DataSet())
                    {
                        dap.Fill(ds);
                        conn.Close();
                        conn.Dispose();
                        return ds.Tables[0];
                    }
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }
        public static int ExecuteSQL(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = 0;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            row = cmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
            return row;
        }
        public static DataTable StoreFillDS(string StoreName, CommandType type, params object[] obj)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(StoreName, conn);
            cmd.CommandType = type;
            SqlCommandBuilder.DeriveParameters(cmd);

            for (int i = 1; i <= obj.Length; i++)
            {
                cmd.Parameters[i].Value = obj[i - 1];
            }
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            conn.Dispose();
            conn.Close();
            return ds.Tables[0];

        }
        public DataSet getDataSet(string tableName)
        {
            string sql;
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            sql = "SELECT * FROM " + tableName;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            //***DO DU LIEU VAO DANH SACH***//
            da.Fill(ds, tableName);
            //****TRA VE DANH SACH SAU KHI DA CO DU LIEU****//
            return ds;
        }
        public DataTable getDataTable(string tableName)
        {
            return getDataSet(tableName).Tables[tableName];
        }
        public bool luugiaovien(string magv, string htgv, string ns, string dc, string dt, string mmh,string mmtt, int gt)
        {
            string sql = "INSERT into GIAOVIEN(MaGiaoVien,TenGiaoVien,NgaySinh,DiaChi,SDT,MaMonHoc,MaMTT ,GioiTinh) values(N'" + magv + "',N'" + htgv + "',N'" + ns + "',N'" + dc + "',N'" + dt +  "',N'" + mmh + "',N'" + mmtt + "',N'" + gt + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;

        }
        //====//
        public DataSet giaovien()
        {
            string sql = "select * from GIAOVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //===========SUU THONG TIN GIAO VIEN LUU VAO CO SO DU LIEU================
        public bool suathongtingiaovien(string magv, string htgv, string ns, string dc, string dt, string mmh,string mmtt, int gt)
        {
            string sql = "update GIAOVIEN set TenGiaoVien=N'" + htgv + "',NgaySinh =N'" + ns + "',DiaChi=N'" + dc + "',SDT=N'" + dt + "',MaMonHoc=N'" + mmh + "',MaMTT=N'" + mmtt + "',GioiTinh=N'" + gt + "' where MaGiaoVien=N'" + magv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return true;
        }
        public bool timkiemall(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
                return true;
            else
                return false;
        }
        public DataSet gettimkiemAll(string tblName, string ma, string vthongtin)
        {
            string sql = "select * from " + tblName + " where " + ma + " like N'%" + vthongtin + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool kiemtatrungkhoagiaovien(string _magv)
        {
            string sql = "select * from GIAOVIEN where MaGiaoVien='" + _magv + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            else
                return false;
        }
        //
        public static int ExecuteStore(string query_object, CommandType type, params object[] obj)
        {
            int row = 0;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query_object, conn);
            cmd.CommandType = type;
            SqlCommandBuilder.DeriveParameters(cmd);
            for (int i = 1; i <= obj.Length; i++)
            {
                cmd.Parameters[i].Value = obj[i - 1];
            }
            cmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
            return row;
        }

        // Hàm GetFieldValues, có tác dụng lấy dữ liệu từ một câu lệnh SQL
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }


        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = ConnectionString.conn; //Kết nối cơ sở dữ liệu
            MyData.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }




        // Hàm đổi số thành chữ
        public static string ChuyenSoSangChu(float number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            //Viết hoa ký tự đầu tiên
            str = str.Substring(0, 1).ToUpper() + str.Substring(1);
            if (booAm) str = "Âm " + str;
            return str + "đồng";
        }

    }
}
