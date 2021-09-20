﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiTHPT
{
    public class GiaoVien
    {
        public DataTable Show()
        {
            string sql = "SELECT gv.MaGV, gv.HoTen, gv.GT, gv.NgaySinh, gv.DiaChi, gv.Luong, gv.SDT, mh.TenMon FROM tblGiaoVien gv, tblMonHoc mh where gv.MaMon = mh.MaMon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Show(string tenmon)
        {
            string sql = "SELECT gv.MaGV, gv.HoTen FROM tblGiaoVien gv, tblMonHoc mh where gv.MaMon = mh.MaMon and mh.TenMon=N'" + tenmon + "'";
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
        public void ADDGiaoVien(string HoTen, string GT, string NgaySinh, string DiaChi, string SDT, string Luong, string MaMon)
        {
            string sql = "ADD_GV";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HoTen", HoTen);
            cmd.Parameters.AddWithValue("@GT", GT);
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(NgaySinh));
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@SDT", int.Parse(SDT));
            cmd.Parameters.AddWithValue("@Luong", int.Parse(Luong));
            cmd.Parameters.AddWithValue("@MaMon", MaMon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        #endregion
        public DataTable LayThongTinMonHoc()
        {
            string sql = "SELECT * FROM tblMonHoc";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
    }
}
