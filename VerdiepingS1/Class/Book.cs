using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdiepingS1.Class
{
    public class Book
    {
        private string title;
        private Author author;

        public Book(string title, Author author)
        {
            this.title = title;
            this.author = author;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Author Author
        {
            get { return author; }
            set { author = value; }
        }
        public override string ToString()
        {
            return $"{title} . {author.Name}";
        }
    }
}