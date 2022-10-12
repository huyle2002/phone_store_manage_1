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
    public class BUS_LOAISANPHAM
    {
        //khởi tạo 1 đối tượng của lớp DAL_LOAISANPHAM
        DAL_LOAISANPHAM dalLOAISANPHAM = new DAL_LOAISANPHAM();
        public DataTable getLOAISANPHAM()
        {
            return dalLOAISANPHAM.getLOAISANPHAM();
        }
        public int kiemtramatrung(string ma)
        {
            return dalLOAISANPHAM.kiemtramatrung(ma);
        }
        public bool ThemLOAISANPHAM(DTO_LOAISANPHAM lsp)
        {
            return dalLOAISANPHAM.ThemLOAISANPHAM(lsp);
        }
        public bool SuaLOAISANPHAM(DTO_LOAISANPHAM lsp)
        {
            return dalLOAISANPHAM.SuaLOAISANPHAM(lsp);
        }
        public bool XoaLOAISANPHAM(DTO_LOAISANPHAM lsp)
        {
            return dalLOAISANPHAM.XoaLOAISANPHAM(lsp);
        }

        public DataTable TimLOAISANPHAM(string lsp)
        {
            return dalLOAISANPHAM.TimLOAISANPHAM(lsp);
        }
    }
}
