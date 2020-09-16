using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Account
    {
        private string id;
        private string username;
        private string password;
        private string displayname;
        private string auth;
        private string checkstatus;

        // hàm get , set

       
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
        public string Displayname
        {
            get
            {
                return displayname;
            }
            set
            {
                displayname = value;
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

        // hàm khởi tạo
        public DTO_Account()
        {

        }

        public DTO_Account(string id, string username, string password, string displayname, string auth, string checkstatus)
        {
            this.Checkstatus = checkstatus;
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Displayname = displayname;
            this.Auth = auth;
        }
    }
}
