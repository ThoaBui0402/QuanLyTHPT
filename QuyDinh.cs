using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT
{
    class QuyDinh
    {
        public QuyDinh()
        {

        }

        private int m_TuoiCanDuoi;
        public int TuoiCanDuoi
        {
            get { return m_TuoiCanDuoi; }
            set { m_TuoiCanDuoi = value; }
        }

        private int m_TuoiCanTren;
        public int TuoiCanTren
        {
            get { return m_TuoiCanTren; }
            set { m_TuoiCanTren = value; }
        }

        private int m_SiSoCanDuoi;
        public int SiSoCanDuoi
        {
            get { return m_SiSoCanDuoi; }
            set { m_SiSoCanDuoi = value; }
        }

        private int m_SiSoCanTren;
        public int SiSoCanTren
        {
            get { return m_SiSoCanTren; }
            set { m_SiSoCanTren = value; }
        }

        private int m_ThangDiem10;
        public int ThangDiem10
        {
            get { return m_ThangDiem10; }
            set { m_ThangDiem10 = value; }
        }

        private int m_ThangDiem100;
        public int ThangDiem100
        {
            get { return m_ThangDiem100; }
            set { m_ThangDiem100 = value; }
        }
        private String m_TenTruong;
        public String TenTruong
        {
            get { return m_TenTruong; }
            set { m_TenTruong = value; }
        }

        private String m_DiaChiTruong;
        public String DiaChiTruong
        {
            get { return m_DiaChiTruong; }
            set { m_DiaChiTruong = value; }
        }
        public QuyDinh(string m_TuoiCanDuoi, string m_TuoiCanTren,string m_SiSoCanDuoi, string m_SiSoCanTren, string m_ThangDiem10,string m_ThangDiem100, string m_TenTruong, string m_DiaChiTruong)
        {
            this.m_DiaChiTruong = DiaChiTruong;
            this.m_TenTruong = TenTruong;
            this.m_SiSoCanTren = SiSoCanTren;
            this.m_ThangDiem10 = ThangDiem10;
            this.m_ThangDiem100 = ThangDiem10;
            this.m_SiSoCanDuoi = SiSoCanDuoi;
            this.m_TuoiCanDuoi = TuoiCanDuoi;
            this.m_TuoiCanTren = TuoiCanTren;
        }
        public Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH"));

            int siSoMin = Convert.ToInt32(dS.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dS.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax)
                return true;
            else
                return false;
        }
    }
}

