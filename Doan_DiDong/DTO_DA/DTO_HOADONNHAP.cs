using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_HOADONNHAP
    {
        private string _MAHOADONNHAP;

        public string MAHOADONNHAP
        {
            get { return _MAHOADONNHAP; }
            set { _MAHOADONNHAP = value; }
        }

        private string _MANHACUNGCAP;

        public string MANHACUNGCAP
        {
            get { return _MANHACUNGCAP; }
            set { _MANHACUNGCAP = value; }
        }

        private DateTime _NGAYNHAP;

        public DateTime NGAYNHAP
        {
            get { return _NGAYNHAP; }
            set { _NGAYNHAP = value; }
        }

        private float _THANHTIEN;

        public float THANHTIEN
        {
            get { return _THANHTIEN; }
            set { _THANHTIEN = value; }
        }

        public DTO_HOADONNHAP() { }

        public DTO_HOADONNHAP(string mhdn, string mncc, DateTime nn, float tt)
        {
            this.MAHOADONNHAP= mhdn;
            this.MANHACUNGCAP = mncc;
            this.NGAYNHAP = nn;
            this.THANHTIEN = tt;
        }
    }
}
