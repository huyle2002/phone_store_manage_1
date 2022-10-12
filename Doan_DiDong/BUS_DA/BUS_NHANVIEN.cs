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
    public class BUS_NHANVIEN
    {
        //khởi tạo 1 đối tượng của lớp DAL_NHANVIEN
        DAL_NHANVIEN dalNHANVIEN = new DAL_NHANVIEN();
        public DataTable getNHANVIEN()
        {
            return dalNHANVIEN.getNHANVIEN();
        }
        public int kiemtramatrung(string ma)
        {
            return dalNHANVIEN.kiemtramatrung(ma);
        }
        public bool ThemNHANVIEN(DTO_NHANVIEN NV)
        {
            return dalNHANVIEN.ThemNHANVIEN(NV);
        }
        public bool SuaNHANVIEN(DTO_NHANVIEN NV)
        {
            return dalNHANVIEN.SuaNHANVIEN(NV);
        }
        public bool XoaNHANVIEN(DTO_NHANVIEN NV)
        {
            return dalNHANVIEN.XoaNHANVIEN(NV);
        }

        public DataTable TimNHANVIEN(string NV)
        {
            return dalNHANVIEN.TimNHANVIEN(NV);
        }

    }
}
