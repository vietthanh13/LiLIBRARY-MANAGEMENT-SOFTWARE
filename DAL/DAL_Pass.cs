using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Pass
    {
        static SqlConnection con;
        public static bool CheckDup(DTO_Pass DTOPass)
        {
            string query = string.Format("exec checkduppass '{0}','{1}'", DTOPass.Username, DTOPass.Password);
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
        public static bool EditPass(DTO_Pass DTOPass)
        {

            string query = string.Format("exec editpass '{0}','{1}'", DTOPass.Password, DTOPass.Username);
            con = DAL_Connect.Connection();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                DAL_Connect.CloseConnect(con);
                return true;
            }
            catch (Exception )
            {
                DAL_Connect.CloseConnect(con);
                return false;
            }
        }
    }
}
