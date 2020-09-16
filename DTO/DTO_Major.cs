using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Major
    {
        private string majorid;
        private string majorname;
        // hàm get , set
        public string Id
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

        public string Name
        {
            get
            {
                return majorname;
            }
            set
            {
                majorname = value;
            }
        }

        // 2 hàm khởi tạo
        public DTO_Major() // public class để tất cả sài được
        {

        }

        public DTO_Major(string id, string name)
        {
            this.Id = majorid;
            this.Name = majorname;
        }
    }
}
