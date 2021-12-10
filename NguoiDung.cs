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
    public partial class NguoiDung : Form
    {
       
        public NguoiDung()
        {
            InitializeComponent();
        }
        TaiKhoan nd = new TaiKhoan();
        
        int chon;
        public void KhoiTao()
        {
            comboBoxMaNV.Enabled = textMatKhau.Enabled = comboBoxLaAdmin.Enabled  = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void Mo()
        {
            comboBoxMaNV.Enabled = textMatKhau.Enabled = comboBoxLaAdmin.Enabled = true;
          
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void SetNull()
        {
            comboBoxMaNV.Text = textMatKhau.Text = comboBoxLaAdmin.Text = "";
            
        }

        private void dataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxMaNV.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
                textMatKhau.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxLaAdmin.Text = dataGridViewNguoiDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
            catch
            {
                
            }

        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dataGridViewNguoiDung.DataSource = nd.Show();
            chon = 0;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            SetNull();
            chon = 1;
            DataTable dt = nd.LoadData("HienThi_NguoiDung");
            comboBoxMaNV.Text = dt.Rows[0][0].ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (nd.LoadData1("XemNguoiDung", "@Username", comboBoxMaNV.Text).Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy Nhân viên này");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        nd.Xoa("XoaNguoiDung", "@Username", comboBoxMaNV.Text);
                        MessageBox.Show("Xóa thành công!");
                        NguoiDung_Load(sender, e);
                        SetNull();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
            //  SetNull();
            comboBoxMaNV.Enabled = false;
            chon = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1) //Them
            {
                if (nd.LoadData1("XemNguoiDung", "@Username", comboBoxMaNV.Text).Rows.Count > 0)
                    MessageBox.Show("Tài khoản đã có trong danh sách");
                else
                {
                    if (textMatKhau.Text == "" || comboBoxLaAdmin.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        nd.NguoiDung_DB("ThemNguoiDung", comboBoxMaNV.Text, textMatKhau.Text, comboBoxLaAdmin.Text);
                        MessageBox.Show("Thêm thành công");
                        NguoiDung_Load(sender, e);
                    }
                }

            }
            else if (chon == 2) //Sua
            {
                if (nd.LoadData1("XemNguoiDung", "@Username", comboBoxMaNV.Text).Rows.Count == 0)
                    MessageBox.Show("Tài khoản này chưa có trong danh sách");
                else
                {
                    if (textMatKhau.Text == "" || comboBoxLaAdmin.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            nd.NguoiDung_DB("SuaNguoiDung", comboBoxMaNV.Text, textMatKhau.Text, comboBoxLaAdmin.Text);
                            MessageBox.Show("Sửa thành công");
                            NguoiDung_Load(sender, e);
                        }
                    }
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NguoiDung_Load(sender, e);
            SetNull();
        }
       
        private void comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = nd.LoadData1("HienThi_MatKhau_LaAdmin", "@Username", comboBoxMaNV.Text);
                if (dt.Rows.Count != 0)
                {
                    if (comboBoxMaNV.Text != null)
                    {
                        textMatKhau.Text = dt.Rows[0][1].ToString();
                        comboBoxLaAdmin.Text = dt.Rows[0][2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
