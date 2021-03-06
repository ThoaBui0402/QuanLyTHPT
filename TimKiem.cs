using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiTHPT
{
    class TimKiem
    {
        // Tìm kiếm Giao vien theo tên
        public DataTable TKTenGiaoVien(string HoTen)
        {
            string sql = "TK_GV_HoTen";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        //tim kiem giao vien theo ma
        public DataTable TK_Ma_GiaoVien(string Ma)
        {
            string sql = "SELECT * FROM tblGiaoVien WHERE MaGV like N'%' + @MaGV + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaGV", Ma);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm Hoc Sinh theo tên
        public DataTable TKTenHocSinh(string HoTen)
        {
            string sql = "TK_HS_HoTen";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        // Tìm kiếm Hoc Sinh theo Ma
        public DataTable TK_Ma_HocSinh(string Ma)
        {
            string sql = "SELECT * FROM tblHocSinh WHERE MaHS like N'%' + @MaHS + '%'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@MaHS", Ma);
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
