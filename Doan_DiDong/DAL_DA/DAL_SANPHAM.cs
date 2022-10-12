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
    public class DAL_SANPHAM : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_SANPHAM
        public DataTable getSANPHAM()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_SANPHAM", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool truSLSANPHAM(string ma, int sl)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("UPDATE Tb_SANPHAM SET SOLUONG = " +
                    "((SELECT SOLUONG FROM Tb_SANPHAM WHERE MASP = '" + ma + "') - " + sl + " ) " +
                    "WHERE MASP = '" + ma + "';");
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

        public bool congSLSANPHAM(string ma, int sl)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("UPDATE Tb_SANPHAM SET SOLUONG = " +
                    "((SELECT SOLUONG FROM Tb_SANPHAM WHERE MASP = '" + ma + "') + " + sl + " ) " +
                    "WHERE MASP = '" + ma + "';");
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

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_SANPHAM where MASP='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemSANPHAM(DTO_SANPHAM sp)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_SANPHAM values('{0}',N'{1}',N'{2}', '{3}', '{4}', N'{5}', '{6}', '{7}')", sp.MASP, sp.TENSP, sp.XUATXU, sp.MANHACUNGCAP, sp.MALOAISP, sp.DONVITINH, sp.DONGIA, sp.SOLUONG);
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
        public bool SuaSANPHAM(DTO_SANPHAM sp)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_SANPHAM set TENSP=N'{0}', XUATXU=N'{1}', MANHACUNGCAP='{2}', MALOAISP='{3}', DONVITINH=N'{4}', DONGIA='{5}', SOLUONG='{6}' where MASP='{7}'", sp.TENSP, sp.XUATXU, sp.MANHACUNGCAP, sp.MALOAISP, sp.DONVITINH, sp.DONGIA, sp.SOLUONG, sp.MASP);
                
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
        public bool XoaSANPHAM(DTO_SANPHAM sp)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_SANPHAM where MASP = '" + sp.MASP + "' ");
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

        public DataTable TimSANPHAM(string TENSP)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_SANPHAM where  TENSP LIKE N'%" + TENSP + "%' OR MASP LIKE '%" + TENSP + "%' OR XUATXU LIKE '%" + TENSP + "%' OR MALOAISP LIKE '%" + TENSP + "%' OR SOLUONG LIKE '%" + TENSP + "%' OR DONGIA LIKE '%" + TENSP + "%' OR MANHACUNGCAP LIKE '%" + TENSP + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }

    }
}
