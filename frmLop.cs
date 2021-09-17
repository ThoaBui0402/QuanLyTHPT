using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHSTHPT.Component;
using DevComponents.DotNetBar;
using QLHSTHPT.Controller;


namespace QLHSTHPT
{
    public partial class frmLop : Office2007Form
    {
        #region Fields
        LopCtrl m_LopCtrl = new LopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_GiaoVienCtrl.HienThiComboBox(cmbGiaoVien);
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);

            m_LopCtrl.HienThi(dGVLop, txtMaLop, txtTenLop, cmbKhoiLop, cmbNamHoc, iniSiSo, cmbGiaoVien);
        }
        #endregion

        #region BindingNavigatorItems


        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_LopCtrl.HienThi(dGVLop, txtMaLop, txtTenLop, cmbKhoiLop, cmbNamHoc, iniSiSo, cmbGiaoVien);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVLop.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraSiSoTruocKhiLuu(String siSoColumn)
        {
            foreach (DataGridViewRow row in dGVLop.Rows)
            {
                if (row.Cells[siSoColumn].Value != null)
                {
                    try
                    {
                        int siSo = Convert.ToInt32(row.Cells[siSoColumn].Value.ToString());

                        if (quyDinh.KiemTraSiSo(siSo) == false)
                        {
                            MessageBoxEx.Show("Sỉ số không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBoxEx.Show("Sỉ số phải là một số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLop") == true &&
                KiemTraTruocKhiLuu("colTenLop") == true &&
                KiemTraTruocKhiLuu("colMaKhoiLop") == true &&
                KiemTraTruocKhiLuu("colMaNamHoc") == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
                KiemTraSiSoTruocKhiLuu("colSiSo") == true)
            {
                m_LopCtrl.LuuLop();
            }
        }
        #endregion

        #region DataError event
        private void dGVLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Tìm kiếm lớp
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemLop();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemLop();
        }

        void TimKiemLop()
        {
            if (chkTimTheoMa.Checked == true)
            {
                m_LopCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_LopCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }
        #endregion

        #region Click event


        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNamHoc();
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);
        }


        #endregion

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu them!");
        }
    }
}
