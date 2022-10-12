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
    public class DAL_NHACUNGCAP : DBConnect
    {
        //viết các thao tác liên quan đến CSDL
        //hàm lấy toàn bộ thông tin của bảng Tb_NHACUNGCAP
        public DataTable getNHACUNGCAP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tb_NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable getMANHACUNGCAP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select MANHACUNGCAP from Tb_NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public int kiemtramatrung(string ma)
        {
            int i;
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Tb_NHACUNGCAP where MANHACUNGCAP='" + ma.Trim() + "'", cnn);
            i = (int)cmd.ExecuteScalar();
            cnn.Close();
            return i;
        }

        public bool ThemNHACUNGCAP(DTO_NHACUNGCAP NCC)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Insert into Tb_NHACUNGCAP values('{0}',N'{1}',N'{2}', N'{3}', '{4}', '{5}')", NCC.MANHACUNGCAP, NCC.TENNHACUNGCAP, NCC.DIACHI, NCC.GIOITINH, NCC.NGAYSINH_NCC, NCC.PHONE);
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
        public bool SuaNHACUNGCAP(DTO_NHACUNGCAP NCC)
        {
            try
            {
                cnn.Open();
                string strUpdate = string.Format("Update Tb_NHACUNGCAP set TENNHACUNGCAP=N'{0}', DIACHI=N'{1}', GIOITINH=N'{2}', NGAYSINH_NCC='{3}', PHONE='{4}' where MANHACUNGCAP='{5}'", NCC.TENNHACUNGCAP, NCC.DIACHI, NCC.GIOITINH, NCC.NGAYSINH_NCC, NCC.PHONE, NCC.MANHACUNGCAP);
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
        public bool XoaNHACUNGCAP(DTO_NHACUNGCAP NCC)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("Delete From Tb_NHACUNGCAP where MANHACUNGCAP = '" + NCC.MANHACUNGCAP + "' ");
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

        public DataTable TimNHACUNGCAP(string TENNHACUNGCAP)
        {
            cnn.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from Tb_NHACUNGCAP where  TENNHACUNGCAP LIKE N'%" + TENNHACUNGCAP + "%' OR MANHACUNGCAP LIKE N'%" + TENNHACUNGCAP + "%' OR DIACHI LIKE N'%" + TENNHACUNGCAP + "%' OR GIOITINH LIKE N'%" + TENNHACUNGCAP + "%' OR NGAYSINH_NCC LIKE N'%" + TENNHACUNGCAP + "%' OR PHONE LIKE N'%" + TENNHACUNGCAP + "%'", cnn);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            cnn.Close();
            return dttk;
        }

    }
}
