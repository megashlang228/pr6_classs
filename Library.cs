using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class Library : IEnumerable
    {
        private BookCard[] _books;
        public Library(BookCard[] books)
        {
            _books = new BookCard[books.Length];

            for (int i = 0; i < books.Length; i++)
            {
                _books[i] = books[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public LibraryEnum GetEnumerator()
        {
            return new LibraryEnum(_books);
        }
    }
}
