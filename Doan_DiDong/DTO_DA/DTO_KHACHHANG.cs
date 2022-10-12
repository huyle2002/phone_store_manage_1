using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_KHACHHANG
    {
        private string _MAKHACHHANG;

        public string MAKHACHHANG
        {
            get { return _MAKHACHHANG; }
            set { _MAKHACHHANG = value; }
        }

        private string _TENKHACHHANG;

        public string TENKHACHHANG
        {
            get { return _TENKHACHHANG; }
            set { _TENKHACHHANG = value; }
        }

        private string _GIOITINH;

        public string GIOITINH_KH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }

        private string _SODIENTHOAI;

        public string SODIENTHOAI
        {
            get { return _SODIENTHOAI; }
            set { _SODIENTHOAI = value; }
        }

        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        private DateTime _NGAYSINH;

        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }

        public DTO_KHACHHANG() { }

        public DTO_KHACHHANG(string mkh, string tkh, string gt, string sdt, string dc, DateTime ns)
        {
            this.MAKHACHHANG = mkh;
            this.TENKHACHHANG = tkh;
            this.GIOITINH_KH = gt;
            this.SODIENTHOAI = sdt;
            this.DIACHI = dc;
            this.NGAYSINH = ns;
        }
    }
}
