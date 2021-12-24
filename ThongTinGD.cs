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
    public partial class ThongTinGD : Form
    {
        public ThongTinGD()
        {
            InitializeComponent();
        }
        public void Mo()
        {
            dateTimePicker1.Enabled =textBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void KhoiTao()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        string user = "", mk = "";
        int laAdmin;
        TTGD hs = new TTGD();
        int chon;
        private void ThongTinGD_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dataGridView1.DataSource = hs.Show();

            comboBox1.DataSource = hs.LayThongTinLop();
            comboBox1.DisplayMember = "TenLop";
            comboBox1.ValueMember = "MaLop";
            comboBox1.SelectedValue = "MaLop";

            comboBox2.DataSource = hs.LayThongTinGV();
            comboBox2.DisplayMember = "HoTen";
            comboBox2.ValueMember = "MaGV";
            comboBox2.SelectedValue = "MaGV";

            comboBox3.DataSource = hs.LayThongTinMH();
            comboBox3.DisplayMember = "TenMon";
            comboBox3.ValueMember = "MaMon";
            comboBox3.SelectedValue = "MaMon";
            chon = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (laAdmin == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa thông tin này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    hs.Xoa_TTGD(textBox1.Text);
                    MessageBox.Show("Xóa thành công!");
                    ThongTinGD_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                Mo();
                textBox1.Enabled = false;
                chon = 1;
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                if (chon == 1)
                {
                    if (dateTimePicker1.Text =="" || textBox1.Text == "")
                        MessageBox.Show("Mời nhập đầy đủ thông tin!");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thông tin này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            hs.Sua_TTGD(comboBox1.Text, comboBox2.Text, comboBox3.Text, dateTimePicker1.Text, Convert.ToInt32(textBox1.Text));
                            MessageBox.Show("Sửa thành công!");
                            
                            ThongTinGD_Load(sender, e);
                        }
                    }
                }
                else
                if (chon == 2)
                {
                    if (dateTimePicker1.Text == "" || textBox1.Text == "")
                        MessageBox.Show("Mời nhập đầy đủ thông tin!");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm thông tin này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            hs.ThemTTGD(comboBox1.Text, comboBox2.Text,comboBox3.Text, DateTime.Parse(dateTimePicker1.Text), Convert.ToInt32(textBox1.Text));
                            MessageBox.Show("Thêm thành công!");
                            ThongTinGD_Load(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThongTinGD_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                Mo();
                chon = 2;
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }
    }
}
