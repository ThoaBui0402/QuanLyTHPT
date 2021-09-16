using QLHSTHPT.Controller;
using System;
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
    public partial class frmHocSinh : Form
    {
        #region Fields
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        NgheNghiepCtrl m_NgheNghiepChaCtrl = new NgheNghiepCtrl();
        NgheNghiepCtrl m_NgheNghiepMeCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmHocSinh()
        {
            InitializeComponent();
        }
        #endregion
        private void groupBoxDanhSach_Enter(object sender, EventArgs e)
        {

        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
        }
    }
}