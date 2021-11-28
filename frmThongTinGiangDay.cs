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
    public partial class frmThongTinGiangDay : Form
    {
        private GroupBox groupBox2;
        private DataGridView dgvGiaoVien;
        private Button btnHuy;
        private Label label9;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtTKGV;
        private DateTimePicker dtpNgaySinhGV;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private Label label1;

        public frmThongTinGiangDay()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTKGV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhGV = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGiaoVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 292);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1332, 342);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column7});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(4, 19);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1324, 319);
            this.dgvGiaoVien.TabIndex = 0;
            this.dgvGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaGV";
            this.Column2.HeaderText = "Mã GV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NgayDay";
            this.Column4.HeaderText = "Ngày Dạy";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Tiet";
            this.Column7.HeaderText = "Tiết học";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1206, 209);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 42);
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tiết học";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1206, 121);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 42);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1206, 43);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 42);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1064, 121);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 42);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1064, 43);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 42);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTKGV);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dtpNgaySinhGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1332, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(652, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(235, 24);
            this.comboBox3.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Môn học";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(276, 24);
            this.comboBox2.TabIndex = 47;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 24);
            this.comboBox1.TabIndex = 46;
            // 
            // txtTKGV
            // 
            this.txtTKGV.Location = new System.Drawing.Point(652, 155);
            this.txtTKGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKGV.Name = "txtTKGV";
            this.txtTKGV.Size = new System.Drawing.Size(235, 22);
            this.txtTKGV.TabIndex = 40;
            // 
            // dtpNgaySinhGV
            // 
            this.dtpNgaySinhGV.CustomFormat = "MM/dd/yyyy";
            this.dtpNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhGV.Location = new System.Drawing.Point(652, 100);
            this.dtpNgaySinhGV.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            this.dtpNgaySinhGV.Size = new System.Drawing.Size(235, 22);
            this.dtpNgaySinhGV.TabIndex = 34;
            this.dtpNgaySinhGV.Value = new System.DateTime(2015, 11, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày Dạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Lớp";
            // 
            // frmThongTinGiangDay
            // 
            this.ClientSize = new System.Drawing.Size(1332, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongTinGiangDay";
            this.Load += new System.EventHandler(this.frmThongTinGiangDay_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        GiaoVien g = new GiaoVien();
        ThongTinGD gv = new ThongTinGD();
        int chon;
        private void frmThongTinGiangDay_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvGiaoVien.DataSource = gv.Show();
            comboBox1.DataSource = gv.LayThongTinLop();
            comboBox1.DisplayMember = "TenLop";
            comboBox1.ValueMember = "MaLop";
            comboBox2.DataSource = gv.LayThongTinGiaoVien();
            comboBox2.DisplayMember = "TenGV";
            comboBox2.ValueMember = "MaGV";
            comboBox3.DataSource = g.LayThongTinMonHoc();
            comboBox3.DisplayMember = "TenMon";
        }

        public void KhoiTao()
        {
            dtpNgaySinhGV.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        public void Mo()
        {
            dtpNgaySinhGV.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void SetNull()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dtpNgaySinhGV.Text = DateTime.Now.ToShortDateString();
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox1.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox2.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinhGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTKGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch
            {

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            chon = 2;
            SetNull();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (chon == 1)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || txtTKGV.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn sửa thông tin giảng dạy này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        gv.Sua_GV(comboBox1.Text, comboBox2.Text, (dtpNgaySinhGV.Value),comboBox3.Text, txtTKGV.Text);
                        MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetNull();
                       frmThongTinGiangDay_Load(sender, e);
                    }
                }
            }
            else if (chon == 2)
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" ||  dtpNgaySinhGV.Text == "" || txtTKGV.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm thông tin giảng dạy này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        gv.ADDGiaoVien(comboBox1.Text, comboBox2.Text, comboBox3.Text, dtpNgaySinhGV.Value, txtTKGV.Text);
                        MessageBox.Show("Thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetNull();
                        frmThongTinGiangDay_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmThongTinGiangDay_Load(sender, e);
            SetNull();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa thông tin giảng dạy này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                gv.Xoa_GV(comboBox1.Text, dtpNgaySinhGV.Value, txtTKGV.Text);
                MessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
               frmThongTinGiangDay_Load(sender, e);
                SetNull();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
            chon = 1;
        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox1.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox2.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinhGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTKGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch
            {

            }

        }


    }
}
