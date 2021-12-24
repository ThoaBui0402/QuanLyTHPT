using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTHPT
{
    class TTGD
    {
        public DataTable Show()
        {
            string sql = "SELECT lop.TenLop, GV.HoTen, m.TenMon,tt.NgayDay, tt.Tiet FROM tblLop lop, tblGiaoVien gv, tblMonHoc m, tblCTGD tt where lop.MaLop=tt.MaLop and gv.MaGV=tt.MaGV";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }


        public void ThemTTGD(string TenLop, string HoTen,string TenMon, DateTime NgayDay, int Tiet)
        {
            string sql = "ThemCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@TenMon", TenMon);
            cmd.Parameters.AddWithValue("@NgayDay", NgayDay);
            cmd.Parameters.AddWithValue("@Tiet", Tiet);

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

        //lay thong tin GV
        public DataTable LayThongTinGV()
        {
            string sql = "SELECT * FROM tblGiaoVien";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        //lay mon hoc
        public DataTable LayThongTinMH()
        {
            string sql = "SELECT * FROM tblMonHoc";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        // Xóa
        public void Xoa_TTGD(string MaHS)
        {
            string sql = "Xoa_HS";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void Sua_TTGD(string TenLop, string HoTen, string TenMon, string NgayDay, int Tiet)
        {
            string sql = "SuaCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenLop", TenLop);
            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@TenMon", TenMon);
            cmd.Parameters.AddWithValue("@NgayDay", NgayDay);
            cmd.Parameters.AddWithValue("@Tiet", Tiet);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
