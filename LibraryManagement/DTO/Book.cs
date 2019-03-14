﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Book
    {
        private int bookID;
        private string bookTitle;
        private string author;
        private int categoryID;
        private string isbn;
        private int quantity;

        public int BookID { get => bookID; set => bookID = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string Author { get => author; set => author = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
