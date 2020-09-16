using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Account
    {
        static SqlConnection con;
        public static List<DTO_Account> loadAccount()
        {
            String query = string.Format("exec loadaccount");
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Account> listaccount = new List<DTO_Account>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Account Account = new DTO_Account();
                Account.Id = dt.Rows[i]["AccountID"].ToString();
                Account.Username = dt.Rows[i]["Username"].ToString();
                Account.Password = dt.Rows[i]["Password"].ToString();
                Account.Checkstatus = dt.Rows[i]["Checkstatus"].ToString();
                Account.Displayname = dt.Rows[i]["Displayname"].ToString();
                Account.Auth = dt.Rows[i]["Auth"].ToString();
                listaccount.Add(Account);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listaccount;
        }

        public static List<DTO_Account> searchAccount(string id)
        {
            string querry = string.Format("exec searchaccount {0}", id);
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(querry, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List

            List<DTO_Account> listaccount = new List<DTO_Account>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Account Account = new DTO_Account();
                Account.Id = dt.Rows[i]["AccountID"].ToString();
                Account.Username = dt.Rows[i]["Username"].ToString();
                Account.Password = dt.Rows[i]["Password"].ToString();
                Account.Checkstatus = dt.Rows[i]["Checkstatus"].ToString();
                Account.Displayname = dt.Rows[i]["Displayname"].ToString();
                Account.Auth = dt.Rows[i]["Auth"].ToString();
                listaccount.Add(Account);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listaccount;
        }
        public static bool CheckDup(DTO_Account DTOAccount)
        {
            string query = string.Format("exec checkdupaccount '{0}'", DTOAccount.Username);
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

        public static bool InsertAccount(DTO_Account DTOAccount)
        {

            string query = string.Format("exec insertaccount '{0}','{1}','{2}'", DTOAccount.Username, DTOAccount.Password, DTOAccount.Displayname);
            con = DAL_Connect.Connection();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                DAL_Connect.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DAL_Connect.CloseConnect(con);
                return false;
            }
        }
       /* public static bool EditAccount(DTO_Account DTOAccount, string id)
        {
            string query = string.Format("exec updateaccount '{0}','{1}','{2}','{3}'", DTOAccount.Username, DTOAccount.Password, id, DTOAccount.Checkstatus);
            con = DAL_Connect.Connection();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                DAL_Connect.CloseConnect(con);
                return false;
            }
       /}*/
        public static bool DeleteAccount(DTO_Account DTOAccount)
        {
            string query = string.Format("exec deleteaccount N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", DTOAccount.Username, DTOAccount.Password, DTOAccount.Displayname,DTOAccount.Checkstatus,DTOAccount.Id);
            con = DAL_Connect.Connection();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                DAL_Connect.CloseConnect(con);
                return false;
            }
        }
        public static bool DeleteAccountInBill(DTO_Bill DTOBill)
        {
            string query = string.Format("exec deleteaccountinbills'{0}'", DTOBill.Username);
            con = DAL_Connect.Connection();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                DAL_Connect.CloseConnect(con);
                return false;
            }
        }

        public static bool UpdateAccount(DTO_Account DTOAccount)
        {

            string query = string.Format("exec updateaccount N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", DTOAccount.Username, DTOAccount.Password, DTOAccount.Displayname, DTOAccount.Checkstatus, DTOAccount.Id);
            con = DAL_Connect.Connection();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                DAL_Connect.CloseConnect(con);
                return true;
            }
            catch (Exception ex)
            {
                DAL_Connect.CloseConnect(con);
                return false;
            }
        }
        public static List<DTO_Account> searchaccount(DTO_Account DTOAccount)
        {
            string query = string.Format("exec searchaccount '{0}'", DTOAccount.Username);
            // Mở kết nối;
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Account> listaccount = new List<DTO_Account>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Account Account = new DTO_Account();
                Account.Id = dt.Rows[i]["AccountID"].ToString();
                Account.Username = dt.Rows[i]["Username"].ToString();
                Account.Password = dt.Rows[i]["Password"].ToString();
                Account.Displayname = dt.Rows[i]["Displayname"].ToString();
                Account.Checkstatus = dt.Rows[i]["Status"].ToString();
                Account.Auth = dt.Rows[i]["Auth"].ToString();
                listaccount.Add(Account);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listaccount;

        }


    }
}
