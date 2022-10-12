using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DA;
using System.Data;
using System.Data.SqlClient;
namespace DAL_DA
{
    public class DAL_NHANVIEN : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_NHANVIEN
        public DataTable getNHANVIEN()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_NHANVIEN", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_NHANVIEN where MANHANVIEN='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemNHANVIEN(DTO_NHANVIEN NV)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_NHANVIEN values('{0}',N'{1}',N'{2}', '{3}', '{4}', N'{5}', '{6}', '{7}')", NV.MANHANVIEN, NV.TENNHANVIEN, NV.GIOITINH_NV, NV.SODIENTHOAI, NV.DIACHI, NV.NGAYSINH, NV.LUONGCOBAN, NV.PHUCAP);
                SqlCommand cmd = new SqlCommand(sql, cnn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        public bool SuaNHANVIEN(DTO_NHANVIEN NV)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_NHANVIEN set TENNHANVIEN=N'{0}', GIOITINH_NV=N'{1}', SODIENTHOAI='{2}', DIACHI=N'{3}', NGAYSINH=N'{4}', LUONGCOBAN='{5}', PHUCAP='{6}' where MANHANVIEN='{7}'", NV.TENNHANVIEN, NV.GIOITINH_NV, NV.SODIENTHOAI, NV.DIACHI, NV.NGAYSINH, NV.LUONGCOBAN, NV.PHUCAP, NV.MANHANVIEN);
                SqlCommand cmd = new SqlCommand(strUpdate, cnn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
        public bool XoaNHANVIEN(DTO_NHANVIEN NV)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_NHANVIEN where MANHANVIEN = '" + NV.MANHANVIEN + "' ");
                SqlCommand cmd = new SqlCommand(sql, cnn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }

        public DataTable TimNHANVIEN(string TENNHANVIEN)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_NHANVIEN where  TENNHANVIEN LIKE N'%" + TENNHANVIEN + "%' OR MANHANVIEN LIKE N'%" + TENNHANVIEN + "%' OR GIOITINH_NV LIKE N'%" + TENNHANVIEN + "%' OR SODIENTHOAI LIKE N'%" + TENNHANVIEN + "%' OR DIACHI LIKE N'%" + TENNHANVIEN + "%' OR NGAYSINH LIKE N'%" + TENNHANVIEN + "%' OR PHUCAP LIKE N'%" + TENNHANVIEN + "%' OR LUONGCOBAN LIKE N'%" + TENNHANVIEN + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }

    }
}
