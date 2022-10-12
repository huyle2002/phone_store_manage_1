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
    public class DAL_CTHOADONNHAP : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_CTHOADONNHAP
        public DataTable getCTHOADONNHAP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_CTHOADONNHAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_CTHOADONNHAP where MAPHIEUNHAP='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemCTHOADONNHAP(DTO_CTHOADONNHAP HD)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_CTHOADONNHAP values('{0}','{1}','{2}', '{3}', '{4}')", HD.MAPHIEUNHAP, HD.MAHOADONNHAP, HD.MASP, HD.SOLUONG, HD.GIANHAP);
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
        public bool SuaCTHOADONNHAP(DTO_CTHOADONNHAP HD)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_CTHOADONNHAP set MAHOADONNHAP='{0}', MASP='{1}', SOLUONG='{2}', GIANHAP='{3}' where MAPHIEUNHAP='{4}'", HD.MAHOADONNHAP, HD.MASP, HD.SOLUONG, HD.GIANHAP, HD.MAPHIEUNHAP);
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
        public bool XoaCTHOADONNHAP(DTO_CTHOADONNHAP HD)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_CTHOADONNHAP where MAPHIEUNHAP = '" + HD.MAPHIEUNHAP + "' ");
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

        public DataTable TimCTHOADONNHAP(string MACTHOADON)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_CTHOADONNHAP where  MAPHIEUNHAP LIKE N'%" + MACTHOADON + "%' OR MAHOADONNHAP LIKE N'%" + MACTHOADON + "%' OR MASP LIKE N'%" + MACTHOADON + "%' OR SOLUONG LIKE N'%" + MACTHOADON + "%' OR GIANHAP LIKE N'%" + MACTHOADON + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }
    }
}
