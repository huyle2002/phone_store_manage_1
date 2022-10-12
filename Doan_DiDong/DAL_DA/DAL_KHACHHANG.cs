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
    public class DAL_KHACHHANG : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_KHACHHANG
        public DataTable getKHACHHANG()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_KHACHHANG", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_KHACHHANG where MAKHACHHANG='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemKHACHHANG(DTO_KHACHHANG KH)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_KHACHHANG values('{0}',N'{1}',N'{2}', N'{3}', '{4}', '{5}')", KH.MAKHACHHANG, KH.TENKHACHHANG, KH.GIOITINH_KH, KH.SODIENTHOAI, KH.DIACHI, KH.NGAYSINH);
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
        public bool SuaKHACHHANG(DTO_KHACHHANG KH)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Update Tb_KHACHHANG set TENKHACHHANG=N'{0}', GIOITINH_KH=N'{1}', SODIENTHOAI='{2}', DIACHI=N'{3}', NGAYSINH=N'{4}' where MAKHACHHANG='{5}'", KH.TENKHACHHANG, KH.GIOITINH_KH, KH.SODIENTHOAI, KH.DIACHI, KH.NGAYSINH, KH.MAKHACHHANG);

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
        public bool XoaKHACHHANG(DTO_KHACHHANG KH)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_KHACHHANG where MAKHACHHANG = '" + KH.MAKHACHHANG + "' ");
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

        public DataTable TimKHACHHANG(string TENKHACHHANG)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_KHACHHANG where  TENKHACHHANG LIKE N'%" + TENKHACHHANG + "%' OR MAKHACHHANG LIKE N'%" + TENKHACHHANG + "%' OR GIOITINH_KH LIKE N'%" + TENKHACHHANG + "%' OR SODIENTHOAI LIKE N'%" + TENKHACHHANG + "%' OR DIACHI LIKE N'%" + TENKHACHHANG + "%' OR NGAYSINH LIKE N'%" + TENKHACHHANG + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }

    }
}
