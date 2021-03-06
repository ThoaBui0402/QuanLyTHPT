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
    public partial class Giao_Vien : Form
    {
        string user = "", mk = "";
        int laAdmin;
      
      
        public Giao_Vien()
        {
            InitializeComponent();
        }
        public Giao_Vien(string user, string mk, int laAdmin)
        {
            InitializeComponent();
            this.user = user;
            this.mk = mk;
            this.laAdmin = laAdmin;
        }
        GiaoVien gv = new GiaoVien();
        int chon;
        TimKiem tk = new TimKiem();
        public void KhoiTao()
        {
            txtHoTenGV.Enabled = txtLuong.Enabled = txtSDT.Enabled = cbGTGV.Enabled = cbMonHoc.Enabled = txtDiaChi.Enabled = false;
            dtpNgaySinhGV.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void Mo()
        {
            txtHoTenGV.Enabled = txtLuong.Enabled = txtSDT.Enabled = cbGTGV.Enabled = cbMonHoc.Enabled = txtDiaChi.Enabled = true;
            dtpNgaySinhGV.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void SetNull()
        {
            txtMaGV.Text = txtHoTenGV.Text = txtDiaChi.Text = txtLuong.Text = cbGTGV.Text = cbMonHoc.Text = cbTKGV.Text = txtTKGV.Text = txtSDT.Text = "";
            dtpNgaySinhGV.Text = DateTime.Now.ToShortDateString();
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTenGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbGTGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinhGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtLuong.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbMonHoc.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            {

            }

        }

        private void Giao_Vien_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvGiaoVien.DataSource = gv.Show();

            cbMonHoc.DataSource = gv.LayThongTinMonHoc();
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
            cbMonHoc.SelectedValue = "MaMon";
            chon = 0;
        }

        private void txtTKGV_TextChanged(object sender, EventArgs e)
        {
            if (cbTKGV.Text == "Mã")
                dgvGiaoVien.DataSource = tk.TK_Ma_GiaoVien(txtTKGV.Text);
            else
                dgvGiaoVien.DataSource = tk.TKTenGiaoVien(txtTKGV.Text);
        }

       

       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                Mo();
                SetNull();
                chon = 2;
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa giáo viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    gv.Xoa_GV(txtMaGV.Text);
                    MessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Giao_Vien_Load(sender, e);
                    SetNull();
                }
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                Mo();
                //  SetNull();
                txtTKGV.Enabled = cbTKGV.Enabled = true;
                chon = 1;
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (laAdmin == 1)
            {
                if (chon == 1)
                {
                    if (txtHoTenGV.Text == "" || cbGTGV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || cbMonHoc.Text == "" || dtpNgaySinhGV.Text == "" || txtLuong.Text == "")
                        MessageBox.Show("Mời nhập đầy đủ thông tin!");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa giáo viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            gv.Sua_GV(txtMaGV.Text, txtHoTenGV.Text, cbGTGV.Text, (dtpNgaySinhGV.Text), txtDiaChi.Text, txtSDT.Text, txtLuong.Text, cbMonHoc.SelectedValue.ToString());
                            MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetNull();
                            Giao_Vien_Load(sender, e);
                        }
                    }
                }
                else if (chon == 2)
                {
                    if (txtHoTenGV.Text == "" || cbGTGV.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || cbMonHoc.Text == "" || dtpNgaySinhGV.Text == "" || txtLuong.Text == "")
                        MessageBox.Show("Mời nhập đầy đủ thông tin!");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm giáo viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            gv.ADDGiaoVien(txtHoTenGV.Text, cbGTGV.Text, dtpNgaySinhGV.Text, txtDiaChi.Text, txtSDT.Text, txtLuong.Text, cbMonHoc.SelectedValue.ToString());
                            MessageBox.Show("Thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetNull();
                            Giao_Vien_Load(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Người dùng là admin mới có quyền này");
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            Giao_Vien_Load(sender, e);
            SetNull();
        }
    }
}
