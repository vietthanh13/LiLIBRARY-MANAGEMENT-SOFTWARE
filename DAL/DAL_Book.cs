using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class DAL_Book
    {

        static SqlConnection con;
        public static List<DTO_Book> loadBook()
        {
            string query = "exec loadbook";
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            // List          

            List<DTO_Book> listbook = new List<DTO_Book>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Book Book = new DTO_Book();
                Book.Bookid = dt.Rows[i]["bookid"].ToString();
                Book.Name = dt.Rows[i]["name"].ToString();
                Book.Majorid = dt.Rows[i]["majorid"].ToString();
                Book.Rentprice = dt.Rows[i]["rentprice"].ToString();
                Book.Buyprice = dt.Rows[i]["buyprice"].ToString();
                Book.Status = dt.Rows[i]["status"].ToString();
                listbook.Add(Book);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listbook;
        }
        public static bool InsertBook(DTO_Book DTOBook)
        {

            string query = string.Format("exec insertbook N'{0}',N'{1}','{2}','{3}',N'{4}',N'{5}'", DTOBook.Bookid, DTOBook.Name, DTOBook.Majorid, DTOBook.Rentprice, DTOBook.Buyprice, DTOBook.Status);
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
        public static bool EditBook(DTO_Book DTOBook, string id)
        { 
            string query = string.Format("exec editbook N'{0}',N'{1}',N'{2}','{3}','{4}',N'{5}',N'{6}'", DTOBook.Bookid, DTOBook.Name, DTOBook.Majorid, DTOBook.Rentprice, DTOBook.Buyprice, DTOBook.Status, id);
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

        public static bool CheckDup(DTO_Book DTOBook)
        {
            string query = string.Format("exec checkdupbook '{0}'", DTOBook.Bookid);
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
        public static bool EditBookNameInBill(DTO_Book DTOBook) // update khóa ngoại Classid = null trong Student
        {

            string query = string.Format("exec editbooknameinbill N'{0}'", DTOBook.Name);
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
        public static bool DeleteBook(DTO_Book DTOBook)
        {
            string query = string.Format("exec deletebook N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'", DTOBook.Bookid, DTOBook.Name, DTOBook.Majorid, DTOBook.Rentprice, DTOBook.Buyprice, DTOBook.Status);
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
        public static List<DTO_Book> searchBook(string id)
        {
            string query = string.Format("exec searchbook N'{0}'", id);
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Book> listbook = new List<DTO_Book>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Book Book = new DTO_Book();
                Book.Bookid = dt.Rows[i]["bookid"].ToString();
                Book.Name = dt.Rows[i]["name"].ToString();
                Book.Majorid = dt.Rows[i]["majorid"].ToString();
                Book.Rentprice = dt.Rows[i]["rentprice"].ToString();
                Book.Buyprice = dt.Rows[i]["buyprice"].ToString();
                Book.Status = dt.Rows[i]["status"].ToString();
                listbook.Add(Book);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listbook;
        }

    }
}
