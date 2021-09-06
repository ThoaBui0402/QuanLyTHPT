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
    public partial class D : Form
    {
        public D()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                // conn.Open();
                string tk = txtDanhNhap.Text;
                string mk = txtMatKhau.Text;

                if (Connetion.Login(tk, mk))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();
                    Program.usernamelogin = tk;
                    Program.frMain_main = new frmMain1();
                    Program.frMain_main.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
