using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLHSTHPT
{
    class Connetion
    {
        static SqlConnection conn;


        public static void ConnectDB()
        {
            conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=QLHocSinhTHPT;Integrated Security=True");
            conn.Open();
        }

        public static bool Login(string tk, string mk)
        {
            string sql = "select * from [NGUOIDUNG] where TenDNhap=@usr and MatKhau=@pass";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@usr", tk));
                command.Parameters.Add(new SqlParameter("@pass", mk));

                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        Program.usernamelogin = tk;
                        return true;
                    }


                }

            }
            return false;
        }

        public static void thayDoiMatKhau(string tk, string mk)
        {
            string sql = "UPDATE NGUOIDUNG set MatKhau=@mk where TenDNhap=@tk";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mk", mk));
                command.Parameters.Add(new SqlParameter("@tk", tk));

                command.ExecuteNonQuery();
                command.Cancel();
            }

        }

        public static DataTable getAllHocSinh()
        {
            string sql = "select * from HOCSINH";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public static void ThemTaiKhoan(DangNhap dn)
        {
            string sql = "insert into NGUOIDUNG(MaND,MaLoai,TenND,TenDNhap, MatKhau) values(@mand,@maloai,@tennd,@tendnhap, @mk)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@mand", dn.maND));
                command.Parameters.Add(new SqlParameter("@maloai", dn.maLoai));
                command.Parameters.Add(new SqlParameter("@tennd", dn.tenND));
                command.Parameters.Add(new SqlParameter("@tendnhap", dn.tenDNnhap));
                command.Parameters.Add(new SqlParameter("@mk", dn.matKhau));
                

                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm tài khoản mới thành công!");
                }
                else MessageBox.Show("Thêm tài khoản mới thất bại!");
                command.Cancel();
            }
        }
        //**************Quy Định***************************//
     //   DataTable m_QuyDinhData = new DataTable();

        public static DataTable LayDsQuyDinh()
        {
            string sql ="SELECT * FROM QUYDINH";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }

        public static void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            string sql = "UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@siSoCanDuoi", siSoCanDuoi));
                command.Parameters.Add(new SqlParameter("@siSoCanTren", siSoCanTren));
                command.ExecuteNonQuery();
                command.Cancel();
            }
        }

        public static void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            string sql="UPDATE QUYDINH SET TuoiCanDuoi = @tuoiCanDuoi, TuoiCanTren = @tuoiCanTren";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tuoiCanDuoi", tuoiCanDuoi));
                command.Parameters.Add(new SqlParameter("@tuoiCanTren", tuoiCanTren));
                command.ExecuteNonQuery();
                command.Cancel();
            }
          
        }

        public static void CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
            string sql="UPDATE QUYDINH SET TenTruong = @tenTruong, DiaChiTruong = @diaChiTruong";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenTruong", tenTruong));
                command.Parameters.Add(new SqlParameter("@diaChiTruong", diaChiTruong));
                command.ExecuteNonQuery();
                command.Cancel();
            }
            
        }

        public static void CapNhatQuyDinhThangDiem(int thangDiem)
        {
            string sql ="UPDATE QUYDINH SET ThangDiem = @thangDiem";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@thangDiem", thangDiem));
                command.ExecuteNonQuery();
                command.Cancel();
            }
            
        }
    }
}
