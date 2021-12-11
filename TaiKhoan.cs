using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTHPT
{
    class TaiKhoan
    {
        ConnectDB cn = new ConnectDB();


        public DataTable Show()
        {
            return LoadData("HienThi_NguoiDung");
        }
        public void NguoiDung_DB(string proc, string manv, string matkhau, string laadmin)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;
                command.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = manv;
                command.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = matkhau;
                command.Parameters.AddWithValue("@LaAdmin", SqlDbType.VarChar).Value = laadmin;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public DataTable LoadData(string proc)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            cn.Close();
            adapter.Dispose();
            return data;
        }


        public DataTable LoadData1(string proc, string param, string value)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = value;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cn.Close();
            adapter.Dispose();
            return table;
        }
        public void Xoa(string proc, string param, string ma)
        {
            try
            {
                
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                SqlCommand command = new SqlCommand(proc, cn);
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = ma;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
