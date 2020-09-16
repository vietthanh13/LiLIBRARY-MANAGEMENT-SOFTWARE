using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private string id;
        private string username;
        private string name;
        private string datesell;
        private string daterent;
        private string count;
        private string rentprice;
        private string buyprice;
        private string majorid;
        private string majorname;
        private string bookname;
        private string count1;
        private string username1;
        private string name1;

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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Majorid
        {
            get
            {
                return majorid;
            }
            set
            {
                majorid = value;
            }
        }
        public string Rentprice
        {
            get
            {
                return rentprice;
            }
            set
            {
                rentprice = value;
            }
        }
        public string Buyprice
        {
            get
            {
                return buyprice;
            }
            set
            {
                buyprice = value;
            }
        }

        public string Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public string Datesell
        {
            get
            {
                return datesell;
            }
            set
            {
                datesell = value;
            }
        }

        public string Daterent
        {
            get
            {
                return daterent;
            }
            set
            {
                daterent = value;
            }
        }

       

        public DTO_Bill()
        {

        }

        public DTO_Bill(string id, string username,  string name, string datesell, string daterent, string count,  string rentprice, string buyprice, string majorid)
        {
          
            this.Majorid = majorid;
            this.Rentprice = rentprice;
            this.Buyprice = buyprice;
            this.Id = id;
            this.Username = username;
            this.Name = name;
            this.Datesell = datesell;
            this.Daterent = daterent;
            this.Count = count;
            
        }
    }
}
