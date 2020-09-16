using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Major
    {
        public static List<DTO_Major> loadmajor()
        {
            // Load Major
            return DAL_Major.loadmajor();
        }
        public static bool CheckDup(DTO_Major DTOMajor)
        {
            return DAL_Major.CheckDup(DTOMajor);
        }
        public static bool InsertMajor(DTO_Major DTOMajor)
        {
            return DAL_Major.InsertMajor(DTOMajor);
        }
        public static bool EditMajor(DTO_Major DTOMajor, string id)
        {
            return DAL_Major.EditMajor(DTOMajor, id);
        }
        public static bool EditMajorIdInBook(DTO_Major DTOMajor, string id)
        {
            return DAL_Major.EditMajorIdInBook(DTOMajor, id);
        }
        public static bool DeleteMajor(DTO_Major DTOMajor)
        {
            return DAL_Major.DeleteMajor(DTOMajor);
        }
        public static List<DTO_Major> searchmajor(DTO_Major major)
        {
            return DAL_Major.searchmajor(major);
        }
    }

}
