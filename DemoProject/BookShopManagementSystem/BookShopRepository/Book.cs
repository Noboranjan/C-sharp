using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopRepository
{
    public class Book
    {
        private string bookId;
        private string bookTitle;
        private string authorName;
        private double price;
        private int quantity;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
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
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
