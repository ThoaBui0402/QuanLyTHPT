using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHSTHPT.DataLayer
{
    public class PhanCongData
    {
        DataService m_PhanCongData = new DataService();

        public DataTable LayDsPhanCong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHANCONG");
            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataRow ThemDongMoi()
        {
            return m_PhanCongData.NewRow();
        }

        public void ThemPhanCong(DataRow m_Row)
        {
            m_PhanCongData.Rows.Add(m_Row);
        }

        public bool LuuPhanCong()
        {
            return m_PhanCongData.ExecuteNoneQuery() > 0;
        }

        public void LuuPhanCong(String maNamHoc, String maLop, String maMonHoc, String maGiaoVien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PHANCONG VALUES(@maNamHoc, @maLop, @maMonHoc, @maGiaoVien)");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = maGiaoVien;

            m_PhanCongData.Load(cmd);
        }


        public void SuaPhanCong(int STT, String maNamHoc, String maLop, String maMonHoc, String maGiaoVien)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PHANCONG SET maNamHoc=@maNamHoc,maLop=@maLop,maMonHoc=@maMonHoc, maGiaoVien=@maGiaoVien where STT=@STT");
            cmd.Parameters.Add("STT", SqlDbType.Int).Value = STT;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = maGiaoVien;
            m_PhanCongData.Load(cmd);
        }

        public void XoaPhanCong(int STT)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM PHANCONG WHERE STT=@STT");
            cmd.Parameters.Add("STT", SqlDbType.Int).Value = STT;

            m_PhanCongData.Load(cmd);
        }


    }
}
