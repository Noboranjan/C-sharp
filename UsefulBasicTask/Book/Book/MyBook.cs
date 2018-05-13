using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class MyBook
    {
        private int bookID;
        private string bookTitle;
        private string authorName;
        private int page;
        private int publicationYear;
        private int balance;

        public MyBook()
        { 
            Console.WriteLine("first constructor");
        }
        public MyBook(int aID, string abookTitle, string aauthorName)
        {

            bookID = aID;
            bookTitle = abookTitle;
            authorName = aauthorName;
        }
        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public int Page
        {
            get { return page; }
            set { page = value; }

        }
        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
