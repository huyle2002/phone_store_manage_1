using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_CHITIETHOADON
    {
        private string _MASP;

        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

        private string _MAHOADON;

        public string MAHOADON
        {
            get { return _MAHOADON; }
            set { _MAHOADON = value; }
        }

        private int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }

        private float _GIABAN;

        public float GIABAN
        {
            get { return _GIABAN; }
            set { _GIABAN = value; }
        }

        private DateTime _NGAYDATHANG;

        public DateTime NGAYDATHANG
        {
            get { return _NGAYDATHANG; }
            set { _NGAYDATHANG = value; }
        }

        public DTO_CHITIETHOADON() { }

        public DTO_CHITIETHOADON(string msp, string mhd, int sl, float gb, DateTime ndh)
        {
            this.MASP = msp;
            this.MAHOADON = mhd;
            this.SOLUONG = sl;
            this.GIABAN = gb;
            this.NGAYDATHANG = ndh;
        }
    }
}
