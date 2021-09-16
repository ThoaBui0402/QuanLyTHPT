using DevComponents.DotNetBar;
using QLHSTHPT.Component;
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
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();
            chenBang();
        }
        private void chenBang()
        {
            BindingSource soureTB = new BindingSource();
            soureTB.DataSource = Connetion.getAllHocSinh();
            dgwTotal.DataSource = soureTB;
        }



        private void ribbonTabItem6_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        /*    private void ribbonBar1_ItemClick(object sender, EventArgs e)
            { 
                frmLop frm = new frmLop();
                frm.Show();
            }*/

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {
            ThemTaiKhoan frm = new ThemTaiKhoan();
            frm.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar7_ItemClick(object sender, EventArgs e)
        {
            ThamSo.ShowFormGiaoVien();
        }

        /*   private void ribbonBar4_ItemClick(object sender, EventArgs e)
           {
               frmHocSinh frm = new frmHocSinh();
               frm.Show();
           }

           private void ribbonBar7_ItemClick(object sender, EventArgs e)
           {
               frmGiaoVien frm = new frmGiaoVien();
               frm.Show();
           }

           private void buttonItem6_Click(object sender, EventArgs e)
           {
               frmTimKiemHS frm = new frmTimKiemHS();
               frm.Show();
           }

           private void buttonItem7_Click(object sender, EventArgs e)
           {
               frmTimKiemGV frm = new frmTimKiemGV();
               frm.Show();
           }*/

        private void ribbonBar5_ItemClick(object sender, EventArgs e)
        {
            Program.usernamelogin = "";
            this.Close();
            D frm = new D();
            frm.Show();
        }

        private void ribbonBar6_ItemClick(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau();
            frm.Show();
        }

        private void dgwTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.Show();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.Show();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.Show();
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.Show();
        }

        frmConnection m_Connection = null;
        private void frmMain1_Load(object sender, EventArgs e)
        {
            if (DataService.OpenConnection() == false)
            {
                ReConnection();
            }

        }
        #region Kết nối lại CSDL
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
        #endregion

      

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocSinh();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
  
            ThamSo.ShowFormGiaoVien();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanCong();
        }


        #region Menu quan ly
        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLopHoc();
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoiLop();
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocKy();
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNamHoc();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNhapDiemChung();
        }

        private void ribbonBarMonHoc_LaunchDialog(object sender, EventArgs e)
        {
            ThamSo.ShowFormNhapDiemRieng();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKetQua();
        }

        private void btnHocLuc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHocLuc();
        }

        private void btnHanhKiem_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormHanhKiem();
        }


        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPhanLop();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDanToc();
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTonGiao();
        }

        private void btnNgheNghiep_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormNgheNghiep();
        }

      
        #endregion
       

    }
}
