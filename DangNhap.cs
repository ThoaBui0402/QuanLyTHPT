using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT
{
    class DangNhap
    {
        private string MaDN;
        private string MaLoai;
        private string TenND;
        private string TenDNnhap;
        private string MatKhau;
        

        public string matKhau
        {
            get
            {
                return MatKhau;
            }

            set
            {
                MatKhau = value;
            }
        }
        public string maLoai
        {
            get
            {
                return MaLoai;
            }

            set
            {
                MaLoai = value;
            }
        }
        public string tenDNnhap
        {
            get
            {
                return TenDNnhap;
            }

            set
            {
                TenDNnhap = value;
            }
        }
        public string tenND
        {
            get
            {
                return TenND;
            }

            set
            {
                TenND = value;
            }
        }

        public string maND
        {
            get
            {
                return MaDN;
            }

            set
            {
                MaDN = value;
            }
        }
        public DangNhap(string MaDN, string MaLoai, string TenND, string TenDNhap, string MatKhau)
        {
            this.tenND = TenND;
            this.MaDN = MaDN;
            this.maLoai= MaLoai;
            this.tenDNnhap = TenDNhap;
            this.matKhau = MatKhau;
        }
    }
}
