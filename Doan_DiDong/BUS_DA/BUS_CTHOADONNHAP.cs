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
    public class BUS_CTHOADONNHAP
    {
        //khởi tạo 1 đối tượng của lớp DAL_CTHOADONNHAP
        DAL_CTHOADONNHAP dalCTHOADONNHAP = new DAL_CTHOADONNHAP();
        DAL_HOADONNHAP dalHOADONNHAP = new DAL_HOADONNHAP();
        DAL_SANPHAM dalSANPHAM = new DAL_SANPHAM();
        public DataTable getCTHOADONNHAP()
        {
            return dalCTHOADONNHAP.getCTHOADONNHAP();
        }
        public DataTable getSANPHAM()
        {
            return dalSANPHAM.getSANPHAM();
        }
        public DataTable getHOADONNHAP()
        {
            return dalHOADONNHAP.getHOADONNHAP();
        }
        public int kiemtramatrung(string ma)
        {
            return dalCTHOADONNHAP.kiemtramatrung(ma);
        }
        public bool ThemCTHOADONNHAP(DTO_CTHOADONNHAP HD)
        {
            return dalCTHOADONNHAP.ThemCTHOADONNHAP(HD);
        }
        public bool SuaCTHOADONNHAP(DTO_CTHOADONNHAP HD)
        {
            return dalCTHOADONNHAP.SuaCTHOADONNHAP(HD);
        }
        public bool XoaCTHOADONNHAP(DTO_CTHOADONNHAP HD)
        {
            return dalCTHOADONNHAP.XoaCTHOADONNHAP(HD);
        }

        public DataTable TimCTHOADONNHAP(string HD)
        {
            return dalCTHOADONNHAP.TimCTHOADONNHAP(HD);
        }

    }
}
