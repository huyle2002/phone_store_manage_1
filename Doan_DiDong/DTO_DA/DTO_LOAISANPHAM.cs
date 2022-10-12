using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DA
{
    public class DTO_LOAISANPHAM
    {
        private string _MALOAISP;

        public string MALOAISP
        {
            get { return _MALOAISP; }
            set { _MALOAISP = value; }
        }
        private string _TENLOAISP;

        public string TENLOAISP
        {
            get { return _TENLOAISP; }
            set { _TENLOAISP = value; }
        }

        private string _MOTA;

        public string MOTA
        {
            get { return _MOTA; }
            set { _MOTA = value; }
        }

        public DTO_LOAISANPHAM() { }
        public DTO_LOAISANPHAM(string mlsp, string tlsp, string mt)
        {
            this.MALOAISP = mlsp;
            this.TENLOAISP = tlsp;
            this.MOTA = mt;
        }
    }
}
