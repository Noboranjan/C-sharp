using BookShopRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LoadBookBtnClicked(object sender, EventArgs e)
        {
            BookRepository bookRepo = new BookRepository();
            List<Book> bList = bookRepo.GetAllBooks();
            this.bookGridView.DataSource = bList;
        }

        private void InsertBookBtnClicked(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookId = this.textBox1.Text;
            b.BookTitle = this.textBox2.Text;
            b.AuthorName = this.textBox3.Text;
            b.Price = Convert.ToDouble(this.textBox4.Text);
            b.Quantity = Convert.ToInt32(this.textBox5.Text);

            BookRepository bookRepo = new BookRepository();
            if (bookRepo.Insert(b))
            {
                List<Book> bList = bookRepo.GetAllBooks();
                this.bookGridView.DataSource = bList;
            }
            else
            {
                MessageBox.Show("Can Not Insert Book", "Insert Error");
            }
        }

        private void UpdateBookBtnClicked(object sender, EventArgs e)
        {

        }

        private void DeleteBookBtnCLicked(object sender, EventArgs e)
        {

        }

        private void SearchBookBtnClicked(object sender, EventArgs e)
        {
            string text = this.searchBookTBox.Text;
            BookRepository bookRepo = new BookRepository();
            List<Book> bList = bookRepo.searchBook(text);
             this.bookGridView.DataSource = bList;
        }

        private void LogoutBtnClicked(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

       
    }
}
