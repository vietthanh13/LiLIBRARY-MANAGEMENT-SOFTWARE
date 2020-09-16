using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2MKPB58;Initial Catalog=QuanLyThuVien;User ID=sa;Password=sa");
        public DataTable ExecuteQuery(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
