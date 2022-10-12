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
    public class DAL_HOADON : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_HOADON
        public DataTable getHOADON()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_HOADON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_HOADON where MAHOADON='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemHOADON(DTO_HOADON HD)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_HOADON values('{0}','{1}','{2}')", HD.MAKHACHHANG, HD.MANHANVIEN, HD.MAHOADON);
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
        public bool SuaHOADON(DTO_HOADON HD)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_HOADON set MAKHACHHANG='{0}', MANHANVIEN='{1}' where MAHOADON='{2}'", HD.MAKHACHHANG, HD.MANHANVIEN, HD.MAHOADON);
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
        public bool XoaHOADON(DTO_HOADON HD)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_HOADON where MAHOADON = '" + HD.MAHOADON + "' ");
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

        public DataTable TimHOADON(string MAHOADON)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_HOADON where  MAHOADON LIKE N'%" + MAHOADON + "%' OR MANHANVIEN LIKE N'%" + MAHOADON + "%' OR MAKHACHHANG LIKE N'%" + MAHOADON + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }
    }
}
