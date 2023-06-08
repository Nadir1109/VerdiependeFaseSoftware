using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdiepingS1.Class
{
    public class BookStore
    {
        private List<Book> books;

        public BookStore()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    } 
}

