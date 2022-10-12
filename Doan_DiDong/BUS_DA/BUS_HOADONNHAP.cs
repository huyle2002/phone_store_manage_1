using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DA;
using DAL_DA;
using System.Data;
namespace BUS_DA
{
    public class BUS_HOADONNHAP
    {
        //khởi tạo 1 đối tượng của lớp DAL_HOADONNHAP
        DAL_HOADONNHAP dalHOADONNHAP = new DAL_HOADONNHAP();
        DAL_NHACUNGCAP dalNHACUNGCAP = new DAL_NHACUNGCAP();
        public DataTable getHOADONNHAP()
        {
            return dalHOADONNHAP.getHOADONNHAP();
        }
        public DataTable getMANHACUNGCAP()
        {
            return dalNHACUNGCAP.getMANHACUNGCAP();
        }
        public int kiemtramatrung(string ma)
        {
            return dalHOADONNHAP.kiemtramatrung(ma);
        }
        public bool ThemHOADONNHAP(DTO_HOADONNHAP HD)
        {
            return dalHOADONNHAP.ThemHOADONNHAP(HD);
        }
        public bool SuaHOADONNHAP(DTO_HOADONNHAP HDN)
        {
            return dalHOADONNHAP.SuaHOADONNHAP(HDN);
        }
        public bool XoaHOADONNHAP(DTO_HOADONNHAP HD)
        {
            return dalHOADONNHAP.XoaHOADONNHAP(HD);
        }

        public DataTable TimHOADONNHAP(string HD)
        {
            return dalHOADONNHAP.TimHOADONNHAP(HD);
        }

    }
}
