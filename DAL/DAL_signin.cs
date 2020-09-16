using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_signin : DBconnect
    {
        public DataTable checklogin(DTO_Login lg)
        {

            conn.Open();
            string query = string.Format("exec checklogin '{0}','{1}'", lg.Username, lg.Password);
           // string sql = string.Format("select * FROM dbo.Account where UserName = '{0}' and PassWord = '{1}' ", lg.Username, lg.Password);
            DataTable dt = ExecuteQuery(query);
            conn.Close();
            return dt;
        }

    }
}
