using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_CTHOADONNHAP
    {
        private string _MAPHIEUNHAP;

        public string MAPHIEUNHAP
        {
            get { return _MAPHIEUNHAP; }
            set { _MAPHIEUNHAP = value; }
        }

        private string _MAHOADONNHAP;

        public string MAHOADONNHAP
        {
            get { return _MAHOADONNHAP; }
            set { _MAHOADONNHAP = value; }
        }

        private string _MASP;

        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

        

        private int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }

        private float _GIANHAP;

        public float GIANHAP
        {
            get { return _GIANHAP; }
            set { _GIANHAP = value; }
        }

        private DateTime _NGAYDATHANG;

        
        public DTO_CTHOADONNHAP() { }

        public DTO_CTHOADONNHAP(string mpn, string mhdn, string msp,  int sl, float gn)
        {
            this.MAPHIEUNHAP = mpn;
            this.MAHOADONNHAP = mhdn;
            this.MASP = msp;
            this.SOLUONG = sl;
            this.GIANHAP = gn;
        }
    }
}
