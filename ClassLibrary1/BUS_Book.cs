using System;
using System.Collections.Generic;
using System.Linq;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Book
    {


        public static List<DTO_Book> loadBook()
        {
            // Load book
            return DAL_Book.loadBook();
        }
        public static bool CheckDup(DTO_Book DTOBook)
        {
            return DAL_Book.CheckDup(DTOBook);
        }
        public static bool InsertBook(DTO_Book DTOBook)
        {
            return DAL_Book.InsertBook(DTOBook);
        }
        public static bool EditBook(DTO_Book DTOBook, string id)
        {
            return DAL_Book.EditBook(DTOBook, id);
        }
        public static bool DeleteBook(DTO_Book DTOBook )
        {
            return DAL_Book.DeleteBook(DTOBook);
        }
        public static bool EditBookNameInBill(DTO_Book DTOBook)
        {
            return DAL_Book.EditBookNameInBill(DTOBook);
        }
        public static List<DTO_Book> searchBook( string id)
        {
            return DAL_Book.searchBook(id);
        }
    }
}
