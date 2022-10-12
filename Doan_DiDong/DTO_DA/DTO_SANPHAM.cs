using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_SANPHAM
    {
        private string _MASP;

        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

        private string _TENSP;

        public string TENSP
        {
            get { return _TENSP; }
            set { _TENSP = value; }
        }

        private string _XUATXU;

        public string XUATXU
        {
            get { return _XUATXU; }
            set { _XUATXU = value; }
        }

        private string _MANHACUNGCAP;

        public string MANHACUNGCAP
        {
            get { return _MANHACUNGCAP; }
            set { _MANHACUNGCAP = value; }
        }

        private string _MALOAISP;

        public string MALOAISP
        {
            get { return _MALOAISP; }
            set { _MALOAISP = value; }
        }

        private string _DONVITINH;

        public string DONVITINH
        {
            get { return _DONVITINH; }
            set { _DONVITINH = value; }
        }

        private float _DONGIA;

        public float DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }

        private int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }

        public DTO_SANPHAM() { }

        public DTO_SANPHAM(string msp, string tsp, string xx, string mncc, string mlsp, string dvt, float dg, int sl)
        {
            this.MASP = msp;
            this.TENSP = tsp;
            this.XUATXU = xx;
            this.MANHACUNGCAP = mncc;
            this.MALOAISP = mlsp;
            this.DONVITINH = dvt;
            this.DONGIA = dg;
            this.SOLUONG = sl;
        }
    }
}
