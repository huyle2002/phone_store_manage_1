using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DA
{
    public class DBConnect
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-SSDM63V;Initial Catalog=QuanLy_BanHang_DienThoai;Integrated Security=True");

    }
}
