
namespace QLHSTHPT
{
    partial class frmPhanCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTimTheoTenGV = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoTenLop = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNamHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemLop = new DevComponents.DotNetBar.ButtonX();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnThemMonHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemGiaoVien = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbMonHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dGVPhanCong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNamHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaMonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.navPanelTimKiem.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.navPaneLeft.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonItemTimKiem
            // 
            this.buttonItemTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemTimKiem.Image")));
            this.buttonItemTimKiem.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItemTimKiem.Name = "buttonItemTimKiem";
            this.buttonItemTimKiem.OptionGroup = "navBar";
            this.buttonItemTimKiem.Text = "Tìm kiếm thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập thông tin tìm kiếm:";
            // 
            // chkTimTheoTenGV
            // 
            this.chkTimTheoTenGV.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTenGV.Location = new System.Drawing.Point(11, 92);
            this.chkTimTheoTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.chkTimTheoTenGV.Name = "chkTimTheoTenGV";
            this.chkTimTheoTenGV.Size = new System.Drawing.Size(217, 28);
            this.chkTimTheoTenGV.TabIndex = 5;
            this.chkTimTheoTenGV.Text = "Tìm theo tên giáo viên";
            // 
            // chkTimTheoTenLop
            // 
            this.chkTimTheoTenLop.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTenLop.Checked = true;
            this.chkTimTheoTenLop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimTheoTenLop.CheckValue = "Y";
            this.chkTimTheoTenLop.Location = new System.Drawing.Point(11, 62);
            this.chkTimTheoTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.chkTimTheoTenLop.Name = "chkTimTheoTenLop";
            this.chkTimTheoTenLop.Size = new System.Drawing.Size(217, 28);
            this.chkTimTheoTenLop.TabIndex = 4;
            this.chkTimTheoTenLop.Text = "Tìm theo tên lớp";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(15, 129);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(213, 28);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // navPanelTimKiem
            // 
            this.navPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelTimKiem.Controls.Add(this.label6);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTenGV);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTenLop);
            this.navPanelTimKiem.Controls.Add(this.btnTimKiem);
            this.navPanelTimKiem.Controls.Add(this.txtTimKiem);
            this.navPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelTimKiem.Location = new System.Drawing.Point(1, 1);
            this.navPanelTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.navPanelTimKiem.Name = "navPanelTimKiem";
            this.navPanelTimKiem.ParentItem = this.buttonItemTimKiem;
            this.navPanelTimKiem.Size = new System.Drawing.Size(245, 420);
            this.navPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelTimKiem.Style.GradientAngle = 90;
            this.navPanelTimKiem.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(15, 31);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(213, 22);
            this.txtTimKiem.TabIndex = 3;
            // 
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNhapDuLieu.Checked = true;
            this.buttonItemNhapDuLieu.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemNhapDuLieu.Image")));
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "Nhập liệu thông tin";
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(15, 289);
            this.btnLuuVaoDS.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(213, 28);
            this.btnLuuVaoDS.TabIndex = 11;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            // 
            // btnThemNamHoc
            // 
            this.btnThemNamHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNamHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNamHoc.Location = new System.Drawing.Point(155, 86);
            this.btnThemNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNamHoc.Name = "btnThemNamHoc";
            this.btnThemNamHoc.Size = new System.Drawing.Size(27, 25);
            this.btnThemNamHoc.TabIndex = 4;
            // 
            // btnThemLop
            // 
            this.btnThemLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemLop.Location = new System.Drawing.Point(155, 142);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(27, 25);
            this.btnThemLop.TabIndex = 6;
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemLop);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemMonHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemGiaoVien);
            this.navPanelNhapDuLieu.Controls.Add(this.label1);
            this.navPanelNhapDuLieu.Controls.Add(this.label3);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbLop);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbMonHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbGiaoVien);
            this.navPanelNhapDuLieu.Controls.Add(this.label2);
            this.navPanelNhapDuLieu.Controls.Add(this.txtSTT);
            this.navPanelNhapDuLieu.Controls.Add(this.label5);
            this.navPanelNhapDuLieu.Controls.Add(this.label4);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 31);
            this.navPanelNhapDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItemNhapDuLieu;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(245, 390);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMonHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMonHoc.Location = new System.Drawing.Point(155, 197);
            this.btnThemMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(27, 25);
            this.btnThemMonHoc.TabIndex = 8;
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemGiaoVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemGiaoVien.Location = new System.Drawing.Point(201, 252);
            this.btnThemGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(27, 25);
            this.btnThemGiaoVien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ tự:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(15, 86);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(132, 20);
            this.cmbNamHoc.TabIndex = 3;
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 14;
            this.cmbLop.Location = new System.Drawing.Point(15, 142);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(132, 20);
            this.cmbLop.TabIndex = 5;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DisplayMember = "Text";
            this.cmbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.ItemHeight = 14;
            this.cmbMonHoc.Location = new System.Drawing.Point(15, 197);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(132, 20);
            this.cmbMonHoc.TabIndex = 7;
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.DisplayMember = "Text";
            this.cmbGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.ItemHeight = 14;
            this.cmbGiaoVien.Location = new System.Drawing.Point(15, 252);
            this.cmbGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(179, 20);
            this.cmbGiaoVien.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học:";
            // 
            // txtSTT
            // 
            // 
            // 
            // 
            this.txtSTT.Border.Class = "TextBoxBorder";
            this.txtSTT.Location = new System.Drawing.Point(15, 31);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(133, 22);
            this.txtSTT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giáo viên dạy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Môn học:";
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneLeft.Controls.Add(this.navPanelTimKiem);
            this.navPaneLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemNhapDuLieu,
            this.buttonItemTimKiem});
            this.navPaneLeft.Location = new System.Drawing.Point(0, 0);
            this.navPaneLeft.Margin = new System.Windows.Forms.Padding(4);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 68;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(247, 490);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 4;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(245, 30);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Nhập liệu thông tin";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dGVPhanCong);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(1005, 490);
            this.groupBoxDanhSach.TabIndex = 5;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách phân công giáo viên giảng dạy";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(372, 250);
            this.ctxMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(100, 29);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 4;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefesh,
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefesh.Text = "Làm tươi danh sách";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            // 
            // dGVPhanCong
            // 
            this.dGVPhanCong.AllowUserToAddRows = false;
            this.dGVPhanCong.AllowUserToResizeColumns = false;
            this.dGVPhanCong.AllowUserToResizeRows = false;
            this.dGVPhanCong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVPhanCong.ColumnHeadersHeight = 29;
            this.dGVPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaNamHoc,
            this.colMaLop,
            this.colMaMonHoc,
            this.colMaGiaoVien});
            this.ctxMenu.SetContextMenuEx(this.dGVPhanCong, this.btnMenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPhanCong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVPhanCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVPhanCong.Location = new System.Drawing.Point(4, 19);
            this.dGVPhanCong.Margin = new System.Windows.Forms.Padding(4);
            this.dGVPhanCong.Name = "dGVPhanCong";
            this.dGVPhanCong.RowHeadersWidth = 51;
            this.dGVPhanCong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVPhanCong.Size = new System.Drawing.Size(997, 467);
            this.dGVPhanCong.TabIndex = 5;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSTT.Width = 60;
            // 
            // colMaNamHoc
            // 
            this.colMaNamHoc.DataPropertyName = "MaNamHoc";
            this.colMaNamHoc.HeaderText = "Năm học";
            this.colMaNamHoc.MinimumWidth = 6;
            this.colMaNamHoc.Name = "colMaNamHoc";
            this.colMaNamHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaNamHoc.Width = 125;
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "Lớp";
            this.colMaLop.MinimumWidth = 6;
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaLop.Width = 125;
            // 
            // colMaMonHoc
            // 
            this.colMaMonHoc.DataPropertyName = "MaMonHoc";
            this.colMaMonHoc.HeaderText = "Môn học";
            this.colMaMonHoc.MinimumWidth = 6;
            this.colMaMonHoc.Name = "colMaMonHoc";
            this.colMaMonHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaMonHoc.Width = 125;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Giáo viên";
            this.colMaGiaoVien.MinimumWidth = 6;
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaGiaoVien.Width = 160;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 490);
            this.Controls.Add(this.navPaneLeft);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Name = "frmPhanCong";
            this.Text = "PHÂN CÔNG";
            this.navPanelTimKiem.ResumeLayout(false);
            this.navPanelTimKiem.PerformLayout();
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            this.navPaneLeft.ResumeLayout(false);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhanCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem buttonItemTimKiem;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTenGV;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTenLop;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private DevComponents.DotNetBar.ButtonX btnLuuVaoDS;
        private DevComponents.DotNetBar.ButtonX btnThemNamHoc;
        private DevComponents.DotNetBar.ButtonX btnThemLop;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.ButtonX btnThemMonHoc;
        private DevComponents.DotNetBar.ButtonX btnThemGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGiaoVien;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVPhanCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNamHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaMonHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaGiaoVien;
    }
}