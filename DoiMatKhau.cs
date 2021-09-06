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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            txtTenDN.ReadOnly = true;
            txtTenDN.Text = Program.usernamelogin;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            status.ForeColor = Color.Red;
            if (Connetion.Login(txtTenDN.Text, txtmatkhaucu.Text) == false)
            {
                status.Text = "Sai mật khẩu!!";
                return;
            }
            if (txtmatkhaumoi.Text != txtnhaplaimatkhaumoi.Text)
            {
                status.Text = "Mật khẩu nhập lại không trùng khớp !!";
                return;
            }
            Connetion.thayDoiMatKhau(txtTenDN.Text, txtmatkhaumoi.Text);
            status.ForeColor = Color.Blue;
            status.Text = "Đã đổi mật khẩu!";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
