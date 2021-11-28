using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTHPT
{
    class ThongTinGD
    {

        public DataTable Show()
        {
            string sql = "SELECT * FROM tblCTGD";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }

        #region Add Giaovien
        public void ADDGiaoVien(string TenLop, string TenGV, string TenMon, DateTime NgayDay, string TietHoc)
        {
            string sql = "ThemCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlop", TenLop);
            cmd.Parameters.AddWithValue("@tengv", TenGV);
            cmd.Parameters.AddWithValue("@tenmon", TenMon);
            cmd.Parameters.AddWithValue("@ngayday",NgayDay);
            cmd.Parameters.AddWithValue("@tiet", TietHoc);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        #endregion
        public DataTable LayThongTinGiaoVien()
        {
            string sql = "SELECT * FROM tblGiaoVien";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public DataTable LayThongTinLop()
        {
            string sql = "SELECT * FROM tblLop";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public void Sua_GV(string TenLop, string TenGV, DateTime NgayDay, string TenMon, string TietHoc)
        {
            string sql = "SuaCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;  
            cmd.Parameters.AddWithValue("@tenlop", TenLop);
            cmd.Parameters.AddWithValue("@tengv", TenGV);
            cmd.Parameters.AddWithValue("@tenmon", TenMon);
            cmd.Parameters.AddWithValue("@ngayday", NgayDay);
            cmd.Parameters.AddWithValue("@tiet", TietHoc);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void Xoa_GV(string TenLop, DateTime NgayDay, string TietHoc)
        {
            string sql = "Xoa_CTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenlop", TenLop);
            cmd.Parameters.AddWithValue("@ngayday",NgayDay);
            cmd.Parameters.AddWithValue("@tiet", TietHoc);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
