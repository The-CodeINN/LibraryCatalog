using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class Book
    {
        // properties of the books
        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

        public int NumberOfCopies { get; set; }

        public Book(string title, string author, string isbn, int numberOfCopies)
        {
            Author = author;
            ISBN = isbn;
            NumberOfCopies = numberOfCopies;
            Title = title;
        }
    }
}
