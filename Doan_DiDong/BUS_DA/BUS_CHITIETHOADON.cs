using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DA;
using System.Data;
using DTO_DA;

namespace BUS_DA
{
    public class BUS_CHITIETHOADON
    {
        //khởi tạo 1 đối tượng của lớp DAL_CHITIETHOADON
        DAL_CHITIETHOADON dalCHITIETHOADON = new DAL_CHITIETHOADON();
        public DataTable getCHITIETHOADON()
        {
            return dalCHITIETHOADON.getCHITIETHOADON();
        }
        public int kiemtramatrung(string ma, string ma1)
        {
            return dalCHITIETHOADON.kiemtramatrung(ma, ma1);
        }
        public bool ThemCHITIETHOADON(DTO_CHITIETHOADON cthd)
        {
            return dalCHITIETHOADON.ThemCHITIETHOADON(cthd);
        }
        public bool SuaCHITIETHOADON(DTO_CHITIETHOADON cthd)
        {
            return dalCHITIETHOADON.SuaCHITIETHOADON(cthd);
        }
        public bool XoaCHITIETHOADON(DTO_CHITIETHOADON cthd)
        {
            return dalCHITIETHOADON.XoaCHITIETHOADON(cthd);
        }

        public DataTable TimCHITIETHOADON(string cthd)
        {
            return dalCHITIETHOADON.TimCHITIETHOADON(cthd);
        }

    }
}
