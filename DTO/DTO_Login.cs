using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        private string username;
        private string password;
        private string auth;
        private string dislayname;
        private string accountid;
        private string checkstatus;
        
        // hàm get , set
        public string Accountid
        {
            get
            {
                return accountid;
            }
            set
            {
                accountid = value;
            }
        }

        public string Checkstatus
        {
            get
            {
                return checkstatus;
            }
            set
            {
                checkstatus = value;
            }
        }

        public string Displayname
        {
            get
            {
                return dislayname;
            }
            set
            {
                dislayname = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Auth
        {
            get
            {
                return auth;
            }
            set
            {
                auth = value;
            }
        }
        public DTO_Login(string user,string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
        public DTO_Login()
        {

        }
    }
}
