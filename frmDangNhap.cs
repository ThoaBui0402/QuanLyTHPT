using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiTHPT;
namespace QuanLiTHPT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
      
       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblUser WHERE Username='" + txtUserName.Text + "' AND Password='" + txtPass.Text + "'";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn đăng nhập thành công ^^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), Int32.Parse(dt.Rows[0][2].ToString()));
                frm1.Show();
                Hide();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Mời bạn nhập lại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có chắc muốn thoát ??", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.ResizeRedraw, true);

        }
    }
}
