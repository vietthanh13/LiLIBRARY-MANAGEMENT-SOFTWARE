using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Book
    {
        private string bookid;
        private string name;
        private string majorid;
        private string rentprice;
        private string buyprice;
        private string status;
        

        //hàm get , set
        public string Bookid
        {
            get
            {
                return bookid;
            }
            set
            {
                bookid = value;
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

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        
        //  2 hàm khởi tạo
        public DTO_Book()
        {

        }

        public DTO_Book(string id, string name, string rentprice, string buyprice, string status, string majorid)
        {
            this.bookid = id;
            this.Name = name;
            this.Rentprice = rentprice;
            this.Buyprice = buyprice;
            this.Status = status;
            this.Majorid = majorid;
        }
    }
}
