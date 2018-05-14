using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopRepository
{
    public class BookRepository : IBookRepository
    {
        public bool Insert(Book b)
        {
            try
            {
                string query = "INSERT into Books VALUES ('" + b.BookId + "', '" + b.BookTitle + "', '" + b.AuthorName + "', " + b.Price + ", " + b.Quantity + ")";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Book b)
        {
            try
            {
                string query = "UPDATE Books SET BookTitle = '" + b.BookTitle + "', AuthorName ='" + b.AuthorName + "', Price = " + b.Price + ", Quantity = " + b.Quantity + "WHERE BookId = '" + b.BookId + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string bookId)
        {
            try
            {
                string query = "DELETE From Books WHERE BookID='"+bookId+"'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Book GetBook(string bookId)
        {
            string query = "SELECT * from Books WHERE BookId = '" + bookId + "'";
            Book b = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                b = new Book();
                b.BookId = sdr["BookID"].ToString();
                b.BookTitle = sdr["BookTitle"].ToString();
                b.AuthorName = sdr["AuthorName"].ToString();
                b.Price = Convert.ToDouble(sdr["Price"]);
                b.Quantity = Convert.ToInt32(sdr["Quantity"]);
            }
            dcc.CloseConnection();
            return b;
        }

        public List<Book> GetAllBooks()
        {
            string query = "SELECT * from Books";
            List<Book> bList = new List<Book>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Book b = new Book();
                b.BookId = sdr["BookID"].ToString();
                b.BookTitle = sdr["BookTitle"].ToString();
                b.AuthorName = sdr["AuthorName"].ToString();
                b.Price = Convert.ToDouble(sdr["Price"]);
                b.Quantity = Convert.ToInt32(sdr["Quantity"]);

                bList.Add(b);
            }
            dcc.CloseConnection();
            return bList;
        }
        public List<Book> searchBook(string text)
        {
            string query = "SELECT * from Books Where BookId like'%" + text + "%' or BookTitle like'%"+text+"%' or AuthorName like'%"+ text +"%'";
            List<Book> bList = new List<Book>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Book b = new Book();
                b.BookId = sdr["BookID"].ToString();
                b.BookTitle = sdr["BookTitle"].ToString();
                b.AuthorName = sdr["AuthorName"].ToString();
                b.Price = Convert.ToDouble(sdr["Price"]);
                b.Quantity = Convert.ToInt32(sdr["Quantity"]);

                bList.Add(b);
            }
            dcc.CloseConnection();
            return bList;
        }
    }
}
