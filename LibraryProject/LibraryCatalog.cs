using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    static class LibraryCatalog
    {
        private static List<Book> _books = new List<Book>();
        public static void AddBook(Book book)
        {
            if (_books.Exists(item => book.ISBN == item.ISBN))
            {
                Console.WriteLine("Book already exists with this ISBN\n");
                return;
            }

            if (book.NumberOfCopies < 0)
            {
                Console.WriteLine("Number of copies cannot be a negative number");
                return;
            }

            _books.Add(book);
            Console.WriteLine($"{book.Title} with {book.ISBN} ISBN has been added to the library.");

        }
    }
}
