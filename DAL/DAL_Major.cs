using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Major
    {
        static SqlConnection con;
        public static List<DTO_Major> loadmajor()
        {
            string query = "exec loadmajor";
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List
            List<DTO_Major> listmajor = new List<DTO_Major>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Major major = new DTO_Major();
                major.Id = dt.Rows[i]["majorid"].ToString();
                major.Name = dt.Rows[i]["majorname"].ToString();
                listmajor.Add(major);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listmajor;
        }

        // thêm account
        public static bool InsertMajor(DTO_Major DTOMajor)
        {
            string query = string.Format("exec insertmajor N'{0}',N'{1}'", DTOMajor.Id, DTOMajor.Name);
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

        public static bool CheckDup(DTO_Major DTOMajor)
        {
            string query = string.Format("exec checkdupmajor '{0}'", DTOMajor.Id);
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
        public static bool EditMajor(DTO_Major DTOMajor,string id)
        {
            string query = string.Format("exec updatemajor N'{0}',N'{1}',N'{2}'", DTOMajor.Id, DTOMajor.Name,id);
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

        public static bool DeleteMajor (DTO_Major DTOMajor)
        {
            string query = string.Format("exec deletemajor N'{0}',N'{1}'", DTOMajor.Id, DTOMajor.Name);
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

        public static bool EditMajorIdInBook(DTO_Major DTOMajor,string id) // update khóa ngoại majorid = null trong Book
        {
            string query = string.Format("exec editmajoridinbook '{0}'", id);
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
        public static List<DTO_Major> searchmajor(DTO_Major DTOAccount)
        {
            string query = string.Format("exec searchmajor '{0}'", DTOAccount.Id);
            // Mở kết nối;
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Major> listmajor = new List<DTO_Major>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Major major = new DTO_Major();
                major.Id = dt.Rows[i]["Majorid"].ToString();
                major.Name = dt.Rows[i]["majorname"].ToString();
                listmajor.Add(major);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listmajor;
        }

    }
}
