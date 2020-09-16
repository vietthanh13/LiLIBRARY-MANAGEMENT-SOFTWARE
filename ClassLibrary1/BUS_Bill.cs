using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Bill
    {
        public static List<DTO_Bill> loadbill()
        {
            return DAL_Bill.loadbill();
        }

        public static bool CheckDup(DTO_Bill DTOBill)
        {
            return DAL_Bill.CheckDup(DTOBill);
        }
        public static bool InsertBill(DTO_Bill DTOBill)
        {
            return DAL_Bill.InsertBill(DTOBill);
        }
        public static bool UpdateBill(DTO_Bill DTOBill)
        {
            return DAL_Bill.UpdateBill(DTOBill);
        }
        public static bool DeleteBill(DTO_Bill DTOBill)
        {
            return DAL_Bill.DeleteBill(DTOBill);
        }
        public static List<DTO_Bill> searchbill(DTO_Bill id)
        {
            return DAL_Bill.searchbill(id);
        }
    }
}
