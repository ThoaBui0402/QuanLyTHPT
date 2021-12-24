using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTHPT
{
    public partial class Form1 : Form
    {

        string user = "", mk = "";
        int laAdmin ;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        public Form1(string user, string mk, int laAdmin)
        {
            InitializeComponent();
            this.user = user;
            this.mk = mk;
            this.laAdmin = laAdmin;
        }
        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giao_Vien gv = new Giao_Vien(user, mk, laAdmin);
            gv.Show();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoc_Sinh hs = new Hoc_Sinh(user,mk,laAdmin);
            hs.Show();
        }

        private void thôngTinGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTTGD frm = new QLTTGD(user, mk, laAdmin);
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát Ứng dụng này?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmHuongDan hd = new frmHuongDan();
            hd.Show();
            Hide();*/
            HuongdanSD frm = new HuongdanSD();
            frm.Show();
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            
                NguoiDung frm = new NguoiDung(user, mk, laAdmin);
                frm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
