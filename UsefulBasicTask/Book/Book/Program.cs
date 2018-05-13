using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBook m = new MyBook();

            m.BookID = 1;
            m.BookTitle = "CSherp";
            m.AuthorName = "NILOY";
            m.Page = 100;
            m.PublicationYear = 1996;
            m.Balance = 150;

            Console.WriteLine(m.BookID+"\n"+m.BookTitle+"\n"+m.AuthorName+"\n"+m.Page+"\n"+m.PublicationYear+"\n"+m.Balance);


            MyBook m1 = new MyBook();
            MyBook m2 = new MyBook(2,"C++","JOY");

            Console.WriteLine("Book Id {0} \nBook Name {1} \nAuthor Name {2}", m2.BookID, m2.BookTitle, m2.AuthorName);
        }
    }
}
