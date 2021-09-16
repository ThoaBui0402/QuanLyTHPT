using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHSTHPT.DataLayer;

namespace QLHSTHPT.Controller
{
    public class PhanCongCtrl
    {
        PhanCongData m_PhanCongData = new PhanCongData();

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            TextBoxX txtSTT,
                            ComboBoxEx cmbNamHoc,
                            ComboBoxEx cmbLop,
                            ComboBoxEx cmbMonHoc,
                            ComboBoxEx cmbGiaoVien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_PhanCongData.LayDsPhanCong();

            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("Text", bS, "STT");

            cmbNamHoc.DataBindings.Clear();
            cmbNamHoc.DataBindings.Add("SelectedValue", bS, "MaNamHoc");

            cmbLop.DataBindings.Clear();
            cmbLop.DataBindings.Add("SelectedValue", bS, "MaLop");

            cmbMonHoc.DataBindings.Clear();
            cmbMonHoc.DataBindings.Add("SelectedValue", bS, "MaMonHoc");

            cmbGiaoVien.DataBindings.Clear();
            cmbGiaoVien.DataBindings.Add("SelectedValue", bS, "MaGiaoVien");

            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_PhanCongData.ThemDongMoi();
        }


        public void ThemPhanCong(DataRow m_Row)
        {
            m_PhanCongData.ThemPhanCong(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuPhanCong()
        {
            return m_PhanCongData.LuuPhanCong();
        }

        public void LuuPhanCong(String maNamHoc, String maLop, String maMonHoc, String maGiaoVien)
        {
            m_PhanCongData.LuuPhanCong(maNamHoc, maLop, maMonHoc, maGiaoVien);
        }
        public void SuaPhanCong(int STT, String maNamHoc, String maLop, String maMonHoc, String maGiaoVien)
        {
            m_PhanCongData.SuaPhanCong(STT, maNamHoc, maLop, maMonHoc, maGiaoVien);
        }
        public void XoaPhanCong(int STT)
        {
            m_PhanCongData.XoaPhanCong(STT);
        }
        #endregion

    }
}
