using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
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
    public partial class frmQuyDinh : Form
    {
        private object tabControlPanelSiSo1;

        public frmQuyDinh()
        {
            InitializeComponent();
        }

      public frmQuyDinh(object tabControlPanelSiSo1)
        {
            this.tabControlPanelSiSo1 = tabControlPanelSiSo1;
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)

        {
            QuyDinh temp =new QuyDinh(txtSiSoCanDuoi.Text, txtSiSoCanTren.Text, txtDoTuoiCanDuoi.Text, txtDoTuoiCanTren.Text, ckbThang10.Text, ckbThang100.Text, txtTenTruong.Text, txtDiaChiTruong.Text);
            
        }

        
        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {

            QuyDinh temp = new QuyDinh(txtSiSoCanDuoi.Text, txtSiSoCanTren.Text, txtDoTuoiCanDuoi.Text, txtDoTuoiCanTren.Text, ckbThang10.Text, ckbThang100.Text, txtTenTruong.Text, txtDiaChiTruong.Text);
            Connetion.CapNhatQuyDinhSiSo(siSoCanDuoi, siSoCanTren);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            QuyDinh temp = new QuyDinh(txtSiSoCanDuoi.Text, txtSiSoCanTren.Text, txtDoTuoiCanDuoi.Text, txtDoTuoiCanTren.Text, ckbThang10.Text, ckbThang100.Text, txtTenTruong.Text, txtDiaChiTruong.Text);
            Connetion.CapNhatQuyDinhDoTuoi(tuoiCanDuoi, tuoiCanTren);
        }

        public void CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
            QuyDinh temp = new QuyDinh(txtSiSoCanDuoi.Text, txtSiSoCanTren.Text, txtDoTuoiCanDuoi.Text, txtDoTuoiCanTren.Text, ckbThang10.Text, ckbThang100.Text, txtTenTruong.Text, txtDiaChiTruong.Text);
            Connetion.CapNhatQuyDinhTruong(tenTruong, diaChiTruong);
        }

        public void CapNhatQuyDinhThangDiem(int thangDiem)
        {
            QuyDinh temp = new QuyDinh(txtSiSoCanDuoi.Text, txtSiSoCanTren.Text, txtDoTuoiCanDuoi.Text, txtDoTuoiCanTren.Text, ckbThang10.Text, ckbThang100.Text, txtTenTruong.Text, txtDiaChiTruong.Text);
            Connetion.CapNhatQuyDinhThangDiem(thangDiem);
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlPanelSiSo.CanSelect)
            {
                if (txtSiSoCanDuoi.Value <= 10 || txtSiSoCanTren.Value >= 60)
                    MessageBoxEx.Show("Sỉ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Connetion.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về sỉ số!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            else if (tabControlPanelDoTuoi.CanSelect)
            {
                if (txtDoTuoiCanDuoi.Value <= 10 || txtDoTuoiCanTren.Value >= 30)
                    MessageBoxEx.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 30!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Connetion.CapNhatQuyDinhDoTuoi(txtDoTuoiCanDuoi.Value, txtDoTuoiCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            else if (tabControlPanelTruong.CanSelect)
            {
                if (txtTenTruong.Text == "")
                    MessageBoxEx.Show("Tên trường học là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtDiaChiTruong.Text == "")
                    MessageBoxEx.Show("Địa chỉ trường là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Connetion.CapNhatQuyDinhTruong(txtTenTruong.Text, txtDiaChiTruong.Text);
                    MessageBoxEx.Show("Cập nhật thành công thông tin trường học!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            else if (tabControlPanelThangDiem.CanSelect)
            {
                if (ckbThang10.Checked == true)
                {
                    Connetion.CapNhatQuyDinhThangDiem(10);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    Connetion.CapNhatQuyDinhThangDiem(100);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
