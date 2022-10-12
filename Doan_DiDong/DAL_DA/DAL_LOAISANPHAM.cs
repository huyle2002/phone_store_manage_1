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
    public class DAL_LOAISANPHAM : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_LOAISANPHAM
        public DataTable getLOAISANPHAM()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_LOAISANPHAM", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_LOAISANPHAM where MALOAISP='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemLOAISANPHAM(DTO_LOAISANPHAM lsp)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_LOAISANPHAM values('{0}',N'{1}',N'{2}')", lsp.MALOAISP, lsp.TENLOAISP, lsp.MOTA);
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
        public bool SuaLOAISANPHAM(DTO_LOAISANPHAM lsp)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_LOAISANPHAM set TENLOAISP=N'{0}', MOTA=N'{1}' where MALOAISP='{2}'", lsp.TENLOAISP, lsp.MOTA, lsp.MALOAISP);
                
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
        public bool XoaLOAISANPHAM(DTO_LOAISANPHAM lsp)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_LOAISANPHAM where MALOAISP = '" + lsp.MALOAISP + "' ");
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

        public DataTable TimLOAISANPHAM(string TENLOAISP)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_LOAISANPHAM where  TENLOAISP LIKE N'%" + TENLOAISP + "%' OR MALOAISP LIKE N'%" + TENLOAISP + "%' OR MOTA LIKE N'%" + TENLOAISP + "%' ", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }

    }
}
