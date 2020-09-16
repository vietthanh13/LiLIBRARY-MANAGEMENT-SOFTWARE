using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Account
    {

        public static List<DTO_Account> loadAccount()
        {
            return DAL_Account.loadAccount();
        }

        public static bool CheckDup(DTO_Account DTOAccount)
        {
            return DAL_Account.CheckDup(DTOAccount);
        }

        public static bool InsertAccount(DTO_Account DTOAccount)
        {
            return DAL_Account.InsertAccount(DTOAccount);
        }

       /* public static bool EditAccount(DTO_Account DTOAccount, string id)
        {
            return DAL_Account.EditAccount(DTOAccount, id);
        }*/

        public static bool DeleteAccount(DTO_Account DTOAccount)
        {
            return DAL_Account.DeleteAccount(DTOAccount);
        }

        public static bool DeleteAccountInBill(DTO_Bill DTOBill)
        {
            return DAL_Account.DeleteAccountInBill(DTOBill);
        }

        public static List<DTO_Account> searchAccount(string id)
        {
            return DAL_Account.searchAccount(id);
        }
        public static bool UpdateAccount(DTO_Account DTOAccount)
        {
            return DAL_Account.UpdateAccount(DTOAccount);
        }
    }
}
