
namespace QLHSTHPT
{
    partial class ThemTaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMaLoai = new System.Windows.Forms.ComboBox();
            this.textTenND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.txtNhapLai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenDNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.Tên = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.textMaLoai);
            this.groupBox1.Controls.Add(this.textTenND);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.txtNhapLai);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTenDNhap);
            this.groupBox1.Controls.Add(this.txtMaND);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.Tên);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(589, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textMaLoai
            // 
            this.textMaLoai.FormattingEnabled = true;
            this.textMaLoai.Items.AddRange(new object[] {
            "LND001",
            "LND002",
            "LND003"});
            this.textMaLoai.Location = new System.Drawing.Point(220, 116);
            this.textMaLoai.Name = "textMaLoai";
            this.textMaLoai.Size = new System.Drawing.Size(247, 24);
            this.textMaLoai.TabIndex = 25;
            // 
            // textTenND
            // 
            // 
            // 
            // 
            this.textTenND.Border.Class = "TextBoxBorder";
            this.textTenND.Location = new System.Drawing.Point(220, 158);
            this.textTenND.Margin = new System.Windows.Forms.Padding(4);
            this.textTenND.Name = "textTenND";
            this.textTenND.Size = new System.Drawing.Size(247, 22);
            this.textTenND.TabIndex = 24;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(56, 154);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(135, 28);
            this.labelX6.TabIndex = 23;
            this.labelX6.Text = "Tên Người Dùng";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(56, 118);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(135, 28);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "Mã Loại";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(392, 332);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(136, 44);
            this.buttonX1.TabIndex = 20;
            this.buttonX1.Text = "Thoát";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(196, 11);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(304, 63);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "THÊM TÀI KHOẢN";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(220, 332);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(136, 44);
            this.btnThemMoi.TabIndex = 18;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtNhapLai
            // 
            // 
            // 
            // 
            this.txtNhapLai.Border.Class = "TextBoxBorder";
            this.txtNhapLai.Location = new System.Drawing.Point(220, 279);
            this.txtNhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(247, 22);
            this.txtNhapLai.TabIndex = 17;
            // 
            // txtMK
            // 
            // 
            // 
            // 
            this.txtMK.Border.Class = "TextBoxBorder";
            this.txtMK.Location = new System.Drawing.Point(220, 241);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(247, 22);
            this.txtMK.TabIndex = 16;
            // 
            // txtTenDNhap
            // 
            // 
            // 
            // 
            this.txtTenDNhap.Border.Class = "TextBoxBorder";
            this.txtTenDNhap.Location = new System.Drawing.Point(220, 196);
            this.txtTenDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDNhap.Name = "txtTenDNhap";
            this.txtTenDNhap.Size = new System.Drawing.Size(247, 22);
            this.txtTenDNhap.TabIndex = 15;
            // 
            // txtMaND
            // 
            // 
            // 
            // 
            this.txtMaND.Border.Class = "TextBoxBorder";
            this.txtMaND.Location = new System.Drawing.Point(220, 82);
            this.txtMaND.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaND.Name = "txtMaND";
            this.txtMaND.Size = new System.Drawing.Size(247, 22);
            this.txtMaND.TabIndex = 14;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(56, 278);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(135, 28);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Nhập lại mật khẩu";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(56, 237);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 28);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Mật Khẩu";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(56, 193);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(116, 28);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Tên Đăng Nhập";
            // 
            // Tên
            // 
            this.Tên.Location = new System.Drawing.Point(56, 83);
            this.Tên.Margin = new System.Windows.Forms.Padding(4);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(135, 28);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Mã Người Dùng";
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemTaiKhoan";
            this.Text = "Thêm Tài Khoản";
            this.Load += new System.EventHandler(this.ThemTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnThemMoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNhapLai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaND;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX Tên;
        private DevComponents.DotNetBar.Controls.TextBoxX textTenND;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox textMaLoai;
    }
}