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

        QLTTGD gv = new QLTTGD();
        int chon;
        public void KhoiTao()
        {
            cmbLop.Enabled = cmbGiaoVien.Enabled = cmbMonHoc.Enabled = txtTiet.Enabled = false;
            dtpNgayDay.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void Mo()
        {
            cmbLop.Enabled=cmbGiaoVien.Enabled= cmbMonHoc.Enabled = txtTiet.Enabled = true;
            dtpNgayDay.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void SetNull()
        {
            cmbLop.Text=cmbGiaoVien.Text=cmbMonHoc.Text =txtTiet.Text= "";
            dtpNgayDay.Text = DateTime.Now.ToShortDateString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 2;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
            chon = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa thông tin này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                gv.Xoa_TTGD(cmbLop.Text, dtpNgayDay.Value, Convert.ToInt32(txtTiet.Text));
                MessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThongTinGD_Load(sender, e);
                SetNull();
            }
        }

        private void ThongTinGD_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvGiaoVien.DataSource = gv.Show();

            cmbLop.DataSource = gv.LayThongTinLop();
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
            cmbLop.SelectedValue = "MaLop";

            cmbGiaoVien.DataSource = gv.LayThongTinGV();
            cmbGiaoVien.DisplayMember = "TenGV";
            cmbGiaoVien.ValueMember = "MaGV";
            cmbGiaoVien.SelectedValue = "MaGV";

            cmbMonHoc.DataSource = gv.LayThongTinMon();
            cmbMonHoc.DisplayMember = "TenMon";
            cmbMonHoc.ValueMember = "MaMon";
            cmbMonHoc.SelectedValue = "MaMon";
            chon = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (chon == 1)
            {
                if (cmbLop.Text == "" || cmbGiaoVien.Text == "" || cmbMonHoc.Text == "" || txtTiet.Text == ""|| dtpNgayDay.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thông tin này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        gv.Sua_TTGD(cmbLop.Text, cmbGiaoVien.Text, cmbMonHoc.Text, (dtpNgayDay.Value), Convert.ToInt32(txtTiet.Text));
                        MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetNull();
                        ThongTinGD_Load(sender, e);
                    }
                }
            }
            else if (chon == 2)
            {
                if (cmbLop.Text == "" || cmbGiaoVien.Text == "" || cmbMonHoc.Text == "" || txtTiet.Text == "" || dtpNgayDay.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm thông tin này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        gv.ThemTTGD(cmbLop.Text, cmbGiaoVien.Text, cmbMonHoc.Text, (dtpNgayDay.Value), Convert.ToInt32(txtTiet.Text));
                        MessageBox.Show("Thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetNull();
                        ThongTinGD_Load(sender, e);
                    }
                }
            }
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                DataGridViewRow r = dgvGiaoVien.SelectedRows[0];
                cmbLop.Text = r.Cells["Column1"].Value.ToString();
                cmbGiaoVien.Text = r.Cells["Column2"].Value.ToString();
                if(r.Cells["Column3"].Value==null) cmbMonHoc.Text = " ";
                else cmbMonHoc.Text = r.Cells["Column3"].Value.ToString();
                dtpNgayDay.Value =Convert.ToDateTime(r.Cells["Column4"].Value.ToString());
                txtTiet.Text = r.Cells["Column5"].Value.ToString();
        }
    }
}
