using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance {
            get
            {
                if (instance == null)
                    instance = new BookDAO();
                return instance;
            }
            private set { BookDAO.instance = value; }
        }
        private BookDAO() { }

        //public bool AddBook(string book) { }
    }
}
