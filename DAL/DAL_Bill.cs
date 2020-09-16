using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Bill
    {
        static SqlConnection con;
        public static List<DTO_Bill> loadbill()
        {
            string query = "exec loadbill";
            // Mở kết nối
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Bill> listbill = new List<DTO_Bill>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Bill Bill = new DTO_Bill();
                Bill.Id = dt.Rows[i]["BillID"].ToString();
                Bill.Username = dt.Rows[i]["Username"].ToString();
                Bill.Name = dt.Rows[i]["Name"].ToString();
                Bill.Majorid = dt.Rows[i]["MajorID"].ToString();
                Bill.Rentprice = dt.Rows[i]["RentPrice"].ToString();
                Bill.Buyprice = dt.Rows[i]["BuyPrice"].ToString();
                Bill.Count = dt.Rows[i]["COUNT"].ToString();
                Bill.Daterent = dt.Rows[i]["Daterent"].ToString();
                Bill.Datesell = dt.Rows[i]["Datesell"].ToString();
                listbill.Add(Bill);
            }
            //Đóng kết nối
            con.Close();
            return listbill;
        }



        public static bool CheckDup(DTO_Bill DTOBill)
        {
            string query = string.Format("exec checkdupbill '{0}','{1}'", DTOBill.Username, DTOBill.Id);
            con.Open();
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
            con.Close();
        }

        
        public static bool InsertBill(DTO_Bill DTOBill)
        {

            string query = string.Format("exec insertbill N'{0}',N'{1}',N'{2}'", DTOBill.Username, DTOBill.Name, DTOBill.Count);
            con.Open();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                con.Close();
                return true;
            }
            catch (Exception )
            {
                con.Close();
                return false;
            }
        }
        public static bool UpdateBill(DTO_Bill DTOBill)
        {

            string query = string.Format("exec updatebill N'{0}',N'{1}',N'{2}'", DTOBill.Username, DTOBill.Name, DTOBill.Count);

            con.Open();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                con.Close();
                return true;
            }
            catch (Exception )
            {
                con.Close();
                return false;
            }
        }
        public static bool DeleteBill(DTO_Bill DTOBill)
        {

            string query = string.Format("exec deletebill N'{0}',N'{1}',N'{2}'", DTOBill.Username, DTOBill.Name, DTOBill.Count);

            con.Open();
            try
            {
                DAL_Connect.ExcuteNonQuery(query, con);
                con.Close();
                return true;
            }
            catch (Exception )
            {
                con.Close();
                return false;
            }
        }
        public static List<DTO_Bill> searchbill(DTO_Bill DTOBill)
        {
            string query = string.Format("exec searchbill '{0}'", DTOBill.Username);
            // Mở kết nối;
            con = DAL_Connect.Connection();
            // Truy Vấn
            DataTable dt = DAL_Connect.GetDataTable(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // List          

            List<DTO_Bill> listbill = new List<DTO_Bill>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_Bill Bill = new DTO_Bill();
                Bill.Id = dt.Rows[i]["BillID"].ToString();
                Bill.Username = dt.Rows[i]["Username"].ToString();
                Bill.Name = dt.Rows[i]["Name"].ToString();
                Bill.Datesell = dt.Rows[i]["DateSell"].ToString();
                Bill.Daterent = dt.Rows[i]["DateRent"].ToString();
                Bill.Count = dt.Rows[i]["Count"].ToString();
                Bill.Majorid = dt.Rows[i]["Auth"].ToString();
                listbill.Add(Bill);
            }
            //Đóng kết nối
            DAL_Connect.CloseConnect(con);
            return listbill;
        }
    }
}
