using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_NHACUNGCAP
    {
        private string _MANHACUNGCAP;

        public string MANHACUNGCAP
        {
            get { return _MANHACUNGCAP; }
            set { _MANHACUNGCAP = value; }
        }

        private string _TENNHACUNGCAP;

        public string TENNHACUNGCAP
        {
            get { return _TENNHACUNGCAP; }
            set { _TENNHACUNGCAP = value; }
        }

        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        private string _GIOITINH;

        public string GIOITINH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }

        private DateTime _NGAYSINH;

        public DateTime NGAYSINH_NCC
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        private string _PHONE;

        public string PHONE
        {
            get { return _PHONE; }
            set { _PHONE = value; }
        }

        public DTO_NHACUNGCAP() { }
        public DTO_NHACUNGCAP(string mncc, string tncc, string dc, string gt, DateTime ns, string sdt)
        {
            this.MANHACUNGCAP = mncc;
            this.TENNHACUNGCAP = tncc;
            this.DIACHI = dc;
            this.GIOITINH = gt;
            this.NGAYSINH_NCC = ns;
            this.PHONE = sdt;
        }
    }
}
