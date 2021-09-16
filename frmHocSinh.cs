using DevComponents.DotNetBar;
using QLHSTHPT.Component;
using QLHSTHPT.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public partial class frmHocSinh : Form
    {
        #region Fields
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        NgheNghiepCtrl m_NgheNghiepChaCtrl = new NgheNghiepCtrl();
        NgheNghiepCtrl m_NgheNghiepMeCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion
        private void groupBoxDanhSach_Enter(object sender, EventArgs e)
        {

        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(cmbDanToc);
            m_TonGiaoCtrl.HienThiComboBox(cmbTonGiao);
            m_NgheNghiepChaCtrl.HienThiComboBox(cmbNgheNghiepCha);
            m_NgheNghiepMeCtrl.HienThiComboBox(cmbNgheNghiepMe);

            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(colMaDanToc);
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(colMaTonGiao);
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(colMaNNghiepCha);
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(colMaNNghiepMe);

            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);
        }
        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dGVHocSinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());

                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi học sinh " + row.Cells["colHoTen"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocSinh") == true &&
                KiemTraTruocKhiLuu("colHoTen") == true &&
                KiemTraTruocKhiLuu("colNoiSinh") == true &&
                KiemTraTruocKhiLuu("colMaDanToc") == true &&
                KiemTraTruocKhiLuu("colMaTonGiao") == true &&
                KiemTraTruocKhiLuu("colHoTenCha") == true &&
                KiemTraTruocKhiLuu("colMaNNghiepCha") == true &&
                KiemTraTruocKhiLuu("colHoTenMe") == true &&
                KiemTraTruocKhiLuu("colMaNNghiepMe") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("colNgaySinh") == true)
                {
                    m_HocSinhCtrl.LuuHocSinh();
                }
            }
        }

        #region DataError event
        private void dGVHocSinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion



        #region Click event
        private void dGVHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtGioiTinh.Text == "True")
                ckbGTinhNu.Checked = true;
            else
                ckbGTinhNam.Checked = true;
        }

        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanToc();
            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(colMaDanToc);
        }

        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTonGiao();
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(colMaTonGiao);
        }

        private void btnThemNNCha_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNgheNghiep();
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(colMaNNghiepCha);
        }

        private void btnThemNNMe_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNgheNghiep();
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(colMaNNghiepMe);
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (ckbGTinhNu.Checked == true)
                gioiTinh = true;

            if (txtMaHocSinh.Text != "" &&
                txtTenHocSinh.Text != "" &&
                txtNoiSinh.Text != "" &&
                txtHoTenCha.Text != "" &&
                txtHoTenMe.Text != "" &&
                dtpNgaySinh.Value != null &&
                cmbDanToc.SelectedValue != null &&
                cmbTonGiao.SelectedValue != null &&
                cmbNgheNghiepCha.SelectedValue != null &&
                cmbNgheNghiepMe.SelectedValue != null)
            {
                if (quyDinh.KiemTraDoTuoi(dtpNgaySinh.Value) == true)
                {
                    m_HocSinhCtrl.LuuHocSinh(txtMaHocSinh.Text, txtTenHocSinh.Text, gioiTinh, dtpNgaySinh.Value, txtNoiSinh.Text, cmbDanToc.SelectedValue.ToString(), cmbTonGiao.SelectedValue.ToString(), txtHoTenCha.Text, cmbNgheNghiepCha.SelectedValue.ToString(), txtHoTenMe.Text, cmbNgheNghiepMe.SelectedValue.ToString());
                    m_HocSinhCtrl.HienThi(dGVHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtTenHocSinh, txtGioiTinh, ckbGTinhNam, ckbGTinhNu, dtpNgaySinh, txtNoiSinh, cmbDanToc, cmbTonGiao, txtHoTenCha, cmbNgheNghiepCha, txtHoTenMe, cmbNgheNghiepMe);

                    bindingNavigatorHocSinh.BindingSource.MoveLast();
                    MessageBoxEx.Show("Luu thanh cong1");
                }
                else
                    MessageBoxEx.Show("Tuổi của học sinh " + txtTenHocSinh.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion


    }

}