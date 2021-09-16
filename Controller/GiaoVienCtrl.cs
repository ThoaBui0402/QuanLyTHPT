using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Collections.Generic;
using QLHSTHPT.DataLayer;
using QLHSTHPT.Bussiness;

namespace QLHSTHPT.Controller
{
    public class GiaoVienCtrl
    {
        GiaoVienData m_GiaoVienData = new GiaoVienData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_GiaoVienData.LayDsGiaoVien();
            comboBox.DisplayMember = "TenGiaoVien";
            comboBox.ValueMember = "MaGiaoVien";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_GiaoVienData.LayDsGiaoVien();
            cmbColumn.DisplayMember = "TenGiaoVien";
            cmbColumn.ValueMember = "MaGiaoVien";
            cmbColumn.DataPropertyName = "MaGiaoVien";
            cmbColumn.HeaderText = "Giáo viên";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_GiaoVienData.LayDsGiaoVien();
            dGV.DataSource = bS;
        }

        
        #endregion

        #region Lay danh sach giao vien do vao report
        public static IList<GiaoVienInfo> LayDsGiaoVien()
        {
            GiaoVienData m_GVData = new GiaoVienData();
            DataTable m_DT = m_GVData.LayDsGiaoVienForReport();

            IList<GiaoVienInfo> dS = new List<GiaoVienInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                GiaoVienInfo gv = new GiaoVienInfo();

                MonHocInfo mh = new MonHocInfo();
                mh.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
                mh.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);
                mh.SoTiet = Convert.ToInt32(Row["SoTiet"]);
                mh.HeSo = Convert.ToInt32(Row["HeSo"]);

                gv.MaGiaoVien = Convert.ToString(Row["MaGiaoVien"]);
                gv.TenGiaoVien = Convert.ToString(Row["TenGiaoVien"]);
                gv.DiaChi = Convert.ToString(Row["DiaChi"]);
                gv.DienThoai = Convert.ToString(Row["DienThoai"]);
                gv.MonHoc = mh;

                dS.Add(gv);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_GiaoVienData.ThemDongMoi();
        }
        

        public void ThemGiaoVien(DataRow m_Row)
        {
            m_GiaoVienData.ThemGiaoVien(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuGiaoVien()
        {
            return m_GiaoVienData.LuuGiaoVien();
        }

        public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon)
        {
            m_GiaoVienData.LuuGiaoVien(maGiaoVien, tenGiaoVien, diaChi, dienThoai, chuyenMon);
        }
        #endregion

        #region Tìm kiem
        public void TimKiemGiaoVien(TextBoxX txtHoTen,
                                    ComboBoxEx cmbTheoDChi,
                                    TextBoxX txtDiaChi,
                                    ComboBoxEx cmbTheoCMon,
                                    ComboBoxEx cmbCMon,
                                    DataGridViewX dGV)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_GiaoVienData.TimKiemGiaoVien(txtHoTen.Text, cmbTheoDChi.Text, txtDiaChi.Text, cmbTheoCMon.Text, cmbCMon.Text);

            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaGiaoVien)
        {
            m_GiaoVienData.TimTheoMa(m_MaGiaoVien);
        }
        
        public void TimTheoTen(String m_TenGiaoVien)
        {
            m_GiaoVienData.TimTheoTen(m_TenGiaoVien);
        }
        #endregion
    }
}
