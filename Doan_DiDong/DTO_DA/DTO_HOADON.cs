using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_HOADON
    {
        private string _MAKHACHHANG;

        public string MAKHACHHANG
        {
            get { return _MAKHACHHANG; }
            set { _MAKHACHHANG = value; }
        }

        private string _MANHANVIEN;

        public string MANHANVIEN
        {
            get { return _MANHANVIEN; }
            set { _MANHANVIEN = value; }
        }

        private string _MAHOADON;

        public string MAHOADON
        {
            get { return _MAHOADON; }
            set { _MAHOADON = value; }
        }

        public DTO_HOADON() { }

        public DTO_HOADON(string mkh, string mnv, string mhd)
        {
            this.MAKHACHHANG = mkh;
            this.MANHANVIEN = mnv;
            this.MAHOADON = mhd;
        }
    }
}
