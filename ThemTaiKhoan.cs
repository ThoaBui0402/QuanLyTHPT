﻿using System;
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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

      

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            DangNhap temp = new DangNhap(txtMaND.Text, textMaLoai.Text, textTenND.Text,txtTenDNhap.Text,txtMK.Text );

            Connetion.ThemTaiKhoan(temp);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
