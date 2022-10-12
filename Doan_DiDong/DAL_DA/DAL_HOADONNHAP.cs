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
    public class DAL_HOADONNHAP : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_HOADONNHAP
        public DataTable getHOADONNHAP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_HOADONNHAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_HOADONNHAP where MAHOADONNHAP='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemHOADONNHAP(DTO_HOADONNHAP HD)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_HOADONNHAP values('{0}','{1}','{2}','{3}')", HD.MAHOADONNHAP, HD.MANHACUNGCAP, HD.NGAYNHAP, HD.THANHTIEN);
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
        public bool SuaHOADONNHAP(DTO_HOADONNHAP HDN)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_HOADONNHAP set MANHACUNGCAP=N'{0}', NGAYNHAP=N'{1}', THANHTIEN='{2}' where MAHOADONNHAP='{3}'", HDN.MANHACUNGCAP, HDN.NGAYNHAP, HDN.THANHTIEN, HDN.MAHOADONNHAP);

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
        public bool XoaHOADONNHAP(DTO_HOADONNHAP HD)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_HOADONNHAP where MAHOADONNHAP = '" + HD.MAHOADONNHAP + "' ");
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

        public DataTable TimHOADONNHAP(string MAHOADONNHAP)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_HOADONNHAP where  MAHOADONNHAP LIKE N'%" + MAHOADONNHAP + "%' OR MANHACUNGCAP LIKE N'%" + MAHOADONNHAP + "%' OR NGAYNHAP LIKE N'%" + MAHOADONNHAP + "%' OR THANHTIEN LIKE N'%" + MAHOADONNHAP + "%' ", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }
    }
}
