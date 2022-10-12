using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_NHANVIEN
    {
        private string _MANHANVIEN;

        public string MANHANVIEN
        {
            get { return _MANHANVIEN; }
            set { _MANHANVIEN = value; }
        }

        private string _TENNHANVIEN;

        public string TENNHANVIEN
        {
            get { return _TENNHANVIEN; }
            set { _TENNHANVIEN = value; }
        }

        private string _GIOITINH;

        public string GIOITINH_NV
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

        private float _LUONGCOBAN;

        public float LUONGCOBAN
        {
            get { return _LUONGCOBAN; }
            set { _LUONGCOBAN = value; }
        }

        private int _PHUCAP;

        public int PHUCAP
        {
            get { return _PHUCAP; }
            set { _PHUCAP = value; }
        }

        public DTO_NHANVIEN() { }

        public DTO_NHANVIEN(string mnv, string tnv, string gt, string sdt, string dc, DateTime ns, float lcb, int pc)
        {
            this.MANHANVIEN = mnv;
            this.TENNHANVIEN = tnv;
            this.GIOITINH_NV = gt;
            this.SODIENTHOAI = sdt;
            this.DIACHI = dc;
            this.NGAYSINH = ns;
            this.LUONGCOBAN = lcb;
            this.PHUCAP = pc;
        }
    }
}
