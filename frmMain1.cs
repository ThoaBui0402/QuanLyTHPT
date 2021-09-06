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

        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

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
    }
}
