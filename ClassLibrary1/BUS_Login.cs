using System.Collections.Generic;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Login
    {
        DAL_Login dlg = new DAL_Login();
        //public bool CheckLogin(DTO_Login lg)
        //{
        //    return dlg.CheckLogin(lg);
        //}
        public static List<DTO_Login> LoadPass(string id)
        {
            // Load Pass
            return DAL_Login.LoadPass(id);
        }
        public  bool Checkauth(DTO_Login DTOLogin)
        {
            return dlg.Checkauth(DTOLogin);
        }
        DAL_signin sn = new DAL_signin();
        public DataTable checkLogin(DTO_Login lb)
        {
            return sn.checklogin(lb);
        }
    }
}
