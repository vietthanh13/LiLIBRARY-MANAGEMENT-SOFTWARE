using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Sql;
using DTO;

namespace DAL
{
    public class DAL_Login
    {
        static SqlConnection con;
        public  bool CheckLogin(DTO_Login lg)
        {

            //string query = string.Format("exec checklogin '{0}','{1}'", DTOLogin.Username, DTOLogin.Password);
            //con = DAL_Connect.Connection();
            //SqlCommand cmd = new SqlCommand(query, con);
            ////create a reader
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    DAL_Connect.CloseConnect(con);
            //    return true; // có
            //}
            //else
            //{
            //    DAL_Connect.CloseConnect(con);
            //    return false;// chưa có;
            //}
            try
            {
                con = DAL_Connect.Connection();
                //string query = string.Format("exec checklogin '{0}','{1}'", lg.Username, lg.Password);
                string sql = string.Format("select * FROM dbo.Account where UserName = '{0}' and PassWord = '{1}' ", lg.Username, lg.Password);
                SqlCommand cm = new SqlCommand(sql,con);
                if (cm.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                DAL_Connect.CloseConnect(con);
            }
            return false;
        }

        public static List<DTO_Login> LoadPass(string id)
        {
            string query = string.Format("exec checkdecode '{0}'", id);
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List
            List<DTO_Login> listpass = new List<DTO_Login>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Login pass = new DTO_Login();
                pass.Username = dt.Rows[i]["username"].ToString();
                pass.Password = dt.Rows[i]["passwords"].ToString();
                listpass.Add(pass);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listpass;
        }

        public bool Checkauth(DTO_Login DTOLogin)
        {
            string query = string.Format("exec checkauth '{0}','{1}'", DTOLogin.Username, DTOLogin.Checkstatus);
            con = DAL_Connect.Connection();
            SqlCommand cmd = new SqlCommand(query, con);
            //create a reader
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                return true; // có
            }
            else
            {

                return false;// chưa có;
            }
            DAL_Connect.CloseConnect(con);
        }
    }
}
