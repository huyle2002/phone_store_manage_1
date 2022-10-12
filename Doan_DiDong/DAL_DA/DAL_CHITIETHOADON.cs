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
    public class DAL_CHITIETHOADON : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_CHITIETHOADON
        public DataTable getCHITIETHOADON()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_CHITIETHOADON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma, string ma1)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_CHITIETHOADON where MASP='" + ma.Trim() + "' AND MAHOADON='" + ma1.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemCHITIETHOADON(DTO_CHITIETHOADON cthd)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_CHITIETHOADON values('{0}','{1}','{2}','{3}', '{4}')", cthd.MASP, cthd.MAHOADON, cthd.SOLUONG, cthd.GIABAN, cthd.NGAYDATHANG);
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
        public bool SuaCHITIETHOADON(DTO_CHITIETHOADON cthd)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_CHITIETHOADON set SOLUONG='{0}', GIABAN='{1}', NGAYDATHANG='{2}' where MASP='{3}' AND MAHOADON='{4}'", cthd.SOLUONG, cthd.GIABAN, cthd.NGAYDATHANG, cthd.MASP, cthd.MAHOADON);
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
        public bool XoaCHITIETHOADON(DTO_CHITIETHOADON cthd)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_CHITIETHOADON where MASP = '" + cthd.MASP + "' AND MAHOADON = '" + cthd.MAHOADON + "' ");
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

        public DataTable TimCHITIETHOADON(string MAHOADON)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_CHITIETHOADON where  MAHOADON LIKE N'%" + MAHOADON + "%' OR MASP LIKE N'%" + MAHOADON + "%' OR SOLUONG LIKE N'%" + MAHOADON + "%' OR GIABAN LIKE N'%" + MAHOADON + "%' OR NGAYDATHANG LIKE N'%" + MAHOADON + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }
    }
}
