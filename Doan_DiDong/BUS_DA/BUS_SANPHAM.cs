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
    public class BUS_SANPHAM
    {
        //khởi tạo 1 đối tượng của lớp DAL_SANPHAM
        DAL_SANPHAM dalSANPHAM = new DAL_SANPHAM();
        public DataTable getSANPHAM()
        {
            return dalSANPHAM.getSANPHAM();
        }
        public int kiemtramatrung(string ma)
        {
            return dalSANPHAM.kiemtramatrung(ma);
        }
        public bool ThemSANPHAM(DTO_SANPHAM sp)
        {
            return dalSANPHAM.ThemSANPHAM(sp);
        }
        public bool SuaSANPHAM(DTO_SANPHAM sp)
        {
            return dalSANPHAM.SuaSANPHAM(sp);
        }
        public bool XoaSANPHAM(DTO_SANPHAM sp)
        {
            return dalSANPHAM.XoaSANPHAM(sp);
        }

        public bool TruSLSANPHAM(string ma, int sl)
        {
            return dalSANPHAM.truSLSANPHAM(ma, sl);
        }
        public bool congSLSANPHAM(string ma, int sl)
        {
            return dalSANPHAM.congSLSANPHAM(ma, sl);
        }
        public DataTable TimSANPHAM(string sp)
        {
            return dalSANPHAM.TimSANPHAM(sp);
        }
        
    }
}
