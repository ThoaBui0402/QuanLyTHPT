using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLHSTHPT.Bussiness;
//using QLHocSinhTHPT.Reports;
using QLHSTHPT.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;

namespace QLHSTHPT.Component
{
    #region Utilities
    public static class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    #endregion

    #region QuyDinh
    public class QuyDinh
    {
        public static QuyDinhInfo LayThongTinTruong()
        {
            QuyDinhInfo m_Truong = new QuyDinhInfo();
            DataService dS = new DataService();

            dS.Load(new SqlCommand("SELECT TenTruong, DiaChiTruong FROM QUYDINH"));

            if (dS.Rows.Count > 0)
            {
                m_Truong.TenTruong = dS.Rows[0]["TenTruong"].ToString();
                m_Truong.DiaChiTruong = dS.Rows[0]["DiaChiTruong"].ToString();
            }

            return m_Truong;
        }

        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT ThangDiem FROM QUYDINH"));

            int thangDiem = Convert.ToInt32(dS.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
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

        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);

            int doTuoi    = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
    #endregion

    #region ThamSo
    public static class ThamSo
    {
        #region Fields
   //     public static frmAbout                  m_FrmAbout              = null;
    //   public static frmConnection             m_FrmConnection         = null;
        public static frmGiaoVien m_FrmGiaoVien           = null;
        public static frmHocSinh m_FrmHocSinh            = null;
        public static frmLop                    m_FrmLop                = null;
        public static frmMain1                   m_FrmMain               = null;
        public static frmPhanCong               m_FrmPhanCong           = null;
        public static frmLoaiNguoiDung          m_FrmLoaiNguoiDung      = null;
        public static frmTimKiemGV              m_TimKiemGV             = null;
        public static frmTimKiemHS              m_TimKiemHS             = null;
        public static frmQuyDinh                m_FrmQuyDinh            = null;
        //public static frptDanhSachGiaoVien      m_FrmDSGiaoVien         = null;
        //public static frptDanhSachHocSinh       m_FrmDSHocSinh          = null;
        //public static frptDanhSachLopHoc        m_FrmDSLopHoc           = null;
        //public static frptKetQuaCaNam_Lop       m_FrmKetQuaCaNam_Lop    = null;
        //public static frptKetQuaCaNam_MonHoc    m_FrmKetQuaCaNam_MonHoc = null;
        //public static frptKetQuaHocKy_Lop       m_FrmKetQuaHocKy_Lop    = null;
        //public static frptKetQuaHocKy_MonHoc    m_FrmKetQuaHocKy_MonHoc = null;
        #endregion

        #region Ham goi hien form
        #region Menu start
        public static void ShowFormLoaiNguoiDung()
        {
            if (m_FrmLoaiNguoiDung == null || m_FrmLoaiNguoiDung.IsDisposed)
            {
                m_FrmLoaiNguoiDung = new frmLoaiNguoiDung();
                m_FrmLoaiNguoiDung.MdiParent = frmMain1.ActiveForm;
                m_FrmLoaiNguoiDung.Show();
            }
            else
                m_FrmLoaiNguoiDung.Activate();
        }
        #endregion

        #region Menu quan ly
        public static void ShowFormLopHoc()
        {
            if (m_FrmLop == null || m_FrmLop.IsDisposed)
            {
                m_FrmLop = new frmLop();
                m_FrmLop.MdiParent = frmMain1.ActiveForm;
                m_FrmLop.Show();
            }
            else
                m_FrmLop.Activate();
        }

        public static void ShowFormKhoiLop()
        {
           
        }

        public static void ShowFormHocKy()
        {
         
        }

        public static void ShowFormNamHoc()
        {
           
        }

        public static void ShowFormMonHoc()
        {
          
        }

        public static void ShowFormLoaiDiem()
        {
            
        }

        public static void ShowFormNhapDiemRieng()
        {
           
        }

        public static void ShowFormNhapDiemChung()
        {
            
        }

        public static void ShowFormXemDiem()
        {
           
        }

        public static void ShowFormKetQua()
        {
        }

        public static void ShowFormHocLuc()
        {
        }

        public static void ShowFormHanhKiem()
        {
           
        }

        public static void ShowFormHocSinh()
        {
            if (m_FrmHocSinh == null || m_FrmHocSinh.IsDisposed)
            {
                m_FrmHocSinh = new frmHocSinh();
                m_FrmHocSinh.MdiParent = frmMain1.ActiveForm;
                m_FrmHocSinh.Show();
            }
            else
                m_FrmHocSinh.Activate();
        }

        public static void ShowFormPhanLop()
        {
            
        }

        public static void ShowFormDanToc()
        {
           
        }

        public static void ShowFormTonGiao()
        {
            
        }

        public static void ShowFormNgheNghiep()
        {
            
        }

        public static void ShowFormGiaoVien()
        {
            if (m_FrmGiaoVien == null || m_FrmGiaoVien.IsDisposed)
            {
                m_FrmGiaoVien = new frmGiaoVien();
                m_FrmGiaoVien.MdiParent = frmMain1.ActiveForm;
                m_FrmGiaoVien.Show();
            }
            else
                m_FrmGiaoVien.Activate();
        }

        public static void ShowFormPhanCong()
        {
            if (m_FrmPhanCong == null || m_FrmPhanCong.IsDisposed)
            {
                m_FrmPhanCong = new frmPhanCong();
                m_FrmPhanCong.MdiParent = frmMain1.ActiveForm;
                m_FrmPhanCong.Show();
            }
            else
                m_FrmPhanCong.Activate();
        }
        #endregion

