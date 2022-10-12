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
    public class BUS_HOADON
    {
        //khởi tạo 1 đối tượng của lớp DAL_HOADON
        DAL_HOADON dalHOADON = new DAL_HOADON();
        public DataTable getHOADON()
        {
            return dalHOADON.getHOADON();
        }
        public int kiemtramatrung(string ma)
        {
            return dalHOADON.kiemtramatrung(ma);
        }
        public bool ThemHOADON(DTO_HOADON HD)
        {
            return dalHOADON.ThemHOADON(HD);
        }
        public bool SuaHOADON(DTO_HOADON HD)
        {
            return dalHOADON.SuaHOADON(HD);
        }
        public bool XoaHOADON(DTO_HOADON HD)
        {
            return dalHOADON.XoaHOADON(HD);
        }

        public DataTable TimHOADON(string HD)
        {
            return dalHOADON.TimHOADON(HD);
        }

    }
}
