using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopRepository
{
    interface IBookRepository
    {
        bool Insert(Book b);
        bool Update(Book b);
        bool Delete(string bookId);
        Book GetBook(string bookId);
        List<Book> GetAllBooks();
    }
}
