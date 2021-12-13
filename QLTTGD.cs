using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTHPT
{
    class QLTTGD
    {
        public DataTable Show()
        {
            string sql = "SELECT l.TenLop as TenLop, gv.HoTen as TenGV, tt.NgayDay, tt.Tiet FROM tblLop l, tblGiaoVien gv, tblCTGD tt where l.MaLop=tt.MaLop and gv.MaGV=tt.MaGV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }


        public void ThemTTGD(string TenLop, string TenGV, string TenMon, DateTime NgayDay, int Tiet)
        {
            string sql = "ThemCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlop", TenLop);
            cmd.Parameters.AddWithValue("@tengv", TenGV);
            cmd.Parameters.AddWithValue("@tenmon", TenMon);
            cmd.Parameters.AddWithValue("@ngayday", NgayDay.Date);
            cmd.Parameters.AddWithValue("@tiet", Tiet);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        //lay thong tin lop
        public DataTable LayThongTinLop()
        {
            string sql = "SELECT * FROM tblLop";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        //lay thong tin mon hoc
        public DataTable LayThongTinMon()
        {
            string sql = "SELECT * FROM tblMonHoc";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        //lay thong tin gv
        public DataTable LayThongTinGV()
        {
            string sql = "SELECT * FROM tblGiaoVien";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        // Xóa
        public void Xoa_TTGD(string TenLop, DateTime NgayDay, int Tiet)
        {
            string sql = "Xoa_CTDG";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenlop", TenLop);
            cmd.Parameters.AddWithValue("@ngayday", NgayDay);
            cmd.Parameters.AddWithValue("@tiet", Tiet);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void Sua_TTGD(string TenLop, string TenGV, string TenMon, DateTime NgayDay, int Tiet)
        {
            string sql = "SuaCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlop", TenLop);
            cmd.Parameters.AddWithValue("@tengv", TenGV);
            cmd.Parameters.AddWithValue("@tenmon", TenMon);
            cmd.Parameters.AddWithValue("@ngayday", NgayDay.Date);
            cmd.Parameters.AddWithValue("@tiet", Tiet);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}

