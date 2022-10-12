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
    public class BUS_NHACUNGCAP
    {
        //khởi tạo 1 đối tượng của lớp DAL_NHACUNGCAP
        DAL_NHACUNGCAP dalNHACUNGCAP = new DAL_NHACUNGCAP();
        public DataTable getNHACUNGCAP()
        {
            return dalNHACUNGCAP.getNHACUNGCAP();
        }
        public int kiemtramatrung(string ma)
        {
            return dalNHACUNGCAP.kiemtramatrung(ma);
        }
        public bool ThemNHACUNGCAP(DTO_NHACUNGCAP NCC)
        {
            return dalNHACUNGCAP.ThemNHACUNGCAP(NCC);
        }
        public bool SuaNHACUNGCAP(DTO_NHACUNGCAP NCC)
        {
            return dalNHACUNGCAP.SuaNHACUNGCAP(NCC);
        }
        public bool XoaNHACUNGCAP(DTO_NHACUNGCAP NCC)
        {
            return dalNHACUNGCAP.XoaNHACUNGCAP(NCC);
        }

        public DataTable TimNHACUNGCAP(string NCC)
        {
            return dalNHACUNGCAP.TimNHACUNGCAP(NCC);
        }
    }
}
