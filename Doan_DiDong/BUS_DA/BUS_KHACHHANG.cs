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
    public class BUS_KHACHHANG
    {
        //khởi tạo 1 đối tượng của lớp DAL_KHACHHANG
        DAL_KHACHHANG dalKHACHHANG = new DAL_KHACHHANG();
        public DataTable getKHACHHANG()
        {
            return dalKHACHHANG.getKHACHHANG();
        }
        public int kiemtramatrung(string ma)
        {
            return dalKHACHHANG.kiemtramatrung(ma);
        }
        public bool ThemKHACHHANG(DTO_KHACHHANG KH)
        {
            return dalKHACHHANG.ThemKHACHHANG(KH);
        }
        public bool SuaKHACHHANG(DTO_KHACHHANG KH)
        {
            return dalKHACHHANG.SuaKHACHHANG(KH);
        }
        public bool XoaKHACHHANG(DTO_KHACHHANG KH)
        {
            return dalKHACHHANG.XoaKHACHHANG(KH);
        }

        public DataTable TimKHACHHANG(string KH)
        {
            return dalKHACHHANG.TimKHACHHANG(KH);
        }

    }
}
