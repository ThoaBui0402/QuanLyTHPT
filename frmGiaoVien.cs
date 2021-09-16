using DevComponents.DotNetBar;
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
    public partial class frmGiaoVien : Office2007Form
    {
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        public frmGiaoVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbMonHoc);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);

            m_GiaoVienCtrl.HienThi(dGVGiaoVien);
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVGiaoVien.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin giáo viên " + row.Cells["colTenGiaoVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }


        private void btnLuuVaoDS_Click_1(object sender, EventArgs e)
        {
            if (txtMaGiaoVien.Text != null && txtTenGiaoVien.Text != null && txtDiaChi.Text != null && txtDienThoai.Text != null && cmbMonHoc.SelectedValue != null)
            {

                m_GiaoVienCtrl.LuuGiaoVien(txtMaGiaoVien.Text, txtTenGiaoVien.Text, txtDiaChi.Text, txtDienThoai.Text, cmbMonHoc.SelectedValue.ToString());
                if (m_GiaoVienCtrl.LuuGiaoVien())
                {
                    MessageBoxEx.Show("Luu thanh cong !");
                    m_GiaoVienCtrl.HienThi(dGVGiaoVien);
                }


            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