        //#region Menu thong ke
        //public static void ShowFormKQHKTheoLop()
        //{
        //    if (m_FrmKetQuaHocKy_Lop == null || m_FrmKetQuaHocKy_Lop.IsDisposed)
        //    {
        //        m_FrmKetQuaHocKy_Lop = new frptKetQuaHocKy_Lop();
        //        m_FrmKetQuaHocKy_Lop.MdiParent = frmMain.ActiveForm;
        //        m_FrmKetQuaHocKy_Lop.Show();
        //    }
        //    else
        //        m_FrmKetQuaHocKy_Lop.Activate();
        //}

        //public static void ShowFormKQHKTheoMon()
        //{
        //    if (m_FrmKetQuaHocKy_MonHoc == null || m_FrmKetQuaHocKy_MonHoc.IsDisposed)
        //    {
        //        m_FrmKetQuaHocKy_MonHoc = new frptKetQuaHocKy_MonHoc();
        //        m_FrmKetQuaHocKy_MonHoc.MdiParent = frmMain.ActiveForm;
        //        m_FrmKetQuaHocKy_MonHoc.Show();
        //    }
        //    else
        //        m_FrmKetQuaHocKy_MonHoc.Activate();
        //}

        //public static void ShowFormKQCNTheoLop()
        //{
        //    if (m_FrmKetQuaCaNam_Lop == null || m_FrmKetQuaCaNam_Lop.IsDisposed)
        //    {
        //        m_FrmKetQuaCaNam_Lop = new frptKetQuaCaNam_Lop();
        //        m_FrmKetQuaCaNam_Lop.MdiParent = frmMain.ActiveForm;
        //        m_FrmKetQuaCaNam_Lop.Show();
        //    }
        //    else
        //        m_FrmKetQuaCaNam_Lop.Activate();
        //}

        //public static void ShowFormKQCNTheoMon()
        //{
        //    if (m_FrmKetQuaCaNam_MonHoc == null || m_FrmKetQuaCaNam_MonHoc.IsDisposed)
        //    {
        //        m_FrmKetQuaCaNam_MonHoc = new frptKetQuaCaNam_MonHoc();
        //        m_FrmKetQuaCaNam_MonHoc.MdiParent = frmMain.ActiveForm;
        //        m_FrmKetQuaCaNam_MonHoc.Show();
        //    }
        //    else
        //        m_FrmKetQuaCaNam_MonHoc.Activate();
        //}

        //public static void ShowFormDanhSachHocSinh()
        //{
        //    if (m_FrmDSHocSinh == null || m_FrmDSHocSinh.IsDisposed)
        //    {
        //        m_FrmDSHocSinh = new frptDanhSachHocSinh();
        //        m_FrmDSHocSinh.MdiParent = frmMain.ActiveForm;
        //        m_FrmDSHocSinh.Show();
        //    }
        //    else
        //        m_FrmDSHocSinh.Activate();
        //}

        //public static void ShowFormDanhSachGiaoVien()
        //{
        //    if (m_FrmDSGiaoVien == null || m_FrmDSGiaoVien.IsDisposed)
        //    {
        //        m_FrmDSGiaoVien = new frptDanhSachGiaoVien();
        //        m_FrmDSGiaoVien.MdiParent = frmMain.ActiveForm;
        //        m_FrmDSGiaoVien.Show();
        //    }
        //    else
        //        m_FrmDSGiaoVien.Activate();
        //}

        //public static void ShowFormDanhSachLopHoc()
        //{
        //    if (m_FrmDSLopHoc == null || m_FrmDSLopHoc.IsDisposed)
        //    {
        //        m_FrmDSLopHoc = new frptDanhSachLopHoc();
        //        m_FrmDSLopHoc.MdiParent = frmMain.ActiveForm;
        //        m_FrmDSLopHoc.Show();
        //    }
        //    else
        //        m_FrmDSLopHoc.Activate();
        //}
        //#endregion

        #region Menu tra cuu
        public static void ShowFormTimKiemHS()
        {
            if (m_TimKiemHS == null || m_TimKiemHS.IsDisposed)
            {
                m_TimKiemHS = new frmTimKiemHS();
                m_TimKiemHS.MdiParent = frmMain1.ActiveForm;
                m_TimKiemHS.Show();
            }
            else
                m_TimKiemHS.Activate();
        }

        public static void ShowFormTimKiemGV()
        {
            if (m_TimKiemGV == null || m_TimKiemGV.IsDisposed)
            {
                m_TimKiemGV = new frmTimKiemGV();
                m_TimKiemGV.MdiParent = frmMain1.ActiveForm;
                m_TimKiemGV.Show();
            }
            else
                m_TimKiemGV.Activate();
        }
        #endregion

        #region Menu quy dinh
        public static void ShowFormQuyDinh()
        {
            if (m_FrmQuyDinh == null || m_FrmQuyDinh.IsDisposed)
            {
                m_FrmQuyDinh = new frmQuyDinh();
                m_FrmQuyDinh.Show();
            }
            else
                m_FrmQuyDinh.Activate();
        }

        
        #endregion

        #region Menu giup do
        //public static void ShowFormThongTin()
        //{
        //    if (m_FrmAbout == null || m_FrmAbout.IsDisposed)
        //    {
        //     //   m_FrmAbout = new frmAbout();
        //        m_FrmAbout.Show();
        //    }
        //    else
        //        m_FrmAbout.Activate();
        //}
        #endregion
        #endregion
    }
    #endregion

    #region Các hàm xử lý tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();
            
            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");
            
            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    #endregion
}